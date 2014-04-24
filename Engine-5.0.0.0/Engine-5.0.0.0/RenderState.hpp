#pragma once
#include "ColorMask.hpp"
#include "Blending.hpp"
#include "PrimitiveRestart.hpp"
#include "FacetCulling.hpp"
#include "StencilTest.hpp"
#include "ScissorTest.hpp"
#include "DepthTest.hpp"
#include "DepthRange.hpp"

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

		PrimitiveRestart primitiveRestart;
		FacetCulling facetCulling;
		ProgramPointSize programPointSize;
		RasterizationMode rasterizationMode;
		ScissorTest scissorTest;
		StencilTest stencilTest;
		DepthTest depthTest;
		DepthRange depthRange;
		Blending blending;
		ColorMask colorMask;
		bool depthMask;

	public:

		inline const PrimitiveRestart PrimitiveRestart() const { return primitiveRestart; }
		void PrimitiveRestart(const Engine::PrimitiveRestart& value) { primitiveRestart = value; }

		inline const FacetCulling FacetCulling() const { return facetCulling; }
		void FacetCulling(const Engine::FacetCulling& value) { facetCulling = value; }

		inline const ProgramPointSize ProgramPointSize() const { return programPointSize; }
		void ProgramPointSize(const Engine::ProgramPointSize& value) { programPointSize = value; }

		inline const RasterizationMode RasterizationMode() const { return rasterizationMode; }
		void RasterizationMode(const Engine::RasterizationMode& value) { rasterizationMode = value; }

		inline const ScissorTest ScissorTest() const { return scissorTest; }
		void ScissorTest(const Engine::ScissorTest& value) { scissorTest = value; }

		inline const StencilTest StencilTest() const { return stencilTest; }
		void StencilTest(const Engine::StencilTest& value) { stencilTest = value; }

		inline const DepthTest DepthTest() const { return depthTest; }
		void DepthTest(const Engine::DepthTest& value) { depthTest = value; }

		inline const DepthRange DepthRange() const { return depthRange; }
		void DepthRange(const Engine::DepthRange& value) { depthRange = value; }

		inline const bool DepthMask() const { return depthMask; }
		void DepthMask(const bool& value) { depthMask = value; }

		inline const ColorMask ColorMask() const { return colorMask; }
		void ColorMask(const Engine::ColorMask& value) { colorMask = value; }

		inline const Blending Blending() const { return blending; }
		void Blending(const Engine::Blending& value) { blending = value; }

		RenderState() = default;
		RenderState(const RenderState &) = delete;
		RenderState & operator=(const RenderState &) = delete;
		RenderState(RenderState  && rhs) = delete;
		RenderState & operator=(RenderState && rhs) = delete;
		~RenderState() = default;
	};
}