using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_2
{
    public class Plantation : Edification
    {
        public Seed Semilla;
        public bool Worms;//gusanos
        public bool Weeds;// maleza
        public double Nutrients;//nutrientes

        public Plantation(Seed semilla, string name)
        {
            Semilla = semilla;
            Nutrients = 100;
            Name = name;
            PurchasePrice = 100;
            SalesPrice = -150;
            Health = 100;
            Water = 100;
            Maturity = 0;
            Disease = false;
            Worms = false;
            Weeds = false;
        }
    }
}
