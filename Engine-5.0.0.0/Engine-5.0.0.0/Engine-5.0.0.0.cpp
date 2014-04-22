
#include "pch.hpp"
#include "ExternalLibraries\Visual Leak Detector\include\vld.h"

int main()
{
	UINT test = 1;
	BinaryConverter::SetAt(test, 2);
	BinaryConverter::ClearAt(test, 1);
	bool result = BinaryConverter::CheckAt(test, 2);

	int *x = new int(324);

	return 0;
}

