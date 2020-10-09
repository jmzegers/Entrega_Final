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
        private int NutrientConsumptionPerTurn;
        private int MinNutrientLv;
        private int NutrientPenalty;
        private double WormProbability;
        private int WormPenalty;
        private double WeedProbability;
        private int WeedPenalty;

        public Seed(string Name, double BaseSellingPrice, double WaterConsumptionPerTurn, double MinWaterLv, 
            double WaterPenalty, int ProductionTime, double DeseaseProbability, double DeseasePenalty, double price_variation,
            double nutrient_use_per_turn, double min_nutrient_lv, double nutrient_penalty, int worm_probability, double worm_penalty, 
            int weed_probability, double weed_penalty) : 
            base(Name, BaseSellingPrice, WaterConsumptionPerTurn,
                MinWaterLv, WaterPenalty, ProductionTime, DeseaseProbability, DeseasePenalty)
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

        public int GetNutrientConsumptionPerTurn()
        {
            return NutrientConsumptionPerTurn;
        }

        public int GetMinNutrientLv()
        {
            return MinNutrientLv;
        }

        public int GetNutrientPenalty()
        {
            return NutrientPenalty;
        }

        public double GetWormProbability()
        {
            return WormProbability;
        }

        public int GetWormPenalty()
        {
            return WormPenalty;
        }

        public double GetWeedProbability()
        {
            return WeedProbability;
        }

        public int GetWeedPenalty()
        {
            return WeedPenalty;
        }
    }
}
