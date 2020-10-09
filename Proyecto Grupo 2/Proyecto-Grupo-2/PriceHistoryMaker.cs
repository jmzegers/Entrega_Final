using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class PriceHistoryMaker
    {
        ObjectBrain ob = new ObjectBrain();

        public double SeedValue(double currentValue, double priceVar, double basePrice) //Calculador del cambio de precio de un turno a otro
        {
            double maxPrice = basePrice * 1.4; //El precio maximo es el 140% del original
            double minPrice = basePrice * 0.7; //El precio minimo es el 70% del original

            currentValue = Math.Round(currentValue * priceVar);

            if (currentValue < minPrice || currentValue > maxPrice)
            {
                currentValue = basePrice;
            }

            return currentValue;
        }

        public Dictionary<string, Dictionary<int, double>> PriceHistory(int currentTurn)
        {
            Dictionary<string, Dictionary<int, double>> priceHistory = ob.GetPriceHistory();
            foreach (KeyValuePair<string, Seed> seed in ob.GetSeedDict())
            {
                Dictionary<int, double> seedHistory = new Dictionary<int, double>();
                string seedName = seed.Value.GetName();
                double basePrice = seed.Value.GetBaseSellingPrice();
                double priceVar = seed.Value.GetPriceVariation();
                int turn = 1;
                double currentVal = basePrice;

                while (turn <= currentTurn)
                {
                    currentVal = SeedValue(currentVal, priceVar, basePrice);
                    seedHistory.Add(turn, currentVal);
                    turn += 1;
                }

                priceHistory.Add(seedName, seedHistory);
            }

            return priceHistory;
        }


    }
}
