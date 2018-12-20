using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using MonsterHunterTerra.Items;
using MonsterHunterTerra.Tiles;

namespace MonsterHunterTerra
{
    public class MonsterHunterTerraWorld : ModWorld
    {
        private void GenOre1Tile(GenerationProgress progress)
        {
            progress.Message = "Generation Machalite";

            for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                int i2 = WorldGen.genRand.Next(0, Main.maxTilesX);
                int j2 = WorldGen.genRand.Next((int)(Main.maxTilesY * .3f), (int)(Main.maxTilesY * .45f));
                WorldGen.OreRunner(i2, j2, WorldGen.genRand.Next(3, 4), WorldGen.genRand.Next(3, 8), (ushort)mod.TileType("Ore1Tile"));
            }
        }
    }
}