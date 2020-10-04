using entrega_01_grupo_2;
using entrega_01_grupo_2.entrega_03;
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
            FunctionBrain b = new FunctionBrain();
            Console.WriteLine("Bienvenido a Farm Life Simulator");
            Ir_al_mercado_de_consumibles buyingConsumable = new Ir_al_mercado_de_consumibles();
            Ir_al_mercado_de_edificaciones DestSell = new Ir_al_mercado_de_edificaciones();
            CompraConsumible Consu = new CompraConsumible();
            VentaDestruir VD = new VentaDestruir();
            List<string> Alimento = new List<string>();
            String ans = "X";
            String answ = "X";
            String answe = "X";
            String res = "X";
            String resp = "X";
            String admins = "X";
            String asd = "X";
            String qwe = "X";
            String poi = "X";
            String klp = "X";
            String mnb = "X";
            String ghj = "X";
            String fgt = "V";
            String ali = "X";
            

            Console.WriteLine("\nCrear nuevo juego [N]");
            Console.WriteLine("Cargar nuevo juego [C]");

            while (true) //Aca se presentan mapas hasta que el jugador se decida por uno
            {
                List<bool> riverAndLake = b.RiverAndLake(); //Aqui hace la pregunta de cual es el tipo de mapa que desea,
                //guardando los valores como dos bools (si tiene rio o no y lo mismo con el lago)
                bool ar = riverAndLake[0]; //valor del bool del rio
                bool al = riverAndLake[1]; //valor del bool del lago
                MapCreator mh = new MapCreator(ar, al);

                string answer = b.YesOrNo("Le gusta el mapa? [Y/N]");

                if (answer == "Y")
                {
                    break;
                }
            }

            double cashMoney = 50000;
            string inventario = "";
            Console.WriteLine("su monto inicial es:  " + cashMoney);
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");



            while (true)
            {
                b.Message(0);
                ans = Console.ReadLine().ToUpper();
                if (ans == "M")
                {
                    b.Message(1);
                    while (true)
                    {
                        answ = Console.ReadLine().ToUpper();
                        if (answ == "E")
                        {
                            b.Message(2);
                            answe = Console.ReadLine().ToUpper();
                            Console.ReadKey();
                            while (true)
                            {
                                answe = Console.ReadLine().ToUpper();
                                if (answe == "P")
                                {
                                    b.EdifMarket("P", cashMoney);

                                }
                                else if (answe == "G")
                                {
                                    b.EdifMarket("G", cashMoney);

                                }
                                else if (answe == "A")
                                {
                                    b.EdifMarket("A", cashMoney);

                                }
                                else if (answe == "D")
                                {
                                    b.Message(4);
                                    resp = Console.ReadLine().ToUpper();
                                    while (true)
                                    {
                                        if (resp == "D")
                                        {
                                            Console.WriteLine("ha destruido el edificio");
                                            DestSell.DestructionSell += VD.OnSellOrDestruction;
                                            DestSell.descision();
                                            cashMoney -= (cashMoney * ((0.5) + (0.078 * 2)));
                                            Console.WriteLine("  dinero actual:  " + cashMoney);
                                            break;
                                        }
                                        else if (resp == "B")
                                        {
                                            Console.WriteLine("ha vendido el edificio");
                                            DestSell.DestructionSell += VD.OnSellOrDestruction1;
                                            DestSell.descision1();
                                            cashMoney += (cashMoney * (0.64) - (0.433));
                                            Console.WriteLine("  dinero actual:  " + cashMoney);
                                            break;
                                        }
                                        else if (resp == "V")
                                        {
                                            Console.WriteLine("VOLVIENDO AL MENU ANTERIOR");
                                            Console.WriteLine(cashMoney);
                                            Console.ReadKey();
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("respuesta invalida");
                                        }
                                    }
                                    break;
                                }
                                else if (answe == "V")
                                {
                                    Console.WriteLine("volviendo al mercado");
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("respuesta invalida");
                                }
                            }
                        }
                        else if (answ == "C")
                        {
                            b.Message(3);
                            while (true)
                            {
                                ali = Console.ReadLine().ToUpper();
                                if (ali == "A")
                                {
                                    Console.WriteLine("¿que ALIMENTO quiere comprar?");
                                    Console.WriteLine("\nFertilizante [T]");
                                    Console.WriteLine("Riego [R]");
                                    Console.WriteLine("Alimento para animales [A]");
                                    Console.WriteLine("Agua para animales [W]");
                                    Console.WriteLine("\nVOLVER");
                                    while (true)
                                    {
                                        res = Console.ReadLine().ToUpper();
                                        if (res == "T")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy4;
                                            buyingConsumable.Buying();
                                            cashMoney -= 33.45;
                                            inventario += "\nFertilizante";
                                            Alimento.Add("\nFertilizante");

                                        }
                                        else if (res == "R")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy5;
                                            buyingConsumable.Buying();
                                            cashMoney -= 56.31;
                                            inventario += "\nriego";
                                            Alimento.Add("\nRiego");

                                        }
                                        else if (res == "A")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy6;
                                            buyingConsumable.Buying();
                                            cashMoney -= 44.96;
                                            inventario += "\nAlimento para animales";
                                            Alimento.Add("\nAlimento para animales");

                                        }
                                        else if (res == "W")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy7;
                                            buyingConsumable.Buying();
                                            cashMoney -= 54.45;
                                            inventario += "\nAgua para animales";
                                            Alimento.Add("\nAgua para animales");

                                        }
                                        else if (res == "V")
                                        {
                                            Console.WriteLine(cashMoney);
                                            Console.WriteLine("a comprado en total lo siguientes productos:  ");
                                            Console.WriteLine(inventario);
                                            Console.WriteLine("volviendo");
                                            Console.ReadKey();
                                            break;

                                        }

                                        else
                                        {
                                            Console.WriteLine("respuesta invalida");
                                        }
                                    }
                                }
                                else if (ali == "C")
                                {
                                    Console.WriteLine("¿que CURA quiere comprar?");
                                    Console.WriteLine("\nHerbicida [H]");
                                    Console.WriteLine("Fungicida [F]");
                                    Console.WriteLine("Pesticida [P]");
                                    Console.WriteLine("Vacunas [G]");
                                    Console.WriteLine("\nVOLVERE");
                                    while (true)
                                    {
                                        res = Console.ReadLine().ToUpper();
                                        if (res == "F")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy;
                                            buyingConsumable.Buying();
                                            cashMoney -= 48.20;
                                            inventario += "\nfungicida";
                                        }
                                        else if (res == "H")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy1;
                                            buyingConsumable.Buying();
                                            cashMoney -= 80.24;
                                            inventario += "\nHerbicida";

                                        }

                                        else if (res == "P")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy2;
                                            buyingConsumable.Buying();
                                            cashMoney -= 42.80;
                                            inventario += "\npesticida";

                                        }

                                        else if (res == "G")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy3;
                                            buyingConsumable.Buying();
                                            cashMoney -= 28.40;
                                            inventario += "\nvacuna";

                                        }
                                        else if (res == "V")
                                        {
                                            Console.WriteLine(cashMoney);
                                            Console.WriteLine("a comprado en total lo siguientes productos:  ");
                                            Console.WriteLine(inventario);
                                            Console.WriteLine("volviendo");
                                            Console.ReadKey();
                                            break;

                                        }

                                        else
                                        {
                                            Console.WriteLine("respuesta invalida");
                                        }
                                    } break;
                                }
                            }
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

                }
                else if (ans == "A")
                {
                    Console.WriteLine("Administrar grnaja");
                    Console.WriteLine("\nAdministrar produccion [P]");
                    Console.WriteLine("Administrar almacenamiento [A]");
                    Console.WriteLine("\nVOLVER [V]");
                    while (true)
                    {
                        admins = Console.ReadLine().ToUpper();
                        if (admins == "P")
                        {
                            Console.WriteLine("administrar produccion");
                            Console.WriteLine("\nAgregar agua o comida [A]");
                            Console.WriteLine("aplicar cura [C]");
                            Console.WriteLine("obtener producto terminado [T]");
                            Console.WriteLine("\nVOLVER [V]"); 
                            while (true)
                            {
                                asd = Console.ReadLine().ToUpper();
                                if (asd == "A")
                                {
                                    Console.WriteLine("¿A QUIEN desea agregar agua o comida?");
                                    Console.WriteLine("\nGanado [G]");
                                    Console.WriteLine("Plantacion [P]");
                                    while (true)
                                    {
                                        qwe = Console.ReadLine().ToUpper();
                                        if (qwe == "G")
                                        {
                                            Console.WriteLine("¿QUE desea usar?");
                                            Console.WriteLine("\nComida [C]");
                                            Console.WriteLine("Agua [A]");
                                            Console.WriteLine("\nVOLVER [V]");
                                            while (true)
                                            {
                                                mnb = Console.ReadLine().ToUpper();
                                                if (mnb == "C")
                                                {
                                                    Console.WriteLine("agregar comida");
                                                }
                                                else if (mnb == "A")
                                                {
                                                    Console.WriteLine("agregar agua");
                                                }
                                                else if (mnb == "V")
                                                {
                                                    Console.WriteLine("VOLVIENDO");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Ésa respuesta no es válida.");
                                                }
                                               
                                            } 
                                        }
                                        else if (qwe == "P")
                                        {
                                            Console.WriteLine("¿QUE desea usar?");
                                            Console.WriteLine("\nFertilizante [F]");
                                            Console.WriteLine("Riego [R]");
                                            Console.WriteLine("\nVOLVER [V]");
                                            while (true)
                                            {
                                                ghj = Console.ReadLine().ToUpper();
                                                if (ghj == "F")
                                                {
                                                    Console.WriteLine("agregar Fertilizante");
                                                }
                                                else if (ghj == "R")
                                                {
                                                    Console.WriteLine("Agregar Riego");
                                                }
                                                else if (ghj == "V")
                                                {
                                                    Console.WriteLine("volviendo");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("respuesta invalida");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ésa respuesta no es válida.");
                                            break;
                                        }
                                    }
                                    
                                }
                                else if (asd == "C")
                                {
                                    Console.WriteLine("¿A quien desea aplicar cura?");
                                    Console.WriteLine("\nGanado [G]");
                                    Console.WriteLine("Plantacion [P]");
                                    while (true)
                                    {
                                        poi = Console.ReadLine().ToUpper();
                                        if (poi == "P")
                                        {
                                            Console.WriteLine("¿QUE desea usar?");
                                            Console.WriteLine("\nHerbicida [H]");
                                            Console.WriteLine("Fungicida [F]");
                                            Console.WriteLine("Pesticida [P]");
                                            Console.WriteLine("\nVOLVER [V]");
                                            while (true)
                                            {
                                                klp = Console.ReadLine().ToUpper();
                                                if (klp == "H")
                                                {
                                                    Console.WriteLine("aplicando Herbicida");
                                                }
                                                else if (klp == "F")
                                                {
                                                    Console.WriteLine("aplicando Fungicida");
                                                }
                                                else if (klp == "P")
                                                {
                                                    Console.WriteLine("aplicando Pesticida");
                                                }
                                                else if (klp == "V")
                                                {
                                                    Console.WriteLine("Volviendo");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("respuesta invalida");
                                                }
                                            }
                                        }
                                        else if (poi == "G")
                                        {
                                            Console.WriteLine("aplicando vacuna");
                                        }
                                        else if (fgt == "V")
                                        {
                                            Console.WriteLine("VOLVIENDO");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ésa respuesta no es válida.");
                                        }
                                    }
                                }
                                else if (asd == "T")
                                {
                                    Console.WriteLine("algo 3");
                                    
                                }
                                else if (asd == "V")
                                {
                                    Console.WriteLine("volviendo");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ésa respuesta no es válida.");
                                }

                            }break;
                        }
                        else if (admins == "A")
                        {
                            break;
                        }
                        else if (admins == "V")
                        {
                            Console.WriteLine("volviendo");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ésa respuesta no es válida.");
                        }
                    }

                }
                else if (ans == "P")
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