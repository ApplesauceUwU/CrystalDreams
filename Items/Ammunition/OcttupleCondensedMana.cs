using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class OcttupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("8x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 55;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 20f;
			Item.value = Item.sellPrice(silver: 45);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlEight>();
			Item.shootSpeed = 20f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe(9);
				recipe0.AddIngredient(ItemID.ManaCrystal, 2187);
				recipe0.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe0.AddIngredient(ItemID.TitaniumBar, 1);
				recipe0.AddTile(TileID.MythrilAnvil);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe(9);
				recipe1.AddIngredient(ItemID.FallenStar, 10935);
				recipe1.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe1.AddIngredient(ItemID.TitaniumBar, 1);
				recipe1.AddTile(TileID.MythrilAnvil);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe(9);
				recipe2.AddIngredient<CondensedMana>(2187);
				recipe2.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe2.AddIngredient(ItemID.TitaniumBar, 1);
				recipe2.AddTile(TileID.MythrilAnvil);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe(9);
				recipe3.AddIngredient<DoubleCondensedMana>(729);
				recipe3.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe3.AddIngredient(ItemID.TitaniumBar, 1);
				recipe3.AddTile(TileID.MythrilAnvil);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe(9);
				recipe4.AddIngredient<TripleCondensedMana>(243);
				recipe4.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe4.AddIngredient(ItemID.TitaniumBar, 1);
				recipe4.AddTile(TileID.MythrilAnvil);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe(9);
				recipe5.AddIngredient<QuadrupleCondensedMana>(81);
				recipe5.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe5.AddIngredient(ItemID.TitaniumBar, 1);
				recipe5.AddTile(TileID.MythrilAnvil);
				recipe5.Register();
			Recipe recipe6 = CreateRecipe(9);
				recipe6.AddIngredient<QuintupleCondensedMana>(27);
				recipe6.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe6.AddIngredient(ItemID.TitaniumBar, 1);
				recipe6.AddTile(TileID.MythrilAnvil);
				recipe6.Register();
			Recipe recipe7 = CreateRecipe(9);
				recipe7.AddIngredient<SextupleCondensedMana>(9);
				recipe7.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe7.AddIngredient(ItemID.TitaniumBar, 1);
				recipe7.AddTile(TileID.MythrilAnvil);
				recipe7.Register();
			Recipe recipe8 = CreateRecipe(9);
				recipe8.AddIngredient<SepttupleCondensedMana>(3);
				recipe8.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe8.AddIngredient(ItemID.TitaniumBar, 1);
				recipe8.AddTile(TileID.MythrilAnvil);
				recipe8.Register();
		}
	}
}