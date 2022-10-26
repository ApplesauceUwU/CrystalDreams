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
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 32f;
			Item.value = Item.sellPrice(silver: 65);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlEleven>();
			Item.shootSpeed = 20f;
            Item.ammo = ModContent.ItemType<CondensedMana>();
        }
		public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe();
				recipe0.AddIngredient(ItemID.ManaCrystal, 59049);
				recipe0.AddIngredient(ItemID.FragmentSolar, 1);
				recipe0.AddIngredient(ItemID.FragmentVortex, 1);
				recipe0.AddIngredient(ItemID.FragmentNebula, 1);
				recipe0.AddIngredient(ItemID.FragmentStardust, 1);
				recipe0.AddTile(TileID.MythrilAnvil);
				recipe0.Register();
			Recipe recipe1 = CreateRecipe();
				recipe1.AddIngredient(ItemID.FallenStar, 295245);
				recipe1.AddIngredient(ItemID.FragmentSolar, 1);
				recipe1.AddIngredient(ItemID.FragmentVortex, 1);
				recipe1.AddIngredient(ItemID.FragmentNebula, 1);
				recipe1.AddIngredient(ItemID.FragmentStardust, 1);
				recipe1.AddTile(TileID.MythrilAnvil);
				recipe1.Register();
			Recipe recipe2 = CreateRecipe();
				recipe2.AddIngredient<CondensedMana>(59049);
				recipe2.AddIngredient(ItemID.FragmentSolar, 1);
				recipe2.AddIngredient(ItemID.FragmentVortex, 1);
				recipe2.AddIngredient(ItemID.FragmentNebula, 1);
				recipe2.AddIngredient(ItemID.FragmentStardust, 1);
				recipe2.AddTile(TileID.MythrilAnvil);
				recipe2.Register();
			Recipe recipe3 = CreateRecipe();
				recipe3.AddIngredient<DoubleCondensedMana>(19683);
				recipe3.AddIngredient(ItemID.FragmentSolar, 1);
				recipe3.AddIngredient(ItemID.FragmentVortex, 1);
				recipe3.AddIngredient(ItemID.FragmentNebula, 1);
				recipe3.AddIngredient(ItemID.FragmentStardust, 1);
				recipe3.AddTile(TileID.MythrilAnvil);
				recipe3.Register();
			Recipe recipe4 = CreateRecipe();
				recipe4.AddIngredient<TripleCondensedMana>(6561);
				recipe4.AddIngredient(ItemID.FragmentSolar, 1);
				recipe4.AddIngredient(ItemID.FragmentVortex, 1);
				recipe4.AddIngredient(ItemID.FragmentNebula, 1);
				recipe4.AddIngredient(ItemID.FragmentStardust, 1);
				recipe4.AddTile(TileID.MythrilAnvil);
				recipe4.Register();
			Recipe recipe5 = CreateRecipe();
				recipe5.AddIngredient<QuadrupleCondensedMana>(2187);
				recipe5.AddIngredient(ItemID.FragmentSolar, 1);
				recipe5.AddIngredient(ItemID.FragmentVortex, 1);
				recipe5.AddIngredient(ItemID.FragmentNebula, 1);
				recipe5.AddIngredient(ItemID.FragmentStardust, 1);
				recipe5.AddTile(TileID.MythrilAnvil);
				recipe5.Register();
			Recipe recipe6 = CreateRecipe();
				recipe6.AddIngredient<QuintupleCondensedMana>(729);
				recipe6.AddIngredient(ItemID.FragmentSolar, 1);
				recipe6.AddIngredient(ItemID.FragmentVortex, 1);
				recipe6.AddIngredient(ItemID.FragmentNebula, 1);
				recipe6.AddIngredient(ItemID.FragmentStardust, 1);
				recipe6.AddTile(TileID.MythrilAnvil);
				recipe6.Register();
			Recipe recipe7 = CreateRecipe();
				recipe7.AddIngredient<SextupleCondensedMana>(243);
				recipe7.AddIngredient(ItemID.FragmentSolar, 1);
				recipe7.AddIngredient(ItemID.FragmentVortex, 1);
				recipe7.AddIngredient(ItemID.FragmentNebula, 1);
				recipe7.AddIngredient(ItemID.FragmentStardust, 1);
				recipe7.AddTile(TileID.MythrilAnvil);
				recipe7.Register();
			Recipe recipe8 = CreateRecipe();
				recipe8.AddIngredient<SepttupleCondensedMana>(81);
				recipe8.AddIngredient(ItemID.FragmentSolar, 1);
				recipe8.AddIngredient(ItemID.FragmentVortex, 1);
				recipe8.AddIngredient(ItemID.FragmentNebula, 1);
				recipe8.AddIngredient(ItemID.FragmentStardust, 1);
				recipe8.AddTile(TileID.MythrilAnvil);
				recipe8.Register();
			Recipe recipe9 = CreateRecipe();
				recipe9.AddIngredient<OcttupleCondensedMana>(27);
				recipe9.AddIngredient(ItemID.FragmentSolar, 1);
				recipe9.AddIngredient(ItemID.FragmentVortex, 1);
				recipe9.AddIngredient(ItemID.FragmentNebula, 1);
				recipe9.AddIngredient(ItemID.FragmentStardust, 1);
				recipe9.AddTile(TileID.MythrilAnvil);
				recipe9.Register();
			Recipe recipe10 = CreateRecipe();
				recipe10.AddIngredient<NontupleCondensedMana>(9);
				recipe10.AddIngredient(ItemID.FragmentSolar, 1);
				recipe10.AddIngredient(ItemID.FragmentVortex, 1);
				recipe10.AddIngredient(ItemID.FragmentNebula, 1);
				recipe10.AddIngredient(ItemID.FragmentStardust, 1);
				recipe10.AddTile(TileID.MythrilAnvil);
				recipe10.Register();
			Recipe recipe11 = CreateRecipe();
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