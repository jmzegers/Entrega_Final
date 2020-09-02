using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{ 
    public class Cattle : Edification
    {
        public Cattle(int unidad)
        {
            Console.WriteLine($"el ganado tiene {unidad}, de animales");
        }

        public int CurrentNutrients(int nutrientsPerTurn, int nutrientsNow)
        {
            return nutrientsNow - nutrientsPerTurn;
        }
    }

}
