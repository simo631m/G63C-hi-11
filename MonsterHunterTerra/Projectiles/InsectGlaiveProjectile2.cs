using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;


namespace MonsterHunterTerra.Projectiles
{
    public class InsectGlaiveProjectile2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("InsectGlaive's Kinsect");
        }






        public override void SetDefaults()
        {
            projectile.CloneDefaults(181);
            projectile.width = 22;
            projectile.height = 14;

            aiType = 181;
        }
    }


}