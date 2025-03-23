using UnityEngine;
using UnityEngine.UI;
using MediaPipe.FaceMesh;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;
using System.Collections.Generic;

public class FaceMeshManager : MonoBehaviour
{
    public GameObject templateMeshObject;
    public ResourceSet resources;
    public RawImage rawImage;

    private WebCamTexture webCamTexture;
    private FacePipeline facePipeline;
    private ComputeBuffer vertexBuffer;
    private Vector3[] faceVertices;
    private Vector2[] originalUVs;
    private Mesh mesh;
    private Material faceMaterial;

    void Start()
    {
        mesh = templateMeshObject.GetComponent<MeshFilter>().mesh;
        faceVertices = new Vector3[mesh.vertexCount];
        originalUVs = (Vector2[])mesh.uv.Clone();

        webCamTexture = new WebCamTexture();
        webCamTexture.Play();

        facePipeline = new FacePipeline(resources);
        faceMaterial = templateMeshObject.GetComponent<MeshRenderer>().material;
        faceMaterial.SetTexture("_MainTex", facePipeline.CroppedFaceTexture);

        if (rawImage != null)
        {
            rawImage.texture = facePipeline.CroppedFaceTexture;
        }
    }

    void Update()
    {
        if (facePipeline == null || webCamTexture == null) return;
        facePipeline.ProcessImage(webCamTexture);

        vertexBuffer = facePipeline.RefinedFaceVertexBuffer;
        if (vertexBuffer == null || vertexBuffer.count == 0) return;

        Vector4[] tempVertices = new Vector4[faceVertices.Length];
        vertexBuffer.GetData(tempVertices);

        for (int i = 0; i < faceVertices.Length; i++)
        {
            faceVertices[i] = new Vector3(tempVertices[i].x, tempVertices[i].y, tempVertices[i].z);
        }

        Dictionary<int, List<Vector2>> uvCandidates = new Dictionary<int, List<Vector2>>();

        int[] triangles = FaceMeshTriangulation.TRIANGLES;
        for (int i = 0; i < triangles.Length; i += 3)
        {
            int i0 = triangles[i];
            int i1 = triangles[i + 1];
            int i2 = triangles[i + 2];

            Point[] srcTri = new Point[]
            {
                ToUV(tempVertices[i0]),
                ToUV(tempVertices[i1]),
                ToUV(tempVertices[i2])
            };

            Point[] dstTri = new Point[]
            {
                new Point(originalUVs[i0].x, originalUVs[i0].y),
                new Point(originalUVs[i1].x, originalUVs[i1].y),
                new Point(originalUVs[i2].x, originalUVs[i2].y)
            };

            MatOfPoint2f srcMat = new MatOfPoint2f(srcTri);
            MatOfPoint2f dstMat = new MatOfPoint2f(dstTri);

            Mat affine = Imgproc.getAffineTransform(srcMat, dstMat);

            AddUV(i0, srcTri[0], affine, uvCandidates);
            AddUV(i1, srcTri[1], affine, uvCandidates);
            AddUV(i2, srcTri[2], affine, uvCandidates);
        }

        Vector2[] finalUVs = new Vector2[faceVertices.Length];
        for (int i = 0; i < faceVertices.Length; i++)
        {
            if (uvCandidates.ContainsKey(i))
            {
                List<Vector2> candidates = uvCandidates[i];
                Vector2 sum = Vector2.zero;
                foreach (var uv in candidates) sum += uv;
                finalUVs[i] = sum / candidates.Count;
            }
            else
            {
                finalUVs[i] = originalUVs[i];
            }
        }

        mesh.vertices = faceVertices;
        mesh.uv = finalUVs;
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
    }

    private Point ToUV(Vector4 vert)
    {
        float u = (vert.x + 1f) * 0.5f;
        float v = (vert.y + 1f) * 0.5f;
        return new Point(u, 1f - v);
    }

    private void AddUV(int index, Point original, Mat affine, Dictionary<int, List<Vector2>> uvDict)
    {
        Mat src = new Mat(1, 1, CvType.CV_32FC2);
        src.put(0, 0, (float)original.x, (float)original.y);

        Mat dst = new Mat();
        Core.transform(src, dst, affine);

        float[] result = new float[2];
        dst.get(0, 0, result);
        Vector2 uv = new Vector2(result[0], result[1]);

        uv.x = Mathf.Clamp01(uv.x);
        uv.y = Mathf.Clamp01(uv.y);

        if (!uvDict.ContainsKey(index))
            uvDict[index] = new List<Vector2>();

        uvDict[index].Add(uv);
    }
}
