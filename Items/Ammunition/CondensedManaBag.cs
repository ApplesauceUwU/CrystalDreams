using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class CondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults() {
			Item.damage = 5;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 1f;
			Item.value = Item.sellPrice(silver: 10);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlOne>();
			Item.shootSpeed = 30f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
        public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<CondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
		}
	}
}