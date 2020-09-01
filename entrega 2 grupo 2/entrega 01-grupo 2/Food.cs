using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class Food : Consumable
    {
        public Food(int price, bool use, int amount, string target) : base(price, use)
        {

        }
    }
}
