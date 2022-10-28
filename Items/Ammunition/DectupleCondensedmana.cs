using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class DectupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("10x Condensed Mana");
			Tooltip.SetDefault("Xtreme Compression");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 75;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 28f;
			Item.value = Item.sellPrice(silver: 55);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTen>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe10 = CreateRecipe(9);
				recipe10.AddIngredient<NontupleCondensedMana>(3);
				recipe10.AddIngredient(ItemID.ChlorophyteBar, 1);
				recipe10.AddTile(TileID.MythrilAnvil);
				recipe10.Register();
		}
	}
}