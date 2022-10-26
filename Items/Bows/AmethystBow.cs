using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Bows
{
	public class AmethystBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
        }

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 28;
			Item.knockBack = 0;
			Item.damage = 8;
			Item.rare = ItemRarityID.White;
            Item.width = 16;
            Item.height = 32;
            Item.maxStack = 1;
            Item.useTime = 28;
            Item.useAnimation = 27;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.UseSound = SoundID.Item5;
            Item.noMelee = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 6.6f;
            Item.autoReuse = false;
			
			Item.value = Item.sellPrice(copper: 35, silver: 40);
			Item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Amethyst, 12);
			recipe.AddIngredient(ItemID.CopperBow, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}