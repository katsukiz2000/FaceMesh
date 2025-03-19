using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FaceCapture : MonoBehaviour
{
    private WebCamTexture webcamTexture;
    public RawImage displayImage;

    void Start()
    {
        webcamTexture = new WebCamTexture();
        displayImage.texture = webcamTexture;
        webcamTexture.Play();
    }

    void CaptureImage()
    {
        Texture2D snap = new Texture2D(webcamTexture.width, webcamTexture.height);
        snap.SetPixels(webcamTexture.GetPixels());
        snap.Apply();

        byte[] imageBytes = snap.EncodeToPNG();
        System.IO.File.WriteAllBytes(UnityEngine.Application.persistentDataPath + "/face.png", imageBytes); // 完全修飾名を使用
    }
}