#pragma once

#include "ExternalLibraries\glm-0.9.4.3\glm\glm.hpp"

namespace Engine
{
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

		inline const bool Enabled() const { return enabled; }
		void Enabled(const bool& value) { enabled = value; }

		inline const SourceBlendingFactor SourceRGBFactor() const { return sourceRGBFactor; }
		void SourceRGBFactor(const SourceBlendingFactor& value) { sourceRGBFactor = value; }

		inline const SourceBlendingFactor SourceAlphaFactor() const { return sourceAlphaFactor; }
		void SourceAlphaFactor(const SourceBlendingFactor& value) { sourceAlphaFactor = value; }

		inline const DestinationBlendingFactor DestinationRGBFactor() const { return destinationRGBFactor; }
		void DestinationRGBFactor(const DestinationBlendingFactor& value) { destinationRGBFactor = value; }

		inline const DestinationBlendingFactor DestinationAlphaFactor() const { return destinationAlphaFactor; }
		void DestinationAlphaFactor(const DestinationBlendingFactor& value) { destinationAlphaFactor = value; }

		inline const BlendEquation RGBEquation() const { return rGBEquation; }
		void RGBEquation(const BlendEquation& value) { rGBEquation = value; }

		inline const BlendEquation AlphaEquation() const{ return alphaEquation; }
		void AlphaEquation(const BlendEquation& value) { alphaEquation = value; }

		inline const glm::vec4 Color() const { return color; }
		void Color(const glm::vec4& value) { color = value; }

		Blending() = default;
		Blending(const Blending &) = default;
		Blending & operator=(const Blending &) = default;
		Blending(Blending  && rhs) = delete;
		Blending & operator=(Blending && rhs) = delete;
		~Blending() = default;
	};
}