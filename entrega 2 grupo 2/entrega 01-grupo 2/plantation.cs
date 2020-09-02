using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public class Plantation : Edification
    {
        public Plantation(bool worm, bool weed, int nutrients = 100)
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

        public bool Weed(int w)
        {
            Random R = new Random();
            bool hasWeeds = false;
            int maleza = R.Next(0, 101);
            if (maleza <= w)
            {
                hasWeeds = true;
            }
            return hasWeeds;
        }

        public int currentNutrients(int nutrientsPerTurn, int nutrientsNow)
        {
            return nutrientsNow - nutrientsPerTurn;
        }

    }


}
