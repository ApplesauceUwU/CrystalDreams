using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class SextupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("6x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 35;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 12f;
			Item.value = Item.sellPrice(silver: 35);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlSix>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe6 = CreateRecipe(9);
				recipe6.AddIngredient<QuintupleCondensedMana>(3);
				recipe6.AddIngredient(ItemID.CobaltBar, 1);
				recipe6.AddIngredient(ItemID.PalladiumBar, 1);
				recipe6.AddTile(TileID.MythrilAnvil);
				recipe6.Register();
		}
	}
}