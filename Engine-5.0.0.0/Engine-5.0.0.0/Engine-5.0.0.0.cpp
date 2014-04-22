#include "pch.hpp"
#include "ExternalLibraries\Visual Leak Detector\include\vld.h"

int main()
{
	pString test = TextFile::Read("error.log");
	return 0;
}