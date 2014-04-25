#pragma once
namespace Engine
{
	enum class StencilOperation
	{
		Zero,
		Invert,
		Keep,
		Replace,
		Increment,
		Decrement,
		IncrementWrap,
		DecrementWrap
	};

	enum class StencilTestFunction
	{
		Never,
		Less,
		Equal,
		LessThanOrEqual,
		Greater,
		NotEqual,
		GreaterThanOrEqual,
		Always,
	};

#pragma once
	class StencilTestFace
	{
	private:
		StencilOperation stencilFailOperation;
		StencilOperation depthFailStencilPassOperation;
		StencilOperation depthPassStencilPassOperation;

		StencilTestFunction function;
		int referenceValue;
		int mask;
	public:

		inline const StencilOperation StencilFailOperation() const { return stencilFailOperation; }
		void StencilFailOperation(const StencilOperation& value) { stencilFailOperation = value; }

		inline const StencilOperation DepthFailStencilPassOperation() const { return depthFailStencilPassOperation; }
		void DepthFailStencilPassOperation(const StencilOperation& value) { depthFailStencilPassOperation = value; }

		inline const StencilOperation DepthPassStencilPassOperation() const { return depthPassStencilPassOperation; }
		void DepthPassStencilPassOperation(const StencilOperation& value) { depthPassStencilPassOperation = value; }

		inline const StencilTestFunction Function() const { return function; }
		void Function(const StencilTestFunction& value) { function = value; }

		inline const int Mask() const { return mask; }
		void Mask(const int& value) { mask = value; }

		StencilTestFace() = default;
		StencilTestFace(const StencilTestFace &) = default;
		StencilTestFace & operator=(const StencilTestFace &) = default;
		StencilTestFace(StencilTestFace  && rhs) = delete;
		StencilTestFace & operator=(StencilTestFace && rhs) = delete;
		~StencilTestFace() = default;
	};

	class StencilTest
	{
	private:
		bool enabled;
		StencilTestFace frontFace;
		StencilTestFace backFace;
	public:

		inline const bool Enabled() const { return enabled; }
		void Enabled(const bool& value) { enabled = value; }

		inline const StencilTestFace FrontFace() const { return frontFace; }
		void FrontFace(const StencilTestFace& value) { frontFace = value; }


		StencilTest() = default;
		StencilTest(const StencilTest &) = default;
		StencilTest & operator=(const StencilTest &) = default;
		StencilTest(StencilTest  && rhs) = delete;
		StencilTest & operator=(StencilTest && rhs) = delete;
		~StencilTest() = default;
	};
}

