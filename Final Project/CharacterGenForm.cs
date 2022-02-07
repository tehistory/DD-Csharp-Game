using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DnDGame
{

    public partial class CharactergenForm : Form
    {
        Character heroPlayer = new Character();
        public CharactergenForm()
        {
            InitializeComponent();

        }

        public void rerollButton_Click(object sender, EventArgs e)
        {

            heroPlayer = NewHero();
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

        public static void SaveCharacter(Character savePlayer)
        {

            File.Delete(@"..\..\character_list.csv");
            StreamWriter cWriter = new StreamWriter(File.OpenWrite(@"..\..\character_list.csv"));

            cWriter.WriteLine(savePlayer.CharName + "," + savePlayer.Background + "," + savePlayer.Profession + "," + savePlayer.HitPoints + "," + savePlayer.Strength + "," + savePlayer.Dexterity + "," + savePlayer.Constitution + "," + savePlayer.Intelligence + "," + savePlayer.Wisdom + "," + savePlayer.Charisma + "," + savePlayer.Acrobatics + "," + savePlayer.AnimalHandling + "," + savePlayer.Arcana + "," + savePlayer.Athletics + "," + savePlayer.Deception + "," + savePlayer.History + "," + savePlayer.Insight + "," + savePlayer.Intimidation + "," + savePlayer.Medicine + "," + savePlayer.Nature + "," + savePlayer.Perception + "," + savePlayer.Performance + "," + savePlayer.Persuasion + "," + savePlayer.Religon + "," + savePlayer.SlightOfHand + "," + savePlayer.Stealth + "," + savePlayer.Survival);
            cWriter.Flush();
            cWriter.Close();
        }
        public Character LoadCharacter()
        {
            StreamReader reader = new StreamReader(File.OpenRead(@"..\..\character_list.csv"));
            string line = reader.ReadLine();
            string[] values = line.Split(',');
            Character loadplayer = new Character(values[0], values[1], values[2], Convert.ToInt32(values[3]), Convert.ToInt32(values[4]), Convert.ToInt32(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]), Convert.ToInt32(values[8]), Convert.ToInt32(values[9]), Convert.ToInt32(values[10]), Convert.ToInt32(values[11]), Convert.ToInt32(values[12]), Convert.ToInt32(values[13]), Convert.ToInt32(values[14]), Convert.ToInt32(values[15]), Convert.ToInt32(values[16]), Convert.ToInt32(values[17]), Convert.ToInt32(values[18]), Convert.ToInt32(values[19]), Convert.ToInt32(values[20]), Convert.ToInt32(values[21]), Convert.ToInt32(values[22]), Convert.ToInt32(values[23]), Convert.ToInt32(values[24]), Convert.ToInt32(values[25]), Convert.ToInt32(values[26]));
            reader.Close();
            return loadplayer;

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveCharacter(heroPlayer);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            heroPlayer = LoadCharacter();
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
        public Character NewHero()
        {
            Character heroPlayer = new Character();
            return heroPlayer;
        }
    }
}

