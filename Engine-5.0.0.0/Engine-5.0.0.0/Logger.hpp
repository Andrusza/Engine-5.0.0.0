#include <vector>

#pragma once
class Logger
{
public:
	static void Write(std::string objectName, std::string error);

	Logger() = default;
	Logger(const Logger&) = delete;
	Logger& operator=(const Logger&) = delete;
	Logger(Logger && rhs) = delete;
	Logger& operator=(Logger&& rhs) = delete;
	~Logger() = default;
};