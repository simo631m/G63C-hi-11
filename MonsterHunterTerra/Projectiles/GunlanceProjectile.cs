using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
namespace MonsterHunterTerra.Projectiles
{
    public class GunlanceProjectile : ModProjectile
    {
        public int counter = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gunlance");


        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 19;
            projectile.penetrate = -1;
            projectile.scale = 2f;
            projectile.alpha = 0;

            projectile.hide = true;
            projectile.ownerHitCheck = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.friendly = true;          
        }

        public float movementFactor 
        {
            get { return projectile.ai[0]; }
            set { projectile.ai[0] = value; }
        }

        public override void AI()
        {
            
            Player projOwner = Main.player[projectile.owner];
           
            Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
            projectile.direction = projOwner.direction;
            projOwner.heldProj = projectile.whoAmI;
            projOwner.itemTime = projOwner.itemAnimation;
            projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
            projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);
            
            if (!projOwner.frozen)
            {
                if (movementFactor == 0f) 
                {
                    movementFactor = 3f;
                    projectile.netUpdate = true; 
                }
                if (projOwner.itemAnimation < projOwner.itemAnimationMax / 3)
                {
                    movementFactor -= 2.4f;
                }
                else 
                {
                    movementFactor += 2.1f;
                }
            }
           
            projectile.position += projectile.velocity * movementFactor;
          
            if (projOwner.itemAnimation == 0)
            {
                projectile.Kill();
            }
          
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(135f);
          
            if (projectile.spriteDirection == -1)
            {
                projectile.rotation -= MathHelper.ToRadians(90f);
            }
            counter++;

        }


       

        public override void Kill(int timeLeft)
        {
            if (counter >= 30)
            {
                Player player = Main.player[projectile.owner];
                Vector2 vector82 = -Main.player[Main.myPlayer].Center + Main.MouseWorld;
                float ai = Main.rand.Next(100);
                Vector2 vector83 = Vector2.Normalize(vector82) * 20f;
                Projectile.NewProjectile(player.Center.X, player.Center.Y, vector83.X, vector83.Y, 580, projectile.damage / 2, .5f, player.whoAmI, vector82.ToRotation(), ai);
               
                counter = 0;
            }
        }

    }
}