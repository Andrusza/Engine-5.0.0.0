#pragma once

namespace Engine
{
	enum class CullFace
	{
		Front,
		Back,
		FrontAndBack
	};

	enum class WindingOrder
	{
		Clockwise,
		Counterclockwise
	};

	class FacetCulling
	{
	private:
		bool enabled;
		CullFace face;
		WindingOrder frontFaceWindingOrder;

	public:

		inline const bool Enabled() const { return enabled; }
		void Enabled(const bool& value) { enabled = value; }

		inline const CullFace Face() const { return face; }
		void Face(const CullFace& value) { face = value; }

		inline const WindingOrder FrontFaceWindingOrder() const { return frontFaceWindingOrder; }
		void FrontFaceWindingOrder(const WindingOrder& value) { frontFaceWindingOrder = value; }

		FacetCulling() = default;
		FacetCulling(const FacetCulling &) = default;
		FacetCulling & operator=(const FacetCulling &) = default;
		FacetCulling(FacetCulling  && rhs) = delete;
		FacetCulling & operator=(FacetCulling && rhs) = delete;
		~FacetCulling() = default;
	};
}