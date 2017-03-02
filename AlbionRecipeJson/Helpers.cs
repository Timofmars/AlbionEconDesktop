using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRecipeJson
{
    class Helpers
    {
        private static List<Item> essences;
        public static Item GetResourceByTier(ResourceType resource, int tier, int rarity)
        {
            if (rarity > 1 && (tier < 4 || resource == ResourceType.Block)) return null;
            if (tier == 1) return null;
            var itemName = "";
            if (rarity == 2) itemName += "Uncommon ";
            if (rarity == 3) itemName += "Rare ";
            if (rarity == 4) itemName += "Exceptional ";
            if (resource == ResourceType.Cloth)
            {
                if (tier == 2) itemName += "Simple";
                else if (tier == 3) itemName += "Neat";
                else if (tier == 4) itemName += "Fine";
                else if (tier == 5) itemName += "Ornate";
                else if (tier == 6) itemName += "Lavish";
                else if (tier == 7) itemName += "Opulent";
                else if (tier == 8) itemName += "Baroque";
                itemName += " Cloth";
            }
            if (resource == ResourceType.Bar)
            {
                if (tier == 2) itemName += "Copper";
                else if (tier == 3) itemName += "Bronze";
                else if (tier == 4) itemName += "Steel";
                else if (tier == 5) itemName += "Titanium Steel";
                else if (tier == 6) itemName += "Runite Steel";
                else if (tier == 7) itemName += "Meteorite Steel";
                else if (tier == 8) itemName += "Adamantium Steel";
                itemName += " Bar";
            }
            if (resource == ResourceType.Leather)
            {
                if (tier == 2) itemName += "Stiff";
                else if (tier == 3) itemName += "Thick";
                else if (tier == 4) itemName += "Worked";
                else if (tier == 5) itemName += "Cured";
                else if (tier == 6) itemName += "Hardened";
                else if (tier == 7) itemName += "Reinforced";
                else if (tier == 8) itemName += "Fortified";
                itemName += " Leather";
            }
            if (resource == ResourceType.Plank)
            {
                if (tier == 2) itemName += "Birch";
                else if (tier == 3) itemName += "Chestnut";
                else if (tier == 4) itemName += "Pine";
                else if (tier == 5) itemName += "Cedar";
                else if (tier == 6) itemName += "Bloodoak";
                else if (tier == 7) itemName += "Ashenbark";
                else if (tier == 8) itemName += "Whitewood";
                itemName += " Planks";
            }
            if (resource == ResourceType.Block)
            {
                if (tier == 2) itemName += "Limestone";
                else if (tier == 3) itemName += "Sandstone";
                else if (tier == 4) itemName += "Travertine";
                else if (tier == 5) itemName += "Granite";
                else if (tier == 6) itemName += "Slate";
                else if (tier == 7) itemName += "Basalt";
                else if (tier == 8) itemName += "Marble";
                itemName += " Block";
            }
            foreach (Item itemObj in Program.Items)
            {
                if (itemObj.Name == itemName)
                    return itemObj;
            }
            var item = new Item(itemName, tier, rarity);
            var recipe = new Recipe(item);
            var rawCount = 2;
            if (tier >= 7) rawCount = 5;
            else if (tier == 6) rawCount = 4;
            else if (tier == 5) rawCount = 3;
            recipe.AddComponent(GetResourceByTierRaw(resource, tier, rarity), rawCount);
            if (rarity > 1) recipe.AddComponent(GetEssenceByTier(tier), (int) Math.Pow(2, rarity-2));
            if (tier > 4) {
                recipe.AddComponent(GetResourceByTier(resource, tier - 1, rarity), 1);
            }
            else if (tier == 4 || tier == 3) recipe.AddComponent(GetResourceByTier(resource, tier - 1, 1), 1);
            Program.Items.Add(item);
            return item;
        }
        public static Item GetResourceByTierRaw(ResourceType resource, int tier, int rarity)
        {
            if (rarity > 1 && (tier < 4 || resource == ResourceType.Block)) return null;
            if (tier < 2) return null;
            var itemName = "";
            if (tier >= 4)
            {
                if (rarity == 2) itemName += "Uncommon ";
                if (rarity == 3) itemName += "Rare ";
                if (rarity == 4) itemName += "Exceptional ";
            }
            if (resource == ResourceType.Cloth)
            {
                if (tier == 2) itemName += "Cotton";
                else if (tier == 3) itemName += "Flax";
                else if (tier == 4) itemName += "Hemp";
                else if (tier == 5) itemName += "Skyflower";
                else if (tier == 6) itemName += "Redleaf Cotton";
                else if (tier == 7) itemName += "Sunflax";
                else if (tier == 8) itemName += "Ghost Hemp";
            }
            if (resource == ResourceType.Bar)
            {
                if (tier == 2) itemName += "Copper";
                else if (tier == 3) itemName += "Tin";
                else if (tier == 4) itemName += "Iron";
                else if (tier == 5) itemName += "Titanium";
                else if (tier == 6) itemName += "Runite";
                else if (tier == 7) itemName += "Meteorite";
                else if (tier == 8) itemName += "Adamantium";
                itemName += " Ore";
            }
            if (resource == ResourceType.Leather)
            {
                if (tier == 2) itemName += "Rugged";
                else if (tier == 3) itemName += "Thin";
                else if (tier == 4) itemName += "Medium";
                else if (tier == 5) itemName += "Heavy";
                else if (tier == 6) itemName += "Robust";
                else if (tier == 7) itemName += "Thick";
                else if (tier == 8) itemName += "Resilient";
                itemName += " Hide";
            }
            if (resource == ResourceType.Plank)
            {
                if (tier == 2) itemName += "Birch";
                else if (tier == 3) itemName += "Chestnut";
                else if (tier == 4) itemName += "Pine";
                else if (tier == 5) itemName += "Cedar";
                else if (tier == 6) itemName += "Bloodoak";
                else if (tier == 7) itemName += "Ashenbark";
                else if (tier == 8) itemName += "Whitewood";
                itemName += " Logs";
            }
            if (resource == ResourceType.Block)
            {
                if (tier == 2) itemName += "Limestone";
                else if (tier == 3) itemName += "Sandstone";
                else if (tier == 4) itemName += "Travertine";
                else if (tier == 5) itemName += "Granite";
                else if (tier == 6) itemName += "Slate";
                else if (tier == 7) itemName += "Basalt";
                else if (tier == 8) itemName += "Marble";
            }
            foreach (Item itemObj in Program.Items)
            {
                if (itemObj.Name == itemName)
                    return itemObj;
            }
            Item item;
            if (rarity == 1) item = new Item(itemName, tier);
            else item = new Item(itemName, tier, rarity);
            Program.Items.Add(item);
            return item;
        }
        public static Item GetEssenceByTier(int tier)
        {
            if (essences == null)
            {
                essences = new List<Item>();
                string[] TierPrefix = { "", "Beginner's", "Novice's", "Journeyman's", "Adept's", "Expert's", "Master's", "Grandmaster's", "Elder's" };
                for (int i = 4; i <= 8; i++)
                {
                    var item = new Item(TierPrefix[i] + " Essence", i);
                    Program.Items.Add(item);
                    essences.Add(item);
                }
            }
            return essences[tier - 4];
        }
    }
}
 