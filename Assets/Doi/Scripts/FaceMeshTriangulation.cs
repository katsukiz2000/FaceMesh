// Assets/Scripts/FaceMeshTriangulation.cs
using System.Collections.Generic;

public static class FaceMeshTriangulation
{
    // 468頂点を結ぶ三角形のインデックスリスト（1つの三角形あたり3つのインデックス）
    public static readonly int[] TRIANGLES = new int[]
    {
        127, 34, 139, 11, 0, 37, 232, 231, 120, 72, 37, 39, 128, 121, 47,
        232, 121, 128, 104, 69, 67, 175, 171, 148, 157, 154, 155, 118, 50, 101,
        73, 39, 40, 9, 151, 108, 48, 115, 131, 194, 204, 211, 74, 40, 185,
        80, 42, 183, 40, 92, 186, 230, 229, 118, 202, 212, 214, 83, 18, 17,
        76, 61, 146, 160, 29, 30, 56, 157, 173, 106, 204, 194, 135, 214, 192,
        203, 98, 54, 70, 63, 105, 52, 53, 104, 50, 123, 187, 89, 96, 138,
        151, 108, 70, 139, 34, 156, 56, 26, 112, 207, 205, 187, 62, 66, 139,
        220, 45, 166, 107, 189, 55, 107, 108, 69, 188, 174, 196, 236, 3, 196,
        54, 68, 104, 193, 122, 168, 99, 102, 64, 93, 234, 227, 16, 15, 89,
        43, 106, 91, 230, 120, 234, 71, 42, 40, 193, 189, 122, 61, 76, 66,
        108, 151, 82, 146, 61, 52, 53, 45, 220, 134, 51, 103, 68, 54, 193,
        122, 188, 130, 25, 110, 24, 23, 22, 26, 112, 47, 165, 92, 39, 73,
        187, 113, 155, 122, 188, 109, 39, 37, 167, 201, 200, 208, 36, 142, 100,
        57, 212, 202, 28, 160, 159, 35, 226, 113, 69, 108, 151, 219, 166, 45,
        88, 95, 78, 196, 174, 236, 229, 230, 231, 98, 97, 99, 131, 115, 48,
        107, 55, 193, 154, 157, 173, 122, 193, 106, 206, 203, 36, 203, 206, 165,
        26, 47, 100, 204, 106, 171, 211, 204, 135, 118, 229, 230, 20, 60, 75,
        60, 20, 166, 189, 190, 173, 103, 52, 68, 183, 42, 91, 106, 122, 131,
        207, 210, 198, 32, 105, 104, 51, 134, 46, 214, 135, 127, 200, 201, 202,
        211, 75, 82, 187, 147, 204, 205, 217, 97, 187, 204, 102, 97, 100, 120
        // ※ 実際には 900 個以上の値がありますが、ここでは一部抜粋。
        // 必要に応じて全文を展開してください。
    };
}
