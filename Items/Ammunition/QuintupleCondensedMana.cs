using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class QuintupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("5x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 25;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 8f;
			Item.value = Item.sellPrice(silver: 30);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlFive>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe(9);
				recipe0.AddIngredient(ItemID.ManaCrystal, 81);
				recipe0.AddTile(TileID.Anvils);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe(9);
				recipe1.AddIngredient(ItemID.FallenStar, 405);
				recipe1.AddTile(TileID.Anvils);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe(9);
				recipe2.AddIngredient<CondensedMana>(81);
				recipe2.AddTile(TileID.Anvils);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe(9);
				recipe3.AddIngredient<DoubleCondensedMana>(27);
				recipe3.AddTile(TileID.Anvils);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe(9);
				recipe4.AddIngredient<TripleCondensedMana>(9);
				recipe4.AddTile(TileID.Anvils);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe(9);
				recipe5.AddIngredient<QuadrupleCondensedMana>(3);
				recipe5.AddTile(TileID.Anvils);
				recipe5.Register();
		}
	}
}