using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class Brain
    {
        public void MapType()
        {
            Console.WriteLine("Elija uno de las siguientes configuraciones del mapa: ");
            Console.WriteLine("1) Solo tierra");
            Console.WriteLine("2) Que contenga un rio");
            Console.WriteLine("3) Que contenga un lago");
            Console.WriteLine("4) Que tenga tanto un rio como un lago");
            Console.WriteLine("Para responder, simplemente escriba el numero de la opcion");
        }

        int answer3 = 0;
        List<int> ansList = new List<int>() { 1, 2, 3, 4 };
        public int MapDecision()
        {
            while (true)
            {
                MapType();
                string mapType = Console.ReadLine();
                try
                {
                    int maptype2 = Convert.ToInt32(mapType);
                    answer3 = maptype2;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (ansList.Contains(answer3) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ésa respuesta no es válida.");
                }
            }

            return answer3;
        }
    }
}
