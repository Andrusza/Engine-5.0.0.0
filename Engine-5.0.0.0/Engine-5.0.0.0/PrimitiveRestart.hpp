#pragma once
namespace Engine
{
	class PrimitiveRestart
	{
	private:
		bool enabled;
		int index;
	public:

		inline const bool Enabled() const { return enabled; }
		void Enabled(const bool& value) { enabled = value; }

		inline const int Index() const { return index; }
		void Index(const int& value) { index = value; }

		PrimitiveRestart() = default;
		PrimitiveRestart(const PrimitiveRestart &) = default;
		PrimitiveRestart & operator=(const PrimitiveRestart &) = default;
		PrimitiveRestart(PrimitiveRestart  && rhs) = delete;
		PrimitiveRestart & operator=(PrimitiveRestart && rhs) = delete;
		~PrimitiveRestart() = default;
	};
}