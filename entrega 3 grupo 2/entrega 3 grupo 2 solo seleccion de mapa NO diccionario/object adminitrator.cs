using entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class object_adminitrator
    {
        List<string> Alimento = new List<string>();
        List<string> AliAnimales = new List<string>() { "zz" };
        List<string> AguAnimales = new List<string>();
        List<string> Cura = new List<string>();
        Seed nuevaSeed = new Seed("nombre", 5, 1, 1, 1, 1, 4, 10, 25, 4, 1, 1, 1, 10, 1, 5);
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
        public void Amensaje(int a)
        {
            if (a == 0)
            {
                Seed nuevaSeed = new Seed("nombre", 5, 1, 1, 1, 1, 4, 10, 25, 4, 1, 1, 1, 10, 1, 5);
                Plantation nuevaPlantation = new Plantation("nombre", 5, "A", 1.5, 3, 2, false, 100, 100, 1);
                Cattle nuevoGanado = new Cattle("nombre", 2.5, "B", 30, 0.5, 0.2, 1, 1, 2, 1);
                List<string> almacen = new List<string>() { "tomato", "letucce", "carrot", "potato", "corn", "onion", "celery" };
                Dictionary<string, (int, int)> ejemplo = new Dictionary<string, (int, int)>();
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
                                                    AliAnimales.Sort();
                                                    for (int i = 0; i < AliAnimales.Count; i++)
                                                    {

                                                        if (AliAnimales[i] == "Alimento para animales")
                                                        {
                                                            Console.WriteLine("Se ha usado un Alimento para animales");
                                                            Alimento.Remove("Alimento para animales");
                                                            AliAnimales.Remove("Alimento para animales");
                                                            break;
                                                        }

                                                        else
                                                        {
                                                            Console.WriteLine("no tiene Alimento para animales");
                                                            Console.WriteLine("\nDesea comprar un alimento para animales");
                                                            // buyingConsumable.ConsumibleMarket += Consu.OnBuy6;
                                                            // buyingConsumable.Buying();
                                                            // similar a lo que hay de en pasar turno

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
                                                                break;
                                                            }
                                                            break;
                                                        }
                                                    }
                                                }
                                                else if (mnb == "A")
                                                {
                                                    for (int i = 0; i < AguAnimales.Count; i++)
                                                    {
                                                        
                                                        if (AguAnimales[i] == "Agua para animales")
                                                        {
                                                            Console.WriteLine("Se ha usado un Agua para animales");
                                                            Alimento.Remove("Agua para animales");
                                                            break;
                                                        }
                                                    }
                                                }
                                                else if (mnb == "V")
                                                {
                                                    Console.WriteLine("VOLVIENDO");
                                                    foreach (String items in Alimento)
                                                    {
                                                        Console.WriteLine(items);
                                                    }
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
                                                    for (int i = 0; i < Alimento.Count; i++)
                                                    {
                                                        if (Alimento[i] == "Fertilizante")
                                                        {
                                                            Console.WriteLine("Se ha usado un Fertilizante");
                                                            Alimento.Remove("Fertilizante");
                                                            break;
                                                        }
                                                        else if (Alimento[i] != "Fertilizante")
                                                        {
                                                            Console.WriteLine("muestrar");
                                                        }
                                                    }
                                                }
                                                else if (ghj == "R")
                                                {
                                                    for (int i = 0; i < Alimento.Count; i++)
                                                    {
                                                        if (Alimento[i] == "Riego")
                                                        {
                                                            Console.WriteLine("Se ha usado un Riego");
                                                            Alimento.Remove("Riego");
                                                            break;
                                                        }
                                                    }
                                                }
                                                else if (ghj == "V")
                                                {
                                                    Console.WriteLine("volviendo");
                                                    foreach (String items in Alimento)
                                                    {
                                                        Console.WriteLine(items);
                                                    }
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
                                                    for (int i = 0; i < Cura.Count; i++)
                                                    {
                                                        if (Cura[i] == "Herbicida")
                                                        {
                                                            Console.WriteLine("Se ha usado un Herbicida");
                                                            Cura.Remove("Herbicida");
                                                            break;
                                                        }
                                                    }
                                                }
                                                else if (klp == "F")
                                                {
                                                    for (int i = 0; i < Cura.Count; i++)
                                                    {
                                                        if (Cura[i] == "Fungicida")
                                                        {
                                                            Console.WriteLine("Se ha usado un Fungicida");
                                                            Cura.Remove("Fungicida");
                                                            break;
                                                        }
                                                    }
                                                }
                                                else if (klp == "P")
                                                {
                                                    for (int i = 0; i < Cura.Count; i++)
                                                    {
                                                        if (Cura[i] == "Pesticida")
                                                        {
                                                            Console.WriteLine("Se ha usado un Pesticida");
                                                            Cura.Remove("Pesticida");
                                                            break;
                                                        }
                                                    }
                                                }
                                                else if (klp == "V")
                                                {
                                                    Console.WriteLine("Volviendo");
                                                    foreach (String items in Cura)
                                                    {
                                                        Console.WriteLine(items);
                                                    }
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
                                            for (int i = 0; i < Cura.Count; i++)
                                            {
                                                if (Cura[i] == "Vacuna")
                                                {
                                                    Console.WriteLine("Se ha usado un Vacuna");
                                                    Cura.Remove("Vacuna");
                                                    break;
                                                }
                                            }
                                        }
                                        else if (fgt == "V")
                                        {
                                            Console.WriteLine("VOLVIENDO");
                                            foreach (String items in Cura)
                                            {
                                                Console.WriteLine(items);
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ésa respuesta no es válida.");
                                        }
                                    }
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

                            }
                            break;
                        }
                        else if (admins == "A")
                        {
                            if (bodegasJugador >= 1 & productoAlmacenado == true)
                            {
                                Console.WriteLine("Tiene los siguientes productos almacenados");
                                for (int i = 0; i < almacen.Count; i++)
                                {
                                    Console.WriteLine(almacen[i]);
                                }
                                Console.WriteLine("¿desea vender uno de estos productos? [Y/N]");
                                // aqui se pondrian los diccionarios
                                while (true)
                                {
                                    vent = Console.ReadLine().ToUpper();
                                    if (vent == "Y")
                                    {
                                        Console.WriteLine("a vendido un producto");
                                        ganancia += (calidad * compraG);
                                        cashMoney += ganancia;
                                        break;
                                    }
                                    else if (vent == "N")
                                    {
                                        Console.WriteLine("no ha vendido nada");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("respuesta invalida");
                                    }
                                    ganancia = 0;
                                }

                            }
                            else
                            {
                                Console.WriteLine("no tiene bodega o no tiene productos almacenados");
                                break;
                            }
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
            }
            
        }
    }
}
