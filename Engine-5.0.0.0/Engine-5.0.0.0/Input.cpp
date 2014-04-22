#include "pch.hpp"
namespace Input
{
	std::function<void(unsigned char, int, int)> onProcessNormalKeysCB = nullptr;
	std::function<void(unsigned char, int, int)> onProcessUpNormalKeysCB = nullptr;
	std::function<void(int, int)> onMotionCB = nullptr;
	std::function<void(int, int, int, int)> onMouseCB = nullptr;
	std::function<void(int, int, int, int)> onWheelCB = nullptr;

	void ProcessNormalKeys(std::function<void(unsigned char, int, int)> cb)
	{
		onProcessNormalKeysCB = cb;
	}

	void NormalKeyDown(unsigned char key, int x, int y)
	{
		onProcessNormalKeysCB(key, x, y);
	}

	void ProcessUpNormalKeys(std::function<void(unsigned char, int, int)> cb)
	{
		onProcessUpNormalKeysCB = cb;
	}

	void NormalKeyUp(unsigned char key, int x, int y)
	{
		onProcessUpNormalKeysCB(key, x, y);
	}

	void MouseMotion(int x, int y)
	{
		onMotionCB(x, y);
	}

	void OnMotion(std::function<void(int, int)> cb)
	{
		onMotionCB = cb;
	}

	void OnMouse(std::function<void(int, int, int, int)> cb)
	{
		onMouseCB = cb;
	}

	void MouseClick(int button, int state, int x, int y)
	{
		onMouseCB(button, state, x, y);
	}

	void OnWheel(std::function<void(int, int, int, int)> cb)
	{
		onWheelCB = cb;
	}

	void WheelMove(int button, int dir, int x, int y)
	{
		onWheelCB(button, dir, x, y);
	}

	void SetEvents()
	{
		if (onProcessNormalKeysCB != nullptr)
		{
			glutKeyboardFunc(NormalKeyDown);
		}
		if (onProcessUpNormalKeysCB != nullptr)
		{
			glutKeyboardUpFunc(NormalKeyUp);
		}
		if (onMotionCB != nullptr)
		{
			glutMotionFunc(MouseMotion);
		}
		if (onMouseCB != nullptr)
		{
			glutMouseFunc(MouseClick);
		}
		if (onWheelCB != nullptr)
		{
			glutMouseWheelFunc(WheelMove);
		}
	}
}