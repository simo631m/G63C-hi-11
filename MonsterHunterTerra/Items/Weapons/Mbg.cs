using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonsterHunterTerra.Items.Weapons
{
    public class Mbg : ModItem
    {
        public override void SetDefaults()
        {

            item.damage = 30;
            item.width = 40;
            item.height = 16;
            item.ranged = true;
            item.useTime = 30;
            item.shoot = 1;
           

            item.shootSpeed = 60f;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.knockBack = 5;
            item.value = 1040;
            item.useAmmo = AmmoID.Arrow;
            item.rare = 6;
            item.crit = 7;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Medium Bow Gun");
            Tooltip.SetDefault("\n[c/FF0000:Tier 1 Medium Bow Gun ]");
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Bar1", 26);
            recipe.AddTile(null, "MachaliteForgeTile");
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }
}
