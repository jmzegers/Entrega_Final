using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Grupo_2
{
    [Serializable]
    public class Seed : Product
    {
        public int PriceVarietyperturn;
        public double WormsProbability;
        public int WormsPenalty;
        public double WeedsProbability;
        public int WeedsPenalty;

        public int CurrentPrice;
        public double MinPrice;
        public double MaxPrice;

        public Seed(string name, int purchasePrice, int baseSellingPrice, int priceVarietyperturn, int foodConsumption,
            int wateronsumption, int minWaterLv, int minFoodLv, int waterpenalty, int foodpenalty, int productiontime,
            double diseaseprobability, int diseasepenalty, double wormsProbability, int wormsPenalty, double weedsProbability,
            int weedsPenalty, int currentPrice, double minPrice, double maxPrice)
        {
            PriceVarietyperturn = priceVarietyperturn;
            WormsProbability = wormsProbability;
            WormsPenalty = wormsPenalty;
            WeedsProbability = weedsProbability;
            WeedsPenalty = weedsPenalty;
            Name = name;
            PurchasePrice = purchasePrice;
            BaseSellingPrice = baseSellingPrice;
            FoodConsumption = foodConsumption;
            WaterConsumption = wateronsumption;
            MinFoodLv = minFoodLv;
            MinWaterLv = minWaterLv;
            FoodPenalty = foodpenalty;
            WaterPenalty = waterpenalty;
            ProductionTime = productiontime;
            DiseaseProbability = diseaseprobability;
            DiseasePenalty = diseasepenalty;

            CurrentPrice = currentPrice;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
        }


        public static void Almacenar_Semillas(List<Seed> s, string adjustedName)
        {
            IFormatter seed_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream seed_stream = new FileStream("../" + farmName + "/Semillas.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                seed_formatter.Serialize(seed_stream, s);
                seed_stream.Close();
            }
            catch
            {
                //Stream seed_stream = new FileStream("../" + adjustedName + "/Semillas.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream seed_stream = new FileStream("Semillas.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                seed_formatter.Serialize(seed_stream, s);
                seed_stream.Close();
            }

        }

    }
}
