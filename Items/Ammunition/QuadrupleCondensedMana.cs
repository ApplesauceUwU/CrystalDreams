using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class QuadrupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("4x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 6f;
			Item.value = Item.sellPrice(silver: 25);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlFour>();
			Item.shootSpeed = 15f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe(9);
				recipe0.AddIngredient(ItemID.ManaCrystal, 27);
				recipe0.AddTile(TileID.Anvils);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe(9);
				recipe1.AddIngredient(ItemID.FallenStar, 135);
				recipe1.AddTile(TileID.Anvils);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe(9);
				recipe2.AddIngredient<CondensedMana>(27);
				recipe2.AddTile(TileID.Anvils);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe(9);
				recipe3.AddIngredient<DoubleCondensedMana>(9);
				recipe3.AddTile(TileID.Anvils);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe(9);
				recipe4.AddIngredient<TripleCondensedMana>(3);
				recipe4.AddTile(TileID.Anvils);
				recipe4.Register();
		}
	}
}