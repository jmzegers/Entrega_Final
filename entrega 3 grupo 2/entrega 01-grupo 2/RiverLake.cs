using Entrega1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class MapCreator
    {
        public void DefaultColor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
        }


        public MapCreator(bool YesRiver, bool YesLake)
        {
            // Create Terrain (creacion del terreno)
            Terrain t = new Terrain();
            List<List<int>> rowList = t.RowListCreator();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Dictionary<string, int> coordinates = new Dictionary<string, int>();

            Random randNum = new Random();
            int HoV = randNum.Next(0, 2);
            //0 es vertical, 1 es horizontal

            int farmPlaceX = randNum.Next(0, 6);
            farmPlaceX = farmPlaceX * 10;
            int farmPlaceY = randNum.Next(0, 5);
            farmPlaceY = farmPlaceY * 10;

            int lakePlaceX = randNum.Next(6, 10);
            lakePlaceX = lakePlaceX * 10;
            int lakePlaceY = randNum.Next(5, 10);
            lakePlaceY = lakePlaceY * 10;

            int firstCol = 0;
            if (HoV == 0)
            {
                while (true)
                {
                    firstCol = randNum.Next(0, 99);
                    if (firstCol >= farmPlaceX && firstCol <= farmPlaceX + 30)
                    {
                        firstCol = randNum.Next(0, 99);
                    }

                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                firstCol = randNum.Next(0, 100);

                while (true)
                {
                    if (firstCol >= farmPlaceY && firstCol <= farmPlaceY + 20)
                    {
                        firstCol = randNum.Next(0, 100);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            int a = 0;

            while (a < rowList.Count)
            {
                List<int> row = rowList[a];
                int b = 0;
                while(b < row.Count)
                {
                    // create River (crea lago)
                    if (YesRiver == true)
                    {
                        if (HoV == 0) //Vertical
                        {
                            if (b > firstCol && b < firstCol + 6)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.White;// para que se vean la pregunta de si se quiere generar otro
                                                                                // mapa
                            }
                            else
                            {
                                DefaultColor();
                            }
                        }

                        else //Horizontal
                        {
                            if (a > firstCol && a < firstCol + 6)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.White;// para que se vean la pregunta de si se quiere generar otro
                                                                                // mapa
                            }
                            else
                            {
                                DefaultColor();
                            }
                        }
                    }
                    
                    
                    // Create Lake (crea lago)
                    if (YesLake == true)
                    {
                        while (true)
                        {
                            if (lakePlaceX >= farmPlaceX && lakePlaceX <= farmPlaceX + 30)
                            {
                                lakePlaceX = randNum.Next(6, 10);
                                lakePlaceX = lakePlaceX * 10;
                            }
                            else if (lakePlaceY >= farmPlaceY && lakePlaceY <= lakePlaceY + 20)
                            {
                                lakePlaceY = randNum.Next(5, 10);
                                lakePlaceY = lakePlaceY * 10;
                            }
                            else
                            {
                                if (YesRiver == true)
                                {
                                    if (HoV == 0)
                                    {
                                        if (lakePlaceX >= firstCol && lakePlaceX <= firstCol + 6)
                                        {
                                            lakePlaceX = randNum.Next(6, 10);
                                            lakePlaceX = lakePlaceX * 10;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        if (lakePlaceY >= firstCol && lakePlaceY <= firstCol + 6)
                                        {
                                            lakePlaceY = randNum.Next(5, 10);
                                            lakePlaceY = lakePlaceY * 10;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        


                        if (a >= lakePlaceY && a <= lakePlaceY + 15)
                        {
                            if (b >= lakePlaceX && b <= lakePlaceX + 15)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.White;// para que se vean la pregunta de si se quiere generar otro
                                                                             // mapa
                            }
                            else
                            {
                                DefaultColor();
                            }
                        }
                    }
                    //Create Farm (crea granja)
                    if (a >= farmPlaceY && a <= farmPlaceY + 30)
                    {
                        if (b >= farmPlaceX && b <= farmPlaceX + 20)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                    }
                    Console.Write(row[b]);
                    Console.Write(" ");

                    b += 1;


                }
                Console.Write(Environment.NewLine);
                a += 1;
            }

            coordinates.Add("FarmPlaceX", farmPlaceX);
            coordinates.Add("FarmPlaceY", farmPlaceY);
            coordinates.Add("LakePlaceX", lakePlaceX);
            coordinates.Add("LakePlaceY", lakePlaceY);
            coordinates.Add("River", firstCol);
        }
    }
}