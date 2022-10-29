using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class DoubleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("2x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 10;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 2f;
			Item.value = Item.sellPrice(silver: 15);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTwo>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe2 = CreateRecipe(9);
				recipe2.AddIngredient<CondensedMana>(3);
				recipe2.AddTile(TileID.Anvils);
				recipe2.Register();
		}
	}
}