using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Grupo_2
{
    [Serializable]
    public class Animal : Product
    {
        public int Units;
        public double Escapeprobability;
        public int Minangeleak;
        public int Maxrangeleak;
        public double Deathprobability;
        public int Minangedeath;
        public int Maxrangedeath;

        public int Maturity;

        public Animal(string name, int purchasePrice, int baseSellingPrice, int units, int foodConsumption,
          int wateronsumption, int minWaterLv, int minFoodLv, int waterpenalty, int foodpenalty, int productiontime,
          double diseaseprobability, int diseasepenalty, double escapeprobability, int minangeleak, int maxrangeleak,
          double deathprobability, int minangedeath, int maxrangedeath, int maturity)
        {
            Units = units;
            Escapeprobability = escapeprobability;
            Minangeleak = minangeleak;
            Maxrangeleak = maxrangeleak;
            Deathprobability = deathprobability;
            Minangedeath = minangedeath;
            Maxrangedeath = minangedeath;
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

            Maturity = maturity;
        }

        public static void Almacenar_Animales(List<Animal> a, string adjustedName)
        {
            IFormatter animal_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream animal_stream = new FileStream("../" + farmName + "/Animales.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                animal_formatter.Serialize(animal_stream, a);
                animal_stream.Close();
            }
            catch
            {
                //Stream animal_stream = new FileStream("../" + adjustedName + "/Animales.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream animal_stream = new FileStream("Animales.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                animal_formatter.Serialize(animal_stream, a);
                animal_stream.Close();
            }

        }
    }
}
