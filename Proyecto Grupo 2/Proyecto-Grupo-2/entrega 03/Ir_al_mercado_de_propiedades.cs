using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Ir_al_mercado_de_propiedades
    {
        public delegate void GoTothePropertyMarket(object source, EventArgs args);
        public event GoTothePropertyMarket MercadoPropiedades;
    }
}
