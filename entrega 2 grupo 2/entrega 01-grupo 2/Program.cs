﻿using entrega_01_grupo_2;
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
            string nuevo_juego = "\nCrear un nuevo juego:";
            string cargar_archivo = "\n¿Desea cargar un mapa anterior?";
            string pregunta = "\n¿desea generar otro mapa? [Y/N]";
            String answer = "x";
            String answer2 = "x";
            int monto = 50000;
            Console.WriteLine(aviso);

            while (answer2 != "Y" && answer2 != "N")
            {
                Console.WriteLine(cargar_archivo + "[Y/N]");
                answer2 = Console.ReadLine().ToUpper();
                if (answer2 == "Y")
                {
                    // deberia abrir un archivo (siempre que haya uno guardado)
                }
                else if (answer2 == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ésa respuesta no es válida.");
                }
            }
            Console.WriteLine(nuevo_juego);

            Console.ReadKey();
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


            while (answer != "N")
            {
                Console.WriteLine(pregunta);
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    MapCreator mh = new MapCreator(addRiver, addLake);
                }
                else if (answer == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ésa respuesta no es válida.");
                }
            }

     
            Console.WriteLine("monto: $" + monto);
            Console.ReadKey();
        }
    }
}