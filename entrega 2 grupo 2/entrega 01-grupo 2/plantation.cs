using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public class Plantation : Edification
    {
        public Plantation(double worm, double weed)
        {

        }
        
        public bool Worm(int gu)
        {
            Random R = new Random();
            bool hasWorms = false;
            int gusano = R.Next(0, 101);
            if (gusano <= gu)
            {
                hasWorms = true;
            }
            return hasWorms;
        }

        public int weed(int w)
        {
            Random R = new Random();
            int maleza = R.Next(0, 101);
            return maleza-w;
        }

        public override int getNutrientsFoods()
        {
            Random N = new Random();
            int nutrients = N.Next(10, 101);
            return nutrients;
        }

    }


}
