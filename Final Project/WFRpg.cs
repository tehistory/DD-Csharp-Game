using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DnDGame
{
    static class WFRpg
    {
        public static List<Weapon> weaponsList = new List<Weapon>();
        public static List<Weapon> inventoryWeaponsList = new List<Weapon>();
        public static List<Reagent> inventoryReagentsList = new List<Reagent>();
        public static List<WeaponCraftRequirement> weaponCraftRequiremenList = new List<WeaponCraftRequirement>();
        public static string gold;

        public static void LoadWeapons()
        {
            // This will read file from csv
            StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\brian\Desktop\WinFormRPG\SwordList.csv"));

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    Weapon tempWeapon = new Weapon(values[0], values[1], Convert.ToInt32(values[2]), values[3], Convert.ToDouble(values[4]));
                    weaponsList.Add(tempWeapon);
                }
            }
            reader.Close();
        }

        public static void LoadInventoryWeapons()
        {
            // This will read file from csv
            StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\brian\Desktop\WinFormRPG\Inventory\Inventory_weapon.csv"));

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    Weapon tempWeapon = new Weapon(values[0], values[1], Convert.ToInt32(values[2]), values[3], Convert.ToDouble(values[4]), Convert.ToInt32(values[5]));
                    inventoryWeaponsList.Add(tempWeapon);
                }
            }
            reader.Close();
        }

        public static void LoadInventoryReagents()
        {
            // This will read file from csv
            StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\brian\Desktop\WinFormRPG\Inventory\Inventory_reagent.csv"));

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    Reagent tempReagent = new Reagent(values[0], values[1], values[2], Convert.ToDouble(values[3]), Convert.ToInt32(values[4]));
                    inventoryReagentsList.Add(tempReagent);
                }
            }
            reader.Close();
        }

        public static void LoadWeaponCraftRequirements()
        {
            // This will read file from csv
            StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\brian\Desktop\WinFormRPG\CraftRequirements\SwordCraftRequirements.csv"));

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');

                    if (values[0] == "Poor" || values[0] == "Uncommon" || values[0] == "Rare")
                    {
                        WeaponCraftRequirement temp = new WeaponCraftRequirement(values[0], values[1], values[2]);
                        weaponCraftRequiremenList.Add(temp);
                    }
                    else if (values[0] == "Epic")
                    {
                        WeaponCraftRequirement temp = new WeaponCraftRequirement(values[0], values[1], values[2], values[3]);
                        weaponCraftRequiremenList.Add(temp);
                    }
                    else if (values[0] == "Legendary")
                    {
                        WeaponCraftRequirement temp = new WeaponCraftRequirement(values[0], values[1], values[2], values[3], values[4]);
                        weaponCraftRequiremenList.Add(temp);
                    }
                }
            }
            reader.Close();
        }

        public static void LoadGold()
        {
            StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\brian\Desktop\WinFormRPG\Inventory\Inventory_gold.txt"));

            string line = reader.ReadLine();

            if (!String.IsNullOrWhiteSpace(line))
            {
                gold = line;
            }
            reader.Close();
        }
    }
}
