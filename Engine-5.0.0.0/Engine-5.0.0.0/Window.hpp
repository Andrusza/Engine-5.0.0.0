#pragma once
enum class WindowType
{
	Windowed,
	FullScreen
};

class Window
{
private:
	int width;
	int height;
	std::string title;
	WindowType type;

protected:
	Window(int width, int height, std::string title = "", WindowType type = WindowType::FullScreen);
public:
	void ChangeSize(int w, int h);
	void Render();
	void Update();

	inline const int Width() const { return width; }
	void Width(const int& value) { width = value; }

	inline const int Height() const { return height; }
	void Height(const int& value) { height = value; }

	inline const std::string Title() const { return title; }
	void Title(const std::string& value) { title = value; }

	inline const WindowType Type() const { return type; }
	void Type(const WindowType& value) { type = value; }

	Window() = delete;
	Window(const Window &) = default;
	Window & operator=(const Window &) = delete;
	Window(Window  && rhs) = delete;
	Window & operator=(Window && rhs) = delete;
	~Window() = default;
};

class WindowGL : public Window
{
private:
	void Create(int width, int height, std::string title = "", WindowType type = WindowType::FullScreen);
public:

	WindowGL(int width, int height);
	WindowGL(int width, int height, std::string title);
	WindowGL(int width, int height, std::string title, WindowType type);

	WindowGL() = delete;
	WindowGL(const WindowGL &) = default;
	WindowGL & operator=(const WindowGL &) = delete;
	WindowGL(WindowGL  && rhs) = delete;
	WindowGL & operator=(WindowGL && rhs) = delete;
	~WindowGL() = default;
};