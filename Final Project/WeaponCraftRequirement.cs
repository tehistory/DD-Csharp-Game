using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDGame
{
    class WeaponCraftRequirement
    {
        string grade;
        string metalReq;
        string woodReq;
        string essenceReq;
        string legendaryReq;

        public WeaponCraftRequirement(string grade, string metal, string wood)
        {
            this.grade = grade;
            this.metalReq = metal;
            this.woodReq = wood;
        }

        public WeaponCraftRequirement(string grade, string metal, string wood, string essence)
        {
            this.grade = grade;
            this.metalReq = metal;
            this.woodReq = wood;
            this.essenceReq = essence;
        }

        public WeaponCraftRequirement(string grade, string metal, string wood, string essence, string legend)
        {
            this.grade = grade;
            this.metalReq = metal;
            this.woodReq = wood;
            this.essenceReq = essence;
            this.legendaryReq = legend;
        }

        public string Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public string MetalReq { get => metalReq; set => metalReq = value; }
        public string WoodReq { get => woodReq; set => woodReq = value; }
        public string EssenceReq { get => essenceReq; set => essenceReq = value; }
        public string LegendaryReq { get => legendaryReq; set => legendaryReq = value; }
    }
}
