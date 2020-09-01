using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{ 
    public class Cattle : Edification
    {
        public int Cattle(int unidad)
        {
            Console.WriteLine($"el ganado tiene {unidad}, de animales");
            return unidad;
        }

        public override int getNutrientsFoods()
        {
            Random A = new Random();
            int nutrients = A.Next(10, 101);
            return nutrients;
        }
    }

}
