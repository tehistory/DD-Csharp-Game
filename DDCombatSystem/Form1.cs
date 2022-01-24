using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DDCombatSystem
{
    public partial class Form1 : Form
    {
        String[] MainAttack = { "You swing your {0} over your head", "You lunge with your {0} " };
        String[] AltAttack = { "You swing low with your {0}" , "temp {0}"};
        String[] OffAttack = { "You throw a haymaker with your free hand" , "temp"};

        string tempString;
        string monstName = "placeholder";
        string weapon = "weapon placeholder";
        int weaponDamage = 25;

        CombatMain run1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            run1 = new CombatMain(1, this);
            monstName = run1.mobName;
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            //button1 click - Main Attack
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.Update();

            tempString = string.Format(MainAttack[(int)CombatMain.Roll(0, MainAttack.Length-1)], weapon);
            MainTextBox.AppendText(tempString + "\n");
            AttackResult(1);

            
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            //button2 click - Alternate Attack
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.Update();

            tempString = string.Format(AltAttack[(int)CombatMain.Roll(0, AltAttack.Length-1)], weapon);
            MainTextBox.AppendText(tempString + "\n");
            AttackResult(2);

            
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            //button3 click - Off Hand Attack
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.Update();

            tempString = string.Format(OffAttack[(int)CombatMain.Roll(0, AltAttack.Length-1)]);
            MainTextBox.AppendText(tempString + "\n");
            AttackResult(3);

            
        }

        public void Button4_Click(object sender, EventArgs e)
        {
            //button4 click - Retreat
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.Update();


            
        }

        public void AttackResult(int buttonResult)
        {
            this.Update();
            Thread.Sleep(1000);
            int res = CombatMain.Roll(0,2);
            if(res >= 0 && res < 1)
            {
                MainTextBox.AppendText("You strike true and do ");
                if (buttonResult == 1)
                {
                    int damage = CombatMain.damageRoll(1, weaponDamage);
                    MainTextBox.AppendText(damage + " damage.\n");
                    run1.ChangeHealth(1, false, damage);
                }
                else if (buttonResult == 2)
                {
                    int damage = CombatMain.damageRoll(2, weaponDamage);
                    MainTextBox.AppendText(damage + " damage.\n");
                    run1.ChangeHealth(1, false, damage);
                }
                else if(buttonResult == 3)
                {
                    int damage = CombatMain.damageRoll(3, weaponDamage);
                    MainTextBox.AppendText(damage + " damage.\n");
                    run1.ChangeHealth(1, false, damage);
                }
            }
            else if (res >= 1 && res < 2)
            {
                MainTextBox.AppendText("Your attack is blocked and does nothing!\n");
            }
            else
            {
                MainTextBox.AppendText("Your attack was countered and you recieved ");
                int damage = CombatMain.Roll(5, 15);
                MainTextBox.AppendText(damage + " damage.\n");
                run1.ChangeHealth(0, false, damage);
            }
            this.Update();
            Thread.Sleep(1000);
            if (run1.CheckHealth())
            {
                run1.defendMethod(this);
            }
            else
            {
                run1.FinalState(this);
            }
        }

    }
}
