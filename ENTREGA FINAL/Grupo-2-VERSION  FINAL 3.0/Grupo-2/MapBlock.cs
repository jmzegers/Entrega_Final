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
    public class MapBlock
    {
        public int calidad;
        public bool agua = false;

        public MapBlock()
        {
            Random random = new Random();
            calidad = random.Next(25, 101);

        }

        public static void Almacenar_MapBlock(List<MapBlock> m, string adjustedName)
        {
            IFormatter mapblock_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream mapblock_stream = new FileStream("../" + farmName + "/Mapblock.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                mapblock_formatter.Serialize(mapblock_stream, m);
                mapblock_stream.Close();
            }
            catch
            {
                //Stream mapblock_stream = new FileStream("../" + adjustedName + "/Mapblock.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream mapblock_stream = new FileStream("Mapblock.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                mapblock_formatter.Serialize(mapblock_stream, m);
                mapblock_stream.Close();
            }
        }
    }


}
