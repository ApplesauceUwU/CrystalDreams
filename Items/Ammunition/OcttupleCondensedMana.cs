using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class OcttupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("8x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 55;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 20f;
			Item.value = Item.sellPrice(silver: 45);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlEight>();
			Item.shootSpeed = 20f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe8 = CreateRecipe(9);
				recipe8.AddIngredient<SepttupleCondensedMana>(3);
				recipe8.AddIngredient(ItemID.AdamantiteBar, 1);
				recipe8.AddIngredient(ItemID.TitaniumBar, 1);
				recipe8.AddTile(TileID.MythrilAnvil);
				recipe8.Register();
		}
	}
}