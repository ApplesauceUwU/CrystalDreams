using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Guns
{
	public class EmeraldSMG : ModItem
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
			Item.damage = 12;
			Item.rare = ItemRarityID.Blue;
			Item.width = 50;
            Item.height = 40;
            Item.scale = 0.75f;
            Item.maxStack = 1;
            Item.useTime = 10;
            Item.useAnimation = 9;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.UseSound = SoundID.Item11;
            Item.noMelee = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 10f;
            Item.autoReuse = true;
			
			Item.value = Item.sellPrice(copper: 30, silver: 90, gold: 1);
		}
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6f, 3f);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Emerald, 12);
			recipe.AddIngredient(ItemID.TungstenBar, 19);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}