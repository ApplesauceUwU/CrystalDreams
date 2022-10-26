using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class DectupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("10x Condensed Mana");
			Tooltip.SetDefault("Xtreme Compression");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 75;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 28f;
			Item.value = Item.sellPrice(silver: 55);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTen>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient(ItemID.ManaCrystal, 19683);
				recipe0.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe0.AddTile(TileID.MythrilAnvil);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient(ItemID.FallenStar, 98415);
				recipe1.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe1.AddTile(TileID.MythrilAnvil);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe();
				recipe2.AddIngredient<CondensedMana>(19683);
				recipe2.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe2.AddTile(TileID.MythrilAnvil);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe();
				recipe3.AddIngredient<DoubleCondensedMana>(6561);
				recipe3.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe3.AddTile(TileID.MythrilAnvil);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe();
				recipe4.AddIngredient<TripleCondensedMana>(2187);
				recipe4.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe4.AddTile(TileID.MythrilAnvil);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe();
				recipe5.AddIngredient<QuadrupleCondensedMana>(729);
				recipe5.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe5.AddTile(TileID.MythrilAnvil);
				recipe5.Register();
			Recipe recipe6 = CreateRecipe();
				recipe6.AddIngredient<QuintupleCondensedMana>(243);
				recipe6.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe6.AddTile(TileID.MythrilAnvil);
				recipe6.Register();
			Recipe recipe7 = CreateRecipe();
				recipe7.AddIngredient<SextupleCondensedMana>(81);
				recipe7.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe7.AddTile(TileID.MythrilAnvil);
				recipe7.Register();
			Recipe recipe8 = CreateRecipe();
				recipe8.AddIngredient<SepttupleCondensedMana>(27);
				recipe8.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe8.AddTile(TileID.MythrilAnvil);
				recipe8.Register();
			Recipe recipe9 = CreateRecipe();
				recipe9.AddIngredient<OcttupleCondensedMana>(9);
				recipe9.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe9.AddTile(TileID.MythrilAnvil);
				recipe9.Register();
			Recipe recipe10 = CreateRecipe();
				recipe10.AddIngredient<NontupleCondensedMana>(3);
				recipe10.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe10.AddTile(TileID.MythrilAnvil);
				recipe10.Register();
		}
	}
}