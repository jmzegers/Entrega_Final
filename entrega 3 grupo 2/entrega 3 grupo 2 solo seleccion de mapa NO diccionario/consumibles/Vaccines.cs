using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Vaccines : Consumable
    {
        private double ChanceOfSuccess;
        
        public Vaccines(int price, double chanceOfSuccess) : base(price)
        {
            this.ChanceOfSuccess = chanceOfSuccess;
        }

        public double GetPrice()
        {
            return Price;
        }

        public bool GetUse()
        {
            return Use;
        }

        public double GetChanceOfSuccess()
        {
            return ChanceOfSuccess;
        }
    }
}
