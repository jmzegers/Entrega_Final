using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grupo_2
{
    [Serializable]
    public class Partida
    {
        public int tipo_mapa;
        public string FarmName;
        public int PlayerCash = 500000;
        public List<Cattle> PlayerBoughtCattle = new List<Cattle>();
        public List<StorageBuilding> playerBoughtStorage = new List<StorageBuilding>();
        public List<Alimento> PlayerFertilizerList = new List<Alimento>();
        public List<Alimento> PlayerPlantWater = new List<Alimento>();
        public List<Alimento> PlayerAnimalFood = new List<Alimento>();
        public List<Alimento> PlayerAnimalWater = new List<Alimento>();
        public List<Remedio> PlayerVaccines = new List<Remedio>();
        public List<Remedio> PlayerHerbicides = new List<Remedio>();
        public List<Remedio> PlayerFungicides = new List<Remedio>();
        public List<Remedio> PlayerPesticides = new List<Remedio>();
        public List<Plantation> PlayerPlantation = new List<Plantation>();
       
        public int Turn = 1;
        public int Day = 31;
        public DateTime currentDateTime = DateTime.Now;
        public Map Map = new Map();
        public List<List<int>> mapa = new List<List<int>>();

        public List<List<int>> Property_Coordinates = new List<List<int>>();
        public List<Terrain> Player_Properties = new List<Terrain>();

        public Dictionary<string, List<int>> Precios_Historicos_Semillas = new Dictionary<string, List<int>>();
        public List<FinishedProduct> Player_FinishedProduct = new List<FinishedProduct>();

        public Partida(string farmName)
        { 
            this.FarmName = farmName;
        }

        public static void Almacenar_Partida(List<Partida> p, string adjustedName)
        {
            IFormatter partida_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream partida_stream = new FileStream("Partidas.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                partida_formatter.Serialize(partida_stream, p);
                partida_stream.Close();
            }
            catch
            {
                //Stream partida_stream = new FileStream("../" + adjustedName + "/Partidas.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream partida_stream = new FileStream("Partidas.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                partida_formatter.Serialize(partida_stream, p);
                partida_stream.Close();
            }
        }
    }
}
