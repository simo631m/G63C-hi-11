﻿using Microsoft.Xna.Framework;
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
using MonsterHunterTerra.Projectiles;

namespace MonsterHunterTerra.Items.Weapons
{
    public class Lance : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lance");
            Tooltip.SetDefault("\n[c/FF0000:Tier 1 Lance ]");
        }
        public override void SetDefaults()
        {
            item.damage = 14;
            item.width = 60;
            item.height = 60;
            item.melee = true;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTime = 30;
            item.shoot = mod.ProjectileType<LanceProjectile>();
            item.shootSpeed = 3f;
            item.useAnimation = 24;
            item.useStyle = 5;
            item.knockBack = 3f;
            item.value = 10000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
           
        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Bar1", 13);
            recipe.AddTile(null, "MachaliteForgeTile");
            recipe.SetResult(this);
            recipe.AddRecipe();

        }




    }
}
