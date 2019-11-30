Shader "CarbonFiber/CarbonFiberPBR Bump" {
	Properties {
		_Color("Main Color", Color) = (1,1,1,1)
		_SpecularColor("Spec Color", Color) = (1,1,1,1)
		_FiberColor("Fiber Spec Color", Color) = (1,1,1,1)
		_Gloss("Main & Fiber Gloss", Range(0,1)) = 0.9
		_ReflectionPower("Reflect Power", Range(0,1)) = 0.5
		_Blend("Reflect Blend", Range(0.0,1.0)) = 0.5
		_MainTex("RGB Tex (A) Fiber Spec", 2D) = "white" {}
		_NormalTex("Normal", 2D) = "bump" {}
		_SpecTex("Fiber Spec Texture", 2D) = "black" {}		
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf StandardSpecular fullforwardshadows
		#pragma target 3.0

		sampler2D _MainTex;
		sampler2D _NormalTex;
		sampler2D _SpecTex;

		struct Input {
			float2 uv_MainTex;
			float2 uv_NormalTex;
			float2 uv_SpecTex;
		};

		half _Gloss;
		half _Blend;
		half _ReflectionPower;
		half _Metallic;
		fixed4 _Color;
		fixed4 _SpecularColor;
		fixed4 _FiberColor;

		void surf (Input IN, inout SurfaceOutputStandardSpecular o) {
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
			fixed4 st = tex2D(_SpecTex, IN.uv_SpecTex);			
			float4 TexNormal = float4(UnpackNormal(tex2D(_NormalTex, (IN.uv_NormalTex).xy)).xyz, 1.0);
			float4 FiberCol = (_FiberColor * st * c.a);
			float4 FiberSpec = (_SpecularColor * c.a);

			o.Albedo = c.rgb;
			o.Specular = lerp(FiberCol*c.a*_Gloss*(15), _SpecularColor+c.a*_Gloss, _ReflectionPower);
			o.Smoothness = lerp(_Gloss, 1+c.a*_Gloss, _Blend);
			o.Normal = TexNormal;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
