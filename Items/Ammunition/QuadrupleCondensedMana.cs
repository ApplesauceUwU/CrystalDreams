using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class QuadrupleCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("4x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 6f;
			Item.value = Item.sellPrice(silver: 25);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlFour>();
			Item.shootSpeed = 15f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe4 = CreateRecipe(9);
				recipe4.AddIngredient<TripleCondensedMana>(3);
				recipe4.AddTile(TileID.Anvils);
				recipe4.Register();
		}
	}
}