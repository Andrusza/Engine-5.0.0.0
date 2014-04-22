#pragma once
class BinaryConverter
{
public:
	static inline bool BinaryConverter::CheckAt(const unsigned int &bits, const unsigned int n)
	{
		return (bits & (1 << n)) != 0;
	}

	static inline void BinaryConverter::SetAt(unsigned int &bits, unsigned int n)
	{
		bits |= (1 << n);
	}

	static inline void BinaryConverter::ClearAt(unsigned int &bits, unsigned int n)
	{
		bits &= ~(1 << n);
	}

private:
	BinaryConverter() = delete;
	BinaryConverter(const BinaryConverter&) = delete;
	BinaryConverter& operator=(const BinaryConverter&) = delete;
	BinaryConverter(BinaryConverter && rhs) = delete;
	BinaryConverter& operator=(BinaryConverter&& rhs) = delete;
	~BinaryConverter() = default;
};