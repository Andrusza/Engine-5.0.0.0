#version 400
layout(triangles) in;
layout(triangle_strip, max_vertices = 3) out;

in vec3 tePosition[3];
out vec4 Normal;
out float logz;


/*void main()
{
    
	float FC = 1.0/log(27000000*0.01 + 1); 
	
    gl_Position = gl_in[0].gl_Position;  logz = log(gl_Position.w*0.01f + 1)*FC; gl_Position.z = (2*logz - 1)*gl_Position.w; Normal=tePosition[0]; EmitVertex();
    gl_Position = gl_in[1].gl_Position;  logz = log(gl_Position.w*0.01f + 1)*FC; gl_Position.z = (2*logz - 1)*gl_Position.w; Normal=tePosition[1]; EmitVertex();
    gl_Position = gl_in[2].gl_Position;  logz = log(gl_Position.w*0.01f + 1)*FC; gl_Position.z = (2*logz - 1)*gl_Position.w; Normal=tePosition[2]; EmitVertex();
    EndPrimitive();
}*/


void main()
{
    
	
    gl_Position = gl_in[0].gl_Position;  Normal=gl_Position; EmitVertex();
    gl_Position = gl_in[1].gl_Position;  Normal=gl_Position;  EmitVertex();
    gl_Position = gl_in[2].gl_Position;  Normal=gl_Position;  EmitVertex();
    EndPrimitive();
}



