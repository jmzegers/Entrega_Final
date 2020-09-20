using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class CompraConsumible
    {
        public void OnBuy(object source, EventArgs args)
        {
            Console.WriteLine("Fungicida");
        }
        public void OnBuy1(object source, EventArgs args)
        {
            Console.WriteLine("herbicida");
        }
        public void OnBuy2(object source, EventArgs args)
        {
            Console.WriteLine("pesticida");
        }
        public void OnBuy3(object source, EventArgs args)
        {
            Console.WriteLine("vacunas");
        }
        public void OnBuy4(object source, EventArgs args)
        {
            Console.WriteLine("Fertilizante");
        }
        public void OnBuy5(object source, EventArgs args)
        {
            Console.WriteLine("riego");
        }
        public void OnBuy6(object source, EventArgs args)
        {
            Console.WriteLine("Alimento para animales");
        }
        public void OnBuy7(object source, EventArgs args)
        {
            Console.WriteLine("Agua para animales");
        }
    }
}
