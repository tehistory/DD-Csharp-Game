using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;


namespace DnDGame
{
    public class CombatMain
    {

        String[] monsterNames = { "Goblin", "Zombie", "Dark Elf", "Orc" };

        public string mobName;

        int playerHealth = 100;
        int mobHealth = 100;
        int weaponDamage = 25;

        public CombatMain(int difficulty, CombatForm form1)
        {
            Random rng = new Random();

            mobName = monsterNames[rng.Next(0, 3)];

            CombatForm myForm = form1;

            myForm.MainTextBox.AppendText("You encountered a " + mobName + ". . . \n");
            myForm.pictureBoxStart.Visible = false;
            if (mobName == "Orc")
            {
                myForm.pictureBoxOrc.Visible = true;
            }
            else if (mobName == "Zombie")
            {
                myForm.pictureBoxZombie.Visible = true;
            }
            else if (mobName == "Goblin")
            {
                myForm.pictureBoxGoblin.Visible = true;
            }
            else
            {
                myForm.pictureBoxElf.Visible = true;
            }

            myForm.Update();
            Thread.Sleep(1000);

            string output1 = "Your initiative is higher and you attack first.\n";
            string output2 = "Your initiative is lower and the monster attacks first.\n";
            int die = Roll(0, 2);
            if (die < 1)
            {
                myForm.MainTextBox.AppendText(output1);

                attackMethod(myForm);

            }
            else
            {
                myForm.MainTextBox.AppendText(output2);

                defendMethod(myForm);
            }

        }

        public void attackMethod(CombatForm myForm)
        {
            myForm.MainTextBox.AppendText("Select your Move. . .\n");
            myForm.button1.Visible = true;
            myForm.button2.Visible = true;
            myForm.button3.Visible = true;
            myForm.button4.Visible = true;
            myForm.Update();

        }

        public void defendMethod(CombatForm myForm)
        {
            int res = Roll(0, 9);
            if (res < 3)
            {
                myForm.Update();
                Thread.Sleep(1000);
                myForm.MainTextBox.AppendText("The " + mobName + " attacks with an overhead blow!\n");
                myForm.Update();
                Thread.Sleep(1000);
                int die = Roll(0, 9);
                if (die < 3)
                {
                    int damage = damageRoll(1, weaponDamage);
                    myForm.MainTextBox.AppendText("The blow lands and does " + damage + " to you.\n");
                    ChangeHealth(0, false, damage);
                }
                else if (die >= 3 && die <= 6)
                {
                    myForm.MainTextBox.AppendText("You manage to block the " + mobName + "'s attack.\n");
                }
                else
                {
                    int damage = Roll(5, 15);
                    myForm.MainTextBox.AppendText("You successfully countered the " + mobName + "'s attack and did " + damage + " damage to the " + mobName + ".\n");
                    ChangeHealth(1, false, damage);
                }
            }
            else if (res >= 3 && res <= 6)
            {
                myForm.Update();
                Thread.Sleep(1000);
                myForm.MainTextBox.AppendText("The " + mobName + " attacks with an underhanded blow!\n");
                myForm.Update();
                Thread.Sleep(1000);
                int die = Roll(0, 9);
                if (die < 3)
                {
                    int damage = damageRoll(2, weaponDamage);
                    myForm.MainTextBox.AppendText("The blow lands and does " + damage + " to you.\n");
                    ChangeHealth(0, false, damage);
                }
                else if (die >= 3 && die <= 6)
                {
                    myForm.MainTextBox.AppendText("You manage to block the " + mobName + "'s attack.\n");
                }
                else
                {
                    int damage = Roll(5, 15);
                    myForm.MainTextBox.AppendText("You successfully countered the " + mobName + "'s attack and did " + damage + " damage to the " + mobName + ".\n");
                    ChangeHealth(1, false, damage);
                }
            }
            else
            {
                myForm.Update();
                Thread.Sleep(1000);
                myForm.MainTextBox.AppendText("The " + mobName + " attacks with an faint and backhand blow!\n");
                myForm.Update();
                Thread.Sleep(1000);
                int die = Roll(0, 9);
                if (die < 3)
                {
                    int damage = damageRoll(3, weaponDamage);
                    myForm.MainTextBox.AppendText("The blow lands and does " + damage + " to you.\n");
                    ChangeHealth(0, false, damage);
                }
                else if (die >= 3 && die <= 6)
                {
                    myForm.MainTextBox.AppendText("You manage to block the " + mobName + "'s attack.\n");
                }
                else
                {
                    int damage = Roll(5, 15);
                    myForm.MainTextBox.AppendText("You successfully countered the " + mobName + "'s attack and did " + damage + " damage to the " + mobName + ".\n");
                    ChangeHealth(1, false, damage);
                }
            }
            myForm.Update();
            Thread.Sleep(1000);
            if (CheckHealth())
            {
                attackMethod(myForm);
            }
            else
            {
                FinalState(myForm);
            }
        }

