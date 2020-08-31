using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public abstract class edificacion
    {
        public string Name(string nombre)
        {
            Console.WriteLine($"nombre es:  {nombre}");
            return nombre;
        }

        protected int a;
        public int Water(int agua)
        {
            Console.WriteLine($"agua de...: {agua}");
            return agua;
        }

        protected int b;
        public int Health(int salud)
        {
            Console.WriteLine($"salud de...: {salud}");
            return salud;
        }

        protected int c;
        public int Maturity (int madurez)
        {
            Console.WriteLine($"madurez de...: {madurez}");
            return madurez;
        }

        protected int d;
        public int PurchasePrice(int preciocompra)
        {
            Console.WriteLine($"precio de compra es de...: ${preciocompra}");
            return preciocompra;
        }

        protected int e;
        public int Disease(int enfermedad)
        {
            Console.WriteLine($" enfermedad de...: {enfermedad}");
            return enfermedad;
        }

        protected int f;
        public abstract int getNutrientsFoods();

        public string Kind(string tipo)
        {
            Console.WriteLine($"es una: {tipo}");
            return tipo;
        }

        protected int g;
        public int SalePrice(int precioventa)
        {
            Console.WriteLine($"el precio de venta es de...: {precioventa}");
            return precioventa;
        }

        protected int h;
        public int FinalProduction(int calidad)
        {
            Console.WriteLine($"la calidad del producto es de...: {calidad}");
            return calidad;
        }
    }
}
