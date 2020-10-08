using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class ObjectBrain
    {

        Dictionary<string, Seed> seedDict = new Dictionary<string, Seed>();
        Dictionary<string, Dictionary<int, double>> priceHistory = new Dictionary<string, Dictionary<int, double>>();
        //Hay que crear 7 semillas y dar sus valores
        /*Los valores de las semillas (en orden) son:
         * 1. Nombre
         * 2. Precio actual de compra
         * 3. Precio base de compra
         * 4. Consumo de agua por turno
         * 5. Nivel minimo de agua
         * 6. Penalizacion por falta de agua
         * 7. Tiempo de produccion (por turnos)
         * 8. Probabilidad de enfermedad
         * 9. Penalizacion por enfermedad
         * 10. Variacion de precio
         * 11. Consumo de nutrientes por turno
         * 12. Nivel minimo de nutrientes
         * 13. Penalizacion por falta de nutrientes
         * 14. Probabilidad de gusanos
         * 15. Penalizacion por gusanos
         * 16. Probabilidad de malezas
         * 17. Penalizacion por malezas
         */

        Seed Tomato = new Seed("Tomato", 4500, 4500, 2.5, 100, 1, 5, 10, 1, 1.05, 15, 1, 10, 10, 2, 5, 2);
        Seed Lettuce = new Seed("Lettuce", 4200, 4200, 2.8, 95, 1, 4, 10, 1, 1.02, 12, 1, 10, 10, 2, 7, 2);
        Seed Carrot = new Seed("Carrot", 1500, 1500, 1.8, 80, 1, 2, 6, 1, 1.02, 10, 1, 1, 3, 2, 5, 2);
        Seed Potato = new Seed("Potato", 2000, 2000, 0.8, 50, 1, 2, 8, 1, 1.01, 7, 1, 1, 12, 2, 12, 2);
        Seed Corn = new Seed("Corn", 2500, 2500, 1.2, 75, 1, 2, 10, 1, 1.04, 10, 1, 1, 7, 2, 15, 2);
        Seed Onion = new Seed("Onion", 3500, 3500, 1.2, 80, 1, 2, 10, 1, 1.04, 9, 1, 1, 5, 2, 15, 2);
        Seed Celery = new Seed("Celery", 4500, 4500, 1.8, 90, 1, 2, 10, 1, 1.05, 11, 1, 5, 10, 2, 15, 2);

        Dictionary<string, Animal> animalDict = new Dictionary<string, Animal>();
        //Tambien hay que crear 5 diferentes tipos de ganado con sus valores respectivos para rellenar este diccionario
        /*Los valores del ganado (en orden) son:
         * 1. Nombre
         * 2. Precio actual de compra
         * 3. Precio base de compra
         * 4. Consumo de agua por turno
         * 5. Nivel minimo de agua
         * 6. Penalizacion por falta de agua
         * 7. Tiempo de produccion (en turnos)
         * 8. Probabilidad de enfermedad
         * 9. Penalizacion por enfermedad
         * 10. Consumo de alimento por turno
         * 11. Nivel minimo de alimentos
         * 12. Penalizacion por falta de alimentos
         * 13. Unidades
         * 14. Probabilidad de escape
         * 15. Numero minimo del rango de escape
         * 16. Numero maximo del rango de escape
         * 17. Probabilidad de muerte subita
         * 18. Numero minimo del rango de muerte subita
         * 19. Numero maximo del rango de muerte subita
         */
        Animal Cow = new Animal("Cow", 7000, 7000, 16.2, 80, 2, 8, 15, 2, 15, 80, 2, 10, 5, 1, 10, 3, 1, 10);
        Animal Pig = new Animal("Pig", 6500, 7000, 12.0, 80, 2, 6, 12, 2, 13, 80, 2, 12, 5, 1, 10, 3, 1, 10);
        Animal Chicken = new Animal("Chicken", 4000, 4000, 5.0, 80, 6, 4, 15, 80, 4, 10, 2, 10, 5, 1, 10, 3, 1, 10);
        Animal Goat = new Animal("Goat", 4200, 4000, 8.5, 80, 2, 6, 8, 6, 11, 80, 2, 11, 5, 1, 10, 3, 1, 10);
        Animal Sheep = new Animal("Sheep", 4400, 4400, 8.8, 80, 2, 6, 9, 2, 12, 80, 2, 12, 5, 1, 10, 3, 1, 10);

        Dictionary<string, StorageBuilding> storageBuildingDict = new Dictionary<string, StorageBuilding>();
        StorageBuilding SmallStorageBuilding = new StorageBuilding("Small Storage Building", 100, 50, 500, "A");
        StorageBuilding MediumStorageBuilding = new StorageBuilding("Medium Storage Building", 200, 150, 1000, "B");
        StorageBuilding LargeStorageBuilding = new StorageBuilding("Large Storage Building", 400, 350, 2000, "C");

        Dictionary<string, List<int>> uc = new Dictionary<string, List<int>>();


        public ObjectBrain(Dictionary<string, List<int>> usedCoordinates = null)
        {
            seedDict.Add("Tomate", Tomato);
            seedDict.Add("Lechuga", Lettuce);
            seedDict.Add("Zanahoria", Carrot);
            seedDict.Add("Papa", Potato);
            seedDict.Add("Maíz", Corn);
            seedDict.Add("Cebolla", Onion);
            seedDict.Add("Apio", Celery);

            animalDict.Add("Vaca", Cow);
            animalDict.Add("Cerdo", Pig);
            animalDict.Add("Pollo", Chicken);
            animalDict.Add("Cabra", Goat);
            animalDict.Add("Oveja", Sheep);

            storageBuildingDict.Add("Edificio de Almacenamiento Pequeño", SmallStorageBuilding);
            storageBuildingDict.Add("Edificio de Almacenamiento Mediano", MediumStorageBuilding);
            storageBuildingDict.Add("Edificio de Almacenamiento Grande", LargeStorageBuilding);

            this.uc = usedCoordinates;
        }

        public Dictionary<string, Seed> GetSeedDict()
        {
            return seedDict;
        }

        public Dictionary<string, Dictionary<int, double>> GetPriceHistory()
        {
            return priceHistory;
        }

        public Dictionary<string, Animal> GetAnimalDict()
        {
            return animalDict;
        }

        public Dictionary<string, StorageBuilding> GetStorageBuildingDict()
        {
            return storageBuildingDict;
        }

        public Dictionary<string, List<int>> GetUsedCoordinates()
        {
            return uc;
        }

        List<string> SeedList = new List<string>()
        {
            "Tomate" + "precio de compra: 5" + "precio base: 5" + "consumo de nutrientes: 1"+"consumo de agua: 1"+
             "nivel minimo de nutrientes: 2"+" nivel minimo de agua: 10" + " 1, 1, 1, 1, 1, 10, 2, 15, 2", 
            "Lettuce" + "precio de compra: 5" + "precio base: 5" + "consumo de nutrientes: 1"+"consumo de agua: 1"+
             "nivel minimo de nutrientes: 2"+" nivel minimo de agua: 10" + " 1, 1, 1, 1, 1, 10, 2, 15, 2"
        };
    }



    /*
    while (a <= 9) //Siempre que este dentro del tamaño de tc
    {
        int b = 0;
        int num = 0;
        List<int> row = tc[b][num];


        while (b <= 9)
        {

            int columnNum = 0;
            int singleSquare = row[columnNum];

            // create River (crea rio)
            if (YesRiver == true)
            {
                if (HoV == 0) //Vertical
                {
                    if (num >= firstCol && num <= firstCol + 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;// para que se vean la pregunta de si se quiere generar otro
                                                                    // mapa
                    }
                    else
                    {
                        DefaultColor();
                    }
                }

                else //Horizontal
                {
                    if (a >= firstCol && a <= firstCol + 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;// para que se vean la pregunta de si se quiere generar otro
                                                                    // mapa
                    }
                    else
                    {
                        DefaultColor();
                    }
                }
            }

            if (YesLake == true) // Create Lake (crea lago)
            {
                if (a >= lakePlaceY && a <= lakePlaceY + 14)
                {
                    if (num >= lakePlaceX && num <= lakePlaceX + 14)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;// para que se vean la pregunta de si se quiere generar otro
                                                                    // mapa
                    }
                    else
                    {
                        DefaultColor();
                    }
                }
            }

            //Create Farm (crea granja)
            if (a >= farmPlaceY && a <= farmPlaceY + 29)
            {
                if (num >= farmPlaceX && num <= farmPlaceX + 19)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
            }
            num += 1;
        }
        Console.Write(row[num]);
        Console.Write(" ");
        Console.Write(Environment.NewLine);
        a += 1;
    }
    */

























}