        public void loot(CombatForm myForm)
        {
            //Randomize 2 items from item list
            int gainedGold = Roll(25, 100);
            myForm.MainTextBox.AppendText("You gained " + gainedGold + " gold!\n");
            WFRpg.gold = WFRpg.gold + gainedGold;
            myForm.Update();

            int itemNum = Roll(0, 12); //12 had to be hard coded as there is no built in length function, this will need to be changed if the list length changes.

            WFRpg.inventoryReagentsList[itemNum].Quantity = WFRpg.inventoryReagentsList[itemNum].Quantity + 1;
            myForm.MainTextBox.AppendText("You gained a " + WFRpg.inventoryReagentsList[itemNum].Grade + WFRpg.inventoryReagentsList[itemNum].Name + "!\n");
            myForm.Update();

            itemNum = Roll(0, 12); //12 had to be hard coded as there is no built in length function, this will need to be changed if the list length changes.

            WFRpg.inventoryReagentsList[itemNum].Quantity = WFRpg.inventoryReagentsList[itemNum].Quantity + 1;
            myForm.MainTextBox.AppendText("You gained a " + WFRpg.inventoryReagentsList[itemNum].Grade + WFRpg.inventoryReagentsList[itemNum].Name + "!\n");
            myForm.Update();
        }

        public static int damageRoll(int attack, int weaponDmg)
        { 
            if(attack == 1)
            {
                return Roll(weaponDmg - 5, weaponDmg + 5);
            }
            else if(attack == 2)
            {
                return Roll(weaponDmg - 10, weaponDmg);
            }
            else
            {
                return Roll(weaponDmg - 15, weaponDmg - 10);
            }
        }


        public static int Roll(int min, int max)
        {
            //return random int for now, will implement skill checks later
            Random rollRan = new Random();

            return rollRan.Next(min, max);
        }

        public bool CheckHealth()
        {
            if(playerHealth <= 0 || mobHealth <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ChangeHealth(int player, bool heal, int change)
        {
            if (player == 0)
            {
                if (heal)
                {

                }
                else
                {
                    playerHealth = playerHealth - change;
                }
            }
            else
            {
                if (heal)
                {

                }
                else
                {
                    mobHealth = mobHealth - change;
                }
            }
        }
        
        public void FinalState(CombatForm myForm)
        {
            if (playerHealth > 0)
            {
                myForm.MainTextBox.AppendText("The " + mobName + " falls still . . .\n");
                myForm.MainTextBox.AppendText("YOU ARE VICTORIOUS!\n");
                myForm.Update();
                loot(myForm);
                myForm.button4.Text = "Leave";
                myForm.button4.Visible = true;
                myForm.Update();
            }
            else
            {
                myForm.MainTextBox.AppendText("You fall to the ground as your vision fades to black. . .\n");
                myForm.Update();
            }
        }
    }

}