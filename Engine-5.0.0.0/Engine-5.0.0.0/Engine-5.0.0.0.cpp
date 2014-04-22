
#include "pch.hpp"
#include "ExternalLibraries\Visual Leak Detector\include\vld.h"

int main()
{
	UINT test = 2;
	BinaryConverter::CheckAt(test, 0);
	return 0;
}

