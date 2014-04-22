#include "pch.hpp"
#pragma once

typedef std::chrono::high_resolution_clock::time_point TimeFormat;

class Timer
{
private:
	__int64 tickPerSec = 0;
	float delta = 0;
	float duration = 0;
	__int64 now;
	__int64 oldTime;
	__int64 start;
	__int64 stop;
public:
	void Start();
	void Stop();
	float Delta();
	void Reset();

	static unsigned int GetTimeNow();

	inline const float GetDelta() const
	{
		return delta;
	}

	inline const float GetDuration() const
	{
		return duration;
	}

	Timer() = default;
	Timer(const Timer&) = delete;
	Timer& operator=(const Timer&) = delete;
	Timer(Timer && rhs) = delete;
	Timer& operator=(Timer&& rhs) = delete;
	~Timer() = default;
};