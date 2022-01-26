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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CharacterBuilder_Click(object sender, EventArgs e)
        {
            //this.Close();

            CharactergenForm form = new CharactergenForm();
            //indowInteropHelper wih = new WindowInteropHelper(this);
            //wih.Owner = form.Handle;
            form.ShowDialog();
            //Application.Run(new CharactergenForm());
        }

        private void Gathering_Click(object sender, EventArgs e)
        {
            GatheringForm form = new GatheringForm();
            form.ShowDialog();
        }

        private void Looting_Click(object sender, EventArgs e)
        {
            
            CombatForm form = new CombatForm();
            form.ShowDialog();
        }

        private void Crafting_Click(object sender, EventArgs e)
        {

            CombatForm form = new CombatForm();
            form.ShowDialog();
        }
    }
}
