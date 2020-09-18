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

        protected virtual void OnBuy()
        {
            if (ConsumibleMarket != null)
                ConsumibleMarket(this, EventArgs.Empty);
        }
        
        public void Buying()
        {
            OnBuy();
            Console.WriteLine("acaba de comprar un consumible");
        }
    }
}
