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
        public static int gold;

        public static void LoadWeapons()
        {
            // This will read file from csv
            StreamReader reader = new StreamReader(File.OpenRead(@"..\..\..\SwordList.csv"));

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
            StreamReader reader = new StreamReader(File.OpenRead(@"..\..\..\Inventory\Inventory_weapon.csv"));

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
            StreamReader reader = new StreamReader(File.OpenRead(@"..\..\..\Inventory\Inventory_reagent.csv"));

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
            StreamReader reader = new StreamReader(File.OpenRead(@"..\..\..\CraftRequirements\SwordCraftRequirements.csv"));

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
            StreamReader reader = new StreamReader(File.OpenRead(@"..\..\..\Inventory\Inventory_gold.txt"));

            string line = reader.ReadLine();

            if (!String.IsNullOrWhiteSpace(line))
            {
                gold = Convert.ToInt32(line);
            }
            reader.Close();
        }

        public static void SaveGame()
        {
            File.Delete(@"..\Inventory\Inventory_weapon.csv");
            StreamWriter wWriter = new StreamWriter(File.OpenWrite(@"..\..\..\Inventory\Inventory_weapon.csv"));
            
            for(int i = 0; i < inventoryWeaponsList.Count; i++)
            {
                //string name, string grade, int damage, string type, double value, int quantity
                wWriter.WriteLine(inventoryWeaponsList[i].Name + "," + inventoryWeaponsList[i].Grade + "," + inventoryWeaponsList[i].Damage + "," + inventoryWeaponsList[i].Type + "," + inventoryWeaponsList[i].Value + "," + inventoryWeaponsList[i].Quantity);
            }

            wWriter.Flush();
            wWriter.Close();

            File.Delete(@"..\Inventory\Inventory_reagent.csv");
            StreamWriter iWriter = new StreamWriter(File.OpenWrite(@"..\..\..\Inventory\Inventory_reagent.csv"));

            for (int i = 0; i < inventoryReagentsList.Count; i++)
            {
                //string name, string grade, string type, double value, int quantity
                iWriter.WriteLine(inventoryReagentsList[i].Name + "," + inventoryReagentsList[i].Grade + "," + inventoryReagentsList[i].Type + "," + inventoryReagentsList[i].Value + "," + inventoryReagentsList[i].Quantity);
            }

            iWriter.Flush();
            iWriter.Close();

            File.Delete(@"..\Inventory\Inventory_gold.txt");
            StreamWriter gWriter = new StreamWriter(File.OpenWrite(@"..\..\..\Inventory\Inventory_gold.txt"));

            gWriter.WriteLine(gold);

            gWriter.Flush();
            gWriter.Close();
        }
    }
}
