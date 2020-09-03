using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class Water : Consumable
    {
        private int Amount;
        private string Target;

        public Water(int price, bool use, int amount, string target) : base(price, use)
        {
            this.Amount = amount;
            this.Target = target;
        }

        public int GetPrice()
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
