using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDGame
{
    internal class Reagent
    {
        string name;
        string grade;
        string type;
        double value;
        int quantity;

        public Reagent(string name, string grade, string type, double value, int quantity)
        {
            this.name = name;
            this.grade = grade;
            this.type = type;
            this.value = value;
            this.quantity = quantity;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
