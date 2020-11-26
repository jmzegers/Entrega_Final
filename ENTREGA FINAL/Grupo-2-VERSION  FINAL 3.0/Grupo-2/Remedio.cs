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
    public class Remedio : Consumable
    {
        public double Prob_exito;
        public int Type;// 5-> pesticida, 6-> herbicida, 7-> fungicida , 8-> vacuna

        public Remedio(int price, double prob_exito, int type, string name)
        {
            Prob_exito = prob_exito;
            Type = type;
            Price = price;
            Used = false;
            Name = name;
        }

        public void Aplicar()
        {
            if (Type == 5)
            {

            }
        }

        public static void Almacenar_Remedios(List<Remedio> r, string adjustedName)
        {
            IFormatter remedio_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream remedio_stream = new FileStream("../" + farmName + "/Remedios.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                remedio_formatter.Serialize(remedio_stream, r);
                remedio_stream.Close();
            }
            catch
            {
                //Stream remedio_stream = new FileStream("../" + adjustedName + "/Remedios.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream remedio_stream = new FileStream("Remedios.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                remedio_formatter.Serialize(remedio_stream, r);
                remedio_stream.Close();
            }
        }
    }
}
