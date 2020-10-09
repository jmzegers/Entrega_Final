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
            //Seed nuevaSeed = new Seed("nombre",);
            CompraConsumible Consu = new CompraConsumible();
            VentaDestruir VD = new VentaDestruir();
            List<string> Alimento = new List<string>();
            List<string> AliAnimales = new List<string>();
            AliAnimales.Add("zzz");
            List<string> AguAnimales = new List<string>();
            List<string> Cura = new List<string>();
            List<string> almacen = new List<string>() { "tomato", "letucce", "carrot", "potato", "corn", "onion", "celery" };
            Dictionary<string, (int, int)> ejemplo = new Dictionary<string, (int, int)>();
            Seed nuevaSeed = new Seed("nombre", 5, 1, 1, 1, 1, 4, 10, 25, 4, 1, 1, 1, 10, 1, 5, 1,0);
            Plantation nuevaPlantation = new Plantation("nombre", 5, "A", 1.5, 3, 2, false, 100, 100, 1);
            Cattle nuevoGanado = new Cattle("nombre", 2.5, "B", 30, 0.5, 0.2, 1, 1, 2, 1);
            StorageBuilding nuevoAlmacen = new StorageBuilding("nombre", 30, 10, 250, "C", 50);
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
            MapCreator mh = new MapCreator(true, true);

            while (true) //Aca se presentan mapas hasta que el jugador se decida por uno
            {
                List<bool> riverAndLake = b.RiverAndLake(); //Aqui hace la pregunta de cual es el tipo de mapa que desea,
                //guardando los valores como dos bools (si tiene rio o no y lo mismo con el lago)

                bool ar = riverAndLake[0]; //valor del bool del rio
                bool al = riverAndLake[1]; //valor del bool del lago
                mh = new MapCreator(ar, al);

                string answer = b.YesOrNo("Le gusta el mapa? [Y/N]");

                if (answer == "Y")
                {
                    break;
                }
            }
            Dictionary<string, Dictionary<string, List<int>>> usedCoordinates = mh.GetStaticCoord();

            double cashMoney = 50000;
            string inventario = "";
            Console.WriteLine("su monto inicial es:  " + cashMoney);
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");

            // aqui empieza lo que te piden de la entrega 3
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
                                    b.EdifMarket("P", cashMoney, usedCoordinates);
  
                                }
                                else if (answe == "G")
                                {
                                    b.EdifMarket("G", cashMoney, usedCoordinates);

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
                                   // b.EdifMarket("A", cashMoney, usedCoordinates);
                                    
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
                                           // DestSell.descision();
                                            DestSell.DestructionSell += VD.OnSellOrDestruction1;

                                            cashMoney -= (cashMoney * ((0.5) + (0.078 * 2)));
                                            Console.WriteLine("  dinero actual:  " + cashMoney);
                                            break;
                                        }
                                        else if (resp == "B")
                                        {
                                            Console.WriteLine("ha vendido el edificio");
                                            // DestSell.descision1();
                                            DestSell.DestructionSell += VD.OnSellOrDestruction;

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
                else if (ans == "P")
                {
                    if (ans == "P")
                    {
                        Console.WriteLine("\nse generando nuevos precios para las semillas");
                        variacion += 1;
                        Console.WriteLine("\nmadurando plantaciones/ganado");
                        maduracionPlanta += 1;
                        maduracionGanado += 1;
                        Console.WriteLine("\ncalculando nueva salud");

                        Console.WriteLine("\nCalculando nuevos niveles de nutrientes y agua");

                        Console.WriteLine("\nVerificando el desarrollo de maleza, gusano o enfermedad en las plantaciones");
                        if (verificandoMaleza == (probaMaleza * 0.01))
                        {
                            maleza = true;
                        }
                        else
                        {
                            maleza = false;
                        }
                        if (verificandoGusano == (probaGusano * 0.01))
                        {
                            gusano = true;
                        }
                        else
                        {
                            gusano = false;
                        }
                        if (verificandoEnfermedad == (probaEnfer * 0.01))
                        {
                            enfermedad = true;
                        }
                        else
                        {
                            enfermedad = false;
                        }
                        Console.WriteLine("\nverificando muerte o escape del ganado");
                        if (verificandoMuerte == (probaMuerte * 0.01))
                        {
                            muerte = true;
                            unidad -= 1;
                        }
                        else
                        {
                            muerte = false;
                        }
                        if (verificandoEscape == (probaEscape * 0.01))
                        {
                            escape = true;
                            unidad -= 1;
                        }
                        else
                        {
                            escape = false;
                        }
                        if (verificandoEnfermedadG == (probaEnfer * 0.01))
                        {
                            enfermedadG = true;
                        }
                        else
                        {
                            enfermedadG = false;
                        }
                        Console.WriteLine("\nrestando calidad a los productos");
                        calidad -= 1;
                        Console.ReadKey();
                    }
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