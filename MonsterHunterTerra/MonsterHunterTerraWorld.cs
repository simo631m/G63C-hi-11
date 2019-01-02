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
       public static bool spawnOre = false;
    }
}