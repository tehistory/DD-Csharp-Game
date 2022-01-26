using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDGame
{
    internal class Weapon
    {
        string name;
        string grade;
        int damage;
        string type;
        double value;
        int quantity;

        public Weapon(string name, string grade, int damage, string type, double value)
        {
            this.name = name;
            this.grade = grade;
            this.damage = damage;
            this.type = type;
            this.value = value;
        }

        public Weapon(string name, string grade, int damage, string type, double value, int quantity)
        {
            this.name = name;
            this.grade = grade;
            this.damage = damage;
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

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
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
