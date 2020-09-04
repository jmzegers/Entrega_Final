using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public abstract class Edification
    {
        private string Name;
        private int PurchasePrice;
        private int SalesPrice;
        private double Health;
        private double Water;
        private int Maturity;
        private bool Disease;
        
        public Edification(string name, int purchasePrice)
        {
            this.Name = name;
            this.PurchasePrice = purchasePrice;
            SalesPrice = 100;
            Health = 100;
            Water = 100;
            Maturity = 0;
            Disease = false;
        }

        protected int f;

        public string Kind(string tipo)
        {
            Console.WriteLine($"es una: {tipo}");
            return tipo;
        }

        protected int h;
        public int FinalProduction(int calidad)
        {
            Console.WriteLine($"la calidad del producto es de...: {calidad}");
            return calidad;
        }
    }
}
