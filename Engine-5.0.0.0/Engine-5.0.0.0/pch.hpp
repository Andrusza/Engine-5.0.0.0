#pragma once
#pragma warning(disable: 4996) 
#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

//C++
#include <stdio.h>
#include <fstream>
#include <iostream>
#include <thread>
#include <chrono>
#include <iostream>
#include <string>
#include <map>
#include <sstream>
#include <iomanip>


//YAML
#include "ExternalLibraries\yaml-cpp\include\yaml-cpp\yaml.h"

//OpenGL
#include "ExternalLibraries\glew-1.9.0\include\GL\glew.h"
#include "ExternalLibraries\freeglut\include\GL\freeglut.h"


//FreeImage
#include "ExternalLibraries\FreeImage\FreeImage.h"

//GLM
#include "ExternalLibraries\glm-0.9.4.3\glm\glm.hpp"
#include "ExternalLibraries\glm-0.9.4.3\glm\gtc\matrix_transform.hpp"
#include "ExternalLibraries\glm-0.9.4.3\glm\gtc\quaternion.hpp"
#include "ExternalLibraries\glm-0.9.4.3\glm\gtx\euler_angles.hpp"
#include "ExternalLibraries\glm-0.9.4.3\glm\gtc\matrix_transform.hpp"

//Project
#include "BinaryConverter.hpp"
#include "Keyboard.hpp"
#include "Mouse.hpp"
#include "Input.hpp"
#include "Logger.hpp"