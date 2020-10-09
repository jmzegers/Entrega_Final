using entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_3_grupo_2_solo_seleccion_de_mapa_NO_diccionario
{
    class EdifMarket
    {
        public EdifMarket(string a, double money, Dictionary<string, Dictionary<string, List<int>>> usedCoordinates)
        {
            /*
            Ir_al_mercado_de_consumibles buyingConsumable = new Ir_al_mercado_de_consumibles();
            Ir_al_mercado_de_edificaciones DestSell = new Ir_al_mercado_de_edificaciones();
            CompraConsumible Consu = new CompraConsumible();
            VentaDestruir VD = new VentaDestruir();
            ObjectBrain ob = new ObjectBrain();
            if (a == "P") //Plantacion
            {
                PlantationPurchase p = new PlantationPurchase(string, double money, Dictionary<string, Dictionary<string, List<int>>> usedCoordinates);
            }

            else if (a == "G") //Ganado
            {
                Dictionary<string, Animal> animalDict = ob.GetAnimalDict();
                Console.WriteLine("Los ganados disponibles son: ");
                int prodNumber = 1;

                foreach (KeyValuePair<string, Animal> c in animalDict)
                {
                    string name = c.Key;
                    double price = c.Value.GetPurchasePrice();
                    Console.WriteLine(prodNumber + "." + name + "      " + price);
                    prodNumber += 1;
                }

                Console.WriteLine("¿Cual desea comprar? Escriba el nombre del producto");
                string prodName = Console.ReadLine();
                Animal cattleBought = ob.GetAnimalDict()["vacas"];

                try
                {
                    cattleBought = ob.GetAnimalDict()[prodName];
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
                    List<int> XCoord = new List<int>();
                    List<int> YCoord = new List<int>();
                    Console.WriteLine("Elija el lugar donde quiera poner el ganado [1 - 100]");
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
                            NewMapElement("G", cattleBought.GetName(), XCoord, YCoord);
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
                    List<int> XCoord = new List<int>();
                    List<int> YCoord = new List<int>();
                    Console.WriteLine("Elija el lugar donde quiera poner el edificio de almacenamiento [1 - 100]");
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
                            NewMapElement("P", storageBought.NameBuilding(), XCoord, YCoord);
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
        }*/

        }
    }
}


