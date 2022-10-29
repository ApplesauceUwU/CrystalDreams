using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace CrystalDreams.Projectiles.CondensedMana
{
    public class LvlOne : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5; // The length of old position to be recorded
            ProjectileID.Sets.TrailingMode[Projectile.type] = 0; // The recording mode
        }
        public override void PostAI()
        {
            if (Main.rand.NextBool())
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.Clentaminator_Blue);
                dust.noGravity = true;
                dust.scale = 1.6f;
            }
        }
        public override void AI()
        {
            float die = 0;
            Projectile.rotation = die;
        }
        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(Projectile.position, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }
        public override void SetDefaults()
        {
            Projectile.extraUpdates = 0;
            Projectile.width = 24;
            Projectile.height = 2;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.scale = 1f;
            AIType = ProjectileID.Bullet;
        }
    }
}