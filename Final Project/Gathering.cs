using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDGame
{
    public partial class GatheringForm : Form
    {

        MainMenu Home;
        public GatheringForm(MainMenu main)
        {
            InitializeComponent();
            
            Home = main;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        //Logic to set gathering area
        public string GetArea()
        {
            int area = cbGatheringSelect.SelectedIndex;
            string currentArea;
            switch (area)
            {
                case 0:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Forest.jpg");
                    currentArea = "Forest";
                    break;
                case 1:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Desert.png");
                    currentArea = "Desert";
                    break;
                case 2:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Grasslands.jpg");
                    currentArea = "Grasslands";
                    break;
                case 3:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Marsh.jpg");
                    currentArea = "Marsh";
                    break;
                case 4:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Mountain.jpg");
                    currentArea = "Mountain";
                    break;
                
                default:
                    currentArea = null;
                    break;
            }
            return currentArea;
        }
        //Controller to set gathering area
        private void cbGatheringSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GetArea();
        }
         
        //Logic for reseiveing gatheringRewards
        public void gatheringAreaRewards()
        {
            int currentRoll = D100DiceRoll();
            int D4Roll = D4DiceRoll();
            int D2Roll = D2DiceRoll();
            bool ForestArea = GetArea().ToString() == "Forest";
            bool Desert = GetArea().ToString() == "Desert";
            bool Grasslands = GetArea().ToString() == "Grasslands";
            bool Marsh = GetArea().ToString() == "Marsh";
            bool Mountian = GetArea().ToString() == "Mountain";


            #region MountiansArea Rewards
            if (Mountian == true && InBetween(currentRoll, 1, 10))
            {
                infoLog.Text = $"Rolled {currentRoll} You failed to gather anything";
            }
            else if (Mountian == true && InBetween(currentRoll, 11, 20))
            {
                infoLog.Text = $"Rolled {currentRoll}, You failed to gather anything.";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 41, 50))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 51, 60))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 61, 70) && InBetween(D2Roll, 1, 2))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully {D2Roll} gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 71, 80) && InBetween(D2Roll, 1, 2))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Reactive Reagents";
            }
            else if (Mountian == true && InBetween(currentRoll, 81, 90))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Uncommon Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 91, 95))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 96, 100))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Primal Essence";
            }
            #endregion
            #region MarshArea Rewards
            if (Marsh == true && InBetween(currentRoll, 1, 10))
            {
                infoLog.Text = $"Rolled {currentRoll} You failed to gather anything";
            }
            else if (Marsh == true && InBetween(currentRoll, 11, 20))
            {
                infoLog.Text = $"Rolled {currentRoll}, You Gathered Common Poisonous Reagent";
            }
            else if (Marsh == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Marsh == true && InBetween(currentRoll, 41, 50))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Marsh == true && InBetween(currentRoll, 51, 60))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Marsh == true && InBetween(currentRoll, 61, 70) && InBetween(D4Roll, 1, 4))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully {D4Roll} gathered Common Poisonous reagents";
            }
            else if (Marsh == true && InBetween(currentRoll, 71, 80) && InBetween(D4Roll, 1, 2))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered {D4Roll} Common Reactive Reagents";
            }
            else if (Marsh == true && InBetween(currentRoll, 81, 90))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Uncommon Poisonous Reagent";
            }
            else if (Marsh == true && InBetween(currentRoll, 91, 95))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Reactive Reagent";
            }
            else if (Marsh == true && InBetween(currentRoll, 96, 100))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Primal Essence";
            }
            #endregion
            #region GrasslandsArea
            if (Grasslands == true && InBetween(currentRoll, 1, 10))
            {
                infoLog.Text = $"Rolled {currentRoll} You failed to gather anything";
            }
            else if (Grasslands == true && InBetween(currentRoll, 11, 20))
            {
                infoLog.Text = $"Rolled {currentRoll}, You failed to gather anything";
            }
            else if (Grasslands == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Grasslands == true && InBetween(currentRoll, 41, 50))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Reactive Reagent";
            }
            else if (Grasslands == true && InBetween(currentRoll, 51, 60))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Poisonous Reagent";
            }
            else if (Grasslands == true && InBetween(currentRoll, 61, 70) && InBetween(D2Roll, 1, 2))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully {D2Roll} gathered Common Poisonous reagents";
            }
            else if (Grasslands == true && InBetween(currentRoll, 71, 80) && InBetween(D2Roll, 1, 2))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered {D2Roll} Common Curative Reagents";
            }
            else if (Grasslands == true && InBetween(currentRoll, 81, 90))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Uncommon Curative Reagent";
            }
            else if (Grasslands == true && InBetween(currentRoll, 91, 95))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Uncommon Reactive Reagent";
            }
            else if (Grasslands == true && InBetween(currentRoll, 96, 100))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Divine Essence";
            }
            #endregion
            #region DesertArea Rewards
            if (Desert == true && InBetween(currentRoll, 1, 10))
            {
                infoLog.Text = $"Rolled {currentRoll} You failed to gather anything";
            }
            else if (Desert == true && InBetween(currentRoll, 11, 20))
            {
                infoLog.Text = $"Rolled {currentRoll}, You failed to gather anything";
            }
            else if (Desert == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Reactive Reagent";
            }
            else if (Desert == true && InBetween(currentRoll, 41, 50))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Reactive Reagent";
            }
            else if (Desert == true && InBetween(currentRoll, 51, 60))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Poisonous Reagent";
            }
            else if (Desert == true && InBetween(currentRoll, 61, 70) && InBetween(D2Roll, 1, 2))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully {D2Roll} gathered Common Reactive reagents";
            }
            else if (Desert == true && InBetween(currentRoll, 71, 80) && InBetween(D2Roll, 1, 2))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered {D2Roll} Common Reactive Reagents";
            }
            else if (Desert == true && InBetween(currentRoll, 81, 90))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Uncommon Curative Reagent";
            }
            else if (Desert == true && InBetween(currentRoll, 91, 95))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Uncommon Poisonous Reagent";
            }
            else if (Desert == true && InBetween(currentRoll, 96, 100))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Arcane Essence";
            }
            #endregion
            #region ForestArea Rewards
            //ForestArea Rewards Bug with statting numbers ex 41,51,21
            if (ForestArea == true && InBetween(currentRoll, 1, 10))
            {
                infoLog.Text = $"Rolled {currentRoll} Bad Luck, you failed to gather anything";
            }
            else if (ForestArea == true && InBetween(currentRoll, 11, 20))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if(ForestArea == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 41, 50))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 51, 60) && InBetween(D4Roll,1,4))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered {D2Roll} common reactive reagent ";
            }
            else if (ForestArea == true && InBetween(currentRoll, 61, 70))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 71, 80))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 81, 90))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 91, 95))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 96, 100))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent!";
            }
        }
        #endregion 



        


//Dice Rolls Logic & InBetween Function 
public int D100DiceRoll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 100);
            return roll;

        }

        public int D4DiceRoll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 4);
            return roll;
        }

        public int D2DiceRoll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 2);
            return roll;
        }

        public static bool InBetween(int roll, int low, int high)
        {
            return roll > low && roll < high;

        }
        //Controller for gathering. DiceRoll and rewards. 
        private void button1_Click(object sender, EventArgs e)
        {
            gatheringAreaRewards();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Update();
            Home.Visible = true;
            this.Close();
            
        }
    }
}
