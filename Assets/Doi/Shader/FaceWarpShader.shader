Shader "Custom/FaceWarpShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Cull Off
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                uint id : SV_VertexID; // ✅ 頂点IDを追加
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            uniform sampler2D _MainTex;
            uniform float4 _FaceLandmarks[468];

            v2f vert (appdata_t v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);

                // 🎯 TemplateMesh のオリジナルUVに補正値を適用
                float2 landmarkPos = _FaceLandmarks[v.id].xy;
                float2 uvOffset = landmarkPos - float2(0.5, 0.5); // 中心補正
                o.uv = v.uv + uvOffset * 0.1; // スケール調整

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                return tex2D(_MainTex, i.uv);
            }
            ENDCG
        }
    }
}
