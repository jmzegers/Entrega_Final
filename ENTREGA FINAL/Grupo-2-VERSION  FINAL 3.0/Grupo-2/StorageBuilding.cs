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
    public class StorageBuilding : Edification
    {
        public int Maxcapacity;
        public List<FinishedProduct> ProductosGuardados = new List<FinishedProduct>();
        public bool IsFull;

        public StorageBuilding(string name, int Maxcapacity)
        {
            Name = name;
            SalesPrice = 100;
            PurchasePrice = 150;
            this.Maxcapacity = Maxcapacity;
            IsFull = false;
            tipo = "S";
        }

        public static void Almacenar_Almacenamiento(List<StorageBuilding> sb, string adjustedName)
        {
            IFormatter sb_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream sb_stream = new FileStream("../" + farmName + "/Almacenamientos.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                sb_formatter.Serialize(sb_stream, sb);
                sb_stream.Close();
            }
            catch
            {
                //Stream sb_stream = new FileStream("../" + adjustedName + "/Almacenamientos.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream sb_stream = new FileStream("Almacenamientos.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                sb_formatter.Serialize(sb_stream, sb);
                sb_stream.Close();
            }
        }
    }
}
