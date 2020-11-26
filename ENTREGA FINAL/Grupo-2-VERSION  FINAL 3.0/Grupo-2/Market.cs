using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_2
{
    [Serializable]
    public class Market
    {
        /* Para cada semilla se debe calcular el precio de 30 turnos hacia atrás, es decir, generar
         * una historia.
         * Para esto, debe utilizar el precio base y la variación de precio por turno
         * que tiene cada semilla (definido en el enunciado 2). El precio de cada turno se calcula
         * como (precio del turno anterior +/- variación de precio). Para evitar que el precio llegue
         * a cero o sea excesivamente alto, defina una ventana segura, por ejemplo, el precio no
         * puede variar en más de un X % del precio original, en caso de que se supere la ventana,
         * se vuelve al precio base.
         * 
        */

        //Esto es solo para el principio del juego.
        public List<int> Price_History(Seed s)
        {
            int base_price = s.BaseSellingPrice;
            List<int> priceHistory = new List<int>();

            priceHistory.Add(base_price);
            int price = base_price;

            for (int i = 1; i <= 30; i++)
            {
                price = price + s.PriceVarietyperturn;
                price = Convert.ToInt32(price);
                if (price < s.MinPrice || price > s.MaxPrice)
                {
                    price = s.BaseSellingPrice;
                }
                priceHistory.Add(price);
            }

            return priceHistory;
        }
    }
}
