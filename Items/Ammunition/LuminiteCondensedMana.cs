using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class LuminiteCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("12x Condensed Mana");
			Tooltip.SetDefault("Blood of the Moon Lord infused within");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 95;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 36f;
			Item.value = Item.sellPrice(silver: 75);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlTwelve>();
			Item.shootSpeed = 10f;
			Item.ammo = ModContent.ItemType<CondensedMana>();
		}
		public override void AddRecipes() {
			Recipe recipe12 = CreateRecipe(9);
				recipe12.AddIngredient<FragmentedCondensedMana>(3);
				recipe12.AddIngredient(ItemID.LunarBar, 1);
				recipe12.AddTile(TileID.MythrilAnvil);
				recipe12.Register();
			
		}
	}
}