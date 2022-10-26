using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Projectiles.CondensedMana
{
    public class LvlEight : ModProjectile
    {
        public override void SetStaticDefaults()
        {
        }
        public override void PostAI()
        {
            if (Main.rand.NextBool())
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, 103);
                dust.noGravity = true;
                dust.scale = 1.6f;
            }
        }
        public override void SetDefaults()
        {
            Projectile.extraUpdates = 0;
            Projectile.width = 6;
            Projectile.height = 6;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.scale = 1f;
        }
    }
}