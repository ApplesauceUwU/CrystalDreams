using CrystalDreams.Projectiles.Yoyos;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Yoyos
{
	public class TopazYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Might be useful.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.WoodYoyo);
			Item.DamageType = DamageClass.Melee;
			Item.width = 16;
			Item.height = 16;
			Item.useAnimation = 25;
			Item.useTime = 24;
			Item.shootSpeed = 16f;
			Item.knockBack = 0;
			Item.damage = 16;
			Item.shoot = ModContent.ProjectileType<TopazYoyoProjectile>();
			Item.rare = ItemRarityID.White;
			Item.UseSound = SoundID.Item1;
			
			Item.value = Item.sellPrice(silver: 73);
			Item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Topaz, 12);
			recipe.AddIngredient(ItemID.Cobweb, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}