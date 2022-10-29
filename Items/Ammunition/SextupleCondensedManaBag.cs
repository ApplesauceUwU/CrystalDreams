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
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.damage = 35;
			Item.DamageType = DamageClass.Magic;
			Item.width = 6;
			Item.height = 6;
			Item.maxStack = 9999;
			Item.consumable = false;
			Item.knockBack = 12f;
			Item.value = Item.sellPrice(silver: 35);
			Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlSix>();
			Item.shootSpeed = 10f;
            Item.ammo = ModContent.ItemType<CondensedMana>();
        }
		public override void AddRecipes()
		{
			Recipe recipe0 = CreateRecipe();
			recipe0.AddIngredient<SextupleCondensedMana>(3996);
			recipe0.AddTile(TileID.CrystalBall);
			recipe0.Register();
			Recipe recipe5 = CreateRecipe();
			recipe5.AddIngredient<QuintupleCondensedManaBag>(3);
			recipe5.AddTile(TileID.CrystalBall);
			recipe5.Register();
		}
	}
}