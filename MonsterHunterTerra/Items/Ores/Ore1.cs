using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonsterHunterTerra.Items.Ores
{
    public class Ore1v2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Machalite Ore");
            Tooltip.SetDefault("Used for Tier 1 bars");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.useTime = 20;
            item.useAnimation = 20;
            item.rare = 3;
            item.useStyle = 1;
            item.value = 100;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("Ore1Tile");
            item.maxStack = 999;

            

        }

    }
}

