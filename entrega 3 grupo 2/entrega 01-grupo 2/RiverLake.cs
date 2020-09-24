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

        public void UsedCoordinates()
        {

        }


        public MapCreator(bool YesRiver, bool YesLake)
        {
            // Create Terrain (creacion del terreno)
            Terrain t = new Terrain();
            ObjectBrain ob = new ObjectBrain();
            List<List<int>> rowList = t.RowListCreator();
            List<List<List<int>>> tc = t.TerrainCreator();

            DefaultColor();

            Dictionary<string, List<int>> coordinates = new Dictionary<string, List<int>>();

            Random randNum = new Random();
            int HoV = randNum.Next(0, 2);
            //0 es vertical, 1 es horizontal

            int farmPlaceX = randNum.Next(0, 9);
            farmPlaceX = farmPlaceX * 10;
            int farmPlaceY = randNum.Next(0, 8);
            farmPlaceY = farmPlaceY * 10;

            int lakePlaceX = randNum.Next(0, 85);
            int lakePlaceY = randNum.Next(0, 85);

            int firstCol = randNum.Next(0, 95);

            if (YesRiver == true) //En el caso de que haya un rio
            {
                if (HoV == 0) //rio vertical
                {
                    while (true) //Revisando que el potencial rio no caiga dentro de la granja
                    {
                        if (firstCol >= farmPlaceX && firstCol <= farmPlaceX + 19)
                        {
                            firstCol = randNum.Next(0, 96);
                        }

                        else
                        {
                            break;
                        }
                    }
                }
                else //rio horizontal
                {
                    while (true) //Lo mismo
                    {
                        if (firstCol >= farmPlaceY && firstCol <= farmPlaceY + 29)
                        {
                            firstCol = randNum.Next(0, 100);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            if (YesLake == true)
            {
                while (true)
                {
                    if (lakePlaceX >= farmPlaceX && lakePlaceX <= farmPlaceX + 19) //Revisando que el lago y la granja no queden en el mismo lugar horizontal
                    {
                        lakePlaceX = randNum.Next(1, 86);
                    }
                    else if (lakePlaceY >= farmPlaceY && lakePlaceY <= lakePlaceY + 29) //Revisando que el lago y la granja no queden en el mismo lugar vertical
                    {
                        lakePlaceY = randNum.Next(1, 86);
                    }
                    else
                    {
                        if (YesRiver == true)
                        {
                            if (HoV == 0) //Rio vertical
                            {
                                if (firstCol >= lakePlaceX && firstCol <= lakePlaceX + 14)
                                {
                                    lakePlaceX = randNum.Next(1, 86);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else //Rio horizontal
                            {
                                if (firstCol >= lakePlaceY && firstCol <= lakePlaceY + 14)
                                {
                                    lakePlaceY = randNum.Next(1, 86);
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
            }









            int a = 0;
            int PositionY = 1;
            while (a <= 9)
            {
                int b = 0;
                int PositionX = 1;

                while (b <= 9)
                {
                    List<int> matrixRow = tc[b][a];
                    int c = 0;
                    while (c <= 9)
                    {
                        if (YesRiver == true) // Creando el rio
                        {
                            if (HoV == 0) //Rio vertical
                            {
                                if (PositionX >= firstCol && PositionX <= firstCol + 4)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                    Console.Write(matrixRow[c]);
                                    Console.Write(" ");
                                    PositionX += 1;
                                    c += 1;
                                }
                                else
                                {
                                    DefaultColor();
                                }
                            }
                            else //Rio horizontal
                            {
                                if (PositionY >= firstCol && PositionY <= firstCol + 4)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                    Console.Write(matrixRow[c]);
                                    Console.Write(" ");
                                    PositionX += 1;
                                    c += 1;
                                }
                                else
                                {
                                    DefaultColor();
                                }
                            }
                        }

                        if (YesLake == true)
                        {
                            if (PositionX >= lakePlaceX && PositionX <= lakePlaceX + 14)
                            {
                                if (PositionY >= lakePlaceY && PositionX <= lakePlaceY + 14)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                    Console.Write(matrixRow[c]);
                                    Console.Write(" ");
                                    PositionX += 1;
                                    c += 1;
                                }
                            }
                            else
                            {
                                DefaultColor();
                            }
                        }

                        if (PositionX >= farmPlaceX && PositionX <= farmPlaceX + 19)
                        {
                            if (PositionY >= farmPlaceY && PositionY <= farmPlaceY + 29)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                Console.Write(matrixRow[c]);
                                Console.Write(" ");
                                PositionX += 1;
                                c += 1;
                            }
                            else
                            {
                                DefaultColor();
                            }
                        }

                        Console.Write(matrixRow[c]);
                        Console.Write(" ");
                        PositionX += 0;
                        c += 1;
                    }

                    PositionY += 1;
                    b += 1;

                }

                Console.Write(Environment.NewLine);
                a += 1;
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

            List<int> farmCoordX = new List<int>();
            farmCoordX.Add(farmPlaceX);
            farmCoordX.Add(farmPlaceX + 19);
            List<int> farmCoordY = new List<int>();
            farmCoordY.Add(farmPlaceY);
            farmCoordY.Add(farmPlaceY + 29);
            List<int> lakeCoordX = new List<int>();
            lakeCoordX.Add(lakePlaceX);
            lakeCoordX.Add(lakePlaceX + 14);
            List<int> lakeCoordY = new List<int>();
            lakeCoordY.Add(lakePlaceY);
            lakeCoordY.Add(lakePlaceY + 14);
            List<int> riverCoordX = new List<int>();
            List<int> riverCoordY = new List<int>();


            coordinates.Add("FarmPlaceX", farmCoordX);
            ob.GetUsedCoordinates().Add("FarmPlaceX", farmCoordX);
            coordinates.Add("FarmPlaceY", farmCoordY);
            ob.GetUsedCoordinates().Add("FarmPlaceY", farmCoordY);
            coordinates.Add("LakePlaceX", lakeCoordX);
            ob.GetUsedCoordinates().Add("LakePlaceX", lakeCoordX);
            coordinates.Add("LakePlaceY", lakeCoordY);
            ob.GetUsedCoordinates().Add("LakePlaceY", lakeCoordY);

            if (HoV == 0) //Vertical
            {
                riverCoordY.Add(firstCol);
                riverCoordY.Add(firstCol + 4);
                coordinates.Add("RiverPlaceY", riverCoordY);
                ob.GetUsedCoordinates().Add("RiverPlaceY", riverCoordY);
            }
            else //Horizontal
            {
                riverCoordX.Add(firstCol);
                riverCoordX.Add(firstCol + 4);
                coordinates.Add("RiverPlaceX", riverCoordX);
                ob.GetUsedCoordinates().Add("RiverPlaceX", riverCoordX);
            }
        }
    }
}