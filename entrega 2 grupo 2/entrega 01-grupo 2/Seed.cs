using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class Seed : Product
    {
        private int PriceVariation;
        private int NutrientConsumptionPerTurn;
        private int MinNutrientLv;
        private int NutrientPenalty;
        private int WormProbability;
        private int WormPenalty;
        private int WeedProbability;
        private int WeedPenalty;

        public Seed(string Name, int PurchasePrice, int BaseSellingPrice, int WaterConsumptionPerTurn, int MinWaterLv, 
            int WaterPenalty, int ProductionTime, int DeseaseProbability, int DeseasePenalty, int price_variation,
            int nutrient_use_per_turn, int min_nutrient_lv, int nutrient_penalty, int worm_probability, int worm_penalty, 
            int weed_probability, int weed_penalty) : 
            base(Name, PurchasePrice, BaseSellingPrice, WaterConsumptionPerTurn,
                MinWaterLv, WaterPenalty, ProductionTime, DeseaseProbability, DeseasePenalty)
        {
            this.PriceVariation = price_variation;
            this.NutrientConsumptionPerTurn = nutrient_use_per_turn;
            this.MinNutrientLv = min_nutrient_lv;
            this.NutrientPenalty = nutrient_penalty;
            this.WormProbability = worm_probability;
            this.WormPenalty = worm_penalty;
            this.WeedProbability = weed_probability;
            this.WeedPenalty = weed_penalty;
        }

        public int GetPriceVariation()
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

        public int GetWormProbability()
        {
            return WormProbability;
        }

        public int GetWormPenalty()
        {
            return WormPenalty;
        }

        public int GetWeedProbability()
        {
            return WeedProbability;
        }

        public int GetWeedPenalty()
        {
            return WeedPenalty;
        }
    }
}
