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
        //Hay que crear 7 semillas y dar sus valores
        Seed Tomato = new Seed("Tomato", 5, 5, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Lettuce = new Seed("Lettuce", 10, 7, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Carrot = new Seed("Carrot", 15, 10, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Potato = new Seed("Potato", 20, 15, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Corn = new Seed("Corn", 25, 20, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Onion = new Seed("Onion", 35, 25, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);
        Seed Celery = new Seed("Celery", 45, 35, 1, 1, 1, 2, 10, 1, 1, 1, 1, 1, 10, 2, 15, 2);

        Dictionary<string, Animal> animalDict = new Dictionary<string, Animal>();
        //Tambien hay que crear 5 diferentes tipos de ganado con sus valores respectivos para rellenar este diccionario
        Animal Cow = new Animal("Cow", 15, 15, 5, 5, 2, 5, 15, 2, 1, 1, 2, 10, 5, 1, 10, 3, 1, 10);
        Animal Pig = new Animal("Pig", 20, 17, 5, 5, 2, 5, 15, 2, 1, 1, 2, 10, 5, 1, 10, 3, 1, 10);
        Animal Chicken = new Animal("Chicken", 25, 20, 5, 5, 2, 5, 15, 2, 1, 1, 2, 10, 5, 1, 10, 3, 1, 10);
        Animal Goat = new Animal("Goat", 27, 23, 5, 5, 2, 5, 15, 2, 1, 1, 2, 10, 5, 1, 10, 3, 1, 10);
        Animal Sheep = new Animal("Sheep", 30, 25, 5, 5, 2, 5, 15, 2, 1, 1, 2, 10, 5, 1, 10, 3, 1, 10);

        Dictionary<string, StorageBuilding> storageBuildingDict = new Dictionary<string, StorageBuilding>();
        StorageBuilding SmallStorageBuilding = new StorageBuilding("Small Storage Building", 100, 50, 500, "A");
        StorageBuilding MediumStorageBuilding = new StorageBuilding("Medium Storage Building", 200, 150, 1000, "B");
        StorageBuilding LargeStorageBuilding = new StorageBuilding("Large Storage Building", 400, 350, 2000, "C");

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

            animalDict.Add("Vaca", Cow);
            animalDict.Add("Cerdo", Pig);
            animalDict.Add("Pollo", Chicken);
            animalDict.Add("Cabra", Goat);
            animalDict.Add("Oveja", Sheep);

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

        public Dictionary<string, Animal> GetAnimalDict()
        {
            return animalDict;
        }

        public Dictionary<string, StorageBuilding> GetStorageBuildingDict()
        {
            return storageBuildingDict;
        }

        public Dictionary<string, List<int>> GetUsedCoordinates()
        {
            return uc;
        }
    }
}
