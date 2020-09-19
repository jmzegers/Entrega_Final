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
            Brain b = new Brain();
            Console.WriteLine("Bienvenido a Farm Life Simulator");

            while (true) //Aca se presentan mapas hasta que el jugador se decida por uno
            {
                List<bool> riverAndLake = b.RiverAndLake(); //Aqui hace la pregunta de cual es el tipo de mapa que desea,
                //guardando los valores como dos bools (si tiene rio o no y lo mismo con el lago)
                bool ar = riverAndLake[0]; //valor del bool del rio
                bool al = riverAndLake[1]; //valor del bool del lago
                MapCreator mh = new MapCreator(ar, al);

                string answer = b.YesOrNo("Le gusta el mapa? Y/N");

                if (answer == "Y")
                {
                    break;
                }
            }

            double CashMoney = 100000.50;
            Console.WriteLine("su monto inicial es:  " + CashMoney);
            Console.WriteLine("su granja es el rectangulo gris");
            Console.ReadKey();

            // aqui empieza lo que te piden de la entrega 3
            string go = "\nQue desea hacer";
            string go1 = "\nir a Administrar la granja [A]";
            string go2 = "Ir al mercado [M]";
            string go3 = "Pasar de turno [P]";
            string go4 = "Grabar la partida [G]";
            String ans = "x";
            String answ = "x";
            String answe = "x";

            while (true)
            {
                Console.WriteLine(go);

                Console.WriteLine(go1);
                Console.WriteLine(go2);
                Console.WriteLine(go3);
                Console.WriteLine(go4);

                ans = Console.ReadLine().ToUpper();
                if (ans == "M")
                {
                    Console.WriteLine("\nque desea hacer en el mercado");
                    Console.WriteLine("\nIr al mercado de edificaciones[E]");
                    Console.WriteLine("Ir al mercado de consumibles [C]");
                    Console.WriteLine("Ir al mercado de propiedades [P]");
                    Console.WriteLine("Revisar los precios históricos por semilla [H]");
                    Console.WriteLine("VOLVER [V]");
                    while (true)
                    {
                        answ = Console.ReadLine().ToUpper();
                        if (answ == "E")
                        {
                            Console.WriteLine("Mercado de EDIFICACIONES: ");
                            Console.ReadKey();
                            answe = Console.ReadLine().ToUpper();
                            while (true)
                            {
                                Console.WriteLine("\nEstas en el mercado de edificaciones, que desea hacer: ");
                                Console.WriteLine("Comprar una plantación [P]");
                                Console.WriteLine("Comprar ganado [G]");
                                Console.WriteLine("Comprar almacenamiento [A]");
                                Console.WriteLine("Vender/Destruir Edificio [E]");
                                Console.WriteLine("VOLVER [V]");
                                break;
                            }
                        }
                        else if (answ == "C")
                        {
                            Console.WriteLine("Mercado de CONSUMIBLES");
                            Ir_al_mercado_de_consumibles buyingConsumable = new Ir_al_mercado_de_consumibles();

                            buyingConsumable.Buying();
                            Console.ReadKey();
                            break;
                        }
                        else if (answ == "P")
                        {
                            Console.WriteLine("Mercado de PROPIEDADES");
                            Console.ReadKey();
                            break;
                        }
                        else if (answ == "H")
                        {
                            Console.WriteLine("Precios HISTORICOS de las semillas");
                            Console.ReadKey();
                            break;
                        }
                        else if (answ == "V")
                        {
                            Console.WriteLine("volviendo al menu anterior");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ésa respuesta no es válida.");
                        }
                    }
                    if (answ != "V")
                    {
                        break;
                    }
                    
                }
                else if (ans == "P")
                {
                    Console.WriteLine("Desea pasar de turno [Y/N]");
                    Console.ReadKey();
                    break;
                }
                else if (ans == "G")
                {
                    Console.WriteLine("Desea Guardar [Y/N]");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Ésa respuesta no es válida.");
                }
            }
            // hasta aqui
            
        }

    }
}