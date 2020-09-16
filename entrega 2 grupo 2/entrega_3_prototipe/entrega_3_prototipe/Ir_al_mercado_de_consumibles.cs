using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_3_prototipe
{
    class Ir_al_mercado_de_consumibles
    {
        public delegate void GoToTheConsumablesMarket(object source, EventArgs args);
        public event GoToTheConsumablesMarket ConsumibleMarket;
    }
}
