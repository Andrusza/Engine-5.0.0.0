#version 400

layout( location = 0 ) out vec4 FragColor;
in vec4 FragVertexPosition;
uniform sampler2D Tex1;

#define PI 3.141592653589793238462643383279

void main(void)
{
	float theta = acos(-FragVertexPosition.y);
	float phi = atan(FragVertexPosition.x, FragVertexPosition.z);

	vec2 texCoord = vec2(phi / 2, theta) / PI;
	vec4 texColor=texture(Tex1, texCoord);
	FragColor=texColor;
}