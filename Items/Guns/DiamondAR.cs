using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Guns
{
	public class DiamondAR : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diamond AR"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("AR stands for Automatic Rifle ;)");
        }

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 17;
			Item.rare = ItemRarityID.Green;
            Item.width = 82;
            Item.height = 24;
            Item.scale = 0.75f;
            Item.maxStack = 1;
            Item.useTime = 15;
            Item.useAnimation = 14;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.UseSound = SoundID.Item11;
            Item.noMelee = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Bullet;
			Item.shootSpeed = 11f;
            Item.autoReuse = true;
			
			Item.value = Item.sellPrice(silver: 75, gold: 3);
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-8f, 0f);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Diamond, 12);
			recipe.AddIngredient(ItemID.PlatinumBar, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}