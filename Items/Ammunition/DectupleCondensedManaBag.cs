using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class DectupleCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 10x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults() {
			Item.damage = 75;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 28f;
			Item.value = Item.sellPrice(silver: 55);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTen>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe9 = CreateRecipe();
				recipe9.AddIngredient<NontupleCondensedManaBag>(3);
				recipe9.AddTile(TileID.CrystalBall);
				recipe9.Register();
		}
	}
}