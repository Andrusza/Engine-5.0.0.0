#include "pch.hpp"

#pragma region Window

Window::Window(int width, int height, std::string title, WindowType window) :
	width(width),
	height(height),
	title(title),
	type(window)
{}



void Window::ChangeSize(int w, int h)
{
	glViewport(0, 0, w, h);
}

void Window::Render()
{
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

	glutSwapBuffers();
}

void Window::Update()
{
}

#pragma endregion

#pragma region WindowGL

void WindowGL::Create(int width, int height, std::string title, WindowType type)
{
	glutSetOption(GLUT_ACTION_ON_WINDOW_CLOSE, GLUT_ACTION_GLUTMAINLOOP_RETURNS);
	glutInitDisplayMode(GLUT_DEPTH | GLUT_DOUBLE | GLUT_RGBA);
	glutInitWindowPosition(0, 0);
	glutInitWindowSize(width, height);

	glutCreateWindow(title.c_str());
	glClearColor(0.336393f, 0.501226f, 0.797253f, 1.0f);

	GLenum err = glewInit();
	if (GLEW_OK != err)
	{
		fprintf(stderr, "Error: %s\n", glewGetErrorString(err));
		exit(EXIT_FAILURE);
	}
	fprintf(stdout, "Status: Using GLEW %s\n", glewGetString(GLEW_VERSION));

	if (type == WindowType::FullScreen)
	{
		glutFullScreen();
	}

	const GLubyte* renderer = glGetString(GL_RENDERER);
	const GLubyte* vendor = glGetString(GL_VENDOR);
	const GLubyte* version = glGetString(GL_VERSION);
	const GLubyte* glslVersion = glGetString(GL_SHADING_LANGUAGE_VERSION);
	GLint glTexUnits;
	glGetIntegerv(GL_MAX_TEXTURE_IMAGE_UNITS_ARB, &glTexUnits);

	GLint major, minor;
	glGetIntegerv(GL_MAJOR_VERSION, &major);
	glGetIntegerv(GL_MINOR_VERSION, &minor);
	printf("OpenGL on %s %s\n", vendor, renderer);
	printf("OpenGL version supported %s\n", version);
	printf("GLSL version supported %s\n", glslVersion);
	printf("GL version major, minor: %i.%i\n", major, minor);
	printf("Texture units to use %i\n", glTexUnits);

	if (!GL_ARB_vertex_buffer_object)
	{
		Logger::Write("WindowGL::Create", "VBO not supported");
		std::cout << "VBO not supported" << std::endl;
		exit(EXIT_FAILURE);
	}
	else
	{
		printf("VBO supported\n");
	}

	RenderEvents::ChangeSize(std::bind(&Window::ChangeSize, this, 1, 2));
	RenderEvents::Render(std::bind(&Window::Render, this));
	RenderEvents::Update(std::bind(&Window::Update, this));
	RenderEvents::SetEvents();
}

WindowGL::WindowGL(int width, int height) : Window(width, height)
{
	Create(width, height);
}

WindowGL::WindowGL(int width, int height, std::string title) : Window(width, height, title)
{
	Create(width, height, title);
}

WindowGL::WindowGL(int width, int height, std::string title, WindowType type) : Window(width, height, title, type)
{
	Create(width, height, title, type);
}

#pragma endregion