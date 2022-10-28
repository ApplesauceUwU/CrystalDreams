using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class FragmentedCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 11x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults() {
			Item.damage = 85;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 32f;
			Item.value = Item.sellPrice(silver: 65);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlEleven>();
			Item.shootSpeed = 20f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<FragmentedCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe10 = CreateRecipe();
				recipe10.AddIngredient<DectupleCondensedManaBag>(3);
				recipe10.AddTile(TileID.CrystalBall);
				recipe10.Register();
		}
	}
}