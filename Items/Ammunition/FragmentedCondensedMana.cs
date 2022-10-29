using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class FragmentedCondensedMana : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("11x Condensed Mana");
			Tooltip.SetDefault("Fragments of the moon help boost these round even further");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults() {
			Item.damage = 85;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 32f;
			Item.value = Item.sellPrice(silver: 65);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlEleven>();
			Item.shootSpeed = 10f;
            Item.ammo = ModContent.ItemType<CondensedMana>();
        }
		public override void AddRecipes() {
			Recipe recipe11 = CreateRecipe(9);
				recipe11.AddIngredient<DectupleCondensedMana>(3);
				recipe11.AddIngredient(ItemID.FragmentSolar, 1);
				recipe11.AddIngredient(ItemID.FragmentVortex, 1);
				recipe11.AddIngredient(ItemID.FragmentNebula, 1);
				recipe11.AddIngredient(ItemID.FragmentStardust, 1);
				recipe11.AddTile(TileID.MythrilAnvil);
				recipe11.Register();
		}
	}
}