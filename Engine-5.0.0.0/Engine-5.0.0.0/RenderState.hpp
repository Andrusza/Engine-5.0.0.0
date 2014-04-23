#pragma once
#include "ColorMask.hpp"

namespace Engine
{
	enum class ProgramPointSize
	{
		Enabled,
		Disabled
	};

	enum class RasterizationMode
	{
		Point,
		Line,
		Fill
	};

	class RenderState
	{
	private:
		bool depthMask;
		ColorMask colorMask;

	public:
		inline const bool DepthMask() const { return depthMask; }
		void DepthMask(const bool& value) { depthMask = value; }

		inline const ColorMask ColorMask() const { return colorMask; }
		void ColorMask(const Engine::ColorMask& value) { colorMask = value; }


		RenderState();
		RenderState(const RenderState &) = delete;
		RenderState & operator=(const RenderState &) = delete;
		RenderState(RenderState  && rhs) = delete;
		RenderState & operator=(RenderState && rhs) = delete;
		~RenderState() = default;
	};
}