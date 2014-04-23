#include <functional>
#pragma once
namespace RenderEvents
{
	void ChangeSize(std::function<void(int, int)> cb);
	void Render(std::function<void()> cb);
	void Update(std::function<void()> cb);
	void SetEvents();
};