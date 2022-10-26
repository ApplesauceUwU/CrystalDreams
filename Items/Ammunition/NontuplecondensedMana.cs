using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class NontupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("9x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 65;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 24f;
			Item.value = Item.sellPrice(silver: 50);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlNine>();
			Item.shootSpeed = 15f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient(ItemID.ManaCrystal, 6561);
				recipe0.AddIngredient(ItemID.HallowedBar, 1);
				recipe0.AddTile(TileID.MythrilAnvil);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient(ItemID.FallenStar, 32805);
				recipe1.AddIngredient(ItemID.HallowedBar, 1);
				recipe1.AddTile(TileID.MythrilAnvil);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe();
				recipe2.AddIngredient<CondensedMana>(6561);
				recipe2.AddIngredient(ItemID.HallowedBar, 1);
				recipe2.AddTile(TileID.MythrilAnvil);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe();
				recipe3.AddIngredient<DoubleCondensedMana>(2187);
				recipe3.AddIngredient(ItemID.HallowedBar, 1);
				recipe3.AddTile(TileID.MythrilAnvil);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe();
				recipe4.AddIngredient<TripleCondensedMana>(729);
				recipe4.AddIngredient(ItemID.HallowedBar, 1);
				recipe4.AddTile(TileID.MythrilAnvil);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe();
				recipe5.AddIngredient<QuadrupleCondensedMana>(243);
				recipe5.AddIngredient(ItemID.HallowedBar, 1);
				recipe5.AddTile(TileID.MythrilAnvil);
				recipe5.Register();
			Recipe recipe6 = CreateRecipe();
				recipe6.AddIngredient<QuintupleCondensedMana>(81);
				recipe6.AddIngredient(ItemID.HallowedBar, 1);
				recipe6.AddTile(TileID.MythrilAnvil);
				recipe6.Register();
			Recipe recipe7 = CreateRecipe();
				recipe7.AddIngredient<SextupleCondensedMana>(27);
				recipe7.AddIngredient(ItemID.HallowedBar, 1);
				recipe7.AddTile(TileID.MythrilAnvil);
				recipe7.Register();
			Recipe recipe8 = CreateRecipe();
				recipe8.AddIngredient<SepttupleCondensedMana>(9);
				recipe8.AddIngredient(ItemID.HallowedBar, 1);
				recipe8.AddTile(TileID.MythrilAnvil);
				recipe8.Register();
			Recipe recipe9 = CreateRecipe();
				recipe9.AddIngredient<OcttupleCondensedMana>(3);
				recipe9.AddIngredient(ItemID.HallowedBar, 1);
				recipe9.AddTile(TileID.MythrilAnvil);
				recipe9.Register();
		}
	}
}