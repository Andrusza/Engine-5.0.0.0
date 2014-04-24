#pragma once
class Device
{
private:

public:
	Device() = default;
	Device(const Device &) = delete;
	Device & operator=(const Device &) = delete;
	Device(Device  && rhs) = delete;
	Device & operator=(Device && rhs) = delete;
	~Device() = default;
};

