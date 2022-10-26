using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Projectiles.Yoyos
{
    public class DiamondYoyoProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.YoyosLifeTimeMultiplier[Projectile.type] = 5f;
            ProjectileID.Sets.YoyosMaximumRange[Projectile.type] = 180f;
            ProjectileID.Sets.YoyosTopSpeed[Projectile.type] = 11f;
        }

        public override void SetDefaults()
        {
            Projectile.extraUpdates = 0;
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.aiStyle = 99;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.scale = 1f;
        }

        // public override void PostAI()
        // {
        //     if (Main.rand.NextBool())
        //     {
        //         Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, 16);
        //         dust.noGravity = true;
        //         dust.scale = 1.6f;
        //     }
        // }
    }
}