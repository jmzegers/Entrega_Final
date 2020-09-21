﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class FunctionBrain
    {
        ObjectBrain ob = new ObjectBrain();

        public FunctionBrain()
        {
            //priceHistory = this.priceHistory;
        }
        
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
                Console.WriteLine("Vender/Destruir un edificio [D]");
                Console.WriteLine("VOLVER [V]");
                Console.WriteLine(" ");
            }
            else if (a == 3)
            {
                Console.WriteLine("Bienvenid al Mercado de CONSUMIBLE");
                Console.WriteLine("\nque desea comprar: ");
                Console.WriteLine("Fungicida (cura) [F]");
                Console.WriteLine("herbicida (cura) [H]");
                Console.WriteLine("pesticida (cura) [P]");
                Console.WriteLine("Vacuna (cura) [G]");
                Console.WriteLine("Fertlizante (alimento) [A]");
                Console.WriteLine("riego (alimento) [R]");
                Console.WriteLine("Agua para animales (alimento) [K]");
                Console.WriteLine("Alimento para animales (alimento) [T]");
                Console.WriteLine("VOLVER [V]");
            }
            else
            {
                Console.WriteLine("No hay nada guardado en este numero");
            }
        }


        public double SeedValue(double currentValue, double priceVar, double basePrice) //Calculador del cambio de precio de un turno a otro
        {
            double maxPrice = basePrice * 1.1; //El precio maximo es el 110% del original
            double minPrice = basePrice * 0.9; //El precio minimo es el 90% del original
            currentValue = currentValue + priceVar;

            if (currentValue < minPrice || currentValue > maxPrice)
            {
                currentValue = basePrice;
            }

            return currentValue;
        }

        public Dictionary<string, Dictionary<int, double>> PriceHistoryMaker(int currentTurn)
        {
            Dictionary<string, Dictionary<int, double>> priceHistory = ob.GetPriceHistory();
            foreach (KeyValuePair<string, Seed> seed in ob.GetSeedDict())
            {
                Dictionary<int, double> seedHistory = new Dictionary<int, double>();
                string seedName = seed.Value.GetName();
                double basePrice = seed.Value.GetBaseSellingPrice();
                double priceVar = seed.Value.GetPriceVariation();
                int turn = 1;
                double currentVal = basePrice;

                while (turn <= currentTurn)
                {
                    currentVal = SeedValue(currentVal, priceVar, basePrice);
                    seedHistory.Add(turn, currentVal);
                    turn += 1;
                }

                priceHistory.Add(seedName, seedHistory);
            }

            return priceHistory;
        }


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
                catch(Exception e)
                {
                    Console.WriteLine("Ese producto no existe");
                }

                string n = seedBought.GetName();
                double seedValue = seedPrices[n];
                if(seedValue > money)
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

                foreach(KeyValuePair<string, Cattle> c in cattleDict)
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
                catch(Exception e)
                {
                    Console.WriteLine("Ese producto no existe");
                }

                double prodPrice = cattleBought.GetPurchasePrice();
                if(prodPrice > money)
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

                foreach(KeyValuePair<string, StorageBuilding> s in storageDict)
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
                catch(Exception e)
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
            
            else if (a == "D")
            {

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

    }
}
