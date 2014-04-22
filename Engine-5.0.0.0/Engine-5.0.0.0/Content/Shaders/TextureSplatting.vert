#version 400
layout (location = 0) in vec4 vPosition;
layout (location = 2) in vec2 vTexCoord;

out vec2 pTexCoord;
out float pHigh;

uniform mat4 MVP;

void main(void)
{
	gl_Position = MVP * vPosition;

	pHigh=gl_Position.y;
	pTexCoord = vTexCoord;
}