using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class LuminiteCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 12x Condensed Mana");
			Tooltip.SetDefault("Power beyond compare");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 95;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 36f;
			Item.value = Item.sellPrice(silver: 75);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTwelve>();
			Item.shootSpeed = 30f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<LuminiteCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient<CondensedManaBag>(177147);
				recipe1.AddTile(TileID.CrystalBall);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe();
				recipe2.AddIngredient<DoubleCondensedManaBag>(59049);
				recipe2.AddTile(TileID.CrystalBall);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe();
				recipe3.AddIngredient<TripleCondensedManaBag>(19683);
				recipe3.AddTile(TileID.CrystalBall);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe();
				recipe4.AddIngredient<QuadrupleCondensedManaBag>(6561);
				recipe4.AddTile(TileID.CrystalBall);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe();
				recipe5.AddIngredient<QuintupleCondensedManaBag>(2187);
				recipe5.AddTile(TileID.CrystalBall);
				recipe5.Register();
			Recipe recipe6 = CreateRecipe();
				recipe6.AddIngredient<SextupleCondensedManaBag>(729);
				recipe6.AddTile(TileID.CrystalBall);
				recipe6.Register();
			Recipe recipe7 = CreateRecipe();
				recipe7.AddIngredient<SepttupleCondensedManaBag>(243);
				recipe7.AddTile(TileID.CrystalBall);
				recipe7.Register();
			Recipe recipe8 = CreateRecipe();
				recipe8.AddIngredient<OcttupleCondensedManaBag>(81);
				recipe8.AddTile(TileID.CrystalBall);
				recipe8.Register();
			Recipe recipe9 = CreateRecipe();
				recipe9.AddIngredient<NontupleCondensedManaBag>(27);
				recipe9.AddTile(TileID.CrystalBall);
				recipe9.Register();
			Recipe recipe10 = CreateRecipe();
				recipe10.AddIngredient<DectupleCondensedManaBag>(9);
				recipe10.AddTile(TileID.CrystalBall);
				recipe10.Register();
			Recipe recipe11 = CreateRecipe();
				recipe11.AddIngredient<FragmentedCondensedManaBag>(3);
				recipe11.AddTile(TileID.CrystalBall);
				recipe11.Register();
		}
	}
}