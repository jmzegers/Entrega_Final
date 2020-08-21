using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Entrega1
{
    class Terrain
    {

        public List<List<int>> RandMatrix(int min, int max)
        {
            int i = 0;
            Random randNum = new Random();

            List<List<int>> matrixList = new List<List<int>>();

            while (i < 10)
            {
                int j = 0;
                List<int> rowList = new List<int>();
                while (j < 10)
                {
                    int num = randNum.Next(min, max);
                    rowList.Add(num);
                    j += 1;
                }

                matrixList.Add(rowList);
                i += 1;
            }

            return matrixList;
        }


        public List<List<int>> MatrixCreator(int num)
        {
            List<List<int>> mat = new List<List<int>>();
            int j = 0;

            while (j < 10)
            {
                int i = 0;
                List<int> rowList = new List<int>();
                while (i < 10)
                {
                    rowList.Add(num);
                    i += 1;
                }

                mat.Add(rowList);
                j += 1;
            }

            return mat;
        }


        public void LinePrinter(List<List<List<int>>> map, int matNumber, int rowNumber)
        {
            List<int> list1 = map[matNumber][rowNumber];
            int rowNum = 0;

            while (rowNum < list1.Count)
            {
                Console.Write(list1[rowNum]);
                Console.Write(" ");
                rowNum += 1;
            }
        }


        public void RowPrinter(List<List<List<int>>> map, int start, int end)
        {
            int a = 0;
            while (a < 10)
            {
                int b = start;

                while (b < end)
                {
                    LinePrinter(map, b, a);
                    b += 1;
                }
                Console.Write(Environment.NewLine);
                a += 1;
            }
        }


        public List<List<int>> RowListCreator()
        {
            List<List<int>> rowList = new List<List<int>>();

            foreach (List<int> l in RandMatrix(25, 100))
            {
                int c = 0;
                while (c < 10)
                {
                    int a = 0;
                    List<int> row = new List<int>();

                    while (a < 10)
                    {
                        int b = 0;
                        while (b < 10)
                        {
                            row.Add(l[a]);
                            b += 1;
                        }
                        a += 1;
                    }
                    rowList.Add(row);
                    c += 1;
                }
            }

            return rowList;
        }


        public Terrain()
        {


            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            List<List<int>> mat = RandMatrix(25, 100);

            int length = mat.Count;
            int j = 0;

            List<List<List<int>>> originalMap = new List<List<List<int>>>();

            foreach (List<int> l in mat)
            {
                foreach (int i in l)
                {
                    List<List<int>> singleSquare = MatrixCreator(i);
                    originalMap.Add(singleSquare);
                }
            }

        }
    }
}