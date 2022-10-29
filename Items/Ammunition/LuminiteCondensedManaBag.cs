using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class LuminiteCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 12x Condensed Mana");
			Tooltip.SetDefault("Power beyond compare");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults() {
			Item.damage = 95;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 36f;
			Item.value = Item.sellPrice(silver: 75);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTwelve>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<LuminiteCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe11 = CreateRecipe();
				recipe11.AddIngredient<FragmentedCondensedManaBag>(3);
				recipe11.AddTile(TileID.CrystalBall);
				recipe11.Register();
		}
	}
}