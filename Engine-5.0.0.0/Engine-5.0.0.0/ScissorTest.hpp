#include "ExternalLibraries\glm-0.9.4.3\glm\glm.hpp"

#pragma once
namespace Engine
{
	class ScissorTest
	{
	private:
		bool enabled;
		glm::vec4 rectangle;
	public:

		inline const bool Enabled() const { return enabled; }
		void Enabled(const bool& value) { enabled = value; }

		inline const glm::vec4 Rectangle() const { return rectangle; }
		void Rectangle(const glm::vec4& value) { rectangle = value; }

		ScissorTest() = default;
		ScissorTest(const ScissorTest &) = default;
		ScissorTest & operator=(const ScissorTest &) = default;
		ScissorTest(ScissorTest  && rhs) = delete;
		ScissorTest & operator=(ScissorTest && rhs) = delete;
		~ScissorTest() = default;
	};
}