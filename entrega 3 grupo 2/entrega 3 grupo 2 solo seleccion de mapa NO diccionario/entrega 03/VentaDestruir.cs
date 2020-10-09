using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class VentaDestruir
    {
        public void OnSellOrDestruction(object source, EventArgs args)
        {
            Console.WriteLine("ha vendido la bodega");
        }
        public void OnSellOrDestruction1(object source, EventArgs args)
        {
            Console.WriteLine("ha destruido una plantacion o ganado");
        }
    }
}
