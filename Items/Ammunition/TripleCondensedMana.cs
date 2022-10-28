using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class TripleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("3x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 15;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 4f;
			Item.value = Item.sellPrice(silver: 20);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlThree>();
			Item.shootSpeed = 20f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe3 = CreateRecipe(9);
				recipe3.AddIngredient<DoubleCondensedMana>(3);
				recipe3.AddTile(TileID.Anvils);
				recipe3.Register();
		}
	}
}