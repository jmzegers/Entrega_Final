using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public class Mercado //aqui solo se manejan los precios 
    {
        public class PurchasePrice
        {
            protected int a;
            protected int b;

            public PurchasePrice(int a, int b)
            {
                this.a = a;
                this.b = b;

            }
            public int GetA()
            {
                return a + 2;
            }
        }
    }
}
