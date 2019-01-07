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
    public class SwitchAxeIn : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("\n[c/FF0000:Tier 1 Switch Axe. ]"
               + "\nRight click in inventory to change Weapon ");
            DisplayName.SetDefault("Switch Axe");

        }

        public override void SetDefaults()
        {
  
            item.melee = true;
            item.damage = 30;
            item.crit = 21;
            item.width = 50;
            item.height = 40;
            item.useStyle = 1;
            item.useTime = 30;
            item.useAnimation = 30;
            item.value = 10000000;
            item.rare = 11;
            item.knockBack = 10;
           
            
            
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

   

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("SwitchAxeOut"));
        }

   


    }
}
