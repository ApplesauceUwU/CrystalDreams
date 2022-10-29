using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class NontupleCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless 9x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults() {
			Item.damage = 65;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 24f;
			Item.value = Item.sellPrice(silver: 50);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlNine>();
			Item.shootSpeed = 10f;
            Item.ammo = ModContent.ItemType<CondensedMana>();
        }
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient<NontupleCondensedMana>(3996);
				recipe0.AddTile(TileID.CrystalBall);
				recipe0.Register();
			Recipe recipe8 = CreateRecipe();
				recipe8.AddIngredient<OcttupleCondensedManaBag>(3);
				recipe8.AddTile(TileID.CrystalBall);
				recipe8.Register();
		}
	}
}