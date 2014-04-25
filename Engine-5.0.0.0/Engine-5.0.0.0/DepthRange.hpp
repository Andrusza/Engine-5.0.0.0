#pragma once
namespace Engine
{
	class DepthRange
	{
	private:

	public:
		DepthRange() = default;
		DepthRange(const DepthRange &) = default;
		DepthRange & operator=(const DepthRange &) = default;
		DepthRange(DepthRange  && rhs) = delete;
		DepthRange & operator=(DepthRange && rhs) = delete;
		~DepthRange() = default;
	};
}