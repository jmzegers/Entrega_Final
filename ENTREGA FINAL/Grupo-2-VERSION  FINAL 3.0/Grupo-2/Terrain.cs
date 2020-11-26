using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Grupo_2
{
    [Serializable]
    public class Terrain
    {
        public bool comprado = false;
        public Edification ed;
        public int Base_Price = 48000;
        public double Quality;
        public double Ground_Ratio;
        public string boton;
        public bool ocupado = false;
        public int price = 0;

        /* El precio del terreno se define como Precio Base x Calidad del
         * terreno x Proporción de tierra, donde Precio Base es un monto base igual para todos
         * los terrenos, ejemplo, $48.000, Calidad del terreno es el promedio de la calidad de cada
         * bloque de tierra que lo compone y Proporción de tierra es (Cantidad de bloques de tierra
         * que posee el terreno) / (Cantidad total de bloques que posee el terreno).
         */

        public Terrain(string boton)
        {
            this.boton = boton;

            { 
                 List<List<MapBlock>> m = new List<List<MapBlock>>();
                 for (int i = 0; i < 10; i++)
                 {
                     List<MapBlock> lista = new List<MapBlock>();
                     for (int e = 0; e < 10; e++)
                     {
                         MapBlock bloque = new MapBlock();
                         lista.Add(bloque);
                     }
                     m.Add(lista);
                 }
                 // Calidad del terreno es el promedio de la calidad de cada bloque de tierra que lo compone.
                 int groundBlockNum = 1; //Lo dejo en 1 por si acaso, ya que no quiero dividir por cero.
                 int qualityTotal = 1;
                 double qualityAverage = 1;


                 foreach (List<MapBlock> l in m)
                 {
                     foreach (MapBlock mb in l)
                     {
                         if (mb.agua == false)
                         {
                             groundBlockNum += 1;
                             qualityTotal += mb.calidad;
                         }
                     }
                 }


                 if (groundBlockNum != 0)
                 {
                     groundBlockNum -= 1;
                     qualityAverage = qualityTotal / groundBlockNum;
                 }
                 Quality = qualityAverage;

                price = (int)(Base_Price * (Quality/ 100));
            }
        }

        public static void Almacenar_Terrain(List<Terrain> t, string adjustedName)
        {
            IFormatter terrain_formatter = new BinaryFormatter();
            string farmName = Juego.PartidaList[0].FarmName;
            try
            {
                Stream terrain_stream = new FileStream("../" + farmName + "/Terrains.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                terrain_formatter.Serialize(terrain_stream, t);
                terrain_stream.Close();
            }
            catch
            {
                //Stream terrain_stream = new FileStream("../" + adjustedName + "/Terrains.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                Stream terrain_stream = new FileStream("Terrains.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                terrain_formatter.Serialize(terrain_stream, t);
                terrain_stream.Close();
            }
        }

    }
}
