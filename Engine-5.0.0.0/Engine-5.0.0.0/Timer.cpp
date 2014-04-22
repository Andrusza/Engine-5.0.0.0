#include "pch.hpp"

void Timer::Start()
{
	QueryPerformanceFrequency((LARGE_INTEGER*)&tickPerSec);
	QueryPerformanceCounter((LARGE_INTEGER*)&start);
	oldTime = start;
}

void Timer::Reset()
{
	QueryPerformanceCounter((LARGE_INTEGER*)&start);
	oldTime = start;
	duration = 0;
	delta = 0;
}

void Timer::Stop()
{
	QueryPerformanceCounter((LARGE_INTEGER*)&stop);
	duration = ((float)(stop - start) / (float)tickPerSec);
}

float Timer::Delta()
{
	QueryPerformanceCounter((LARGE_INTEGER*)&now);
	delta = ((float)(now - oldTime) / (float)tickPerSec);
	oldTime = now;
	return delta;
}

unsigned int Timer::GetTimeNow()
{
	return std::chrono::high_resolution_clock::now().time_since_epoch().count();
}