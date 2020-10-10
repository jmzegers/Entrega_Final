using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Pig : Animal
    {
        private int Units { get; set; }
        private double Health { get; set; }
        private double SellingPrice { get; set; }

        public Pig(string name, double basePurchasePrice, double water_consumption, double min_water_lvl,
            double water_penalty, int prodTime, int disease_prob, double disease_penalty, int PurchasePrice,
            double feed_use_per_turn, double min_feed_lv, double feed_penalty, int escape_probability,
            int min_escape, int max_escape, int sudden_death_probability, int min_sudden_deaths, int max_sudden_deaths,
            int units, double health, double sellingPrice)

            : base(name, basePurchasePrice, water_consumption, min_water_lvl, water_penalty, prodTime, disease_prob, disease_penalty, PurchasePrice,
                  feed_use_per_turn, min_feed_lv, feed_penalty, escape_probability, min_escape, max_escape, sudden_death_probability,
                  min_sudden_deaths, max_sudden_deaths, units)
        {
            this.Name = "Cerdo";
            this.BaseSellingPrice = 30000;
            this.WaterConsumptionPerTurn = 125;
            this.MinWaterLv = 500;
            this.WaterPenalty = 25;
            this.ProductionTime = 6;
            this.DiseaseProbability = 15;
            this.DiseasePenalty = 25;
            this.PurchasePrice = 35000;
            this.FeedConsumptionPerTurn = 200;
            this.MinFeedLv = 250;
            this.FeedPenalty = 35;
            this.EscapeProbability = 7;
            this.MinEscape = 2;
            this.MaxEscape = 5;
            this.SuddenDeathProbability = 5;
            this.MinSuddenDeaths = 2;
            this.MaxSuddenDeaths = 5;

            this.Units = units;
            this.Health = health;
            this.SellingPrice = sellingPrice;
        }
    }
}
