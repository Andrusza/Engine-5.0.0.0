#include "pch.hpp"

void Logger::Write(std::string objectName, std::string error)
{
	std::ofstream outfile;

	outfile.open("errors.log", std::ios::out | std::ios::app);

	auto now = std::chrono::system_clock::now();
	auto date = std::chrono::system_clock::to_time_t(now);

	std::stringstream ss;
	ss << std::put_time(std::localtime(&date), "%Y-%m-%d %X");

	std::cout << ss.str() << " " << objectName << " " << error << std::endl;
	outfile << ss.str() << " " << objectName << " " << error << std::endl;
	outfile.close();
	system("PAUSE");
}