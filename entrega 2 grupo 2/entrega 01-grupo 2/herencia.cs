using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public class edificacion
    {
        public void Name(string nombre)
        {
            Console.WriteLine($"nombre es:  {nombre}");
        }

        protected int a;
        public void Water(int agua)
        {
            Console.WriteLine($"agua de...: {agua}");
        }

        protected int b;
        public void Health(int salud)
        {
            Console.WriteLine($"salud de...: {salud}");
        }

        protected int c;
        public void Maturity (int madurez)
        {
            Console.WriteLine($"madurez de...: {madurez}");
        }

        protected int d;
        public void PurchasePrice(int preciocompra)
        {
            Console.WriteLine($"precio de compra es de...: ${preciocompra}");
        }

        protected int e;
        public void Disease(int enfermedad)
        {
            Console.WriteLine($" enfermedad de...: {enfermedad}");
        }

        protected int f;
        public void NutrientsFoods(int comida)
        {
            Console.WriteLine($"necesidad de nutrientes/alimento de...: {comida}");
        }

        public void Kind(string tipo)
        {
            Console.WriteLine($"es una: {tipo}");
        }

        protected int g;
        public void SalePrice(int precioventa)
        {
            Console.WriteLine($"el precio de venta es de...: {precioventa}");
        }

        protected int h;
        public void FinalProduction(int calidad)
        {
            Console.WriteLine($"la calidad del producto es de...: {calidad}");
        }
    }
}
