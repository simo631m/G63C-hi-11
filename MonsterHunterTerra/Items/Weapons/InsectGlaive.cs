using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Events;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ObjectData;
using Terraria.Social;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;
using Terraria.Utilities;
using Terraria.World.Generation;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace MonsterHunterTerra.Items.Weapons
{
    public class InsectGlaive : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("\n[c/FF0000:Tier 1 InsectGlaive. ]"
                +"\nRight click for different attack");
            DisplayName.SetDefault("Insect Glaive");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(3858);
            item.melee = true;
            item.damage = 21;
            item.crit = 11;
            item.width = 50;
            item.height = 40;
            item.value = 100000;
            item.rare = 3;
            item.knockBack = 10;
            item.scale = 1.5f;
            item.shoot = mod.ProjectileType("InsectGlaiveSwing");
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse != 2)
            {
                item.shoot = mod.ProjectileType("InsectGlaiveSwing");

            }
            if (player.altFunctionUse == 2)
            {
                item.useTime = 15;
                item.useAnimation = 15;
                item.damage = 40;
                item.shootSpeed = 24f;
                item.shoot = mod.ProjectileType("InsectGlaiveProjectile");
                item.noMelee = true;
                item.noUseGraphic = true;
            }

            return base.CanUseItem(player);

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