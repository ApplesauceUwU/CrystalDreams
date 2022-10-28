using Terraria;
using System;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;

namespace CrystalDreams.Items.Guns
{
	public class SapphireShotgun : ModItem
	{
		private float speedX;
		private float speedY;

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 14;
			Item.rare = ItemRarityID.Blue;
            Item.width = 40;
            Item.height = 16;
            Item.scale = 0.9f;
            Item.maxStack = 1;
            Item.useTime = 38;
            Item.useAnimation = 37;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 6;
			Item.crit = 4;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = ProjectileID.Bullet;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 40f;
            Item.autoReuse = false;
			
			Item.value = Item.sellPrice(copper: 15, silver: 53, gold: 1);
		}
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            float numberProjectiles = 4;
            float rotation = MathHelper.ToRadians(5);
            position += Vector2.Normalize(velocity) * 5f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1 + Main.rand.Next(5)))) * .2f;
                float scale = 1f - (Main.rand.NextFloat() * .3f);
                perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);
            }
            return false;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(1f, -1f);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Sapphire, 12);
			recipe.AddIngredient(ItemID.SilverBar, 18);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}