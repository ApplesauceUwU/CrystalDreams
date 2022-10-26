using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Guns
{
	public class TopazPistol : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
        }

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 11;
			Item.rare = ItemRarityID.White;
            Item.width = 42;
            Item.height = 30;
            Item.scale = 0.75f;
            Item.maxStack = 1;
            Item.useTime = 13;
            Item.useAnimation = 12;
            Item.useStyle = 5;
            Item.knockBack = 4;
            Item.UseSound = SoundID.Item11;
            Item.noMelee = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 10f;
            Item.autoReuse = false;
			
			Item.value = Item.sellPrice(gold: 1);
		}
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(1f, 0f);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Topaz, 12);
			recipe.AddIngredient(ItemID.TinBar, 14);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
        }
	}
}