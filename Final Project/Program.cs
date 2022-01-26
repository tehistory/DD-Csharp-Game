using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DnDGame
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WFRpg.LoadWeapons();
            WFRpg.LoadInventoryWeapons();
            WFRpg.LoadInventoryReagents();
            WFRpg.LoadWeaponCraftRequirements();
            WFRpg.LoadGold();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
