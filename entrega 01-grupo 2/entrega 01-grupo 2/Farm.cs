using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1
{



    class Farm
    {
        public Farm(int farmPlaceX, int farmPlaceY)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Random randNum = new Random();

            Terrain t = new Terrain();
            List<List<int>> rowList = t.RowListCreator();

            int firstRowNum = farmPlaceX * 10;
            int lastRowNum = firstRowNum + 29;
            int firstColNum = farmPlaceY * 10;
            int lastColNum = firstColNum + 19;

            int a = 0;
            while (a < rowList.Count)
            {
                List<int> row = rowList[a];
                int b = 0;

                while (b < row.Count)
                {
                    if (a >= firstRowNum && a <= lastRowNum)
                    {
                        if (b >= firstColNum && b <= lastColNum)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }

                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write(row[b]);
                    Console.Write(" ");
                    b += 1;
                }

                Console.Write(Environment.NewLine);
                a += 1;
            }
        }
    }
}