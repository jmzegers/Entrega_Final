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

        List<Seed> seedList = new List<Seed>();

        Dictionary<string, Dictionary<int, double>> priceHistory = new Dictionary<string, Dictionary<int, double>>();
        //Hay que crear 7 semillas y dar sus valores
        /*Los valores de las semillas (en orden) son:
       * 1. Nombre
       * 2. Precio actual de compra
       * 3. Precio base de compra
       * 4. Consumo de agua por turno
       * 5. Nivel minimo de agua
       * 6. Penalizacion por falta de agua
       * 7. Tiempo de produccion (por turnos)
       * 8. Probabilidad de enfermedad
       * 9. Penalizacion por enfermedad
       * 10. Variacion de precio
       * 11. Consumo de nutrientes por turno
       * 12. Nivel minimo de nutrientes
       * 13. Penalizacion por falta de nutrientes
       * 14. Probabilidad de gusanos
       * 15. Penalizacion por gusanos
       * 16. Probabilidad de malezas
       * 17. Penalizacion por malezas
       */

        /*
        Seed Lettuce = new Seed("Lettuce", 4200, 4200, 2.8, 95, 1, 4, 10, 1, 1.02, 12, 1, 10, 10, 2, 7, 2, 100);
        Seed Carrot = new Seed("Carrot", 1500, 1500, 1.8, 80, 1, 2, 6, 1, 1.02, 10, 1, 1, 3, 2, 5, 2, 100);
        Seed Potato = new Seed("Potato", 2000, 2000, 0.8, 50, 1, 2, 8, 1, 1.01, 7, 1, 1, 12, 2, 12, 2, 100);
        Seed Corn = new Seed("Corn", 2500, 2500, 1.2, 75, 1, 2, 10, 1, 1.04, 10, 1, 1, 7, 2, 15, 2, 100);
        Seed Onion = new Seed("Onion", 3500, 3500, 1.2, 80, 1, 2, 10, 1, 1.04, 9, 1, 1, 5, 2, 15, 2, 100);
        Seed Celery = new Seed("Celery", 4500, 4500, 1.8, 90, 1, 2, 10, 1, 1.05, 11, 1, 5, 10, 2, 15, 2, 100);
        */

        Dictionary<string, StorageBuilding> storageBuildingDict = new Dictionary<string, StorageBuilding>();
        StorageBuilding SmallStorageBuilding = new StorageBuilding("Small Storage Building", 100, 50, 500, "A",1);
        StorageBuilding MediumStorageBuilding = new StorageBuilding("Medium Storage Building", 200, 150, 1000, "B",1);
        StorageBuilding LargeStorageBuilding = new StorageBuilding("Large Storage Building", 400, 350, 2000, "C",1);

        Dictionary<string, List<int>> uc = new Dictionary<string, List<int>>();


        public ObjectBrain(Dictionary<string, List<int>> usedCoordinates = null)
        {
            seedDict.Add("Lechuga", Lettuce);
            seedDict.Add("Zanahoria", Carrot);
            seedDict.Add("Papa", Potato);
            seedDict.Add("Maíz", Corn);
            seedDict.Add("Cebolla", Onion);
            seedDict.Add("Apio", Celery);
            */

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

