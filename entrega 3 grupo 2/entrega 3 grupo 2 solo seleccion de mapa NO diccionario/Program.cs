using entrega;
using entrega;
using entrega_3_grupo_2_solo_seleccion_de_mapa_NO_diccionario;
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
            object_adminitrator k = new object_adminitrator();
            object_turns t = new object_turns();
            object_mercado m = new object_mercado();
            Console.WriteLine("Bienvenido a Farm Life Simulator");
            Console.WriteLine();
            Ir_al_mercado_de_consumibles buyingConsumable = new Ir_al_mercado_de_consumibles();
            Ir_al_mercado_de_edificaciones DestSell = new Ir_al_mercado_de_edificaciones();
            CompraConsumible Consu = new CompraConsumible();
            VentaDestruir VD = new VentaDestruir();
            List<string> Alimento = new List<string>();
            List<string> AliAnimales = new List<string>();
            AliAnimales.Add("zzz");
            List<string> AguAnimales = new List<string>();
            List<string> Cura = new List<string>();
            List<string> almacen = new List<string>() { "tomato", "letucce", "carrot", "potato", "corn", "onion", "celery" };
            Dictionary<string, (int, int)> ejemplo = new Dictionary<string, (int, int)>();
            Seed nuevaSeed = new Seed("nombre", 5, 1, 1, 1, 1, 4, 10, 25, 4, 1, 1, 1, 10, 1, 5, 1, 10);
            Plantation nuevaPlantation = new Plantation("nombre", 5, "A", 1.5, 3, 2, false, 100, 100,1);
            Cattle nuevoGanado = new Cattle("nombre", 2.5, "B", 30, 0.5, 0.2, 1, 1, 2,1);
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
            // agregar lista con las plantaciones y ganados para que el jugador pueda elegir, esto simulara lel almacen
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
            Console.WriteLine("\nCrear nuevo juego [N]");
            Console.WriteLine("Cargar nuevo juego [C]");

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

            double cashMoney = 10000000;
            string inventario = "";
            Console.WriteLine("su monto inicial es:  " + cashMoney);
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");



            while (true)
            {
                b.Message(0);
                Console.WriteLine("\nsu monto actual es de:  " + cashMoney);
                ans = Console.ReadLine().ToUpper();
                if (ans == "M")
                {
                    m.Mmensaje(0);
                }

                else if (ans == "A")
                {
                    k.Amensaje(0);
                }
                
                else if (ans == "P")
                {
                    t.Tmensaje(0);
                }
                else if (ans == "G")
                {
                    // aqui se pondra la opcion de guardar partida
                }
                else
                {
                    Console.WriteLine("Ésa respuesta no es válida.");
                }
            }

        }

    }
}
