﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class FunctionBrain
    {
        ObjectBrain ob = new ObjectBrain();
        Ir_al_mercado_de_consumibles buyingConsumable = new Ir_al_mercado_de_consumibles();
        CompraConsumible Consu = new CompraConsumible();

        public FunctionBrain()
        {
            //priceHistory = this.priceHistory;
        }

        int answer3 = 0;
        List<int> ansList = new List<int>() { 1, 2, 3, 4 };
        public int MapDecision()
        {
            while (true)
            {

                //Messages m = new Messages(5);

                Messages m = new Messages(6);

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


            Messages m = new Messages(a);
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
                Console.WriteLine("desea comprar un objeto: [C]");
                Console.WriteLine("desea usar de su stock: [S]");
            }
            else
            {
                Console.WriteLine("No hay nada guardado en este numero");
            }

            //Messages m = new Messages(a);

        }

        //PriceHistoryMaker phm = new PriceHistoryMaker();
       /* public double SeedValue(double currentValue, double priceVar, double basePrice) //Calculador del cambio de precio de un turno a otro
        {
            double s = phm.SeedValue(currentValue, priceVar, basePrice);

            return s;
        }

        public Dictionary<string, Dictionary<int, double>> PriceHistoryMaker(int currentTurn)
        {
            Dictionary<string, Dictionary<int, double>> d = phm.PriceHistory(currentTurn);

            return d;
        }
       
        public double EdifMarket(string a, double money)
        {
            EdifMarket e = new EdifMarket(a, money);
            
            return money;
        }
*/

        /*
        public double EdifMarket(string a, double money)
        {
            if (a == "P") //Plantacion
            {
                int turn = 30;
                Dictionary<string, double> seedPrices = new Dictionary<string, double>();
                Dictionary<string, Dictionary<int, double>> seedHistory = PriceHistoryMaker(turn);

                foreach (KeyValuePair<string, Seed> seed in ob.GetSeedDict())
                {
                    string seedName = seed.Value.GetName();
                    double seedPrice = seedHistory[seedName][turn + 1];
                    seedPrices.Add(seedName, seedPrice);
                }

                foreach(KeyValuePair<string, double> i in seedPrices)
                {
                    Console.WriteLine(" Key: " + i.Key + " Value: " + i.Value);
                }

                int prodNum = 1;
                Console.WriteLine("Las semillas disponibles y sus precios son: ");
                foreach (KeyValuePair<string, double> priceList in seedPrices)
                {
                    Console.WriteLine(prodNum + "." + "{0}:, {1}", priceList.Key + "       " + priceList.Value);
                    prodNum += 1;
                }

                Console.WriteLine(" ");
                Console.WriteLine("¿Cual desea comprar? Escriba el nombre del producto");

                string productName = Console.ReadLine();
                Seed seedBought = ob.GetSeedDict()["tomate"];

                try
                {
                    seedBought = ob.GetSeedDict()[productName];
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ese producto no existe");
                }

                string n = seedBought.GetName();
                double seedValue = seedPrices[n];
                if (seedValue > money)
                {
                    Console.WriteLine("No tienes suficiente dinero");
                }
                else
                {
                    money = money - seedValue;
                    //Aca hay que añadirle el producto al inventario del jugador
                }
            }

            else if (a == "G") //Ganado
            {
                Dictionary<string, Cattle> cattleDict = ob.GetCattleDict();
                Console.WriteLine("Los ganados disponibles son: ");
                int prodNumber = 1;

                foreach (KeyValuePair<string, Cattle> c in cattleDict)
                {
                    string name = c.Key;
                    double price = c.Value.GetPurchasePrice();
                    Console.WriteLine(prodNumber + "." + name + "      " + price);
                    prodNumber += 1;
                }

                Console.WriteLine("¿Cual desea comprar? Escriba el nombre del producto");
                string prodName = Console.ReadLine();
                Cattle cattleBought = ob.GetCattleDict()["vacas"];

                try
                {
                    cattleBought = ob.GetCattleDict()[prodName];
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ese producto no existe");
                }

                double prodPrice = cattleBought.GetPurchasePrice();
                if (prodPrice > money)
                {
                    Console.WriteLine("No tienes suficiente dinero");
                }
                else
                {
                    money = money - prodPrice;
                    //Aca hay que añadirle el producto al inventario del jugador
                }


            }

            else if (a == "A")//Edificios de Almacenamiento
            {
                Dictionary<string, StorageBuilding> storageDict = ob.GetStorageBuildingDict();
                Console.WriteLine("Los edificios de almacenamiento disponibles son: ");
                int prodNumber = 1;

                foreach (KeyValuePair<string, StorageBuilding> s in storageDict)
                {
                    string name = s.Key;
                    double price = s.Value.GetPurchasePrice();
                    Console.WriteLine(prodNumber + "." + name + "      " + price);
                    prodNumber += 1;
                }

                Console.WriteLine("¿Cual desea comprar? Escriba el nombre del producto");
                string prodName = Console.ReadLine();

                StorageBuilding storageBought = ob.GetStorageBuildingDict()["Z"];

                try
                {
                    storageBought = ob.GetStorageBuildingDict()[prodName];
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ese producto no existe");
                }

                double prodPrice = storageBought.GetPurchasePrice();
                if (prodPrice > money)
                {
                    Console.WriteLine("No tienes suficiente dinero");
                }
                else
                {
                    money = money - prodPrice;
                    //Aca hay que añadirle el producto al inventario del jugador
                }
            }

            else if (a == "C")
            {
                Console.WriteLine("Los productos consumibles son: ");
                string inventario = "";

                while (true)
                {
                    string res = Console.ReadLine().ToUpper();
                    if (res == "F")
                    {
                        buyingConsumable.ConsumibleMarket += Consu.OnBuy;
                        buyingConsumable.Buying();
                        money -= 48.20;
                        inventario += "\nfungicida (cura)";
                    }
                    else if (res == "H")
                    {
                        buyingConsumable.ConsumibleMarket += Consu.OnBuy1;
                        buyingConsumable.Buying();
                        money -= 80.24;
                        inventario += "\nHerbicida (cura)";

                    }

                    else if (res == "P")
                    {
                        buyingConsumable.ConsumibleMarket += Consu.OnBuy2;
                        buyingConsumable.Buying();
                        money -= 42.80;
                        inventario += "\npesticida (cura)";

                    }

                    else if (res == "G")
                    {
                        buyingConsumable.ConsumibleMarket += Consu.OnBuy3;
                        buyingConsumable.Buying();
                        money -= 28.40;
                        inventario += "\nvacuna (cura)";

                    }
                    else if (res == "A")
                    {
                        buyingConsumable.ConsumibleMarket += Consu.OnBuy4;
                        buyingConsumable.Buying();
                        money -= 33.45;
                        inventario += "\nFertilizante (alimento)";

                    }
                    else if (res == "R")
                    {
                        buyingConsumable.ConsumibleMarket += Consu.OnBuy5;
                        buyingConsumable.Buying();
                        money -= 56.31;
                        inventario += "\nriego (alimento)";

                    }
                    else if (res == "K")
                    {
                        buyingConsumable.ConsumibleMarket += Consu.OnBuy6;
                        buyingConsumable.Buying();
                        money -= 44.96;
                        inventario += "\nAlimento para animales (alimento)";

                    }
                    else if (res == "T")
                    {
                        buyingConsumable.ConsumibleMarket += Consu.OnBuy7;
                        buyingConsumable.Buying();
                        money -= 54.45;
                        inventario += "\nAgua para animales (alimento)";

                    }
                    else if (res == "V")
                    {
                        Console.WriteLine(money);
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

            else if (a == "V")
            {

            }

            else
            {
                Console.WriteLine("El comando para esta letra no existe");
            }

            return money;
        }
        */
    }
}
