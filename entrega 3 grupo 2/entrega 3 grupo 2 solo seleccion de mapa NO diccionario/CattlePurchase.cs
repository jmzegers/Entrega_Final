using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class CattlePurchase
    {
        public CattlePurchase()
        {
            /*
            Dictionary<string, Animal> animalDict = ob.GetAnimalDict();
            Console.WriteLine("Los ganados disponibles son: ");
            int prodNumber = 1;

            foreach (KeyValuePair<string, Animal> c in animalDict)
            {
                string name = c.Key;
                double price = c.Value.GetPurchasePrice();
                Console.WriteLine(prodNumber + "." + name + "      " + price);
                prodNumber += 1;
            }

            Console.WriteLine("¿Cual desea comprar? Escriba el nombre del producto");
            string prodName = Console.ReadLine();
            Animal cattleBought = ob.GetAnimalDict()["vacas"];

            try
            {
                cattleBought = ob.GetAnimalDict()[prodName];
            }
            catch (Exception e)
            {
                Console.WriteLine("Ese producto no existe");
            }

            double prodPrice = cattleBought.GetPurchasePrice();
            if (prodPrice > money)
            {
                Console.WriteLine("No tienes suficiente dinero");
            }
            else
            {
                money = money - prodPrice;
                List<int> XCoord = new List<int>();
                List<int> YCoord = new List<int>();
                Console.WriteLine("Elija el lugar donde quiera poner el ganado [1 - 100]");
                Console.WriteLine("Eje X: ");
                while (true)
                {
                    try
                    {
                        int EjeX = Convert.ToInt32(Console.ReadLine());
                        XCoord.Add(EjeX);
                        XCoord.Add(EjeX);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Debe ser un numero");
                    }
                }
                Console.WriteLine("Eje Y: ");
                while (true)
                {
                    try
                    {
                        int EjeY = Convert.ToInt32(Console.ReadLine());
                        YCoord.Add(EjeY);
                        YCoord.Add(EjeY);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Debe ser un numero");
                    }
                }

                while (true)
                {
                    if (CheckIfUsedCoord(usedCoordinates, XCoord, YCoord) == false)
                    {
                        NewMapElement("G", cattleBought.GetName(), XCoord, YCoord);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ese lugar no esta disponible");
                        Console.WriteLine("Intente nuevamente");
                    }
                }
            }

            */
        }
    }
}
