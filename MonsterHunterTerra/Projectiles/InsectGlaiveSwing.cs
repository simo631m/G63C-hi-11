using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace MonsterHunterTerra.Projectiles
{
    public class InsectGlaiveSwing : ModProjectile
    {
        public int counter = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("InsectGlaive's Swing");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(707);
            projectile.width = 25;
            projectile.height = 25;
            projectile.aiStyle = 140;
            aiType = 707;
            projectile.scale = 2f;
        }

      
    }


}