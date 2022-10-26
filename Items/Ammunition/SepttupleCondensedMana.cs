using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class SepttupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("7x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 45;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 16f;
			Item.value = Item.sellPrice(silver: 40);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlSeven>();
			Item.shootSpeed = 25f;
			Item.ammo = ModContent.ItemType<CondensedMana>();

        }
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient(ItemID.ManaCrystal, 729);
				recipe0.AddIngredient(ItemID.MythrilBar, 1);
				recipe0.AddIngredient(ItemID.OrichalcumBar, 1);
				recipe0.AddTile(TileID.MythrilAnvil);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient(ItemID.FallenStar, 3645);
				recipe1.AddIngredient(ItemID.MythrilBar, 1);
				recipe1.AddIngredient(ItemID.OrichalcumBar, 1);
				recipe1.AddTile(TileID.MythrilAnvil);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe();
				recipe2.AddIngredient<CondensedMana>(729);
                recipe2.AddIngredient(ItemID.MythrilBar, 1);
				recipe2.AddIngredient(ItemID.OrichalcumBar, 1);
				recipe2.AddTile(TileID.MythrilAnvil);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe();
				recipe3.AddIngredient<DoubleCondensedMana>(243);

                recipe3.AddIngredient(ItemID.MythrilBar, 1);
				recipe3.AddIngredient(ItemID.OrichalcumBar, 1);
				recipe3.AddTile(TileID.MythrilAnvil);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe();
				recipe4.AddIngredient<TripleCondensedMana>(81);

                recipe4.AddIngredient(ItemID.MythrilBar, 1);
				recipe4.AddIngredient(ItemID.OrichalcumBar, 1);
				recipe4.AddTile(TileID.MythrilAnvil);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe();
				recipe5.AddIngredient<QuadrupleCondensedMana>(27);

                recipe5.AddIngredient(ItemID.MythrilBar, 1);
				recipe5.AddIngredient(ItemID.OrichalcumBar, 1);
				recipe5.AddTile(TileID.MythrilAnvil);
				recipe5.Register();
			Recipe recipe6 = CreateRecipe();
				recipe6.AddIngredient<QuintupleCondensedMana>(9);

                recipe6.AddIngredient(ItemID.MythrilBar, 1);
				recipe6.AddIngredient(ItemID.OrichalcumBar, 1);
				recipe6.AddTile(TileID.MythrilAnvil);
				recipe6.Register();
			Recipe recipe7 = CreateRecipe();
				recipe7.AddIngredient<SextupleCondensedMana>(3);
				recipe7.AddIngredient(ItemID.MythrilBar, 1);
				recipe7.AddIngredient(ItemID.OrichalcumBar, 1);
				recipe7.AddTile(TileID.MythrilAnvil);
				recipe7.Register();
		}
	}
}