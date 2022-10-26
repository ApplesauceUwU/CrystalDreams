using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Guns
{
	public class AmberSniper : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
        }

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 55;
			Item.rare = ItemRarityID.Blue;
            Item.width = 62;
            Item.height = 18;
            Item.scale = 0.9f;
            Item.maxStack = 1;
            Item.useTime = 37;
            Item.useAnimation = 36;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.UseSound = SoundID.Item11;
            Item.noMelee = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 24f;
            Item.autoReuse = false;
			
			Item.value = Item.sellPrice(silver: 30, gold: 3);
		}
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-8f, 0f);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Amber, 12);
			recipe.AddIngredient(ItemID.FossilOre, 35);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}