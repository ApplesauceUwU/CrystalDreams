using CrystalDreams.Items.Ammunition;
using CrystalDreams.Projectiles.Unique;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System;
using Terraria.GameContent.Creative;

namespace CrystalDreams.Items.Condensed
{
	public class PewPewStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pew Pew Staff");
			Tooltip.SetDefault("Basically a gun");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Magic;
			Item.knockBack = 0;
			Item.damage = 12;
			Item.rare = ItemRarityID.Blue;
            Item.width = 48;
            Item.height = 14;
            Item.maxStack = 1;
            Item.useTime = 16;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 6;
            Item.UseSound = SoundID.Item8;
            Item.noMelee = true;
			Item.shoot = ProjectileID.Bullet;
            Item.useAmmo = ModContent.ItemType<CondensedMana>();
            Item.shootSpeed = 6.6f;
            Item.autoReuse = false;
			
			Item.value = Item.sellPrice(silver: 5);
			Item.autoReuse = false;
		}
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Vector2 perturbedSpeed = velocity * 1f;
            Projectile.NewProjectile(source, position, perturbedSpeed, ProjectileID.Bullet, damage, knockback, player.whoAmI);
            return false;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-1f, -2f);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PlatinumBar, 7);
			recipe.AddIngredient(ItemID.Wood,14);
			recipe.AddIngredient<CondensedMana>(10);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}