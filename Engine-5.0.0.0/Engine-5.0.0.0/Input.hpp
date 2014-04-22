#include <functional>
#pragma once
namespace Input
{
	void ProcessNormalKeys(std::function<void(unsigned char, int, int)>);
	void ProcessUpNormalKeys(std::function<void(unsigned char, int, int)>);
	void OnMouse(std::function<void(int, int, int, int)>);
	void OnMotion(std::function<void(int, int)>);
	void OnWheel(std::function<void(int, int, int, int)>);
	void SetEvents();
};