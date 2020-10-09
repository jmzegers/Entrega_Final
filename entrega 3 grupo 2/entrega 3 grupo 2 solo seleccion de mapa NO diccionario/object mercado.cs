using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class object_mercado
    {
        List<string> Alimento = new List<string>();
        List<string> AliAnimales = new List<string>() { "zz" };
        List<string> AguAnimales = new List<string>() { "zz" };
        List<string> fertil = new List<string>() { "zz" };
        List<string> riego = new List<string>() { "zz" };
        List<string> Cura = new List<string>();
        Seed nuevaSeed = new Seed("nombre", 5, 1, 1, 1, 1, 4, 10, 25, 4, 1, 1, 1, 10, 1, 5,0);
        Plantation nuevaPlantation = new Plantation("nombre", 5, "A", 1.5, 3, 2, false, 100, 100, 1);
        Cattle nuevoGanado = new Cattle("nombre", 2.5, "B", 30, 0.5, 0.2, 1, 1, 2, 1);
        StorageBuilding nuevoAlmacen = new StorageBuilding("nombre", 30, 10, 250, "C", 50);
        double cashMoney = 10000000;
        string inventario = "";
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
        String bod = "X";
        String vent = "X";
        public void Mmensaje(int a)
        {
            if (a == 0)
            {
                Seed nuevaSeed = new Seed("nombre", 5, 1, 1, 1, 1, 4, 10, 25, 4, 1, 1, 1, 10, 1, 5);
                Plantation nuevaPlantation = new Plantation("nombre", 5, "A", 1.5, 3, 2, false, 100, 100, 1);
                Cattle nuevoGanado = new Cattle("nombre", 2.5, "B", 30, 0.5, 0.2, 1, 1, 2, 1);
                List<string> almacen = new List<string>() { "tomato", "letucce", "carrot", "potato", "corn", "onion", "celery" };
                Dictionary<string, (int, int)> ejemplo = new Dictionary<string, (int, int)>();
                Ir_al_mercado_de_consumibles buyingConsumable = new Ir_al_mercado_de_consumibles();
                Ir_al_mercado_de_edificaciones DestSell = new Ir_al_mercado_de_edificaciones();
                CompraConsumible Consu = new CompraConsumible();
                VentaDestruir VD = new VentaDestruir();
                FunctionBrain b = new FunctionBrain();
                double variacion;
                int maduracionPlanta;
                int maduracionGanado;
                int verificandoMaleza;
                int verificandoGusano;
                int unidad;
                int calidad;
                double verificandoMuerte;
                double verificandoEscape;
                double verificandoEnfermedad;
                double verificandoEnfermedadG;
                double compraG;
                double compraP;
                bool enfermedad;
                bool enfermedadG;
                bool gusano;
                bool maleza;
                bool muerte;
                bool escape;
                int bodegasJugador;
                bool productoAlmacenado;
                var random = new Random();
                int probaMaleza = random.Next(0, 100);
                int probaGusano = random.Next(0, 100);
                double probaMuerte = random.Next(0, 100);
                double probaEscape = random.Next(0, 100);
                double probaEnfer = random.Next(0, 100);
                double ganancia;
                variacion = nuevaSeed.GetPriceVariation();
                maduracionPlanta = nuevaPlantation.GetMaturity();
                maduracionGanado = nuevoGanado.GetMaturity();
                verificandoMaleza = nuevaPlantation.GetWeedChance();
                verificandoGusano = nuevaPlantation.GetWormChance();
                verificandoEnfermedad = nuevaPlantation.GetDiseaseChance();
                verificandoEscape = nuevoGanado.GetScapeChance();
                verificandoMuerte = nuevoGanado.GetSuddenDeathChance();
                unidad = nuevoGanado.GetUnidad();
                verificandoEnfermedadG = nuevoGanado.GetDesease();
                calidad = nuevoAlmacen.GetQuality();
                compraG = nuevoGanado.GetPurchasePrice();
                compraP = nuevaPlantation.GetPurchasePrice();
                productoAlmacenado = true;
                enfermedad = false;
                gusano = false;
                maleza = false;
                muerte = false;
                escape = false;
                bodegasJugador = 0;
                ganancia = 0;
                if (a == 0)
                {
                    while (true)
                    {
                        b.Message(1);
                        answ = Console.ReadLine().ToUpper();
                        if (answ == "E")
                        {
                            b.Message(2);
                            answe = Console.ReadLine().ToUpper();
                            //Console.ReadKey();
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
                                    Console.WriteLine("Desea comprar un edificio de almacenamiento (bodegas) [Y/N]");

                                    while (true)
                                    {
                                        bod = Console.ReadLine().ToUpper();
                                        if (bod == "Y")
                                        {
                                            Console.WriteLine("a comprado una bodega");
                                            bodegasJugador += 1;
                                            cashMoney -= compraP;
                                            cashMoney -= compraG;
                                            break;
                                        }
                                        else if (bod == "N")
                                        {
                                            Console.WriteLine("no ha comprado nada");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("respuesta invalida");
                                        }
                                    }
                                    // b.EdifMarket("A", cashMoney);


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

                                            if (cashMoney < 33.45)
                                            {
                                                Console.WriteLine("... ESPERA, \nno tienes dinero suficiente vuelva mas tarde");
                                            }
                                            else if (cashMoney >= 33.45)
                                            {
                                                cashMoney -= 33.45;
                                                inventario += "\nFertilizante";
                                                Alimento.Add("Fertilizante");
                                                fertil.Add("Fertilizante");
                                            }


                                        }
                                        else if (res == "R")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy5;
                                            buyingConsumable.Buying();

                                            if (cashMoney < 56.31)
                                            {
                                                Console.WriteLine("... ESPERA, \nno tienes dinero suficiente vuelva mas tarde");
                                            }
                                            else if (cashMoney >= 56.31)
                                            {
                                                cashMoney -= 56.31;
                                                inventario += "\nriego";
                                                Alimento.Add("Riego");
                                                riego.Add("Riego");
                                            }


                                        }
                                        // se copio desde aca hasta 
                                        else if (res == "A")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy6;
                                            buyingConsumable.Buying();

                                            if (cashMoney < 44.96)
                                            {
                                                Console.WriteLine("... ESPERA, \nno tienes dinero suficiente vuelva mas tarde");
                                            }
                                            else if (cashMoney >= 44.96)
                                            {
                                                cashMoney -= 44.96;
                                                inventario += "\nAlimento para animales";
                                                Alimento.Add("Alimento para animales");
                                                AliAnimales.Add("Alimento para animales");
                                            }
                                            // hasta aca   

                                        }
                                        else if (res == "W")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy7;
                                            buyingConsumable.Buying();

                                            if (cashMoney < 54.45)
                                            {
                                                Console.WriteLine("... ESPERA, \nno tienes dinero suficiente vuelva mas tarde");

                                            }
                                            else if (cashMoney >= 54.45)
                                            {
                                                cashMoney -= 54.45;
                                                inventario += "\nAgua para animales";
                                                Alimento.Add("Agua para animales");
                                                AguAnimales.Add("Agua para animales");
                                            }


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
                                    break;
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

                                            if (cashMoney < 48.20)
                                            {
                                                Console.WriteLine("... ESPERA, \nno tienes dinero suficiente vuelva mas tarde");
                                            }
                                            else if (cashMoney >= 48.20)
                                            {
                                                cashMoney -= 48.20;
                                                inventario += "\nfungicida";
                                                Cura.Add("Fungicida");
                                            }

                                        }
                                        else if (res == "H")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy1;
                                            buyingConsumable.Buying();
                                            if (cashMoney < 80.24)
                                            {
                                                Console.WriteLine("... ESPERA, \nno tienes dinero suficiente vuelva mas tarde");
                                            }
                                            else if (cashMoney >= 80.24)
                                            {
                                                cashMoney -= 80.24;
                                                inventario += "\nHerbicida";
                                                Cura.Add("Herbicida");
                                            }

                                        }

                                        else if (res == "P")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy2;
                                            buyingConsumable.Buying();
                                            if (cashMoney < 42.80)
                                            {
                                                Console.WriteLine("... ESPERA, \nno tienes dinero suficiente vuelva mas tarde");
                                            }
                                            else if (cashMoney >= 42.80)
                                            {
                                                cashMoney -= 42.80;
                                                inventario += "\npesticida";
                                                Cura.Add("Pesticida");
                                            }

                                        }

                                        else if (res == "G")
                                        {
                                            buyingConsumable.ConsumibleMarket += Consu.OnBuy3;
                                            buyingConsumable.Buying();

                                            if (cashMoney < 28.40)
                                            {
                                                Console.WriteLine("... ESPERA, \nno tienes dinero suficiente vuelva mas tarde");
                                            }
                                            else if (cashMoney >= 28.40)
                                            {
                                                cashMoney -= 28.40;
                                                inventario += "\nvacuna";
                                                Cura.Add("Vacuna");
                                            }

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
                                    break;
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
            }
        }
    }
}
