using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MonsterHunterTerra.Items.Weapons;


namespace MonsterHunterTerra.Projectiles
{
    public class GunlanceExplosive : ModProjectile
    {
        public override void SetStaticDefaults()
        { 
        DisplayName.SetDefault("GunlanceExplosive");


        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(41);

            aiType = 41;
        }


    }

}


