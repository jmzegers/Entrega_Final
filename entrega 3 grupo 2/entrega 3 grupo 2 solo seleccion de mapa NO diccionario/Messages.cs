using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Messages
    {
        public Messages(int a)
        {
            if (a == 0)
            {
                Console.WriteLine("\nQue desea hacer");
                Console.WriteLine("Ir a Administrar la granja [A]");
                Console.WriteLine("Ir al mercado [M]");
                Console.WriteLine("Pasar de turno [P]");
                Console.WriteLine("Grabar la partida [G]");
                Console.WriteLine(" ");
            }

            else if (a == 1)
            {
                Console.WriteLine("\n¿Que desea hacer en el mercado?");
                Console.WriteLine("Ir al mercado de edificaciones[E]");
                Console.WriteLine("Ir al mercado de consumibles [C]");
                Console.WriteLine("Ir al mercado de propiedades [P]");
                Console.WriteLine("Revisar los precios históricos por semilla [H]");
                Console.WriteLine("VOLVER [V]");
                Console.WriteLine(" ");
            }

            else if (a == 2)
            {
                Console.WriteLine("\nBienvenido al Mercado de EDIFICACIONES");
                Console.WriteLine("¿Que desea comprar?");
                Console.WriteLine("Una plantacion [P]");
                Console.WriteLine("Ganado [G]");
                Console.WriteLine("Un edificio de almacenamiento [A]");
                Console.WriteLine("Vender/Destruir un edificio [D]");
                Console.WriteLine("VOLVER [V]");
                Console.WriteLine(" ");
            }
            else if (a == 3)
            {
                Console.WriteLine("\nBienvenido al Mercado de CONSUMIBLE");
                Console.WriteLine("\nque desea comprar: ");
                Console.WriteLine("Alimento [A]");
                Console.WriteLine("Curas [C]");
            }
            else if (a == 4)
            {
                Console.WriteLine("\nha destruido/vendido un edificio, ¿que quiere hacer?");
                Console.WriteLine("\nDestruir [D]");
                Console.WriteLine("Vender [B]");
                Console.WriteLine("VOLVER [V]");
            }
            else if (a == 5)
            {
                Console.WriteLine("Elija uno de las siguientes configuraciones del mapa: ");
                Console.WriteLine("1) Solo tierra");
                Console.WriteLine("2) Que contenga un rio");
                Console.WriteLine("3) Que contenga un lago");
                Console.WriteLine("4) Que tenga tanto un rio como un lago");
                Console.WriteLine("Para responder, simplemente escriba el numero de la opcion");
            }
            else
            {
                Console.WriteLine("No hay nada guardado en este numero");
            }
        }
    }
}