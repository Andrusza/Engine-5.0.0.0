#include <string>
#include <memory>
#pragma once

typedef std::unique_ptr<std::string> pString;

class TextFile
{
public:
	static pString Read(const char *fileName);

	TextFile() = delete;
	TextFile(const TextFile&) = delete;
	TextFile& operator=(const TextFile&) = delete;
	TextFile(TextFile && rhs) = delete;
	TextFile& operator=(TextFile&& rhs) = delete;
	~TextFile() = default;
};