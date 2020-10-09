using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Tomato : Seed
    {
        private double Health { get; set; }
        private double CurrentPurchasePrice { get; set; }

        public Tomato(string name = "Tomate", double basePurchasePrice = 4500, double waterConsumptionPerTurn = 50,
            double minWater = 750, double waterPenalty = 10, int productionTime = 5, int diseaseProb = 8, double diseasePenalty = 8,
            double priceVar = 1.02, double nutrient_use_per_turn = 8, double min_nutrient_level = 60, double nutrient_penalty = 12, int worm_prob = 11,

            double worm_penalty = 9.5, int weed_probability = 5, double weed_penalty = 10.3, double health = 98.9, double currentPurchasePrice = 3050)
/*


        */    : base(name, basePurchasePrice, waterConsumptionPerTurn, minWater, waterPenalty, productionTime, diseaseProb, diseasePenalty, priceVar,
                    nutrient_use_per_turn, min_nutrient_level, nutrient_penalty, worm_prob, worm_penalty, weed_probability, weed_penalty)
        {
            this.Health = health;
            this.CurrentPurchasePrice = currentPurchasePrice;
        }


    }
}

