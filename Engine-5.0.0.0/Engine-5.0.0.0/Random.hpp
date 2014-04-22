#include <random>

#pragma once
typedef std::mt19937 Rng;
class Random
{
private:
	unsigned int seed = 0;
	Rng rng;
	std::uniform_int_distribution<int> dist;
public:
	explicit Random(unsigned int seed) :seed(seed), rng(seed){};
	int NextInt();

	Random() = default;
	Random(const Random&) = delete;
	Random& operator=(const Random&) = delete;
	Random(Random && rhs) = delete;
	Random& operator=(Random&& rhs) = delete;
	~Random() = default;
};