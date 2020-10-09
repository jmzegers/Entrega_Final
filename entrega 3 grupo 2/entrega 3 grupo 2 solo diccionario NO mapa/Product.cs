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
        protected double WaterConsumptionPerTurn;
        protected int MinWaterLv;
        protected int WaterPenalty;
        protected int ProductionTime;
        protected double DiseaseProbability;
        protected int DiseasePenalty;
        public Product(string name, double purchase_price, double base_selling_price, double water_use_per_turn, double min_water_lv, 
            double water_penalty, double production_time, int disease_probability, double disease_penalty)
        {
            this.Name = name;
            this.PurchasePrice = purchase_price;
            this.BaseSellingPrice = base_selling_price;
            this.WaterConsumptionPerTurn = water_use_per_turn;
            this.MinWaterLv = (int)min_water_lv;
            this.WaterPenalty = (int)water_penalty;
            this.ProductionTime = (int)production_time;
            this.DiseaseProbability = disease_probability;
            this.DiseasePenalty = (int)disease_penalty;
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

        public double GetWaterConsumptionPerTurn()
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
