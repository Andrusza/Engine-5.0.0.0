#pragma once

class Mouse
{
public:
	void OnMouse(int button, int state, int x, int y);
	void OnMotion(int x, int y);
	void OnWheel(int button, int dir, int x, int y);

	Mouse();
	Mouse(const Mouse&) = delete;
	Mouse& operator=(const Mouse&) = delete;
	Mouse(Mouse && rhs) = delete;
	Mouse& operator=(Mouse&& rhs) = delete;
	~Mouse() = default;
};