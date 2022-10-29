using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystalDreams.Items.Ammunition
{
    public class CondensedMana : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Condensed Mana");
            Tooltip.SetDefault("");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
        }
        public override void SetDefaults()
        {
            Item.damage = 5;
            Item.DamageType = DamageClass.Magic;
            Item.width = 6;
            Item.height = 6;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.value = Item.sellPrice(silver: 10);
            Item.shoot = ModContent.ProjectileType<Projectiles.CondensedMana.LvlOne>();
            Item.shootSpeed = 10f;
            Item.ammo = ModContent.ItemType<CondensedMana>();
        }
        public override void AddRecipes() {
			Recipe recipe0 = CreateRecipe(9);
				recipe0.AddIngredient(ItemID.ManaCrystal, 1);
				recipe0.AddTile(TileID.WorkBenches);
				recipe0.Register();
		}
	}
}