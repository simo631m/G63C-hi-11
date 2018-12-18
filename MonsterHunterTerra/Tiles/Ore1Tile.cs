using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonsterHunterTerra.Tiles
{
    public class Ore1Tile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = false;
            drop = mod.ItemType("Ore1v2");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Blue Ore");
            AddMapEntry(new Color(14, 120, 244), name);
            minPick = 65;
         
        }
    }
}


