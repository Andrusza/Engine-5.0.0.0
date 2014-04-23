#pragma once
class ColorMask
{
private:
	bool red;
	bool green;
	bool blue;
	bool alfa;
public:

	inline const bool Red() const { return red; }
	void Red(const bool& value) { red = value; }

	inline const bool Green() const { return green; }
	void Green(const bool& value) { green = value; }

	inline const bool Blue() const { return green; }
	void Blue(const bool& value) { green = value; }

	inline const bool Alfa() const { return alfa; }
	void Alfa(const bool& value) { alfa = value; }

	ColorMask(bool red,bool green,bool blue,bool alfa);

	ColorMask() = delete;
	ColorMask(const ColorMask &) = delete;
	ColorMask & operator=(const ColorMask &) = delete;
	ColorMask(ColorMask  && rhs) = delete;
	ColorMask & operator=(ColorMask && rhs) = delete;
	~ColorMask() = default;
};