#pragma once
namespace Engine
{
	class DepthTest
	{
	private:

	public:
		DepthTest() = default;
		DepthTest(const DepthTest &) = default;
		DepthTest & operator=(const DepthTest &) = default;
		DepthTest(DepthTest  && rhs) = delete;
		DepthTest & operator=(DepthTest && rhs) = delete;
		~DepthTest() = default;
	};
}