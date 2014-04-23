#include "pch.hpp"
namespace RenderEvents
{
	std::function<void(int, int)> ChangeSizeCB = nullptr;
	std::function<void()> RenderCB = nullptr;
	std::function<void()> UpdateCB = nullptr;

	void Render(std::function<void()> cb)
	{
		RenderCB = cb;
	}

	void Render()
	{
		RenderCB();
	}

	void Update(std::function<void()> cb)
	{
		UpdateCB = cb;
	}

	void Update()
	{
		UpdateCB();
	}

	void ChangeSize(std::function<void(int, int)> cb)
	{
		ChangeSizeCB = cb;
	}

	void ChangeSize(int h, int w)
	{
		ChangeSizeCB(h, w);
	}

	void SetEvents()
	{
		glutReshapeFunc(ChangeSize);
		glutDisplayFunc(Render);
		glutIdleFunc(Update);
	}
}