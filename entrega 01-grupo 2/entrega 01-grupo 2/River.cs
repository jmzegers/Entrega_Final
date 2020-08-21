using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1
{
    class River
    {
        public River()
        {
            Random RandNum = new Random();
            int HoV = RandNum.Next(0, 2);
            //0 es vertical, 1 es horizontal

            int farmPlaceX = RandNum.Next(0, 8);
            int farmPlaceY = RandNum.Next(0, 7);

            if (HoV == 0)
            {
                bool a = true;
                while (a == true)
                {
                    int firstCol = RandNum.Next(0, 99);
                    if (firstCol == farmPlaceX || firstCol == farmPlaceX + 1)
                    {
                        firstCol = RandNum.Next(0, 99);
                    }

                    else
                    {
                        a = false;
                    }
                }
            }
            else
            {
                int firstCol = RandNum.Next(0, 100);
                bool a = true;

                while (a == true)
                {
                    if (firstCol == farmPlaceY || firstCol == farmPlaceY + 1 || firstCol == farmPlaceY + 2)
                    {
                        firstCol = RandNum.Next(0, 100);
                    }
                    else
                    {
                        a = false;
                    }
                }
            }




            if (HoV == 0)
            {

            }
        }
    }
}