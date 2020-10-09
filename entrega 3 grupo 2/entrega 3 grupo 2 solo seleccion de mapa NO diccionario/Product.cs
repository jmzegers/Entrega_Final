﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Product
    {
        protected string Name;
        protected double BaseSellingPrice;
        protected double WaterConsumptionPerTurn;
        protected double MinWaterLv;
        protected double WaterPenalty;
        protected int ProductionTime;
        protected double DiseaseProbability;
        protected double DiseasePenalty;
        protected int PurchasePrice;

        public Product(string name, double base_selling_price, double water_use_per_turn, double min_water_lv, 
            double water_penalty, int production_time, double disease_probability, double disease_penalty, int purchase_price)
        {
            this.Name = name;
            this.BaseSellingPrice = base_selling_price;
            this.WaterConsumptionPerTurn = water_use_per_turn;
            this.MinWaterLv = min_water_lv;
            this.WaterPenalty = water_penalty;
            this.ProductionTime = production_time;
            this.DiseaseProbability = disease_probability;
            this.DiseasePenalty = disease_penalty;
            this.PurchasePrice = purchase_price;
        }

        public string GetName()
        {
            return Name;
        }

<<<<<<< HEAD
=======
        public int GetPurchasePrice()
        {
            return PurchasePrice;
        }

>>>>>>> b441be53059a7dcbc89279feb68219cc3fe017ce
        public double GetBaseSellingPrice()
        {
            return BaseSellingPrice;
        }

        public double GetWaterConsumptionPerTurn()
        {
            return WaterConsumptionPerTurn;
        }

        public double GetMinWaterLv()
        {
            return  MinWaterLv;
        }

        public double GetWaterPenalty()
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

        public double GetDiseasePenalty()
        {
            return DiseasePenalty;
        }
    }
}
