using entrega_01_grupo_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entrega1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool addRiver = false;
            bool addLake = false;
            String response = "X";
            string aviso = "Ojo que puede que no se pueda ver todo, para eso haga clic derecho en la consola y, " +
                "en 'Propiedades', bajar la letra (por ejemplo en 10)";
            Console.WriteLine(aviso);

            while (response != "Y" && response != "N")
            {
                Console.WriteLine("¿desea agregar un rio?  [Y/N]");
                response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    addRiver = true;
                }
                else if (response == "N")
                {
                    addRiver = false;
                }
                else
                {
                    Console.WriteLine("Ésa respuesta no es válida.");
                }
            }

            response = "X";

            while (response != "Y" && response != "N")
            {
                Console.WriteLine("¿desea agregar un lago? [Y/N]");
                response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    addLake = true;
                }
                else if (response == "N")
                {
                    addLake = false;
                }
                else
                {
                    Console.WriteLine("Ésa respuesta no es válida.");
                }
            }

            response = "X";

            MapCreator mc = new MapCreator(addRiver,addLake);

            Console.WriteLine(mc);
            Console.ReadKey();
            Console.WriteLine("hola mundo");
            Console.ReadKey();

        }
    }
}