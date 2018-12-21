using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonsterHunterTerra.Items
{
    public class MachaliteForge : ModItem
    {
        public override void SetDefaults()
        {

            item.width = 48;
            item.height = 32;
            item.maxStack = 99;
            item.useTurn = true;
            item.rare = 3;
            item.autoReuse = true;
            item.useAnimation = 15;

            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = mod.TileType("MachaliteForgeTile");
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mechalite Forge");
            Tooltip.SetDefault("Combines the function of the anvil and furnace");

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Ore1v2", 30);
            recipe.AddIngredient(33, 1);
            recipe.AddIngredient(35, 1);
            recipe.AddTile(16);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

    }
}