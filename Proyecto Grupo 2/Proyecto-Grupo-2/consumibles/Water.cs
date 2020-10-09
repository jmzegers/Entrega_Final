using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Water_of_animals : Consumable
    {
        private int Amount;
        private string Target;

        public Water_of_animals(int price, int amount, string target) : base(price)
        {
            this.Amount = amount;
            this.Target = target;
        }

        public double GetPrice()
        {
            return Price;
        }

        public bool GetUse()
        {
            return Use;
        }

        public int GetAmount()
        {
            return Amount;
        }

        public string GetTarget()
        {
            return Target;
        }
    }
}
