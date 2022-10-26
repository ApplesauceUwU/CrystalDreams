using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class QuintupleCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 5x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 25;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 8f;
			Item.value = Item.sellPrice(silver: 30);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlFive>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<QuintupleCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient<CondensedManaBag>(81);
				recipe1.AddTile(TileID.CrystalBall);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe();
				recipe2.AddIngredient<DoubleCondensedManaBag>(27);
				recipe2.AddTile(TileID.CrystalBall);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe();
				recipe3.AddIngredient<TripleCondensedManaBag>(9);
				recipe3.AddTile(TileID.CrystalBall);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe();
				recipe4.AddIngredient<QuadrupleCondensedManaBag>(3);
				recipe4.AddTile(TileID.CrystalBall);
				recipe4.Register();
			
		}
	}
}