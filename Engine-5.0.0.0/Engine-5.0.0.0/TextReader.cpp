#include "pch.hpp"

pString TextFile::Read(const char *fileName)
{
	try
	{
		pString fileString(new std::string);
		std::string line = std::string();

		std::ifstream file(fileName);
		if (file.is_open())
		{
			while (!file.eof())
			{
				getline(file, line);
				fileString->append(line);
				fileString->append("\n");
			}
			file.close();
		}
		else
		{
			Logger::Write("TextFile::Read", "No file found");
		}

		return fileString;
	}
	catch (std::exception& e)
	{
		Logger::Write("TextFile::Read", e.what());
	}
}