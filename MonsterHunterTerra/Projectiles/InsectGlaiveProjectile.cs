using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;


namespace MonsterHunterTerra.Projectiles
{
    public class InsectGlaiveProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("InsectGlaive's Kinsect");
        }



        
    
            
         public override void SetDefaults()
            {
                projectile.CloneDefaults(181);
                projectile.width = 50;
                projectile.height = 40;
               
                aiType = 181;
            }
    }

   
}