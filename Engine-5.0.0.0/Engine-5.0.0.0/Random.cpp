#include "pch.hpp"

int Random::NextInt()
{
	return dist(rng);
}