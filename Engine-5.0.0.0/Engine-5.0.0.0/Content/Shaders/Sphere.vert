#version 400
layout (location = 0) in vec4 VertexPosition;


out vec4 FragVertexPosition;
uniform mat4 MVP;

void main(void)
{
	gl_Position = MVP * VertexPosition;
	FragVertexPosition=VertexPosition;
}