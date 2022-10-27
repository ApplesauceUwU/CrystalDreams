using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Projectiles.Unique
{
    public class MagicSpark : ModProjectile
    {
        public override void SetStaticDefaults()
        {
        }
        public override void PostAI()
        {
            if (Main.rand.NextBool())
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, 132);
                dust.noGravity = true;
                dust.scale = .85f;
            }
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.PurificationPowder);
            Projectile.timeLeft = 40;
            Projectile.extraUpdates = 0;
            Projectile.width = 6;
            Projectile.height = 6;
            Projectile.aiStyle = 504;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.scale = 1f;
            AIType = ProjectileID.PurificationPowder;
        }
        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(Projectile.position, Projectile.velocity, Projectile.width, Projectile.height);
            
            Projectile.timeLeft = 0;
        }
    }
}