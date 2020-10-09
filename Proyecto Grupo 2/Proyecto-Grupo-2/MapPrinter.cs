using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class MapPrinter
    {
        
        public MapPrinter(List<List<List<string>>> tc, Dictionary<string, Dictionary<string, List<int>>> staticCoord, 
            Dictionary<string, Dictionary<string, List<int>>> newCoord, string letter, ConsoleColor color, bool YesLake, bool YesRiver)
        {
            int a = 0;
            int PositionY = 1;

            Dictionary<string, List<int>> farmCoord = staticCoord["Farm"];
            List<int> farmCoordX = farmCoord["X"];
            List<int> farmCoordY = farmCoord["Y"];

            Dictionary<string, List<int>> lakeCoord;
            List<int> lakeCoordX = new List<int>();
            List<int> lakeCoordY = new List<int>();

            Dictionary<string, List<int>> riverCoord;
            List<int> riverCoordX = new List<int>();
            List<int> riverCoordY = new List<int>();


            if (YesLake == true)
            {
                lakeCoord = staticCoord["Lake"];
                lakeCoordX = lakeCoord["X"];
                lakeCoordY = lakeCoord["Y"];
            }

            if (YesRiver == true)
            {
                riverCoord = staticCoord["River"];
                riverCoordX = riverCoord["X"];
                riverCoordY = riverCoord["Y"];
            }

            while(a <= 9)
            {
                int b = 0;
                int PositionX = 1;

                while (b <= 9)
                {
                    List<string> matrixRow = tc[b][a];
                    int c = 0;
                    while (c <= 9)
                    {
                        if (YesRiver == true)
                        {
                            if (PositionX >= riverCoordX[0] && PositionX <= riverCoordX[1])
                            {
                                if (PositionY >= riverCoordY[0] && PositionY <= riverCoordY[1])
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
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                        }

                        if (YesLake == true)
                        {
                            if (PositionX >= lakeCoordX[0] && PositionX <= lakeCoordX[1])
                            {
                                if (PositionY >= lakeCoordY[0] && PositionY <= lakeCoordY[1])
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
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                        }

                        if (PositionX >= farmCoordX[0] && PositionX <= farmCoordX[1])
                        {
                            if (PositionY >= farmCoordY[0] && PositionY <= farmCoordY[1])
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
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                        }

                        foreach(KeyValuePair<string, Dictionary<string, List<int>>> coord in newCoord)
                        {
                            List<int> xCoord = coord.Value["X"];
                            List<int> yCoord = coord.Value["Y"];

                            if (PositionX >= xCoord[0] && PositionX <= xCoord[1])
                            {
                                if (PositionY >= yCoord[0] && PositionY <= yCoord[1])
                                {
                                    Console.BackgroundColor = color;
                                    Console.ForegroundColor = ConsoleColor.Black;

                                    Console.Write(letter + letter);
                                    Console.Write(" ");
                                    PositionX += 1;
                                    c += 1;
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }
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
        }
    }
}
