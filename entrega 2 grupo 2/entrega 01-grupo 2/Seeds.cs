using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public class Plantation : edificacion
    {
         public Plantation(string name, int price)
        {
          
            
        }
        public int Worm()
        {
            Random R = new Random();
            int gusano = R.Next(0, 101);
            return gusano;
        }

        public int weed()
        {
            Random R = new Random();
            int maleza = R.Next(0, 101);
            return maleza;
        }

    }


}
