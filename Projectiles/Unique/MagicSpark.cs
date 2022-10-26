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
       /*
        public override void AI()
        {
            projectile.velocity.Y += projectile.ai[0];
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Sparkle>(), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }
       */
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
    }
}