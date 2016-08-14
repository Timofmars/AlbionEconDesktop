using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AlbionRecipeJson
{
    class Program
    {
        public static List<Item> Items = new List<Item>();
        static void Main(string[] args)
        {
            FillList();
            FarmingRecipes();
            var json = ListToJson(Items);
            WriteStringToFile(json);
        }
        private static string ListToJson(List<Item> list)
        {
            return JsonConvert.SerializeObject(list, Formatting.Indented,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
        }
        private static void FillList()
        {
            #region recipes
            #region bar
            GroupRecipe bar4plank4 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 4);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 4);
            };
            GroupRecipe bar8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 8);
            };
            GroupRecipe bar12leather12 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 12);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, rarity), 12);
            };
            GroupRecipe bar16 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 16);
            };
            GroupRecipe bar16leather8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 16);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, rarity), 8);
            };
            GroupRecipe bar16cloth8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 16);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, rarity), 8);
            };
            GroupRecipe bar16plank8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 16);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 8);
            };
            GroupRecipe bar16leather16 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 16);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, rarity), 16);
            };
            GroupRecipe bar20cloth12 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 20);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, rarity), 12);
            };
            GroupRecipe bar20leather12 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 20);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, rarity), 12);
            };
            GroupRecipe bar20plank12 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 20);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 12);
            };
            GroupRecipe bar24 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 24);
            };
            #endregion bar
            #region cloth
            GroupRecipe cloth4leather4 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, rarity), 4);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, rarity), 4);
            };
            GroupRecipe cloth4plank4 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, rarity), 4);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 4);
            };
            GroupRecipe cloth8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, rarity), 8);
            };
            GroupRecipe cloth8leather8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, rarity), 8);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, rarity), 8);
            };
            GroupRecipe cloth16 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, rarity), 16);
            };
            #endregion
            #region leather
            GroupRecipe leather8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, rarity), 8);
            };
            GroupRecipe leather16 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, rarity), 16);
            };
            GroupRecipe leather20bar12 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, rarity), 20);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 12);
            };
            #endregion
            #region plank
            GroupRecipe plank6bar2 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 6);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 2);
            };
            GroupRecipe plank8block8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 8);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Block, tier, rarity), 8);
            };
            GroupRecipe plank16bar8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 16);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 8);
            };
            GroupRecipe plank16cloth8 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 16);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, rarity), 8);
            };
            GroupRecipe plank32 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 32);
            };
            GroupRecipe plank20bar12 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 20);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, rarity), 12);
            };
            GroupRecipe plank20cloth12 = (tier, rarity, recipe) =>
            {
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, rarity), 20);
                recipe.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, rarity), 12);
            };
            #endregion
            #endregion

            #region Warrior

            CreateGroup("Soldier Boots", 2, bar8);
            CreateGroup("Knight Boots", 4, bar8);
            CreateGroup("Guardian Boots", 4, bar8);

            CreateGroup("Soldier Armor", 2, bar16);
            CreateGroup("Knight Armor", 4, bar16);
            CreateGroup("Guardian Armor", 4, bar16);

            CreateGroup("Soldier Helmet", 2, bar8);
            CreateGroup("Knight Helmet", 4, bar8);
            CreateGroup("Guardian Helmet", 4, bar8);

            CreateGroup("Claymore", 4, bar20leather12);
            CreateGroup("Dual Swords", 4, bar20leather12);
            CreateGroup("Broadsword", 2, bar16leather8);

            CreateGroup("Greataxe", 4, bar20plank12);
            CreateGroup("Halberd", 4, plank20bar12);
            CreateGroup("Battleaxe", 3, bar16plank8);

            CreateGroup("Flail", 4, bar20cloth12);
            CreateGroup("Heavy Mace", 4, bar20cloth12);
            CreateGroup("Mace", 3, bar16cloth8);

            CreateGroup("Great Hammer", 4, bar20cloth12);
            CreateGroup("Polehammer", 4, bar20cloth12);
            CreateGroup("Hammer", 4, bar24);

            CreateGroup("Crossbow", 4, plank20bar12);
            CreateGroup("Heavy Crossbow", 4, plank20bar12);
            CreateGroup("Light Crossbow", 4, plank16bar8);

            CreateGroup("Shield", 2, bar4plank4);
            #endregion Blacksmith

            #region Hunter
            CreateGroup("Mercenary Shoes", 2, leather8);
            CreateGroup("Hunter Shoes", 4, leather8);
            CreateGroup("Assassin Shoes", 4, leather8);

            CreateGroup("Mercenary Jacket", 2, leather16);
            CreateGroup("Hunter Jacket", 4, leather16);
            CreateGroup("Assassin Jacket", 4, leather16);

            CreateGroup("Mercenary Hood", 2, leather8);
            CreateGroup("Hunter Hood", 4, leather8);
            CreateGroup("Assassin Hood", 4, leather8);

            CreateGroup("Bow", 2, plank32);
            CreateGroup("Longbow", 4, plank32);
            CreateGroup("Warbow", 4, plank32);

            CreateGroup("Glaive", 4, bar20plank12);
            CreateGroup("Pike", 4, plank20bar12);
            CreateGroup("Spear", 3, plank16bar8);

            CreateGroup("Great Nature Staff", 4, plank20cloth12);
            CreateGroup("Wild Staff", 4, plank20cloth12);
            CreateGroup("Nature Staff", 3, plank16cloth8);

            CreateGroup("Claws", 4, leather20bar12);
            CreateGroup("Dagger Pair", 4, bar16leather16);
            CreateGroup("Dagger", 4, bar12leather12);

            CreateGroup("Double Bladed Staff", 4, leather20bar12);
            CreateGroup("Iron-Clad Staff", 4, leather20bar12);
            CreateGroup("Quarterstaff", 4, leather20bar12);

            CreateGroup("Torch", 3, cloth4plank4);
            #endregion
            #region Mage
            CreateGroup("Scholar Sandals", 2, cloth8);
            CreateGroup("Cleric Sandals", 4, cloth8);
            CreateGroup("Mage Sandals", 4, cloth8);

            CreateGroup("Scholar Robe", 2, cloth16);
            CreateGroup("Cleric Robe", 4, cloth16);
            CreateGroup("Mage Robe", 4, cloth16);

            CreateGroup("Scholar Cowl", 2, cloth8);
            CreateGroup("Cleric Cowl", 4, cloth8);
            CreateGroup("Mage Cowl", 4, cloth8);

            CreateGroup("Great Fire Staff", 4, plank20bar12);
            CreateGroup("Infernal Staff", 4, plank20bar12);
            CreateGroup("Fire Staff", 2, plank16bar8);

            CreateGroup("Divine Staff", 4, plank20cloth12);
            CreateGroup("Great Holy Staff", 4, plank20cloth12);
            CreateGroup("Holy Staff", 3, plank16cloth8);

            CreateGroup("Great Arcane Staff", 4, plank20bar12);
            CreateGroup("Enigmatic Staff", 4, plank20bar12);
            CreateGroup("Arcane Staff", 3, plank16bar8);

            CreateGroup("Great Frost Staff", 4, plank20bar12);
            CreateGroup("Glacial Staff", 4, plank20bar12);
            CreateGroup("Frost Staff", 4, plank16bar8);

            CreateGroup("Great Cursed Staff", 4, plank20bar12);
            CreateGroup("Demonic Staff", 4, plank20bar12);
            CreateGroup("Cursed Staff", 4, plank16bar8);

            CreateGroup("Tome of Spells", 2, cloth4leather4);
            #endregion

            #region Toolsmith
            CreateGroup("Bag", 2, cloth8leather8);
            CreateGroup("Cape", 2, cloth4leather4);

            CreateGroup("Axe", 2, plank6bar2, false);
            CreateGroup("Stone Hammer", 2, plank6bar2, false);
            CreateGroup("Pickaxe", 2, plank6bar2, false);
            CreateGroup("Skinning Knife", 2, plank6bar2, false);
            CreateGroup("Sickle", 2, plank6bar2, false);
            CreateGroup("Demolition Hammer", 2, plank8block8, false);
            #endregion Toolsmith
        }
        private static void FarmingRecipes()
        {
            var l = Items;

            #region Cook

            var Carrot = new Item("Carrots", 1);
            l.Add(Carrot);
            var CarrotSoup = new Item("Carrot Soup", 1);
            l.Add(CarrotSoup);
            var r = new Recipe(CarrotSoup, 10);
            r.AddComponent(Carrot, 16);

            var Beans = new Item("Beans", 2);

            var SheafofWheat = new Item("Sheaf of Wheat", 3);
            l.Add(SheafofWheat);
            var Flour = new Item("Flour", 3);
            l.Add(Flour);
            r = new Recipe(Flour);
            r.AddComponent(SheafofWheat, 48);

            var Chicken = new Item("Chicken", 3);
            l.Add(Chicken);
            var RawChicken = new Item("Raw Chicken", 3);
            l.Add(RawChicken);
            r = new Recipe(RawChicken);
            r.AddComponent(Chicken, 1);

            var HenEgg = new Item("Hen Egg", 3);
            l.Add(HenEgg);
            var ChickenOmelette = new Item("Chicken Omelette", 3);
            l.Add(ChickenOmelette);
            r = new Recipe(ChickenOmelette, 10);
            r.AddComponent(RawChicken, 8);
            r.AddComponent(SheafofWheat, 4);
            r.AddComponent(HenEgg, 2);

            var ChickenPie = new Item("Chicken Pie", 3);
            r = new Recipe(ChickenPie, 10);
            l.Add(ChickenPie);
            r.AddComponent(RawChicken, 8);
            r.AddComponent(Flour, 4);
            r.AddComponent(SheafofWheat, 2);

            var WheatSoup = new Item("Wheat Soup", 3);
            l.Add(WheatSoup);
            r = new Recipe(WheatSoup, 10);
            r.AddComponent(SheafofWheat, 48);

            #endregion
            #region Soup
            var Cabbage = new Item("Cabbage", 5);
            l.Add(Cabbage);
            var CabbageSoup = new Item("Cabbage Soup", 3);
            r = new Recipe(CabbageSoup, 10);
            r.AddComponent(Cabbage, 144);
            l.Add(CabbageSoup);
            #endregion
            #region Salad
            var Turnips = new Item("Turnips", 4);
            l.Add(Turnips);
            var TurnipSalad = new Item("Turnip Salad", 4);
            l.Add(TurnipSalad);
            r = new Recipe(TurnipSalad, 10);
            r.AddComponent(Turnips, 24);
            r.AddComponent(SheafofWheat, 24);

            var Potatoes = new Item("Potatoes", 6);
            l.Add(Potatoes);
            var PotatoSalad = new Item("Potato Salad ", 6);
            l.Add(PotatoSalad);
            r = new Recipe(PotatoSalad, 10);
            r.AddComponent(Potatoes, 72);
            r.AddComponent(Cabbage, 72);
            #endregion
            #region Omelette
            var Goose = new Item("Goose", 5);
            l.Add(Goose);
            var RawGoose = new Item("Raw Goose", 5);
            l.Add(RawGoose);
            var GooseEggs = new Item("Goose Eggs", 5);
            l.Add(GooseEggs);
            var GooseOmelette = new Item("Goose Omelette", 5);
            l.Add(GooseOmelette);
            r = new Recipe(GooseOmelette, 10);
            r.AddComponent(RawGoose, 24);
            r.AddComponent(Cabbage, 12);
            r.AddComponent(GooseEggs, 6);

            var Pig = new Item("Pig", 7);
            l.Add(Pig);
            var RawPork = new Item("Raw Pork", 7);
            l.Add(RawPork);
            var BundleofCorn = new Item("Bundle of Corn", 7);
            l.Add(BundleofCorn);
            var PorkOmelette = new Item("Pork Omelette", 7);
            l.Add(PorkOmelette);
            r = new Recipe(PorkOmelette, 10);
            r.AddComponent(RawPork, 72);
            r.AddComponent(BundleofCorn, 36);
            r.AddComponent(GooseEggs, 18);
            #endregion
            #region Pie
            var GoatsMilk = new Item("Goat's Milk", 4);
            l.Add(GoatsMilk);
            var GoosePie = new Item("Goose Pie", 5);
            l.Add(GoosePie);
            r = new Recipe(GoosePie, 10);
            r.AddComponent(RawGoose, 24);
            r.AddComponent(Flour, 12);
            r.AddComponent(GoatsMilk, 6);
            r.AddComponent(Cabbage, 6);

            var SheepsMilk = new Item("Sheep's Milk", 6);
            l.Add(SheepsMilk);
            var PorkPie = new Item("Pork Pie", 7);
            l.Add(PorkPie);
            r = new Recipe(PorkPie, 10);
            r.AddComponent(RawPork, 72);
            r.AddComponent(Flour, 36);
            r.AddComponent(SheepsMilk, 18);
            r.AddComponent(BundleofCorn, 18);
            #endregion
            #region Stew
            var Goat = new Item("Goat", 4);
            l.Add(Goat);
            var RawGoat = new Item("Raw Goat", 4);
            l.Add(RawGoat);
            var Bread = new Item("Bread", 4);
            l.Add(Bread);
            var GoatStew = new Item("Goat Stew", 4);
            l.Add(GoatStew);
            r = new Recipe(GoatStew, 10);
            r.AddComponent(RawGoat, 8);
            r.AddComponent(Bread, 4);
            r.AddComponent(Turnips, 4);

            var Sheep = new Item("Sheep", 6);
            l.Add(Sheep);
            var RawMutton = new Item("Raw Mutton", 6);
            l.Add(RawMutton);
            var MuttonStew = new Item("Mutton Stew", 6);
            l.Add(MuttonStew);
            r = new Recipe(MuttonStew, 10);
            r.AddComponent(RawMutton, 24);
            r.AddComponent(Bread, 12);
            r.AddComponent(Potatoes, 12);

            var Cow = new Item("Cow", 8);
            l.Add(Cow);
            var RawBeef = new Item("Raw Beef", 8);
            l.Add(RawBeef);
            var Pumpkin = new Item("Pumpkin", 8);
            l.Add(Pumpkin);
            var BeefStew = new Item("Beef Stew", 8);
            l.Add(BeefStew);
            r = new Recipe(BeefStew, 10);
            r.AddComponent(RawBeef, 72);
            r.AddComponent(Bread, 36);
            r.AddComponent(Pumpkin, 36);
            #endregion
            #region Sandwich
            var GoatsButter = new Item("Goat's Butter", 4);
            l.Add(GoatsButter);
            var GoatSandwich = new Item("Goat Sandwich", 4);
            l.Add(GoatSandwich);
            r = new Recipe(GoatSandwich, 10);
            r.AddComponent(RawGoat, 8);
            r.AddComponent(Bread, 4);
            r.AddComponent(GoatsButter, 2);

            var SheepsButter = new Item("Sheep's Butter", 6);
            l.Add(SheepsButter);
            var MuttonSandwich = new Item("Mutton Sandwich", 6);
            l.Add(MuttonSandwich);
            r = new Recipe(MuttonSandwich, 10);
            r.AddComponent(RawMutton, 24);
            r.AddComponent(Bread, 12);
            r.AddComponent(SheepsButter, 6);

            var CowsMilk = new Item("Cow's Milk", 8);
            l.Add(CowsMilk);
            var CowsButter = new Item("Cow's Butter", 8);
            l.Add(CowsButter);
            var BeefSandwich = new Item("Beef Sandwich", 8);
            l.Add(BeefSandwich);
            r = new Recipe(BeefSandwich, 10);
            r.AddComponent(RawBeef, 72);
            r.AddComponent(Bread, 36);
            r.AddComponent(CowsButter, 18);
            #endregion
            #region Miller
            r = new Recipe(GoatsButter);
            r.AddComponent(GoatsMilk, 1);
            r = new Recipe(Bread);
            r.AddComponent(Flour, 1);
            r = new Recipe(SheepsButter);
            r.AddComponent(SheepsMilk, 1);
            r = new Recipe(CowsButter);
            r.AddComponent(CowsMilk, 1);
            #endregion
            #region Butcher
            r = new Recipe(RawGoat);
            r.AddComponent(Goat, 1);

            r = new Recipe(RawGoose);
            r.AddComponent(Goose, 1);

            r = new Recipe(RawMutton);
            r.AddComponent(Sheep, 1);

            r = new Recipe(RawPork);
            r.AddComponent(Pig, 1);

            r = new Recipe(RawBeef);
            r.AddComponent(Cow, 1);
            #endregion
            #region mounts
            string[] TierPrefix = { "", "Beginner's", "Novice's", "Journeyman's", "Adept's", "Expert's", "Master's", "Grandmaster's", "Elder's" };
            for (var tier = 3; tier <= 8; tier++)
            {
                var horse = new Item(TierPrefix[tier] + " Horse", tier);
                l.Add(horse);
                var rhorse = new Item(TierPrefix[tier] + " Riding Horse", tier);
                l.Add(rhorse);
                r = new Recipe(rhorse);
                r.AddComponent(horse, 1);
                r.AddComponent(Helpers.GetResourceByTier(ResourceType.Leather, tier, 1), 20);

                var ahorse = new Item(TierPrefix[tier] + " Armored Horse", tier);
                l.Add(ahorse);
                r = new Recipe(ahorse);
                r.AddComponent(horse, 1);
                r.AddComponent(Helpers.GetResourceByTier(ResourceType.Cloth, tier, 1), 10);
                r.AddComponent(Helpers.GetResourceByTier(ResourceType.Bar, tier, 1), 10);

                var ox = new Item(TierPrefix[tier] + " Transport Ox", tier);
                l.Add(ox);
                var rox = new Item(TierPrefix[tier] + " Riding Horse", tier);
                l.Add(rox);
                r = new Recipe(rox);
                r.AddComponent(ox, 1);
                r.AddComponent(Helpers.GetResourceByTier(ResourceType.Plank, tier, 1), 20);
            }
            #endregion

            #region alchemist
            Item[] herbs = { null, null,
                new Item("Arcane Agaric", 2),
                new Item("Brightleaf Comfrey", 3),
                new Item("Crenellated Burdock", 4),
                new Item("Dragon Teasel", 5),
                new Item("Elusive Foxglove", 6),
                new Item("Firetouched Mullein", 7),
                new Item("Ghoul Yarrow", 8),
            };
            for (var i = 2; i <= 8; i++) l.Add(herbs[i]);
            #region bootlegger
            var PotatoSchnapps = new Item("Potato Schnapps", 6);
            l.Add(PotatoSchnapps);
            r = new Recipe(PotatoSchnapps, 5);
            r.AddComponent(Potatoes, 1);

            var CornHooch = new Item("Corn Hooch", 7);
            l.Add(CornHooch);
            r = new Recipe(CornHooch, 5);
            r.AddComponent(BundleofCorn, 1);

            var PumpkinMoonshine = new Item("Pumpkin Moonshine", 8);
            l.Add(PumpkinMoonshine);
            r = new Recipe(PumpkinMoonshine, 5);
            r.AddComponent(Pumpkin, 1);
            #endregion
            #region cleanse
            var cleansepot = new Item("Cleansing Potion", 8);
            l.Add(cleansepot);
            r = new Recipe(cleansepot, 5);
            r.AddComponent(herbs[8], 72);
            r.AddComponent(herbs[7], 36);
            r.AddComponent(herbs[6], 36);
            r.AddComponent(CowsMilk, 38);
            r.AddComponent(PumpkinMoonshine, 38);
            #endregion
            #region cooldown
            var cdr4 = new Item("Minor Recovery Potion", 4);
            l.Add(cdr4);
            r = new Recipe(cdr4, 5);
            r.AddComponent(herbs[4], 8);
            r.AddComponent(herbs[3], 4);

            var cdr6 = new Item("Recovery Potion", 6);
            l.Add(cdr6);
            r = new Recipe(cdr6, 5);
            r.AddComponent(herbs[6], 24);
            r.AddComponent(herbs[5], 12);
            r.AddComponent(herbs[3], 12);
            r.AddComponent(SheepsMilk, 6);

            var cdr8 = new Item("Major Recovery Potion", 8);
            l.Add(cdr8);
            r = new Recipe(cdr8, 5);
            r.AddComponent(herbs[8], 72);
            r.AddComponent(herbs[7], 24);
            r.AddComponent(herbs[5], 24);
            r.AddComponent(CowsMilk, 18);
            r.AddComponent(PumpkinMoonshine, 18);
            #endregion
            #region slowfield
            var chill3 = new Item("Minor Chilling Flask", 3);
            l.Add(chill3);
            r = new Recipe(chill3, 5);
            r.AddComponent(herbs[3], 8);

            var chill5 = new Item("Chilling Flask", 5);
            l.Add(chill5);
            r = new Recipe(chill5, 5);
            r.AddComponent(herbs[5], 24);
            r.AddComponent(herbs[4], 12);
            r.AddComponent(GooseEggs, 6);

            var chill7 = new Item("Major Chilling Flask", 7);
            l.Add(chill7);
            r = new Recipe(chill7, 5);
            r.AddComponent(herbs[7], 72);
            r.AddComponent(herbs[6], 36);
            r.AddComponent(herbs[4], 36);
            r.AddComponent(GooseEggs, 18);
            r.AddComponent(CornHooch, 18);
            #endregion
            #region resistance
            var res3 = new Item("Minor Resistance Potion", 3);
            l.Add(res3);
            r = new Recipe(res3, 5);
            r.AddComponent(herbs[3], 8);

            var res5 = new Item("Chilling Flask", 5);
            l.Add(res5);
            r = new Recipe(res5, 5);
            r.AddComponent(herbs[5], 24);
            r.AddComponent(herbs[4], 12);
            r.AddComponent(GoatsMilk, 6);

            var res7 = new Item("Major Chilling Flask", 7);
            l.Add(res7);
            r = new Recipe(res7, 5);
            r.AddComponent(herbs[7], 72);
            r.AddComponent(herbs[6], 36);
            r.AddComponent(herbs[4], 36);
            r.AddComponent(SheepsMilk, 18);
            r.AddComponent(CornHooch, 18);
            #endregion
            #region revival
            var revive3 = new Item("Minor Revive Flask", 3);
            l.Add(revive3);
            r = new Recipe(revive3, 5);
            r.AddComponent(herbs[3], 8);

            var revive5 = new Item("Revive Flask", 5);
            l.Add(revive5);
            r = new Recipe(revive5, 5);
            r.AddComponent(herbs[5], 24);
            r.AddComponent(herbs[4], 12);
            r.AddComponent(GooseEggs, 6);

            var revive7 = new Item("Major Revive Flask", 7);
            l.Add(revive7);
            r = new Recipe(revive7, 5);
            r.AddComponent(herbs[7], 71);
            r.AddComponent(herbs[6], 36);
            r.AddComponent(GooseEggs, 18);
            r.AddComponent(CornHooch, 18);
            #endregion
            #region energy
            var energy2 = new Item("Minor Energy Potion", 2);
            l.Add(energy2);
            r = new Recipe(energy2, 5);
            r.AddComponent(herbs[2], 8);

            var energy4 = new Item("Energy Potion", 4);
            l.Add(energy4);
            r = new Recipe(energy4, 5);
            r.AddComponent(herbs[4], 24);
            r.AddComponent(GoatsMilk, 6);

            var energy6 = new Item("Major Energy Potion", 6);
            l.Add(energy6);
            r = new Recipe(energy6, 5);
            r.AddComponent(herbs[6], 72);
            r.AddComponent(SheepsMilk, 18);
            r.AddComponent(PotatoSchnapps, 18);
            #endregion
            #region healing
            var healing2 = new Item("Minor Healing Potion", 2);
            l.Add(healing2);
            r = new Recipe(healing2, 5);
            r.AddComponent(herbs[2], 8);

            var healing4 = new Item("Healing Potion", 6);
            l.Add(healing4);
            r = new Recipe(healing4, 5);
            r.AddComponent(herbs[4], 24);
            r.AddComponent(HenEgg, 6);

            var healing6 = new Item("Major Healing Potion", 6);
            l.Add(healing6);
            r = new Recipe(healing6, 5);
            r.AddComponent(herbs[6], 72);
            r.AddComponent(GooseEggs, 18);
            r.AddComponent(PotatoSchnapps, 18);
            #endregion
            #endregion
        }
        delegate void GroupRecipe(int tier, int rarity, Recipe recipe);
        private static void CreateGroup(string name, int minTier, GroupRecipe recipeMethod, bool hasRarity = true)
        {
            CreateGroup(name, minTier, 8, recipeMethod, hasRarity);
        }
        private static void CreateGroup(string name, int minTier, int maxTier, GroupRecipe recipeMethod, bool hasRarity = true)
        {
            string[] TierPrefix = { "", "Beginner's", "Novice's", "Journeyman's", "Adept's", "Expert's", "Master's", "Grandmaster's", "Elder's" };

            for (int tier = minTier; tier <= maxTier; tier++)
            {
                for (int rarity = 1; rarity <= 4; rarity++)
                {
                    if ((tier >= 4 && hasRarity) || rarity == 1)
                    {
                        var itemname = TierPrefix[tier] + " " + name;
                        var item = new Item(itemname, tier, rarity);
                        var recipe = new Recipe(item);
                        recipeMethod(tier, rarity, recipe);
                        Items.Add(item);
                    }
                }
            }
        }
        private static void WriteStringToFile(string str)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\krissam\AppData\Roaming\krss\albionecon\recipes.json"))
            {
                file.WriteLine(str);
            }
        }
    }
}
