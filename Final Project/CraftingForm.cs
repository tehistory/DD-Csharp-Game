using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DnDGame
{
    public partial class CraftingForm : Form
    {
        public CraftingForm()
        {
            InitializeComponent();

            for (int i = 0; i < WFRpg.weaponsList.Count; i++)
            {
                listCraftableItems.Items.Add(WFRpg.weaponsList[i].Name);
            }

            for (int i = 0; i < WFRpg.inventoryWeaponsList.Count; i++)
            {
                string inventoryDisplayFormat = WFRpg.inventoryWeaponsList[i].Name;
                listInventoryWeapons.Items.Add(inventoryDisplayFormat);
            }

            for (int i = 0; i < WFRpg.inventoryReagentsList.Count; i++)
            {
                string inventoryDisplayFormat = WFRpg.inventoryReagentsList[i].Name;
                listInventoryReagents.Items.Add(inventoryDisplayFormat);
            }

            lblGold.Text = Convert.ToString(WFRpg.gold);
        }
        private void listInventoryWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listInventoryWeapons.SelectedItem != null)
            {
                string nl = "\r\n";

                for (int i = 0; i < WFRpg.inventoryWeaponsList.Count; i++)
                {
                    if (listInventoryWeapons.SelectedItem.ToString() == WFRpg.inventoryWeaponsList[i].Name)
                    {
                        txtInventoryItemDescription.Text = "" + nl + nl;
                        txtInventoryItemDescription.AppendText(WFRpg.inventoryWeaponsList[i].Name + nl + nl);
                        txtInventoryItemDescription.AppendText("Damage: " + WFRpg.inventoryWeaponsList[i].Damage.ToString() + nl);
                        txtInventoryItemDescription.AppendText("Type: " + WFRpg.inventoryWeaponsList[i].Type + nl);
                        txtInventoryItemDescription.AppendText("Grade: " + WFRpg.inventoryWeaponsList[i].Grade + nl);
                        txtInventoryItemDescription.AppendText("Value: " + WFRpg.inventoryWeaponsList[i].Value.ToString() + " Gold" + nl);
                        txtInventoryItemDescription.AppendText("Quantity: " + WFRpg.inventoryWeaponsList[i].Quantity.ToString() + nl);
                        break;
                    }
                }
            }


        }
        private void listInventoryReagents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listInventoryReagents.SelectedItem != null)
            {
                string nl = "\r\n";

                for (int i = 0; i < WFRpg.inventoryReagentsList.Count; i++)
                {
                    if (listInventoryReagents.SelectedItem.ToString() == WFRpg.inventoryReagentsList[i].Name)
                    {
                        txtInventoryItemDescription.Text = "" + nl + nl + nl;
                        txtInventoryItemDescription.AppendText(WFRpg.inventoryReagentsList[i].Name + nl + nl);
                        txtInventoryItemDescription.AppendText("Type: " + WFRpg.inventoryReagentsList[i].Type + nl);
                        txtInventoryItemDescription.AppendText("Grade: " + WFRpg.inventoryReagentsList[i].Grade + nl);
                        txtInventoryItemDescription.AppendText("Value: " + WFRpg.inventoryReagentsList[i].Value.ToString() + " Gold" + nl);
                        txtInventoryItemDescription.AppendText("Quantity: " + WFRpg.inventoryReagentsList[i].Quantity.ToString() + nl);
                        break;
                    }
                }
            }
        }

        private void listCraftableItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCraftableItems.SelectedItem != null)
            {
                string nl = "\r\n";

                for (int i = 0; i < WFRpg.weaponsList.Count; i++)
                {
                    if (listCraftableItems.SelectedItem.ToString() == WFRpg.weaponsList[i].Name)
                    {
                        txtItemCraftDescription.Text = "" + nl + nl + nl;
                        txtItemCraftDescription.AppendText(WFRpg.weaponsList[i].Name + nl + nl);
                        txtItemCraftDescription.AppendText("Damage: " + WFRpg.weaponsList[i].Damage.ToString() + nl);
                        txtItemCraftDescription.AppendText("Type: " + WFRpg.weaponsList[i].Type + nl);
                        txtItemCraftDescription.AppendText("Grade: " + WFRpg.weaponsList[i].Grade + nl);
                        txtItemCraftDescription.AppendText("Value: " + WFRpg.weaponsList[i].Value.ToString() + " Gold" + nl);

                        for (int j = 0; j < WFRpg.weaponCraftRequiremenList.Count; j++)
                        {
                            if (WFRpg.weaponsList[i].Grade == WFRpg.weaponCraftRequiremenList[j].Grade)
                            {
                                txtRequiredReagents.Text = "Requirements\r\n\r\n";
                                switch (WFRpg.weaponsList[i].Grade)
                                {
                                    case "Poor":
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].MetalReq + "\r\n");
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].WoodReq + "\r\n");
                                        txtRequiredReagents.AppendText("\r\n" + "50 Gold");
                                        break;
                                    case "Uncommon":
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].MetalReq + "\r\n");
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].WoodReq + "\r\n");
                                        txtRequiredReagents.AppendText("\r\n" + "150 Gold");
                                        break;
                                    case "Rare":
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].MetalReq + "\r\n");
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].WoodReq + "\r\n");
                                        txtRequiredReagents.AppendText("\r\n" + "500 Gold");
                                        break;
                                    case "Epic":
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].MetalReq + "\r\n");
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].WoodReq + "\r\n");
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].EssenceReq + "\r\n");
                                        txtRequiredReagents.AppendText("\r\n" + "1500 Gold");
                                        break;
                                    case "Legendary":
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].MetalReq + "\r\n");
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].WoodReq + "\r\n");
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].EssenceReq + "\r\n");
                                        txtRequiredReagents.AppendText(WFRpg.weaponCraftRequiremenList[j].LegendaryReq + "\r\n");
                                        txtRequiredReagents.AppendText("\r\n" + "3000 Gold");
                                        break;
                                }



                            }
                        }

                        break;
                    }
                }
            }
        }

        private void btnCraft_Click(object sender, EventArgs e)
        {
            if (listCraftableItems.SelectedItem != null)
            {
                for (int i = 0; i < WFRpg.weaponsList.Count; i++)
                {
                    if (listCraftableItems.SelectedItem.ToString() == WFRpg.weaponsList[i].Name)
                    {
                        CraftRoll craftRoll = new CraftRoll(WFRpg.weaponsList[i].Grade, WFRpg.weaponsList[i].Name);
                        craftRoll.ShowDialog();
                        break;
                    }
                }
            }
        }

        private void CraftingForm_Activated(object sender, EventArgs e)
        {
            txtGameNarrative.AppendText(CraftRoll.craftUserAction);

            if (CraftRoll.craftInitiate == true)
            {
                DiceRollToCraft();
            }

            CraftRoll.craftUserAction = "";
            CraftRoll.craftInitiate = false;
        }

        private void DiceRollToCraft()
        {
            Random rng = new Random();
            int diceRoll = rng.Next(1, 100);
            int failRate = 100 - CraftRoll.successRate;

            txtGameNarrative.AppendText("Your roll must be higher than " + failRate + ".\r\n");
            txtGameNarrative.AppendText("Your roll: " + diceRoll.ToString() + "\r\n");

            if (diceRoll > failRate)
            {
                if (CheckForReagentsBeforeCraft() == false)
                {
                    txtGameNarrative.AppendText("You do not have enough materials required to craft this item.");
                }
                else
                {
                    txtGameNarrative.AppendText("You have successfully crafted a new item" + "\r\n");
                    listInventoryWeapons.Items.Add(listCraftableItems.SelectedItem.ToString());
                }
            }
            else
            {
                txtGameNarrative.AppendText("The World Spirit deems you unworthy. Crafting failed." + "\r\n");
            }
        }

        private bool CheckForReagentsBeforeCraft()
        {
            List<string> requiredReagents = new List<string>();
            bool hasAll = false;
            bool hasReagents = false;
            bool hasGold = false;

            string grade = "";
            int gold = Convert.ToInt32(lblGold.Text);
            int requiredGold = 0;

            bool hasMetal = false;
            bool hasWood = false;
            bool hasEssence = false;
            bool hasLegendary = false;

            string metal = "placeholder";
            string wood = "placeholder";
            string essence = "placeholder";
            string legendary = "placeholder";

            for (int i = 0; i < listCraftableItems.Items.Count; i++)
            {
                if (listCraftableItems.SelectedItem.ToString() == WFRpg.weaponsList[i].Name)
                {
                    requiredGold = Convert.ToInt32(WFRpg.weaponsList[i].Value);
                    grade = WFRpg.weaponsList[i].Grade;

                    for (int j = 0; j < WFRpg.weaponCraftRequiremenList.Count; j++)
                    {
                        if (grade == WFRpg.weaponCraftRequiremenList[j].Grade)
                        {
                            if (grade == "Poor" || grade == "Uncommon" || grade == "Rare")
                            {
                                requiredReagents.Add(WFRpg.weaponCraftRequiremenList[j].MetalReq);
                                requiredReagents.Add(WFRpg.weaponCraftRequiremenList[j].WoodReq);
                            }
                            else if (WFRpg.weaponsList[i].Grade == "Epic")
                            {
                                requiredReagents.Add(WFRpg.weaponCraftRequiremenList[j].MetalReq);
                                requiredReagents.Add(WFRpg.weaponCraftRequiremenList[j].WoodReq);
                                requiredReagents.Add(WFRpg.weaponCraftRequiremenList[j].EssenceReq);
                            }
                            else if (WFRpg.weaponsList[i].Grade == "Legendary")
                            {
                                requiredReagents.Add(WFRpg.weaponCraftRequiremenList[j].MetalReq);
                                requiredReagents.Add(WFRpg.weaponCraftRequiremenList[j].WoodReq);
                                requiredReagents.Add(WFRpg.weaponCraftRequiremenList[j].EssenceReq);
                                requiredReagents.Add(WFRpg.weaponCraftRequiremenList[j].LegendaryReq);
                            }
                        }                        
                    }
                }
            }

            if (gold >= requiredGold)
            {
                hasGold = true;

            }

            for (int i = 0; i < WFRpg.inventoryReagentsList.Count; i++)
            {
                for (int j = 0; j < requiredReagents.Count; j++)
                {
                    if (requiredReagents[j] == WFRpg.inventoryReagentsList[i].Name)
                    {
                        switch (j)
                        {
                            case 0:
                                hasMetal = true;
                                metal = requiredReagents[j];
                                break;
                            case 1:
                                hasWood = true;
                                wood = requiredReagents[j];
                                break;
                            case 2:
                                hasEssence = true;
                                essence = requiredReagents[j];
                                break;
                            case 3:
                                hasLegendary = true;
                                legendary = requiredReagents[j];
                                break;
                        }
                    }
                    else
                    {
                        hasReagents = false;
                    }
                }
            }

            switch (grade)
            {
                case "Poor":
                    if (hasMetal == true && hasWood == true)
                    {
                        hasReagents = true;
                    }
                    break;
                case "Uncommon":
                    if (hasMetal == true && hasWood == true)
                    {
                        hasReagents = true;
                    }
                    break;
                case "Rare":
                    if (hasMetal == true && hasWood == true)
                    {
                        hasReagents = true;
                    }
                    break;
                case "Epic":
                    if (hasMetal == true && hasWood == true && hasEssence == true)
                    {
                        hasReagents = true;
                    }
                    break;
                case "Legendary":
                    if (hasMetal == true && hasWood == true && hasEssence == true && hasLegendary == true)
                    {
                        hasReagents = true;
                    }
                    break;
            }


            if (hasGold && hasReagents)
            {
                hasAll = true;

                // Update gold

                gold = gold - requiredGold;

                File.WriteAllText(@"..\..\..\Inventory\Inventory_gold.txt", gold.ToString());

                StreamReader reader = new StreamReader(File.OpenRead(@"..\..\..\Inventory\Inventory_gold.txt"));

                string line = reader.ReadLine();

                if (!String.IsNullOrWhiteSpace(line))
                {
                    gold = Convert.ToInt32(line);
                }
                reader.Close();

                lblGold.Text = gold.ToString();

                // Update reagents

                for (int i = 0; i < WFRpg.inventoryReagentsList.Count; i++)
                {
                    if (metal == WFRpg.inventoryReagentsList[i].Name)
                    {
                        if (WFRpg.inventoryReagentsList[i].Quantity == 1)
                        {
                            WFRpg.inventoryReagentsList.Remove(WFRpg.inventoryReagentsList[i]);
                        }
                        else
                        {
                            WFRpg.inventoryReagentsList[i].Quantity--;
                        }
                    }
                    if (wood == WFRpg.inventoryReagentsList[i].Name)
                    {
                        if (WFRpg.inventoryReagentsList[i].Quantity == 1)
                        {
                            WFRpg.inventoryReagentsList.Remove(WFRpg.inventoryReagentsList[i]);
                        }
                        else
                        {
                            WFRpg.inventoryReagentsList[i].Quantity--;
                        }
                    }
                    if (essence == WFRpg.inventoryReagentsList[i].Name)
                    {
                        if (WFRpg.inventoryReagentsList[i].Quantity == 1)
                        {
                            WFRpg.inventoryReagentsList.Remove(WFRpg.inventoryReagentsList[i]);
                        }
                        else
                        {
                            WFRpg.inventoryReagentsList[i].Quantity--;
                        }
                    }
                    if (legendary == WFRpg.inventoryReagentsList[i].Name)
                    {
                        if (WFRpg.inventoryReagentsList[i].Quantity == 1)
                        {
                            WFRpg.inventoryReagentsList.Remove(WFRpg.inventoryReagentsList[i]);
                        }
                        else
                        {                            
                            WFRpg.inventoryReagentsList[i].Quantity--;
                        }
                    }
                }
                //string nl = "\r\n";
                //// Update textbox
                //txtInventoryItemDescription.Text = "" + nl + nl + nl;
                //txtInventoryItemDescription.AppendText(WFRpg.inventoryReagentsList[i].Name + nl + nl);
                //txtInventoryItemDescription.AppendText("Type: " + WFRpg.inventoryReagentsList[i].Type + nl);
                //txtInventoryItemDescription.AppendText("Grade: " + WFRpg.inventoryReagentsList[i].Grade + nl);
                //txtInventoryItemDescription.AppendText("Value: " + WFRpg.inventoryReagentsList[i].Value.ToString() + " Gold" + nl);
                //txtInventoryItemDescription.AppendText("Quantity: " + WFRpg.inventoryReagentsList[i].Quantity.ToString() + nl);
            }

            return hasAll;
        }
    }
}
