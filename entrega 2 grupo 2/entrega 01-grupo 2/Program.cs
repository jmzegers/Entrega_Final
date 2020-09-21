﻿using entrega_01_grupo_2;
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
            CompraConsumible Consu = new CompraConsumible();

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

            // aqui empieza lo que te piden de la entrega 3
            String ans = "x";
            String answ = "x";
            String answe = "x";
            String res = "X";

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
                                else if (answe == "C")
                                {

                                }
                                else if (answe == "D")
                                {
                                    Console.WriteLine("ha destruido/vendido un edificio");

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
                                res = Console.ReadLine().ToUpper();
                                if (res == "F")
                                {
                                    buyingConsumable.ConsumibleMarket += Consu.OnBuy;
                                    buyingConsumable.Buying();
                                    cashMoney -= 48.20;
                                    inventario += "\nfungicida (cura)";
                                }
                                else if (res == "H")
                                {
                                    buyingConsumable.ConsumibleMarket += Consu.OnBuy1;
                                    buyingConsumable.Buying();
                                    cashMoney -= 80.24;
                                    inventario += "\nHerbicida (cura)";

                                }

                                else if (res == "P")
                                {
                                    buyingConsumable.ConsumibleMarket += Consu.OnBuy2;
                                    buyingConsumable.Buying();
                                    cashMoney -= 42.80;
                                    inventario += "\npesticida (cura)";
       
                                }

                                else if (res == "G")
                                {
                                    buyingConsumable.ConsumibleMarket += Consu.OnBuy3;
                                    buyingConsumable.Buying();
                                    cashMoney -= 28.40;
                                    inventario += "\nvacuna (cura)";
                          
                                }
                                else if (res == "A")
                                {
                                    buyingConsumable.ConsumibleMarket += Consu.OnBuy4;
                                    buyingConsumable.Buying();
                                    cashMoney -= 33.45;
                                    inventario += "\nFertilizante (alimento)";
                      
                                }
                                else if (res == "R")
                                {
                                    buyingConsumable.ConsumibleMarket += Consu.OnBuy5;
                                    buyingConsumable.Buying();
                                    cashMoney -= 56.31;
                                    inventario += "\nriego (alimento)";
                     
                                }
                                else if (res == "K")
                                {
                                    buyingConsumable.ConsumibleMarket += Consu.OnBuy6;
                                    buyingConsumable.Buying();
                                    cashMoney -= 44.96;
                                    inventario += "\nAlimento para animales (alimento)";
                          
                                }
                                else if (res == "T")
                                {
                                    buyingConsumable.ConsumibleMarket += Consu.OnBuy7;
                                    buyingConsumable.Buying();
                                    cashMoney -= 54.45;
                                    inventario += "\nAgua para animales (alimento)";
                          
                                }
                                else if (res == "V")
                                {
                                    Console.WriteLine(cashMoney);
                                    Console.WriteLine("a comprado en total lo siguientes productos:  ");
                                    Console.WriteLine(inventario);
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