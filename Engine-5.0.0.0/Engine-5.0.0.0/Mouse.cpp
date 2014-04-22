#include "pch.hpp"
using namespace std::placeholders;

Mouse::Mouse()
{
	Input::OnMouse(std::bind(&Mouse::OnMouse, this, _1, _2, _3, _4));
	Input::OnMotion(std::bind(&Mouse::OnMotion, this, _1, _2));
	Input::OnWheel(std::bind(&Mouse::OnWheel, this, _1, _2, _3, _4));
}

void Mouse::OnMotion(int x, int y)
{
	/*MouseMovePtr msg = MouseMovePtr(new MouseMoveMsg(x, y));
	EventManager::Get()->ProcessEvent(msg);*/
}

void Mouse::OnMouse(int button, int state, int x, int y)
{
	/*MouseMsgPtr msg = MouseMsgPtr(new MouseMsg(x, y));
	if (button == GLUT_LEFT_BUTTON && state == GLUT_DOWN)
	{
		msg->rButtonDown = true;
		EventManager::Get()->ProcessEvent(msg);
		return;
	}
	if (button == GLUT_MIDDLE_BUTTON && state == GLUT_DOWN)
	{
		msg->mButtonDown = true;
		EventManager::Get()->ProcessEvent(msg);
		return;
	}
	if (button == GLUT_RIGHT_BUTTON && state == GLUT_DOWN)
	{
		msg->rButtonDown = true;
		EventManager::Get()->ProcessEvent(msg);
		return;
	}*/
}

void Mouse::OnWheel(int button, int dir, int x, int y)
{
	/*MouseWheelPtr msg = MouseWheelPtr(new MouseWheelMsg(dir));
	EventManager::Get()->ProcessEvent(msg);*/
}