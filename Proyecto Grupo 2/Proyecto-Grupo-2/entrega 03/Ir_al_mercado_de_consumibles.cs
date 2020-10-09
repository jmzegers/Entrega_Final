using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Ir_al_mercado_de_consumibles
    {
        public delegate void GoToTheConsumablesMarket(object source, EventArgs args);
        public event GoToTheConsumablesMarket ConsumibleMarket;
        public event GoToTheConsumablesMarket ConsumibleMarket1;
        public event GoToTheConsumablesMarket ConsumibleMarket2;
        public event GoToTheConsumablesMarket ConsumibleMarket3;
        public event GoToTheConsumablesMarket ConsumibleMarket4;
        public event GoToTheConsumablesMarket ConsumibleMarket5;
        public event GoToTheConsumablesMarket ConsumibleMarket6;
        public event GoToTheConsumablesMarket ConsumibleMarket7;



        protected virtual void OnBuy()
        {
            if (ConsumibleMarket != null)
                ConsumibleMarket(this, EventArgs.Empty);
        }

        protected virtual void OnBuy1()
        {
            if (ConsumibleMarket1 != null)
                ConsumibleMarket1(this, EventArgs.Empty);
        }
        protected virtual void OnBuy2()
        {
            if (ConsumibleMarket2 != null)
                ConsumibleMarket2(this, EventArgs.Empty);
        }
        protected virtual void OnBuy3()
        {
            if (ConsumibleMarket3 != null)
                ConsumibleMarket3(this, EventArgs.Empty);
        }
        protected virtual void OnBuy4()
        {
            if (ConsumibleMarket4 != null)
                ConsumibleMarket4(this, EventArgs.Empty);
        }
        protected virtual void OnBuy5()
        {
            if (ConsumibleMarket5 != null)
                ConsumibleMarket5(this, EventArgs.Empty);
        }
        protected virtual void OnBuy6()
        {
            if (ConsumibleMarket6 != null)
                ConsumibleMarket6(this, EventArgs.Empty);
        }
        protected virtual void OnBuy7()
        {
            if (ConsumibleMarket7 != null)
                ConsumibleMarket7(this, EventArgs.Empty);
        }
        public void Buying()
        {
            OnBuy();
            Console.WriteLine("acaba de comprar: ");
            
        }
    }
}
