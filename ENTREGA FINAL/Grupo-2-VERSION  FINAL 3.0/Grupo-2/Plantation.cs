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
    public class Plantation : Edification
    {
        public Seed Semilla;
        public bool Worms;//gusanos
        public bool Weeds;// maleza
        public double Nutrients;//nutrientes
        public int Units;

        public Plantation(Seed semilla, string name)
        {
            Semilla = semilla;
            Nutrients = 100;
            Name = name;
            PurchasePrice = 100;
            SalesPrice = -150;
            Health = 100;
            Water = 100;
            Maturity = 0;
            Disease = false;
            Worms = false;
            Weeds = false;
            tipo = "P";
            Units = 100;
        }

        public static void Almacenar_Plantacion(List<Plantation> p, string adjustedName)
        {
            IFormatter plantation_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream plantation_stream = new FileStream("../" + farmName + "/Plantations.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                plantation_formatter.Serialize(plantation_stream, p);
                plantation_stream.Close();
            }
            catch
            {
                //Stream plantation_stream = new FileStream("../" + adjustedName + "/Plantations.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream plantation_stream = new FileStream("Plantations.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                plantation_formatter.Serialize(plantation_stream, p);
                plantation_stream.Close();
            }
        }
    }
}
