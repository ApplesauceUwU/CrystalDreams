using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class SextupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("6x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 35;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 12f;
			Item.value = Item.sellPrice(silver: 35);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlSix>();
			Item.shootSpeed = 30f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe(9);
				recipe0.AddIngredient(ItemID.ManaCrystal, 243);
				recipe0.AddTile(TileID.MythrilAnvil);
				recipe0.AddIngredient(ItemID.CobaltBar, 1);
				recipe0.AddIngredient(ItemID.PalladiumBar, 1);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe(9);
				recipe1.AddIngredient(ItemID.FallenStar, 1215);
				recipe1.AddTile(TileID.MythrilAnvil);
				recipe1.AddIngredient(ItemID.CobaltBar, 1);
				recipe1.AddIngredient(ItemID.PalladiumBar, 1);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe(9);
				recipe2.AddIngredient<CondensedMana>(243);
				recipe2.AddTile(TileID.MythrilAnvil);
				recipe2.AddIngredient(ItemID.CobaltBar, 1);
				recipe2.AddIngredient(ItemID.PalladiumBar, 1);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe(9);
				recipe3.AddIngredient<DoubleCondensedMana>(81);
				recipe3.AddTile(TileID.MythrilAnvil);
				recipe3.AddIngredient(ItemID.CobaltBar, 1);
				recipe3.AddIngredient(ItemID.PalladiumBar, 1);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe(9);
				recipe4.AddIngredient<TripleCondensedMana>(7);
				recipe4.AddTile(TileID.MythrilAnvil);
				recipe4.AddIngredient(ItemID.CobaltBar, 1);
				recipe4.AddIngredient(ItemID.PalladiumBar, 1);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe(9);
				recipe5.AddIngredient<QuadrupleCondensedMana>(9);
				recipe5.AddTile(TileID.MythrilAnvil);
				recipe5.AddIngredient(ItemID.CobaltBar, 1);
				recipe5.AddIngredient(ItemID.PalladiumBar, 1);
				recipe5.Register();
			Recipe recipe6 = CreateRecipe(9);
				recipe6.AddIngredient<QuintupleCondensedMana>(3);
				recipe6.AddIngredient(ItemID.CobaltBar, 1);
				recipe6.AddIngredient(ItemID.PalladiumBar, 1);
				recipe6.AddTile(TileID.MythrilAnvil);
				recipe6.Register();
		}
	}
}