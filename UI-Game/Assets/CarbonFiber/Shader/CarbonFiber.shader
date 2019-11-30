
Shader "CarbonFiber/CarbonFiber"{
	Properties{
_Color("Main Color", Color) = (1,1,1,1)
_SpecularColor("Spec Color", Color) = (1,1,1,1)
_FiberColor("Fiber Spec Color", Color) = (1,1,1,1)
_Gloss("Main & Fiber Gloss", Range(0.1,1) ) = 0.5
_ReflectionPower("Reflect Power", Range(0,1) ) = 1
_MainTex("RGB Tex (A) Fiber Spec", 2D) = "white" {}
_NormalTex("Normal", 2D) = "bump" {}
_Reflect("Reflect Cube", Cube) = "gray" {}
_SpecTex("Fiber Spec Texture", 2D) = "black" {}
	}
	
	SubShader{
		Tags{
			"Queue"="Geometry"
			"IgnoreProjector"="False"
			"RenderType"="Opaque"
		}

		
Cull Back
ZWrite On
ZTest LEqual
ColorMask RGBA
Fog{}


	CGPROGRAM
#pragma surface surf BlinnPhongEditor vertex:vert
#pragma target 3.0


float4 _Color;
float4 _SpecularColor;
float4 _FiberColor;
float _Gloss;
float _ReflectionPower;
sampler2D _MainTex;
sampler2D _NormalTex;
samplerCUBE _Reflect;
sampler2D _SpecTex;

			struct EditorSurfaceOutput {
				half3 Albedo;
				half3 Normal;
				half3 Emission;
				half3 Gloss;
				half Specular;
				half Alpha;
				half4 Custom;
			};
			
			inline half4 LightingBlinnPhongEditor_PrePass (EditorSurfaceOutput s, half4 light)
			{
				half3 spec = light.a * s.Gloss;
				half4 c;
				c.rgb = (s.Albedo * light.rgb + light.rgb * spec);
				c.a = s.Alpha;
				return c;

			}

			inline half4 LightingBlinnPhongEditor (EditorSurfaceOutput s, half3 lightDir, half3 viewDir, half atten)
			{
				half3 h = normalize (lightDir + viewDir);				
				half diff = max (0, dot ( lightDir, s.Normal ));				
				float nh = max (0, dot (s.Normal, h));
				float spec = pow (nh, s.Specular*128.0);				
				half4 res;
				res.rgb = _LightColor0.rgb * diff;
				res.w = spec * Luminance (_LightColor0.rgb);
				res *= atten * 2.0;
				return LightingBlinnPhongEditor_PrePass( s, res );
			}
			
			struct Input {
				float3 simpleWorldRefl;
				float2 uv_MainTex;
				float2 uv_NormalTex;
				float2 uv_SpecTex;
			};

				void vert (inout appdata_full v, out Input o) {
					UNITY_INITIALIZE_OUTPUT(Input,o);
				float4 VertexOutputMaster0_0_NoInput = float4(0,0,0,0);
				float4 VertexOutputMaster0_1_NoInput = float4(0,0,0,0);
				float4 VertexOutputMaster0_2_NoInput = float4(0,0,0,0);
				float4 VertexOutputMaster0_3_NoInput = float4(0,0,0,0);
				o.simpleWorldRefl = -reflect( normalize(WorldSpaceViewDir(v.vertex)), normalize(mul((float3x3)unity_ObjectToWorld, SCALED_NORMAL)));
			}
			

			void surf (Input IN, inout EditorSurfaceOutput o) {
				o.Normal = float3(0.0,0.0,1.0);
				o.Alpha = 1.0;
				o.Albedo = 0.0;
				o.Emission = 0.0;
				o.Gloss = 0.0;
				o.Specular = 0.0;
				o.Custom = 0.0;
				
				float4 TexCUBE0=texCUBE(_Reflect,float4( IN.simpleWorldRefl.x, IN.simpleWorldRefl.y,IN.simpleWorldRefl.z,1.0 ));
				float4 Multiply3=TexCUBE0 * _ReflectionPower.xxxx;
				float4 Tex2D0=tex2D(_MainTex,(IN.uv_MainTex.xyxy).xy);
				float4 Multiply0=_Color * Tex2D0;
				float4 Add0=Multiply3 + Multiply0;
				float4 Tex2DNormal0=float4(UnpackNormal( tex2D(_NormalTex,(IN.uv_NormalTex.xyxy).xy)).xyz, 1.0 );
				float4 Tex2D2=tex2D(_SpecTex,(IN.uv_SpecTex.xyxy).xy);
				float4 Multiply1=Tex2D2 * _FiberColor;
				float4 Multiply2=Tex2D0.aaaa * Multiply1;
				float4 Add2=_SpecularColor + Multiply2;
				float4 Master0_2_NoInput = float4(0,0,0,0);
				float4 Master0_5_NoInput = float4(1,1,1,1);
				float4 Master0_7_NoInput = float4(0,0,0,0);
				float4 Master0_6_NoInput = float4(1,1,1,1);
				o.Albedo = Add0;
				o.Normal = Tex2DNormal0;
				o.Specular = _Gloss.xxxx;
				o.Gloss = Add2;
				o.Normal = normalize(o.Normal);
			}
		ENDCG
	}
	Fallback "Diffuse"
}