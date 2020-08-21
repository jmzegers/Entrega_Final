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
        
        public MapCreator(bool YesRiver)
        {
            Terrain t = new Terrain();
            List<List<int>> rowList = t.RowListCreator();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Random randNum = new Random();
            int HoV = randNum.Next(0, 2);
            //0 es vertical, 1 es horizontal

            int farmPlaceX = randNum.Next(0, 8);
            farmPlaceX = farmPlaceX * 10;
            int farmPlaceY = randNum.Next(0, 7);
            farmPlaceY = farmPlaceY * 10;

            int firstCol = 0;

            if (HoV == 0)
            {
                bool a2 = true;
                while (a2 == true)
                {
                    firstCol = randNum.Next(0, 99);
                    if (firstCol >= farmPlaceX && firstCol <= farmPlaceX + 30)
                    {
                        firstCol = randNum.Next(0, 99);
                    }

                    else
                    {
                        a2 = false;
                    }
                }
            }
            else
            {
                firstCol = randNum.Next(0, 100);
                bool a2 = true;

                while (a2 == true)
                {
                    if (firstCol >= farmPlaceY && firstCol <= farmPlaceY + 20)
                    {
                        firstCol = randNum.Next(0, 100);
                    }
                    else
                    {
                        a2 = false;
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

                    if (YesRiver == true)
                    {
                        if (HoV == 0) //Vertical
                        {
                            if (b > firstCol && b < firstCol + 5)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else
                            {
                                DefaultColor();
                            }
                        }

                        else //Horizontal
                        {
                            if (a > firstCol && a < firstCol + 5)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else
                            {
                                DefaultColor();
                            }
                        }
                    }

                    if (a > farmPlaceY && a < farmPlaceY + 30)
                    {
                        if (b > farmPlaceX && b < farmPlaceX + 20)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }

                        else if (b > firstCol && b < firstCol + 5)
                        {
                            if(HoV == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            else
                            {
                                DefaultColor();
                            }
                        }

                        else
                        {
                            DefaultColor();
                        }
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