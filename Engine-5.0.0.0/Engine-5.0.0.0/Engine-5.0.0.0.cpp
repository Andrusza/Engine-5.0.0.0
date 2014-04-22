#include "pch.hpp"
#include "ExternalLibraries\Visual Leak Detector\include\vld.h"

int main()
{
	Random rng(2);
	for (int i = 0; i < 100; i++)
	{
		int x = rng.NextInt();
		std::cout << x <<std::endl;
	}
	return 0;
}