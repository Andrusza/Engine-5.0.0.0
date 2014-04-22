#version 400

layout( location = 0 ) out vec4 FragColor;
in vec2 pTexCoord;
in float pHeigh;


struct TerrainRegion
{
    float min;
    float max;
};

uniform TerrainRegion region1;
uniform TerrainRegion region2;
uniform TerrainRegion region3;
uniform TerrainRegion region4;
uniform TerrainRegion region5;

uniform sampler2D tSand;
uniform sampler2D tGrass;
uniform sampler2D tDirt;
uniform sampler2D tRock;
uniform sampler2D tSnow;

vec4 GenerateTerrainColor()
{
    vec4 terrainColor = vec4(0.0, 0.0, 0.0, 1.0);
    float height = pHeigh;
    float regionMin = 0.0;
    float regionMax = 0.0;
    float regionRange = 0.0;
    float regionWeight = 0.0;
    
    // Terrain region 1.
    regionMin = region1.min;
    regionMax = region1.max;
    regionRange = regionMax - regionMin;
    regionWeight = (regionRange - abs(height - regionMax)) / regionRange;
    regionWeight = max(0.0, regionWeight);
    terrainColor += regionWeight * texture2D(tSand, pTexCoord);

    // Terrain region 2.
    regionMin = region2.min;
    regionMax = region2.max;
    regionRange = regionMax - regionMin;
    regionWeight = (regionRange - abs(height - regionMax)) / regionRange;
    regionWeight = max(0.0, regionWeight);
    terrainColor += regionWeight * texture2D(tGrass, pTexCoord);

    // Terrain region 3.
    regionMin = region3.min;
    regionMax = region3.max;
    regionRange = regionMax - regionMin;
    regionWeight = (regionRange - abs(height - regionMax)) / regionRange;
    regionWeight = max(0.0, regionWeight);
    terrainColor += regionWeight * texture2D(tDirt, pTexCoord);

    // Terrain region 4.
    regionMin = region4.min;
    regionMax = region4.max;
    regionRange = regionMax - regionMin;
    regionWeight = (regionRange - abs(height - regionMax)) / regionRange;
    regionWeight = max(0.0, regionWeight);
    terrainColor += regionWeight * texture2D(tRock, pTexCoord);
	
	 // Terrain region 5.
    regionMin = region5.min;
    regionMax = region5.max;
    regionRange = regionMax - regionMin;
    regionWeight = (regionRange - abs(height - regionMax)) / regionRange;
    regionWeight = max(0.0, regionWeight);
    terrainColor += regionWeight * texture2D(tSnow, pTexCoord);

    return terrainColor;
}


void main(void)
{
	FragColor=GenerateTerrainColor();
}