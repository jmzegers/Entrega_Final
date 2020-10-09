using entrega;
using entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class EdifMarket
    {

        FunctionBrain fb = new FunctionBrain();
        Ir_al_mercado_de_consumibles buyingConsumable = new Ir_al_mercado_de_consumibles();
        Ir_al_mercado_de_edificaciones DestSell = new Ir_al_mercado_de_edificaciones();
        CompraConsumible Consu = new CompraConsumible();
        VentaDestruir VD = new VentaDestruir();
        ObjectBrain ob = new ObjectBrain();
        string a = "X";
        double money = 0.0;
        //string a, double money, Dictionary<string, Dictionary<string, List<int>>> usedCoordinates

        public EdifMarket(string a, double money)
        {
            if (a == "P") //Plantacion
            {
                PlantationPurchase p = new PlantationPurchase();
                //string a, double money, Dictionary<string, Dictionary<string, List<int>>> usedCoordinates
            }

            else if (a == "G") //Ganado
            {
                CattlePurchase c = new CattlePurchase();
            }

            else if (a == "A")//Edificios de Almacenamiento
            {
                StoragePurchase s = new StoragePurchase();
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
        }
    }
}


