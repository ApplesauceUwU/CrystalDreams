using IL.Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class CondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Condensed Mana");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults() {
			Item.damage = 5;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 1f;
			Item.value = Item.sellPrice(silver: 10);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlOne>();
			Item.shootSpeed = 30f;
			Item.ammo = Item.type;
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient(ItemID.ManaCrystal, 1);
				recipe0.AddTile(TileID.WorkBenches);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient(ItemID.FallenStar, 5);
				recipe1.AddTile(TileID.WorkBenches);
				recipe1.Register();
		}
	}
}