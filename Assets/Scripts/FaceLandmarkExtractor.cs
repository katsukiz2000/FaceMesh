using UnityEngine;
using System.Collections.Generic;
using Debug = UnityEngine.Debug; // エイリアスを設定

public class FaceLandmarkExtractor : MonoBehaviour
{
    public FaceMesh faceMesh;

    void Update()
    {
        if (faceMesh == null || faceMesh.vertices == null)
        {
            Debug.LogWarning("FaceMesh または vertices が null です。");
            return;
        }

        List<Vector3> landmarks = new List<Vector3>(faceMesh.vertices);

        if (landmarks.Count > 33)
        {
            Debug.Log("特徴点数: " + landmarks.Count);
            Debug.Log("目の位置: " + landmarks[33]); // 例: 右目の位置
        }
        else
        {
            Debug.LogWarning("特徴点の数が不足しています。");
        }
    }
}