using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace DnDGame
{
    public partial class MainMenu : Form
    {
        public Character character = new Character();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void CharacterBuilder_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            CharactergenForm form = new CharactergenForm();
            
            form.ShowDialog();
        }

        private void Gathering_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            GatheringForm form = new GatheringForm(this);
            form.ShowDialog();
        }

        private void Looting_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            CombatForm form = new CombatForm(this);
            form.ShowDialog();
        }

        private void Crafting_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            CraftingForm form = new CraftingForm(this);
            form.ShowDialog();
        }

        private void SaveGame_Click(object sender, EventArgs e)
        {
            WFRpg.SaveGame();

            MessageBox.Show("Save Complete", "Success", MessageBoxButtons.OK);

        }

        public static implicit operator Button(MainMenu v)
        {
            throw new NotImplementedException();
        }
    }
}
