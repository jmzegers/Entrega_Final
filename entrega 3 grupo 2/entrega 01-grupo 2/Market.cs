using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public class Market 
    //aqui solo se manejan los precios de todas las cosas
    {
        public Market()
        {
            //Los productos iran en diccionarios, cuyos Keys sean el producto mismo y su Value es el precio
            Dictionary<string, int> seedPrices = new Dictionary<string, int>(); //Precios de las semillas
            Dictionary<string, int> animalPrices = new Dictionary<string, int>(); //Precios de los animales
            Dictionary<string, int> storageBuidingPrices = new Dictionary<string, int>(); //Precios de los edificios
            Dictionary<string, int> consumablePrices = new Dictionary<string, int>(); //Precios de los consumibles

            //Para tenerlo todo bien ordenado, creamos un diccionario de diccionarios que contengan todos los datos anteriores
            Dictionary<string, Dictionary<string, int>> productDict = new Dictionary<string, Dictionary<string, int>>();

            List<int> Market_list; // hacemos la lista
            Market_list = new List<int>(); // iniciamos la lista
            List<int> Market_list1 = new List<int>() { }; // falta agregar las los animales y sus precios

            productDict.Add("Seeds", seedPrices);
            productDict.Add("Animals", animalPrices);
            productDict.Add("Buildings", storageBuidingPrices);
            productDict.Add("Consumables", consumablePrices);
            
        }
    }
}
