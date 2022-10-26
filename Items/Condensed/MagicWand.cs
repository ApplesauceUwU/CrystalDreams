using CrystalDreams.Items.Ammunition;
using CrystalDreams.Projectiles.Unique;
using Microsoft.Xna.Framework;
using Terraria;
using CrystalDreams.Projectiles.Unique;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Condensed
{
	public class MagicWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Wand");
			Tooltip.SetDefault("");
        }

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.knockBack = 0;
			Item.damage = 7;
			Item.rare = ItemRarityID.Blue;
            Item.width = 16;
            Item.height = 32;
            Item.maxStack = 1;
            Item.useTime = 12;
            Item.useAnimation = 11;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 2;
            Item.UseSound = SoundID.Item8;
            Item.noMelee = true;
            Item.shoot = ModContent.ProjectileType<MagicSpark>();
            Item.useAmmo = ModContent.ItemType<CondensedMana>();
            Item.shootSpeed = 6.6f;
            Item.autoReuse = false;
			
			Item.value = Item.sellPrice(silver: 5);
			Item.autoReuse = false;
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-1f, -2f);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddIngredient<CondensedMana>(8);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}