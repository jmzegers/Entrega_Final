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

        Dictionary<string, Seed> seedDict = new Dictionary<string, Seed>();
        Dictionary<string, Dictionary<int, double>> priceHistory = new Dictionary<string, Dictionary<int, double>>();
        //Hay que crear varias semillas y dar sus valores
        // Seed tomato = new Seed();
        // Seed lettuce = new Seed();
        // Seed carrot = new Seed();

        Dictionary<string, Cattle> cattleDict = new Dictionary<string, Cattle>();
        //Tambien hay que crear varios diferentes tipos de ganado con sus valores respectivos para rellenar este diccionario

        Dictionary<string, StorageBuilding> storageBuildingDict = new Dictionary<string, StorageBuilding>();
        //La misma historia


        public ObjectBrain()
        {
            //seedDict.Add("Tomate", tomato);
            //seedDict.Add("Lechuga", lettuce);

        }

        public Dictionary<string, Seed> GetSeedDict()
        {
            return seedDict;
        }

        public Dictionary<string, Dictionary<int, double>> GetPriceHistory()
        {
            return priceHistory;
        }

        public Dictionary<string, Cattle> GetCattleDict()
        {
            return cattleDict;
        }

        public Dictionary<string, StorageBuilding> GetStorageBuildingDict()
        {
            return storageBuildingDict;
        }
    }
}
