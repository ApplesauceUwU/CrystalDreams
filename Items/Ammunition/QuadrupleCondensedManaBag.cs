using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class QuadrupleCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 4x Condensed Mana");
			Tooltip.SetDefault("");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 6f;
			Item.value = Item.sellPrice(silver: 25);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlFour>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<QuadrupleCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe3 = CreateRecipe();
				recipe3.AddIngredient<TripleCondensedManaBag>(3);
				recipe3.AddTile(TileID.CrystalBall);
				recipe3.Register();
		}
	}
}