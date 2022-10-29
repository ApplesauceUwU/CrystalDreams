using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class DoubleCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("2x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults() {
			Item.damage = 10;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 2f;
			Item.value = Item.sellPrice(silver: 15);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTwo>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<DoubleCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient<CondensedManaBag>(3);
				recipe1.AddTile(TileID.CrystalBall);
				recipe1.Register();
		}
	}
}