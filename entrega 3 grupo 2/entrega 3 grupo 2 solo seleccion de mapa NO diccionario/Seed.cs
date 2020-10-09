using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Seed : Product
    {
        private double PriceVariation;
        private double NutrientConsumptionPerTurn;
        private double MinNutrientLv;
        private double NutrientPenalty;
        private double WormProbability;
        private double WormPenalty;
        private double WeedProbability;
        private double WeedPenalty;

        public Seed(string Name, double BaseSellingPrice, double WaterConsumptionPerTurn, double MinWaterLv, 
            double WaterPenalty, int ProductionTime, double DeseaseProbability, double DeseasePenalty, int PurchasePrice, double price_variation,
            double nutrient_use_per_turn, double min_nutrient_lv, double nutrient_penalty, int worm_probability, double worm_penalty, 
            int weed_probability, double weed_penalty) : 
            base(Name, BaseSellingPrice, WaterConsumptionPerTurn,
                MinWaterLv, WaterPenalty, ProductionTime, DeseaseProbability, DeseasePenalty, PurchasePrice)
        {
            this.PriceVariation = price_variation;
            this.NutrientConsumptionPerTurn = (int)nutrient_use_per_turn;
            this.MinNutrientLv = (int)min_nutrient_lv;
            this.NutrientPenalty = (int)nutrient_penalty;
            this.WormProbability = worm_probability;
            this.WormPenalty = (int)worm_penalty;
            this.WeedProbability = weed_probability;
            this.WeedPenalty = (int)weed_penalty;
        }

        public double GetPriceVariation()
        {
            return PriceVariation;
        }

        public double GetNutrientConsumptionPerTurn()
        {
            return NutrientConsumptionPerTurn;
        }

        public double GetMinNutrientLv()
        {
            return MinNutrientLv;
        }

        public double GetNutrientPenalty()
        {
            return NutrientPenalty;
        }

        public double GetWormProbability()
        {
            return WormProbability;
        }

        public double GetWormPenalty()
        {
            return WormPenalty;
        }

        public double GetWeedProbability()
        {
            return WeedProbability;
        }

        public double GetWeedPenalty()
        {
            return WeedPenalty;
        }
    }
}
