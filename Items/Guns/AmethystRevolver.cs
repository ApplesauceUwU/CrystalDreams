using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Guns
{
	public class AmethystRevolver : ModItem
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
			Item.damage = 18;
			Item.rare = ItemRarityID.Blue;
            Item.width = 46;
            Item.height = 24;
            Item.scale = 0.75f;
            Item.maxStack = 1;
            Item.useTime = 18;
            Item.useAnimation = 17;
            Item.useStyle = 5;
            Item.knockBack = 3;
            Item.UseSound = SoundID.Item11;
            Item.noMelee = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 6.5f;
            Item.autoReuse = false;
			
			Item.value = Item.sellPrice(silver: 65, gold: 1);
		}
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2f, -2f);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Amethyst, 20);
			recipe.AddIngredient(ItemID.CopperBar, 15);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}