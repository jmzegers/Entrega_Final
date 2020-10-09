using entrega;
using entrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_3_grupo_2_solo_seleccion_de_mapa_NO_diccionario
{
    class object_turns
    {
        List<string> Alimento = new List<string>();
        List<string> AliAnimales = new List<string>() { "zz" };
        List<string> AguAnimales = new List<string>();
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
        public void Tmensaje(int a)
        {
            if (a == 0)
            {
                Seed nuevaSeed = new Seed("nombre", 5, 1, 1, 1, 1, 4, 10, 25, 4, 1, 1, 1, 10, 1, 5,0);
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
            }
            
        }
    }
}
