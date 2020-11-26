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
    public class Cattle : Edification
    {
        public Animal Animal;
        public double Food;//comida
        public int Units;// unidades

        public Cattle(Animal animal, string name)
        {
            Animal = animal;
            Food = 100;
            Name = name;
            PurchasePrice = 100;
            SalesPrice = -150;
            Health = 100;
            Water = 100;
            Maturity = 0;
            Disease = false;
            Units = animal.Units;
            tipo = "C";
        }

        public static void Almacenar_Ganado(List<Cattle> c, string adjustedName)
        {
            IFormatter cattle_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream cattle_stream = new FileStream("../" + farmName + "/Ganados.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                cattle_formatter.Serialize(cattle_stream, c);
                cattle_stream.Close();
            }
            catch
            {
                //Stream cattle_stream = new FileStream("../" + adjustedName + "/Ganados.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream cattle_stream = new FileStream("Ganados.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                cattle_formatter.Serialize(cattle_stream, c);
                cattle_stream.Close();
            }

        }
    }
}
