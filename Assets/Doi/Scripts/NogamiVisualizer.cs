using UnityEngine;
using UnityEngine.UI;
using Unity.Mathematics;
using System.Collections.Generic;
using System.IO;
using Klak.TestTools;
using MediaPipe.FaceMesh;

public sealed class NogamiVisualizer : MonoBehaviour
{
    [SerializeField] ImageSource _source = null;
    [SerializeField] ResourceSet _resources = null;
    [SerializeField] Shader _shader = null;
    [SerializeField] RawImage _faceUI = null;

    FacePipeline _pipeline;
    Material _material;

    Vector3[] _vertices;
    Vector2[] _uvs;
    int[] _triangles;

    void Start()
    {
        _pipeline = new FacePipeline(_resources);
        _material = new Material(_shader);

        var mesh = _resources.faceMeshTemplate;
        _vertices = mesh.vertices;
        _uvs = mesh.uv;
        _triangles = mesh.triangles;
    }

    void OnDestroy()
    {
        _pipeline?.Dispose();
        Destroy(_material);
    }

    void Update()
    {
        _pipeline.ProcessImage(_source.Texture);
        _faceUI.texture = _source.Texture;

        if (Input.GetKeyDown(KeyCode.C))
        {
            SaveCroppedTextureAndObj();
        }
    }

    void OnRenderObject()
    {
        var dF = MathUtil.ScaleOffset(1f, new float2(-0.5f, -0.5f));
        _material.SetBuffer("_Vertices", _pipeline.RefinedFaceVertexBuffer);
        _material.SetPass(1);
        Graphics.DrawMeshNow(_resources.faceLineTemplate, dF);
    }

    void SaveCroppedTextureAndObj()
    {
        var srcRT = _pipeline.CroppedFaceTexture as RenderTexture;
        if (srcRT == null)
        {
            Debug.LogError("CroppedFaceTexture is not RenderTexture.");
            return;
        }

        // Texture2Dに変換
        RenderTexture.active = srcRT;
        Texture2D tex2D = new Texture2D(srcRT.width, srcRT.height, TextureFormat.RGB24, false);
        tex2D.ReadPixels(new Rect(0, 0, srcRT.width, srcRT.height), 0, 0);
        tex2D.Apply();
        RenderTexture.active = null;

        // 保存先フォルダの作成
        string baseFolder = Path.Combine(Application.dataPath, "captured");
        if (!Directory.Exists(baseFolder))
            Directory.CreateDirectory(baseFolder);

        string baseName = "CapturedFace";
        int index = GetNextAvailableIndex(baseFolder, baseName);

        string texFileName = $"{baseName}{index}.png";
        string objFileName = $"{baseName}{index}.obj";
        string texPath = Path.Combine(baseFolder, texFileName);
        string objPath = Path.Combine(baseFolder, objFileName);

        // PNG保存
        File.WriteAllBytes(texPath, tex2D.EncodeToPNG());
        Debug.Log("✅ Texture saved: " + texPath);

        // 頂点取得
        var buffer = _pipeline.RawFaceVertexBuffer;
        if (buffer == null || buffer.count != _vertices.Length)
        {
            Debug.LogWarning("頂点数が一致しません");
            return;
        }

        Vector4[] data = new Vector4[_vertices.Length];
        buffer.GetData(data);

        Vector3[] updatedVertices = new Vector3[_vertices.Length];
        for (int i = 0; i < _vertices.Length; i++)
            updatedVertices[i] = new Vector3(data[i].x, data[i].y, data[i].z);

        SaveMeshAsOBJ(objPath, updatedVertices, _uvs, _triangles, texFileName);
    }

    void SaveMeshAsOBJ(string path, Vector3[] vertices, Vector2[] uvs, int[] triangles, string textureFileName)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("# Exported FaceMesh");
            sw.WriteLine("mtllib " + Path.GetFileNameWithoutExtension(path) + ".mtl");
            sw.WriteLine("usemtl FaceTexture");

            foreach (var v in vertices)
                sw.WriteLine($"v {v.x} {v.y} {v.z}");

            foreach (var uv in uvs)
                sw.WriteLine($"vt {uv.x} {uv.y}");

            for (int i = 0; i < triangles.Length; i += 3)
            {
                int i0 = triangles[i] + 1;
                int i1 = triangles[i + 1] + 1;
                int i2 = triangles[i + 2] + 1;
                sw.WriteLine($"f {i0}/{i0} {i1}/{i1} {i2}/{i2}");
            }
        }

        string mtlPath = path.Replace(".obj", ".mtl");
        using (StreamWriter sw = new StreamWriter(mtlPath))
        {
            sw.WriteLine("newmtl FaceTexture");
            sw.WriteLine("map_Kd " + textureFileName);
        }

        Debug.Log("✅ OBJ+MTL saved: " + path);
    }

    int GetNextAvailableIndex(string folder, string baseName)
    {
        int index = 0;
        while (File.Exists(Path.Combine(folder, $"{baseName}{index}.png")) ||
               File.Exists(Path.Combine(folder, $"{baseName}{index}.obj")) ||
               File.Exists(Path.Combine(folder, $"{baseName}{index}.mtl")))
        {
            index++;
        }
        return index;
    }
}
