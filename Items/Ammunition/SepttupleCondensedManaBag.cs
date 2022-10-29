using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class SepttupleCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 7x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults() {
			Item.damage = 45;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 16f;
			Item.value = Item.sellPrice(silver: 40);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlSeven>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<SepttupleCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe6 = CreateRecipe();
				recipe6.AddIngredient<SextupleCondensedManaBag>(3);
				recipe6.AddTile(TileID.CrystalBall);
				recipe6.Register();
		}
	}
}