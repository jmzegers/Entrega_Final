using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class ObjectBrain
    {
        Dictionary<string, Seed> seedDict = new Dictionary<string, Seed>();
        
        //Hay que crear varias semillas y dar sus valores
        Seed tomato = new Seed();
        Seed lettuce = new Seed();
        Seed carrot = new Seed();
        
        public ObjectBrain()
        {
            seedDict.Add("Tomate", tomato);
            seedDict.Add("Lechuga", lettuce);
        }
    }
}
