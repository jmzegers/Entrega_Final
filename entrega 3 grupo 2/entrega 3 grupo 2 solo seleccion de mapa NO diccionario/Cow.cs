using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Cow : Animal
    {
        private int Units { get; set; }
        private double Health { get; set; }

        private double PurchasePrice { get; set; }
        public Cow(string name = "vaca", double basePurchasePrice = 50000, double water_consumption = 150, double min_water_lvl = 600,
               double water_penalty = 20, int prodTime = 8, int disease_prob = 20, double disease_penalty = 15,
               double feed_use_per_turn = 150, double min_feed_lv = 200, double feed_penalty = 25, int escape_probability = 25,
               int min_escape = 1, int max_escape = 5, int sudden_death_probability = 10, int min_sudden_deaths = 1, int max_sudden_deaths = 10, int units = 50,
               double health = 99.5, double purchasePrice = 1500)
            : base(name, basePurchasePrice, water_consumption, min_water_lvl, water_penalty, prodTime, disease_prob, disease_penalty);
        private double SellingPrice { get; set; }
        
        public Cow(string name, double basePurchasePrice, double water_consumption, double min_water_lvl, 
            double water_penalty, int prodTime, int disease_prob, double disease_penalty, int PurchasePrice, 
            double feed_use_per_turn = 150, double min_feed_lv = 200, double feed_penalty = 25, int escape_probability = 10,
            int min_escape = 3, int max_escape = 5, int sudden_death_probability = 5, int min_sudden_deaths = 3, int max_sudden_deaths = 5,
            int units, double health, double sellingPrice)

            : base(name, basePurchasePrice, water_consumption, min_water_lvl, water_penalty, prodTime, disease_prob, disease_penalty, PurchasePrice,

                  feed_use_per_turn, min_feed_lv, feed_penalty, escape_probability, min_escape, max_escape, sudden_death_probability, 
                  min_sudden_deaths, max_sudden_deaths, units)
        {
            this.Name = "Vaca";
            this.BaseSellingPrice = 50000;
            this.WaterConsumptionPerTurn = 150;
            this.MinWaterLv = 600;
            this.WaterPenalty = 20;
            this.ProductionTime = 8;
            this.DiseaseProbability = 20;
            this.DiseasePenalty = 15;
            this.PurchasePrice = 55000;
            this.FeedConsumptionPerTurn = 150;

            this.Units = units;
            this.Health = health;
            this.SellingPrice = sellingPrice;
        }
    }
}
