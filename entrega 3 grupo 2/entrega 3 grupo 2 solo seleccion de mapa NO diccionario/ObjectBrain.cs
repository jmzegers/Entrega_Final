using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class ObjectBrain
    {

        Dictionary<string, Seed> seedDict = new Dictionary<string, Seed>();
        Dictionary<string, Dictionary<int, double>> priceHistory = new Dictionary<string, Dictionary<int, double>>();
        //Hay que crear 7 semillas y dar sus valores

        Seed Tomato = new Seed("Tomato", 5, 5, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Lettuce = new Seed("Lettuce", 10, 7, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Carrot = new Seed("Carrot", 15, 10, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Potato = new Seed("Potato", 20, 15, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Corn = new Seed("Corn", 25, 20, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Onion = new Seed("Onion", 35, 25, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Celery = new Seed("Celery", 45, 35, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);


        Dictionary<string, StorageBuilding> storageBuildingDict = new Dictionary<string, StorageBuilding>();
        StorageBuilding SmallStorageBuilding = new StorageBuilding("Small Storage Building", 100, 50, 500, "A",1);
        StorageBuilding MediumStorageBuilding = new StorageBuilding("Medium Storage Building", 200, 150, 1000, "B",1);
        StorageBuilding LargeStorageBuilding = new StorageBuilding("Large Storage Building", 400, 350, 2000, "C",1);

        Dictionary<string, List<int>> uc = new Dictionary<string, List<int>>();


        public ObjectBrain(Dictionary<string, List<int>> usedCoordinates = null)
        {
            seedDict.Add("Tomate", Tomato);
            seedDict.Add("Lechuga", Lettuce);
            seedDict.Add("Zanahoria", Carrot);
            seedDict.Add("Papa", Potato);
            seedDict.Add("Maíz", Corn);
            seedDict.Add("Cebolla", Onion);
            seedDict.Add("Apio", Celery);

            storageBuildingDict.Add("Edificio de Almacenamiento Pequeño", SmallStorageBuilding);
            storageBuildingDict.Add("Edificio de Almacenamiento Mediano", MediumStorageBuilding);
            storageBuildingDict.Add("Edificio de Almacenamiento Grande", LargeStorageBuilding);

            this.uc = usedCoordinates;
        }

        public Dictionary<string, Seed> GetSeedDict()
        {
            return seedDict;
        }

        public Dictionary<string, Dictionary<int, double>> GetPriceHistory()
        {
            return priceHistory;
        }

       

        public Dictionary<string, StorageBuilding> GetStorageBuildingDict()
        {
            return storageBuildingDict;
        }

        public Dictionary<string, List<int>> GetUsedCoordinates()
        {
            return uc;
        }

        List<string> SeedList = new List<string>()
        {
            "Tomate" + "precio de compra: 5" + "precio base: 5" + "consumo de nutrientes: 1"+"consumo de agua: 1"+
             "nivel minimo de nutrientes: 2"+" nivel minimo de agua: 10" + " 1, 1, 1, 1, 1, 10, 2, 15, 2",
            "Lettuce" + "precio de compra: 5" + "precio base: 5" + "consumo de nutrientes: 1"+"consumo de agua: 1"+
             "nivel minimo de nutrientes: 2"+" nivel minimo de agua: 10" + " 1, 1, 1, 1, 1, 10, 2, 15, 2"
        };

        internal Dictionary<string, Cattle> GetCattleDict()
        {
            throw new NotImplementedException();
        }
    }
    /*
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
    }*/
}

