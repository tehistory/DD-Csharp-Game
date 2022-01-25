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
    public partial class CharactergenForm : Form
    {
        public CharactergenForm()
        {
            InitializeComponent();
            
        }

        private void rerollButton_Click(object sender, EventArgs e)
        {
            Character heroPlayer = new Character();
            StatLabelSet(strIntLabel, strModLabel, heroPlayer.Strength, heroPlayer.Athletics);
            StatLabelSet(dexIntLabel, dexModLabel, heroPlayer.Dexterity, heroPlayer.Stealth);
            StatLabelSet(conIntLabel, conModLabel, heroPlayer.Constitution, (heroPlayer.HitPoints - 10));
            StatLabelSet(wisIntLabel, wisModLabel, heroPlayer.Wisdom, heroPlayer.Perception);
            StatLabelSet(intIntLabel, intModLabel, heroPlayer.Intelligence, heroPlayer.Arcana);
            StatLabelSet(chaIntLabel, chaModLabel, heroPlayer.Charisma, heroPlayer.Persuasion);
            RevealPanel(strLabalPanel);
            RevealPanel(dexLabalPanel);
            RevealPanel(conLabalPanel);
            RevealPanel(intLabalPanel);
            RevealPanel(wisLabalPanel);
            RevealPanel(chaLabalPanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
                             
            HidePanel(strLabalPanel);
            HidePanel(dexLabalPanel);
            HidePanel(conLabalPanel);
            HidePanel(intLabalPanel);
            HidePanel(wisLabalPanel);
            HidePanel(chaLabalPanel);
        }
        public void HidePanel(Panel p)
        {
            p.Visible = false;
        }
        public void RevealPanel(Panel p)
        {
            p.Visible = true;
        }
        public void StatLabelSet(Label statIntLabel, Label statModLabel, int statIntValue, int statModValue)
        {

            statIntLabel.Text = (statIntValue.ToString());
            statModLabel.Text = (statModValue.ToString());
        }
    }
}

