using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
	public class SextupleCondensedManaBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Endless 6x Condensed Mana");
			Tooltip.SetDefault("");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}
		public override void SetDefaults()
		{
			Item.damage = 35;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 12f;
			Item.value = Item.sellPrice(silver: 35);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlSix>();
			Item.shootSpeed = 30f;
            Item.ammo = ModContent.ItemType<CondensedMana>();
        }
		public override void AddRecipes()
		{
			Recipe recipe0 = CreateRecipe();
			recipe0.AddIngredient<SextupleCondensedMana>(3996);
			recipe0.AddTile(TileID.CrystalBall);
			recipe0.Register();
			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient<CondensedManaBag>(243);
			recipe1.AddTile(TileID.CrystalBall);
			recipe1.Register();
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient<DoubleCondensedManaBag>(81);
			recipe2.AddTile(TileID.CrystalBall);
			recipe2.Register();
			Recipe recipe3 = CreateRecipe();
			recipe3.AddIngredient<TripleCondensedManaBag>(27);
			recipe3.AddTile(TileID.CrystalBall);
			recipe3.Register();
			Recipe recipe4 = CreateRecipe();
			recipe4.AddIngredient<QuadrupleCondensedManaBag>(9);
			recipe4.AddTile(TileID.CrystalBall);
			recipe4.Register();
			Recipe recipe5 = CreateRecipe();
			recipe5.AddIngredient<QuintupleCondensedManaBag>(3);
			recipe5.AddTile(TileID.CrystalBall);
			recipe5.Register();
		}
	}
}