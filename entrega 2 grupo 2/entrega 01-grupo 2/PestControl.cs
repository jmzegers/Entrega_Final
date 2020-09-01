using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class PestControl : Consumable
    {
        public PestControl(int price, bool use, string enemy, double chanceOfSuccess) : base(price, use)
        {

        }
    }
}
