using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class QuadrupleCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 4x Condensed Mana");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 6f;
			Item.value = Item.sellPrice(silver: 25);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlFour>();
			Item.shootSpeed = 15f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<QuadrupleCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient<CondensedManaBag>(27);
				recipe1.AddTile(TileID.CrystalBall);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe();
				recipe2.AddIngredient<DoubleCondensedManaBag>(9);
				recipe2.AddTile(TileID.CrystalBall);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe();
				recipe3.AddIngredient<TripleCondensedManaBag>(3);
				recipe3.AddTile(TileID.CrystalBall);
				recipe3.Register();
		}
	}
}