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
    public class Map
    {
        public List<Terrain> MapaTerrenos = new List<Terrain>();

        public Map()
        {
            
        }

        public static void Almacenar_Mapa(Map m, string adjustedName)
        {
            IFormatter map_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream map_stream = new FileStream("../" + farmName + "/Map.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                map_formatter.Serialize(map_stream, m);
                map_stream.Close();
            }
            catch
            {
                //Stream map_stream = new FileStream("../" + adjustedName + "/Map.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream map_stream = new FileStream("Map.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                map_formatter.Serialize(map_stream, m);
                map_stream.Close();
            }
        }
    }
}
