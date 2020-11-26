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
    public class Alimento : Consumable
    {
        public int Amount; //cantidad de incremento
        public int Type;// 1-> fertilizante, 2-> riego, 3-> alimento animal, 4-> agua animal

        public Alimento(int price, int amount, int type, string name)
        {
            Amount = amount;
            Type = type;
            Price = price;
            Used = false;
            Name = name;
        }

        public int Incrementar()
        {
            if (Type == 1)
            {

            }
            return 10;//cambiar 
        }

        public static void Almacenar_Alimentos(List<Alimento> a, string adjustedName)
        {
            IFormatter alimento_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;

            string root = "@../" + farmName;
            /*
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            */
            try
            {
                Stream alimento_stream = new FileStream("../" + farmName + "/Alimentos.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                alimento_formatter.Serialize(alimento_stream, a);
                alimento_stream.Close();
            }
            catch
            {
                /*
                string adjusted_root = "@../" + adjustedName;
                if (!Directory.Exists(adjusted_root))
                {
                    Directory.CreateDirectory(adjusted_root);
                }
                */
                Stream alimento_stream = new FileStream("Alimentos.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                //Stream alimento_stream = new FileStream("../" + adjustedName + "/Alimentos.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                alimento_formatter.Serialize(alimento_stream, a);
                alimento_stream.Close();
            }
        }
    }
}
