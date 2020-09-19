using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class FunctionBrain
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

        public List<bool> RiverAndLake()
        {
            List<bool> boolList = new List<bool>();
            bool addRiver;
            bool addLake;
            int d = MapDecision();
            if (d == 1)
            {
                addRiver = false;
                addLake = false;
            }
            else if (d == 2)
            {
                addRiver = true;
                addLake = false;
            }
            else if (d == 3)
            {
                addRiver = false;
                addLake = true;
            }
            else
            {
                addRiver = true;
                addLake = true;
            }

            boolList.Add(addRiver);
            boolList.Add(addLake);

            return boolList;
        }

        public string YesOrNo(string message) //Funcion que filtra respuestas diferentes a "si" o "no"
        {
            String answer = "x";
            while (true)
            {
                Console.WriteLine(message);
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y" || answer == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Respuesta invalida");
                }
            }

            return answer;
        }


        public void Message(int a)
        {
            if (a == 0)
            {
                Console.WriteLine("Que desea hacer");
                Console.WriteLine("Ir a Administrar la granja [A]");
                Console.WriteLine("Ir al mercado [M]");
                Console.WriteLine("Pasar de turno [P]");
                Console.WriteLine("Grabar la partida [G]");
                Console.WriteLine(" ");
            }

            else if (a == 1)
            {
                Console.WriteLine("¿Que desea hacer en el mercado?");
                Console.WriteLine("Ir al mercado de edificaciones[E]");
                Console.WriteLine("Ir al mercado de consumibles [C]");
                Console.WriteLine("Ir al mercado de propiedades [P]");
                Console.WriteLine("Revisar los precios históricos por semilla [H]");
                Console.WriteLine("VOLVER [V]");
                Console.WriteLine(" ");
            }

            else if (a == 2)
            {
                Console.WriteLine("Bienvenido al Mercado de EDIFICACIONES");
                Console.WriteLine("¿Que desea comprar?");
                Console.WriteLine("Una plantacion [P]");
                Console.WriteLine("Ganado [G]");
                Console.WriteLine("Un edificio de almacenamiento [A]");
                Console.WriteLine("Destruir un edificio [D]");
                Console.WriteLine(" ");
            }

            else
            {
                Console.WriteLine("No hay nada guardado en este numero");
            }
        }

        public void EdifMarket(string a)
        {
            if (a == "P")
            {
                Console.WriteLine("Semillas: ");
            }
        }

    }
}
