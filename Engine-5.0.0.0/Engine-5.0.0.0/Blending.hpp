#pragma once

enum class SourceBlendingFactor
{
	Zero,
	One,
	SourceAlpha,
	OneMinusSourceAlpha,
	DestinationAlpha,
	OneMinusDestinationAlpha,
	DestinationColor,
	OneMinusDestinationColor,
	SourceAlphaSaturate,
	ConstantColor,
	OneMinusConstantColor,
	ConstantAlpha,
	OneMinusConstantAlpha
};

enum class DestinationBlendingFactor
{
	Zero,
	One,
	SourceColor,
	OneMinusSourceColor,
	SourceAlpha,
	OneMinusSourceAlpha,
	DestinationAlpha,
	OneMinusDestinationAlpha,
	DestinationColor,
	OneMinusDestinationColor,
	ConstantColor,
	OneMinusConstantColor,
	ConstantAlpha,
	OneMinusConstantAlpha
};

enum class BlendEquation
{
	Add,
	Minimum,
	Maximum,
	Subtract,
	ReverseSubtract
};

class Blending
{
private:

	bool enabled;
	SourceBlendingFactor sourceRGBFactor;
	SourceBlendingFactor sourceAlphaFactor;
	DestinationBlendingFactor destinationRGBFactor;
	DestinationBlendingFactor destinationAlphaFactor;
	BlendEquation rGBEquation;
	BlendEquation alphaEquation;
	glm::vec4 color;

public:
	Blending();
	Blending(const Blending &) = delete;
	Blending & operator=(const Blending &) = delete;
	Blending(Blending  && rhs) = delete;
	Blending & operator=(Blending && rhs) = delete;
	~Blending() = default;
};