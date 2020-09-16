using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class Product
    {
        protected string Name;
        protected double PurchasePrice;
        protected double BaseSellingPrice;
        protected int WaterConsumptionPerTurn;
        protected int MinWaterLv;
        protected int WaterPenalty;
        protected int ProductionTime;
        protected double DiseaseProbability;
        protected int DiseasePenalty;

        public Product(string name, int purchase_price, int base_selling_price, int water_use_per_turn, int min_water_lv, 
            int water_penalty, int production_time, int disease_probability, int disease_penalty)
        {
            this.Name = name;
            this.PurchasePrice = purchase_price;
            this.BaseSellingPrice = base_selling_price;
            this.WaterConsumptionPerTurn = water_use_per_turn;
            this.MinWaterLv = min_water_lv;
            this.WaterPenalty = water_penalty;
            this.ProductionTime = production_time;
            this.DiseaseProbability = disease_probability;
            this.DiseasePenalty = disease_penalty;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPurchasePrice()
        {
            return PurchasePrice;
        }

        public double GetBaseSellingPrice()
        {
            return BaseSellingPrice;
        }

        public int GetWaterConsumptionPerTurn()
        {
            return WaterConsumptionPerTurn;
        }

        public int GetMinWaterLv()
        {
            return  MinWaterLv;
        }

        public int GetWaterPenalty()
        {
            return WaterPenalty;
        }

        public int GetProductionTime()
        {
            return ProductionTime;
        }

        public double GetDiseaseProbability()
        {
            return DiseaseProbability;
        }

        public int GetDiseasePenalty()
        {
            return DiseasePenalty;
        }
    }
}
