#include "pch.hpp"
#include <cctype>
using namespace std::placeholders;

Keyboard::Keyboard()
{
	Input::ProcessNormalKeys(std::bind(&Keyboard::ProcessNormalKeys, this, _1, _2, _3));
	Input::ProcessUpNormalKeys(std::bind(&Keyboard::ProcessUpNormalKeys, this, _1, _2, _3));
}

void Keyboard::ProcessNormalKeys(unsigned char key, int x, int y)
{
	/*key = std::toupper(key);
	KeyboardMsgPtr msg(new KeyboardMsg);
	msg->isDown = true;
	msg->key = key;
	EventManager::Get()->ProcessEvent(msg);*/
}

void Keyboard::ProcessUpNormalKeys(unsigned char key, int x, int y)
{
	/*key = std::toupper(key);
	KeyboardMsgPtr msg(new KeyboardMsg);
	msg->isDown = false;
	msg->key = key;
	EventManager::Get()->ProcessEvent(msg);*/
}

