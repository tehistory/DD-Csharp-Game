using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnDGame
{
    public partial class CraftRoll : Form
    {
        public static string craftUserAction = "";
        public static bool craftInitiate = false;
        public static int successRate = 0;
        private string grade;

        public CraftRoll(string grade, string itemName)
        {
            InitializeComponent();
            this.grade = grade;
        }

        private void CraftRoll_Load(object sender, EventArgs e)
        {
            switch (grade)
            {
                case "Poor":
                    successRate = 90;
                    break;
                case "Common":
                    successRate = 80;
                    break;
                case "Uncommon":
                    successRate = 70;
                    break;
                case "Rare":
                    successRate = 55;
                    break;
                case "Epic":
                    successRate = 45;
                    break;
                case "Legendary":
                    successRate = 30;
                    break;
            }

            lblSuccessRate.Text = successRate.ToString() + " %";

        }

        private void btnCancelCraft_Click(object sender, EventArgs e)
        {
            craftUserAction = "You cower at the chance that your resources and effort might crumble into thin air." + "\r\n";
            this.Close();
        }

        private void btnRollToCraft_Click(object sender, EventArgs e)
        {
            craftInitiate = true;
            this.Close();
        }
    }
}
