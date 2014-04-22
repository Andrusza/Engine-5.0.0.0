#include "pch.hpp"
#include "ExternalLibraries\Visual Leak Detector\include\vld.h"

int main()
{
	Timer t;
	t.Start();
	Sleep(2000);
	t.Stop();
	auto time = t.GetTimeNow();
	auto d = t.GetDuration();

	return 0;
}