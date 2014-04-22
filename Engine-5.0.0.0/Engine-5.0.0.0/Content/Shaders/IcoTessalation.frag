#version 400
out vec4 FragColor;

in vec4 Normal;
uniform sampler2D Tex1;


#define PI 3.141592653589793238462643383279

vec2 ComputeTexCoords(vec4 position)
{
   float theta = acos(-position.y);
   float phi = atan(position.x, position.z);
   return (vec2(phi / 2, theta) / PI);
}

void main(void)
{
    gl_FragDepth=log(0.01f*Normal.w + 1) / log(0.01f*27000000.0f + 1);
	FragColor=texture(Tex1, ComputeTexCoords(Normal));
}