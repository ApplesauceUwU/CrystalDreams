using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class DectupleCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 10x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 75;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 28f;
			Item.value = Item.sellPrice(silver: 55);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTen>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<DectupleCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient<CondensedManaBag>(6561);
				recipe1.AddTile(TileID.CrystalBall);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe();
				recipe2.AddIngredient<DoubleCondensedManaBag>(2187);
				recipe2.AddTile(TileID.CrystalBall);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe();
				recipe3.AddIngredient<TripleCondensedManaBag>(729);
				recipe3.AddTile(TileID.CrystalBall);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe();
				recipe4.AddIngredient<QuadrupleCondensedManaBag>(243);
				recipe4.AddTile(TileID.CrystalBall);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe();
				recipe5.AddIngredient<QuintupleCondensedManaBag>(81);
				recipe5.AddTile(TileID.CrystalBall);
				recipe5.Register();
			Recipe recipe6 = CreateRecipe();
				recipe6.AddIngredient<SextupleCondensedManaBag>(27);
				recipe6.AddTile(TileID.CrystalBall);
				recipe6.Register();
			Recipe recipe7 = CreateRecipe();
				recipe7.AddIngredient<SepttupleCondensedManaBag>(9);
				recipe7.AddTile(TileID.CrystalBall);
				recipe7.Register();
			Recipe recipe8 = CreateRecipe();
				recipe8.AddIngredient<OcttupleCondensedManaBag>(3);
				recipe8.AddTile(TileID.CrystalBall);
				recipe8.Register();
			Recipe recipe9 = CreateRecipe();
				recipe9.AddIngredient<NontupleCondensedManaBag>(3);
				recipe9.AddTile(TileID.CrystalBall);
				recipe9.Register();
		}
	}
}