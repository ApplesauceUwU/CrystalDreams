using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class NontupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("9x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 65;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 24f;
			Item.value = Item.sellPrice(silver: 50);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlNine>();
			Item.shootSpeed = 15f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe9 = CreateRecipe(9);
				recipe9.AddIngredient<OcttupleCondensedMana>(3);
				recipe9.AddIngredient(ItemID.HallowedBar, 1);
				recipe9.AddTile(TileID.MythrilAnvil);
				recipe9.Register();
		}
	}
}