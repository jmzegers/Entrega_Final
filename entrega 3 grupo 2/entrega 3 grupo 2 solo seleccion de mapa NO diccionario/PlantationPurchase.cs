using entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_3_grupo_2_solo_seleccion_de_mapa_NO_diccionario
{
    class PlantationPurchase
    {
        public PlantationPurchase(string a, double money, double money1, Dictionary<string, Dictionary<string, List<int>>> usedCoordinates)
        {
            /*
            FunctionBrain fb = new FunctionBrain();
            ObjectBrain ob = new ObjectBrain();
            int turn = 30;
            Dictionary<string, double> seedPrices = new Dictionary<string, double>();
            Dictionary<string, Dictionary<int, double>> seedHistory = ob.PriceHistoryMaker(turn);

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
            else //Si llega aca, entonces la compra fue exitosa
            {
                money = money - seedValue;
                List<int> XCoord = new List<int>();
                List<int> YCoord = new List<int>();
                Console.WriteLine("Elija el lugar donde quiera poner la plantacion [1 - 100]");
                Console.WriteLine("Eje X: ");
                while (true)
                {
                    try
                    {
                        int EjeX = Convert.ToInt32(Console.ReadLine());
                        XCoord.Add(EjeX);
                        XCoord.Add(EjeX);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Debe ser un numero");
                    }
                }
                Console.WriteLine("Eje Y: ");
                while (true)
                {
                    try
                    {
                        int EjeY = Convert.ToInt32(Console.ReadLine());
                        YCoord.Add(EjeY);
                        YCoord.Add(EjeY);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Debe ser un numero");
                    }
                }


                while (true)
                {
                    if (CheckIfUsedCoord(usedCoordinates, XCoord, YCoord) == false)
                    {
                        NewMapElement("P", seedBought.GetName(), XCoord, YCoord);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ese lugar no esta disponible");
                        Console.WriteLine("Intente nuevamente");
                    }
                }

            }
        }

        public PlantationPurchase(string a, double money, double money1, Dictionary<string, Dictionary<string, List<int>>> usedCoordinates, Dictionary<string, Dictionary<string, List<int>>> usedCoordinates1) : this(a, money, money1, usedCoordinates)
        {
        }*/
        }
    }
}
