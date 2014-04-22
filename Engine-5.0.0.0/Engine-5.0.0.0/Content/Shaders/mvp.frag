#version 400

layout( location = 0 ) out vec4 FragColor;
in vec2 TexCoord;
uniform sampler2D Tex1;

void main(void)
{
  vec4 texColor = texture( Tex1, TexCoord );
	
  float n = 0.1; // camera z near
  float f = 27000000.0; // camera z far
  float d = texture( Tex1, TexCoord ).x;
  
  
  float z = (exp(d*log(0.01f*27000000.f+1)) - 1)/0.01f;
  z=z/27000000;
  
  //FragColor=vec4(z,z,z,1);
  FragColor=texColor;
  //FragColor=vec4(z,z,z,1);
}