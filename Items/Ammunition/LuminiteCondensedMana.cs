using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class LuminiteCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("12x Condensed Mana");
			Tooltip.SetDefault("Blood of the Moon Lord infused within");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 95;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 36f;
			Item.value = Item.sellPrice(silver: 75);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTwelve>();
			Item.shootSpeed = 30f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe(9);
				recipe0.AddIngredient(ItemID.ManaCrystal, 177147);
				recipe0.AddIngredient(ItemID.LunarBar, 1);
				recipe0.AddTile(TileID.MythrilAnvil);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe(9);
				recipe1.AddIngredient(ItemID.FallenStar, 885735);
				recipe1.AddIngredient(ItemID.LunarBar, 1);
				recipe1.AddTile(TileID.MythrilAnvil);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe(9);
				recipe2.AddIngredient<CondensedMana>(177147);
				recipe2.AddIngredient(ItemID.LunarBar, 1);
				recipe2.AddTile(TileID.MythrilAnvil);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe(9);
				recipe3.AddIngredient<DoubleCondensedMana>(59049);
				recipe3.AddIngredient(ItemID.LunarBar, 1);
				recipe3.AddTile(TileID.MythrilAnvil);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe(9);
				recipe4.AddIngredient<TripleCondensedMana>(19683);
				recipe4.AddIngredient(ItemID.LunarBar, 1);
				recipe4.AddTile(TileID.MythrilAnvil);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe(9);
				recipe5.AddIngredient<QuadrupleCondensedMana>(6561);
				recipe5.AddIngredient(ItemID.LunarBar, 1);
				recipe5.AddTile(TileID.MythrilAnvil);
				recipe5.Register();
			Recipe recipe6 = CreateRecipe(9);
				recipe6.AddIngredient<QuintupleCondensedMana>(2187);
				recipe6.AddIngredient(ItemID.LunarBar, 1);
				recipe6.AddTile(TileID.MythrilAnvil);
				recipe6.Register();
			Recipe recipe7 = CreateRecipe(9);
				recipe7.AddIngredient<SextupleCondensedMana>(729);
				recipe7.AddIngredient(ItemID.LunarBar, 1);
				recipe7.AddTile(TileID.MythrilAnvil);
				recipe7.Register();
			Recipe recipe8 = CreateRecipe(9);
				recipe8.AddIngredient<SepttupleCondensedMana>(243);
				recipe8.AddIngredient(ItemID.LunarBar, 1);
				recipe8.AddTile(TileID.MythrilAnvil);
				recipe8.Register();
			Recipe recipe9 = CreateRecipe(9);
				recipe9.AddIngredient<OcttupleCondensedMana>(81);
				recipe9.AddIngredient(ItemID.LunarBar, 1);
				recipe9.AddTile(TileID.MythrilAnvil);
				recipe9.Register();
			Recipe recipe10 = CreateRecipe(9);
				recipe10.AddIngredient<NontupleCondensedMana>(27);
				recipe10.AddIngredient(ItemID.LunarBar, 1);
				recipe10.AddTile(TileID.MythrilAnvil);
				recipe10.Register();
			Recipe recipe11 = CreateRecipe(9);
				recipe11.AddIngredient<DectupleCondensedMana>(9);
				recipe11.AddIngredient(ItemID.LunarBar, 1);
				recipe11.AddTile(TileID.MythrilAnvil);
				recipe11.Register();
			Recipe recipe12 = CreateRecipe(9);
				recipe12.AddIngredient<DectupleCondensedMana>(3);
				recipe12.AddIngredient(ItemID.LunarBar, 1);
				recipe12.AddTile(TileID.MythrilAnvil);
				recipe12.Register();
			
		}
	}
}