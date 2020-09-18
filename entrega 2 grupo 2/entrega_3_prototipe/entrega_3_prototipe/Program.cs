using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_3_prototipe
{
    class Program
    {
        static void Main(string[] args)
        {
            string go = "Que desea hacer";
            string go1 = "ir a Administrar la granja [A]";
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
                    Console.WriteLine("que desea hacer en el mercado");
                    Console.WriteLine("Ir al mercado de edificaciones[E]");
                    Console.WriteLine("Ir al mercado de consumibles [C]");
                    Console.WriteLine("Ir al mercado de propiedades [P]");
                    Console.WriteLine("Revisar los precios históricos por semilla [H]");
                    Console.WriteLine("VOLVER [V]");
                    while (true)
                    {
                        answ = Console.ReadLine().ToUpper();
                        if (answ == "E")
                        {
                            Console.WriteLine("Mercado de EDIFICACIONES");
                            Console.ReadKey();
                            break;
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
                    break;
                }
                else if (ans == "[P]")
                {
                    Console.WriteLine("Desea pasar de turno [Y/N]");
                    break;
                }

                else
                {
                    Console.WriteLine("Ésa respuesta no es válida.");
                }
            }

        }
    }
}
