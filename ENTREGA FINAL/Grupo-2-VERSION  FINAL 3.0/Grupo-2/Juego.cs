using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Grupo_2
{
    public static class Juego// cerebro del programa
    {
        public static List<Seed> Lista_Semillas = new List<Seed>(); // lista de semillas que trae el juego
        public static List<Alimento> Lista_Alimetos = new List<Alimento>();// lista de alimentos diponibles que trae el juego
        public static List<Remedio> Lista_Remedios = new List<Remedio>();// lista de remedios y curas que trae el juego
        public static List<StorageBuilding> Lista_Almacenamiento = new List<StorageBuilding>();// lista de tipos de almacenamiento que trae el juego
        public static int turn;
        public static int day;
        //public static Dictionary<string, List<int>> Precios_Historicos_Semillas = new Dictionary<string, List<int>>();
        public static List<Animal> Animal_List = new List<Animal>();// lista de animales que trae el juego

        public static List<System.Windows.Forms.Button> Property_Coordinates = new List<System.Windows.Forms.Button>();

        public static List<Partida> PartidaList = new List<Partida>();



        public static List<string> Paso_de_turno()
        {
            /*Pasar de turno: Al pasar de turno, se deben realizar los siguientes cálculos:
             * • Generar los nuevos precios de las semillas: Este se calcula como el precio del turno anterior
             * +/- la variación de precio según corresponda.
             * • Madurar plantaciones/ganado en un punto.
             * • Para cada plantación/ganado calcular nueva salud: Se debe penalizar si el agua esta bajo
             * el nivel mínimo que exige el producto, si el alimento/nutrientes están bajo el nivel mínimo
             * que exige el producto y si la plantación/ganado estaba con alguna enfermedad y esta no
             * fue tratada en el turno anterior. La cantidad de puntos a penalizar depende de lo que
             * defina el producto según el enunciado 2.
             * • Para cada plantación/ganado calcular los nuevos niveles de nutrientes y agua según el
             * consumo del producto.
             * • Para cada plantación verificar si desarrollan Maleza, Gusanos o Enfermedad.
             * • Para cada ganado verificar si se produce un Escape o Muerte súbita (En dicho caso se
             * debe restar al numero de unidades la cantidad de animales que escaparon o que murieron).
             * A la vez se debe verificar si desarrollan alguna Enfermedad.
             * • Para cada elemento almacenado restar un punto de calidad.
            */

            PartidaList[0].Turn += 1;
            PartidaList[0].Day += 1;

            List<string> messages = new List<string>();

            // Generar los nuevos precios de las semillas
            foreach (Seed s in Lista_Semillas)
            {
                int price = s.PurchasePrice;
                int newPrice = Convert.ToInt32(Math.Round(Convert.ToDouble(price + s.PriceVarietyperturn)));
                int basePrice = s.BaseSellingPrice;
                if (newPrice < s.MinPrice * basePrice || newPrice > s.MaxPrice * basePrice)
                {
                    s.CurrentPrice = s.PurchasePrice;
                }
                else
                {
                    s.CurrentPrice = newPrice;
                }

                PartidaList[0].Precios_Historicos_Semillas[s.Name].Add(newPrice);
            }


            if(PartidaList[0].PlayerPlantation.Count() > 0)
            {
                foreach (Plantation p in PartidaList[0].PlayerPlantation)
                {
                    //Madurar plantaciones en un punto
                    p.Maturity += 1;

                    //Para cada plantación, generar nueva salud.
                    //Penalizar si tiene Enfermedad, Malezas o Gusanos.
                    if (p.Disease == true)
                    {
                        p.Health -= p.Semilla.DiseasePenalty;
                        string perdida = p.Semilla.DiseasePenalty.ToString();
                        messages.Add("La semilla " + p.Name + " está enferma y ha perdido " + perdida + "de vida.");
                    }

                    if (p.Weeds == true)
                    {
                        p.Health -= p.Semilla.WeedsPenalty;
                        string perdida = p.Semilla.WeedsPenalty.ToString();
                        messages.Add("La semilla " + p.Name + " tiene malezas y ha perdido " + perdida + "de vida.");
                    }

                    if (p.Worms == true)
                    {
                        p.Health -= p.Semilla.WormsPenalty;
                        string perdida = p.Semilla.WormsPenalty.ToString();
                        messages.Add("La plantación " + p.Name + " tiene gusanos y ha perdido " + perdida + "de vida.");
                    }

                    //Penalizar si el agua y los nutrientes están bajo el mínimo que pide el producto
                    double minWaterLevel = p.Semilla.MinWaterLv;
                    if (p.Water < minWaterLevel)
                    {
                        p.Health -= p.Semilla.WaterPenalty;
                        string perdida = p.Semilla.WaterPenalty.ToString();
                        messages.Add("La plantación " + p.Name + " no tiene suficiente agua y ha perdido " + perdida + " de vida.");
                    }

                    double minNutrientLevel = p.Semilla.MinFoodLv;
                    if (p.Nutrients < minNutrientLevel)
                    {
                        p.Health -= p.Semilla.FoodPenalty;
                        string perdida = p.Semilla.FoodPenalty.ToString();
                        messages.Add("La plantación " + p.Name + " no tiene suficiente fertilizante y ha perdido " + perdida + " de vida.");
                    }

                    //Para cada plantación, calcular los nuevos niveles de agua y nutrientes
                    //según su consumo.
                    double waterCons = p.Semilla.WaterConsumption;
                    p.Water -= waterCons;

                    double foodCons = p.Semilla.FoodConsumption;
                    p.Nutrients -= foodCons;

                    //Para cada plantación verificar si desarrollan Maleza, Gusanos o Enfermedad.
                    Random random = new Random();

                    /* Esta es mi manera de usar una probabilidad en C#.
                     * No sé cuál sería una mejor.
                     * Esto asume que la probabilidad puede llegar a tener un máximo
                     * de dos decimales.
                    */
                    double weedProb = p.Semilla.WeedsProbability;
                    int adjustedWeedProb = Convert.ToInt32(weedProb * 100);
                    int hasWeedNum = random.Next(1, 101);
                    if (hasWeedNum <= adjustedWeedProb)
                    {
                        p.Weeds = true;
                        messages.Add("La plantación " + p.Name + " ha adquirido malezas.");
                    }

                    double wormProb = p.Semilla.WormsProbability;
                    int adjustedWormProb = Convert.ToInt32(wormProb * 100);
                    int hasWormNum = random.Next(1, 101);
                    if (hasWormNum <= adjustedWormProb)
                    {
                        p.Worms = true;
                        messages.Add("La plantación " + p.Name + " ha adquirido gusanos.");
                    }

                    double diseaseProb = p.Semilla.DiseaseProbability;
                    int adjustedDiseaseProb = Convert.ToInt32(diseaseProb * 100);
                    int hasDiseaseNum = random.Next(1, 101);
                    if (hasDiseaseNum <= adjustedDiseaseProb)
                    {
                        p.Disease = true;
                        messages.Add("La plantación " + p.Name + " se ha enfermado.");
                    }


                    /* Sacar a las plantas de la lista de Plantaciones si estas 
                     * tienen Salud <= 0.
                    */

                    string health_left = p.Health.ToString();


                    if (p.Health <= 0)
                    {
                        PartidaList[0].PlayerPlantation.Remove(p);
                        List<int> coord = p.Coordinates;
                        messages.Add("Su plantación " + p.Name + " de " + p.Semilla.Name + " se ha muerto.");

                    }

                    else
                    {
                        messages.Add("A su plantación " + p.Name + " de " + p.Semilla.Name + " le queda " + health_left + " de vida");
                    }
                }

            }
            
            if(PartidaList[0].PlayerBoughtCattle.Count() > 0)
            {
                foreach (Cattle c in PartidaList[0].PlayerBoughtCattle)
                {

                    //Madurar ganado en un punto
                    c.Maturity += 1;

                    //Para cada ganado, generar una nueva salud.
                    //Penalizar si tiene Enfermedad.
                    if (c.Disease == true)
                    {
                        c.Health -= c.Animal.DiseasePenalty;
                        string perdida = c.Animal.DiseasePenalty.ToString();
                        messages.Add("Su ganado " + c.Name + " está enfermo y ha perdido " + perdida + " de vida.");
                    }

                    //Penalizar si el agua o los nutrientes están bajo el nivel mínimo
                    double minWaterLevel = c.Animal.MinWaterLv;
                    if (c.Water < minWaterLevel)
                    {
                        c.Health -= c.Animal.WaterPenalty;
                        string perdida = c.Animal.WaterPenalty.ToString();
                        messages.Add("Su ganado " + c.Name + " no tiene suficiente agua y ha perdido " + perdida + " de vida.");
                    }

                    double minNutrientLevel = c.Animal.MinFoodLv;
                    if (c.Food < minNutrientLevel)
                    {
                        c.Health -= c.Animal.FoodPenalty;
                        string perdida = c.Animal.FoodPenalty.ToString();
                        messages.Add("Su ganado " + c.Name + " no tiene suficiente agua y ha perdido " + perdida + " de vida.");
                    }

                    //Para cada ganado, calcular los nuevos niveles de agua y nutrientes
                    //según su consumo.
                    double waterCons = c.Animal.WaterConsumption;
                    c.Water -= waterCons;
                    double foodCons = c.Animal.FoodConsumption;
                    c.Food -= foodCons;

                    //• Para cada ganado verificar si se produce un Escape o Muerte súbita (En dicho caso se
                    // debe restar al numero de unidades la cantidad de animales que escaparon o que murieron).
                    // A la vez se debe verificar si desarrollan alguna Enfermedad.

                    /* Esta es mi manera de usar una probabilidad en C#.
                     * No sé cuál sería una mejor.
                     * Esto asume que la probabilidad puede llegar a tener un máximo
                     * de dos decimales.
                    */
                    Random random = new Random();

                    double escapeChance = c.Animal.Escapeprobability;
                    int adjustedEscapeChance = Convert.ToInt32(escapeChance * 100);
                    int hasEscapedNum = random.Next(1, 101);
                    if (hasEscapedNum <= adjustedEscapeChance)
                    {
                        int minEscape = c.Animal.Minangeleak;
                        int maxEscape = c.Animal.Maxrangeleak;
                        int escapedNum = random.Next(minEscape, maxEscape + 1);
                        c.Units -= escapedNum;
                        string num = escapedNum.ToString();
                        messages.Add("Se le ha escapado " + num + " unidades al ganado " + c.Name);
                    }

                    double deathChance = c.Animal.Deathprobability;
                    int adjustedDeathChance = Convert.ToInt32(deathChance * 100);
                    int hasDiedNum = random.Next(1, 101);
                    if (hasDiedNum <= adjustedDeathChance)
                    {
                        int minDeath = c.Animal.Minangedeath;
                        int maxDeath = c.Animal.Maxrangedeath;
                        int diedNum = random.Next(minDeath, maxDeath + 1);
                        c.Units -= diedNum;
                        messages.Add("Se le ha muerto " + diedNum.ToString() + " unidades al ganado " + c.Name);
                    }

                    double diseaseChance = c.Animal.DiseaseProbability;
                    int adjustedDiseaseChance = Convert.ToInt32(diseaseChance * 100);
                    int isSickNum = random.Next(1, 101);
                    if (isSickNum <= adjustedDiseaseChance)
                    {
                        c.Disease = true;
                        messages.Add("Se ha enfermado el ganado " + c.Name);
                    }

                    /* Sacar a los ganados de la lista de Ganados si estos cumplen una
                     * de las siguientes condiciones:
                     * 1. Tienen Health <= 0.
                     * 2. Tienen Units <= 0.
                     */

                    if (c.Health <= 0)
                    {
                        PartidaList[0].PlayerBoughtCattle.Remove(c);
                        List<int> coord = c.Coordinates;

                        messages.Add("Se le ha muerto por completo el ganado " + c.Name);
                    }

                    if (c.Units <= 0)
                    {
                        PartidaList[0].PlayerBoughtCattle.Remove(c);
                        List<int> coord = c.Coordinates;

                        messages.Add("Ya no le quedan unidades al ganado " + c.Name);

                    }
                    else
                    {
                        messages.Add("Le queda " + c.Units.ToString() + " unidades al ganado " + c.Name);
                    }

                }
            }

            if (PartidaList[0].playerBoughtStorage.Count() > 0)
            {
                // • Para cada elemento almacenado restar un punto de calidad.
                foreach (StorageBuilding storage in PartidaList[0].playerBoughtStorage)
                {
                    foreach (FinishedProduct edif in storage.ProductosGuardados)
                    {
                        if (edif.calidad <= 0)
                        {
                            messages.Add("Su producto almacenado " + edif.tipo.ToUpper() + " ha llegado al mínimo de calidad");
                        }
                        else
                        {
                            messages.Add("Su producto almacenado " + edif.tipo.ToUpper() + " ha perdido un punto de calidad");
                            edif.calidad -= 1;
                        }
                    }
                }
            }
           

            return messages;
        }


        public static void GuardarPartida()
        {
            string farmName = PartidaList[0].FarmName;
            string adjustedName = farmName + DateTime.Now.ToString();
            Partida.Almacenar_Partida(PartidaList, adjustedName);


            Alimento.Almacenar_Alimentos(PartidaList[0].PlayerAnimalFood, adjustedName);
            Alimento.Almacenar_Alimentos(PartidaList[0].PlayerFertilizerList, adjustedName);
            Alimento.Almacenar_Alimentos(PartidaList[0].PlayerAnimalWater, adjustedName);
            Alimento.Almacenar_Alimentos(PartidaList[0].PlayerPlantWater, adjustedName);
            Cattle.Almacenar_Ganado(PartidaList[0].PlayerBoughtCattle, adjustedName);
            Map.Almacenar_Mapa(PartidaList[0].Map, adjustedName);
            Plantation.Almacenar_Plantacion(PartidaList[0].PlayerPlantation, adjustedName);
            Remedio.Almacenar_Remedios(PartidaList[0].PlayerVaccines, adjustedName);
            Remedio.Almacenar_Remedios(PartidaList[0].PlayerFungicides, adjustedName);
            Remedio.Almacenar_Remedios(PartidaList[0].PlayerPesticides, adjustedName);
            Remedio.Almacenar_Remedios(PartidaList[0].PlayerHerbicides, adjustedName);
        }





        public static List<Alimento> CargarAlimentos()
        {
            BinaryFormatter alimentoFormatter = new BinaryFormatter();
            Stream alimentoStream = File.Open("Alimentos.bin", FileMode.Open);
            try
            {
                List<Alimento> saved_alimento = (List<Alimento>)alimentoFormatter.Deserialize(alimentoStream);
                alimentoStream.Close();
                return saved_alimento;
            }
            catch
            {
                List<Alimento> saved_alimento = new List<Alimento>();
                alimentoStream.Close();
                return saved_alimento;
            }
        }

        public static List<Animal> CargarAnimales()
        {
            BinaryFormatter animalFormatter = new BinaryFormatter();
            Stream animalStream = File.Open("Animales.bin", FileMode.OpenOrCreate);
            try
            {
                List<Animal> saved_animal = (List<Animal>)animalFormatter.Deserialize(animalStream);
                animalStream.Close();
                return saved_animal;
            }
            catch
            {
                List<Animal> saved_animal = new List<Animal>();
                animalStream.Close();
                return saved_animal;
            }
        }

        //Ganados.bin
        public static List<Cattle> CargarGanado()
        {
            BinaryFormatter cattleFormatter = new BinaryFormatter();
            Stream cattleStream = File.Open("Ganados.bin", FileMode.OpenOrCreate);
            try
            {
                List<Cattle> saved_cattle = (List<Cattle>)cattleFormatter.Deserialize(cattleStream);
                cattleStream.Close();
                return saved_cattle;
            }
            catch
            {
                List<Cattle> saved_cattle = new List<Cattle>();
                cattleStream.Close();
                return saved_cattle;
            }
        }

        //Partidas.bin
        public static List<Partida> CargarPartidas()
        {
            BinaryFormatter partidaFormatter = new BinaryFormatter();
            Stream partidaStream = File.Open("Partidas.bin", FileMode.OpenOrCreate);
            try
            {
                List<Partida> saved_partida = (List<Partida>)partidaFormatter.Deserialize(partidaStream);
                partidaStream.Close();
                return saved_partida;
            }
            catch
            {
                List<Partida> saved_partida = new List<Partida>();
                partidaStream.Close();
                return saved_partida;
            }
        }

        //Plantations.bin
        public static List<Plantation> CargarPlantations()
        {
            BinaryFormatter plantationFormatter = new BinaryFormatter();
            Stream plantationStream = File.Open("Plantations.bin", FileMode.OpenOrCreate);
            try
            {
                List<Plantation> saved_plantation =
                    (List<Plantation>)plantationFormatter.Deserialize(plantationStream);
                plantationStream.Close();
                return saved_plantation;
            }
            catch
            {
                List<Plantation> saved_plantation = new List<Plantation>();
                plantationStream.Close();
                return saved_plantation;
            }
        }

        //Products.bin
        public static List<Product> CargarProduct()
        {
            BinaryFormatter prodFormatter = new BinaryFormatter();
            Stream prodStream = File.Open("Products.bin", FileMode.OpenOrCreate);
            try
            {
                List<Product> saved_product = (List<Product>)prodFormatter.Deserialize(prodStream);
                prodStream.Close();
                return saved_product;
            }
            catch
            {
                List<Product> saved_product = new List<Product>();
                prodStream.Close();
                return saved_product;
            }
        }

        //Remedios.bin
        public static List<Remedio> CargarRemedio()
        {
            BinaryFormatter remedioFormatter = new BinaryFormatter();
            Stream remedioStream = File.Open("Remedios.bin", FileMode.OpenOrCreate);
            try
            {
                List<Remedio> saved_remedio =
                    (List<Remedio>)remedioFormatter.Deserialize(remedioStream);
                remedioStream.Close();
                return saved_remedio;
            }
            catch
            {
                List<Remedio> saved_remedio = new List<Remedio>();
                remedioStream.Close();
                return saved_remedio;
            }
        }

        //Semillas.bin
        public static List<Seed> CargarSemillas()
        {
            BinaryFormatter seedFormatter = new BinaryFormatter();
            Stream seedStream = File.Open("Semillas.bin", FileMode.OpenOrCreate);
            try
            {
                List<Seed> saved_seed =
                    (List<Seed>)seedFormatter.Deserialize(seedStream);
                seedStream.Close();
                return saved_seed;
            }
            catch
            {
                List<Seed> saved_seed = new List<Seed>();
                seedStream.Close();
                return saved_seed;
            }
        }

        //Almacenamientos.bin
        public static List<StorageBuilding> CargarAlmacenamiento()
        {
            BinaryFormatter storageFormatter = new BinaryFormatter();
            Stream storageStream = File.Open("Almacenamientos.bin", FileMode.OpenOrCreate);
            try
            {
                List<StorageBuilding> saved_storage =
                    (List<StorageBuilding>)storageFormatter.Deserialize(storageStream);
                storageStream.Close();
                return saved_storage;
            }
            catch
            {
                List<StorageBuilding> saved_storage = new List<StorageBuilding>();
                storageStream.Close();
                return saved_storage;
            }
        }

        //Terrains.bin
        public static List<Terrain> CargarTerrenos()
        {
            BinaryFormatter terrainFormatter = new BinaryFormatter();
            Stream terrainStream = File.Open("Terrains.bin", FileMode.OpenOrCreate);
            try
            {
                List<Terrain> saved_terrain =
                    (List<Terrain>)terrainFormatter.Deserialize(terrainStream);
                terrainStream.Close();
                return saved_terrain;
            }
            catch
            {
                List<Terrain> saved_terrain = new List<Terrain>();
                terrainStream.Close();
                return saved_terrain;
            }
        }

        public static Partida Cargar_Antigua_Partida()
        {
            /*
            Lista_Alimetos = CargarAlimentos();
            Lista_Almacenamiento = CargarAlmacenamiento();
            Animal_List = CargarAnimales();
            Cattle_List = CargarGanado();
            PartidaList = CargarPartidas();
            Plantation_List = CargarPlantations();
            Lista_Productos = CargarProduct();
            Lista_Remedios = CargarRemedio();
            Lista_Semillas = CargarSemillas();
            Lista_Terrenos = CargarTerrenos();
            */

            Partida antigua_partida = new Partida(CargarPartidas()[0].FarmName);
            antigua_partida.PlayerCash = CargarPartidas()[0].PlayerCash;
            antigua_partida.Turn = CargarPartidas()[0].Turn;
            antigua_partida.Day = CargarPartidas()[0].Day;
            antigua_partida.Precios_Historicos_Semillas =
                CargarPartidas()[0].Precios_Historicos_Semillas;

            antigua_partida.playerBoughtStorage = CargarAlmacenamiento();
            antigua_partida.PlayerBoughtCattle = CargarGanado();
            antigua_partida.PlayerPlantation = CargarPlantations();

            // 1-> fertilizante, 2-> riego, 3-> alimento animal, 4-> agua animal
            foreach (Alimento r in CargarAlimentos())
            {
                if (r.Type == 1)
                {
                    antigua_partida.PlayerFertilizerList.Add(r);
                }
                else if (r.Type == 2)
                {
                    antigua_partida.PlayerPlantWater.Add(r);
                }
                else if (r.Type == 3)
                {
                    antigua_partida.PlayerAnimalFood.Add(r);
                }
                else if (r.Type == 4)
                {
                    antigua_partida.PlayerAnimalWater.Add(r);
                }
            }

            // 5-> pesticida, 6-> herbicida, 7-> fungicida , 8-> vacuna
            foreach (Remedio r in CargarRemedio())
            {
                if (r.Type == 5)
                {
                    antigua_partida.PlayerPesticides.Add(r);
                }
                else if (r.Type == 6)
                {
                    antigua_partida.PlayerHerbicides.Add(r);
                }
                else if (r.Type == 7)
                {
                    antigua_partida.PlayerFungicides.Add(r);
                }
                else if (r.Type == 8)
                {
                    antigua_partida.PlayerVaccines.Add(r);
                }
            }

            antigua_partida.Player_Properties = CargarTerrenos();


            PartidaList.Insert(0, antigua_partida);
            return antigua_partida;
        }

        

    }
}
