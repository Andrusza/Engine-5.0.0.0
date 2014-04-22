#pragma once
class Keyboard
{
public:
	Keyboard();
	void ProcessNormalKeys(unsigned char key, int x, int y);
	void ProcessUpNormalKeys(unsigned char key, int x, int y);

	Keyboard(const Keyboard&) = delete;
	Keyboard& operator=(const Keyboard&) = delete;
	Keyboard(Keyboard && rhs) = delete;
	Keyboard& operator=(Keyboard&& rhs) = delete;
	~Keyboard() = default;
};