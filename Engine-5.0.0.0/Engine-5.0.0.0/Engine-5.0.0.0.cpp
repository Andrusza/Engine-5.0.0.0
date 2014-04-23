#include "pch.hpp"
#include "ExternalLibraries\cereal\types\map.hpp"
#include "ExternalLibraries\cereal\types\memory.hpp"
#include "ExternalLibraries\cereal\archives\json.hpp"
#include "ExternalLibraries\cereal\archives\binary.hpp"

struct MyRecord
{
	float x, y;
	float z;

	template <class Archive>
	void serialize(Archive & ar)
	{
		ar(x, y, z);
	}
};

struct SomeData
{
	int id;
	std::map<int, MyRecord> data;

	template <class Archive>
	void save(Archive & ar) const
	{
		ar(id, data);
	}

	template <class Archive>
	void load(Archive & ar)
	{
		ar(id, data);
	}
};

int main(int argc, char* argv[])
{
	{
		std::ofstream os("out.cereal", std::ios::binary);
		cereal::BinaryOutputArchive archive(os);

		SomeData myData;
		myData.id = 111;
		for (int i = 0; i < 100; i++)
		{
			MyRecord xxx;
			xxx.x = i;
			xxx.y = i * 2;
			xxx.z = xxx.x + xxx.y;

			myData.data.insert(std::pair<int32_t, MyRecord>(i, xxx));
		}

		archive(myData);
	}

	{
	std::ifstream os("out.cereal", std::ios::binary);
	cereal::BinaryInputArchive archive(os);

	SomeData myData;
	archive(myData); // Read the data from the archive

	std::cout << myData.data[0].x << " " << myData.data[0].z;
	myData.data[0].x;
}
	glutInit(&argc, argv);
	WindowGL(400, 400, "derp", WindowType::Windowed);

	glutMainLoop();

	return 0;
}