using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class ObjectBrain
    {
        FunctionBrain fb = new FunctionBrain();
        Dictionary<string, Seed> seedDict = new Dictionary<string, Seed>();
        Dictionary<string, Dictionary<int, double>> priceHistory = new Dictionary<string, Dictionary<int, double>>();

        public ObjectBrain(Dictionary<string, Seed> SeedDict, Dictionary<string, Dictionary<int, double>> PriceHistory)
        {
            SeedDict = this.seedDict;
            PriceHistory = this.priceHistory;
        }
        
        //Hay que crear varias semillas y dar sus valores
        Seed tomato = new Seed();
        Seed lettuce = new Seed();
        Seed carrot = new Seed();
        
        public ObjectBrain()
        {
            seedDict.Add("Tomate", tomato);
            seedDict.Add("Lechuga", lettuce);
        }

        public Dictionary<string, Seed> GetSeedDict()
        {
            return seedDict;
        }

        public Dictionary<string, Dictionary<int, double>> GetPriceHistory()
        {
            return priceHistory;
        }
    }
}
