using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    abstract class Consumable
    {
        protected double Price;
        protected bool Use;
        
        protected Consumable(int price)
        {
            this.Price = price;
            Use = true;
            
        }
    }
}
