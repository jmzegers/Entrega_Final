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
    public class Product
    {
        public string Name;
        public int PurchasePrice;
        public int BaseSellingPrice;
        public int FoodConsumption;// este puede ser tanto comida de animales como nutrientes
        public int WaterConsumption;
        public int MinFoodLv;// este puede ser tanto comida de animales como nutrientes
        public int MinWaterLv;
        public int FoodPenalty; // este puede ser tanto comida de animales como nutrientes
        public int WaterPenalty;
        public int ProductionTime;
        public double DiseaseProbability;
        public int DiseasePenalty;

        public static void Almacenar_Productos(List<Product> p, string adjustedName)
        {
            IFormatter product_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream product_stream = new FileStream("../" + farmName + "/Products.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                product_formatter.Serialize(product_stream, p);
                product_stream.Close();
            }
            catch
            {
                //Stream product_stream = new FileStream("../" + adjustedName + "/Products.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream product_stream = new FileStream("Products.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                product_formatter.Serialize(product_stream, p);
                product_stream.Close();
            }

        }
    }


}
