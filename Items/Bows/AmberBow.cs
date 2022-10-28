using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Bows
{
	public class AmberBow : ModItem
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
			Item.useTime = 26;
			Item.knockBack = 2;
			Item.damage = 12;
			Item.rare = ItemRarityID.Blue;
            Item.width = 16;
            Item.height = 32;
            Item.maxStack = 1;
            Item.useTime = 26;
            Item.useAnimation = 24;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.UseSound = SoundID.Item5;
            Item.noMelee = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 6.6f;
            Item.autoReuse = false;
			
			Item.value = Item.sellPrice(silver: 23, gold: 3);
			Item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Amber, 12);
			recipe.AddIngredient(ItemID.FossilOre, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}