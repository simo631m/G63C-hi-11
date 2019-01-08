using System;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace MonsterHunterTerra.Items.Bars
{
    public class Bar2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fucium Bar");
            Tooltip.SetDefault("");
        }


        public override void SetDefaults()
        {
            item.width = 80;
            item.height = 60;
            item.maxStack = 99;
            item.value = 12000;
            item.rare = 3;
            item.consumable = false;


        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Ore2", 3);
            recipe.SetResult(this);
            recipe.AddTile(null, "MachaliteForgeTile");
            recipe.AddRecipe();
        }

    }

}