Shader "Unlit/Spirit"
{
	Properties
	{
		_MainTex ("Albedo Texture", 2D) = "red" {}
		_Transparency("Transparency", Range(0.0,0.5)) = 0.4 //transparent red shader
	}
	SubShader
	{
		Tags {"Queue" = "Transparent" "RenderType" = "Transparent"}
		ZWrite Off
		Blend SrcAlpha OneMinusSrcAlpha //doesn't work without this
		Cull front

		LOD 100


		Pass
		{
			CGPROGRAM
			#pragma vertex vert alpha
			#pragma fragment frag alpha
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float _Transparency;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv);
				col.a = _Transparency;
				return col;
			}
			ENDCG
		}
	}
}
