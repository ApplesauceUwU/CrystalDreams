using CrystalDreams.Projectiles.Yoyos;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Yoyos
{
	public class DiamondYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
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
			Item.knockBack = 4;
			Item.damage = 23;
			Item.shoot = ModContent.ProjectileType<DiamondYoyoProjectile>();
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
			
			Item.value = Item.sellPrice(silver: 50, gold: 3);
			Item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Diamond, 12);
			recipe.AddIngredient(ItemID.Cobweb, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}