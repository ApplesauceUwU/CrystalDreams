using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Guns
{
	public class RubyRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 17;
			Item.rare = ItemRarityID.Blue;
            Item.width = 86;
            Item.height = 36;
            Item.scale = 0.75f;
            Item.maxStack = 1;
            Item.useTime = 4;
            Item.useAnimation = 12;
			Item.reuseDelay = 15; 
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.UseSound = SoundID.Item11;
            Item.noMelee = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 11f;
            Item.autoReuse = false;
			
			Item.value = Item.sellPrice(silver: 47, gold: 2);
		}
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20f, 0f);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Ruby, 12);
			recipe.AddIngredient(ItemID.GoldBar, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}