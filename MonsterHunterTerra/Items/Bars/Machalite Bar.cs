using System;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace MonsterHunterTerra.Items.Bars
{
    public class Bar1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Machalite Bar");
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
            recipe.AddIngredient(null, "Ore1v2", 3);
            recipe.SetResult(this);
            recipe.AddTile(null, "MachaliteForgeTile");
            recipe.AddRecipe();
        }

    }

}