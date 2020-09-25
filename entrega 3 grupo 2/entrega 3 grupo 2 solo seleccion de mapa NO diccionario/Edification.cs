using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public abstract class Edification
    {
        protected string Name;
        protected int PurchasePrice;
        protected int SalesPrice;
        protected double Health;
        protected double Water;
        protected int Maturity;
        protected bool Disease;
        protected string Kind;
        
        public Edification(string name, int purchasePrice, string kind)
        {
            this.Name = name;
            this.PurchasePrice = purchasePrice;
            SalesPrice = 100;
            Health = 100;
            Water = 100;
            Maturity = 0;
            Disease = false;
            this.Kind = kind;
        }

        public int FinalProduction(int calidad)
        {
            Console.WriteLine($"la calidad del producto es de...: {calidad}");
            return calidad;
        }
    }
}
