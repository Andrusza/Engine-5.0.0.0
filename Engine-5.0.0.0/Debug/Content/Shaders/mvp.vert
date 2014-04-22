#version 400
layout (location = 0) in vec2 VertexPosition;
layout (location = 1) in vec2 VertexTexCoord;

out vec2 TexCoord;

uniform mat4 MVP;

void main(void)
{
	gl_Position = vec4(VertexPosition, 0.0, 1.0);
	TexCoord = VertexTexCoord;
}