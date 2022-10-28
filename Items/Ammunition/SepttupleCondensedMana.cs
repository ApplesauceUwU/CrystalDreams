using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class SepttupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("7x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 45;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 16f;
			Item.value = Item.sellPrice(silver: 40);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlSeven>();
			Item.shootSpeed = 25f;
			Item.ammo = ModContent.ItemType<CondensedMana>();

        }
		public override void AddRecipes() {
			Recipe recipe7 = CreateRecipe(9);
				recipe7.AddIngredient<SextupleCondensedMana>(3);
				recipe7.AddIngredient(ItemID.MythrilBar, 1);
				recipe7.AddIngredient(ItemID.OrichalcumBar, 1);
				recipe7.AddTile(TileID.MythrilAnvil);
				recipe7.Register();
		}
	}
}