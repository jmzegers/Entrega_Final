using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Chicken : Animal
    {
        private int Units { get; set; }
        private double Health { get; set; }
        private double SellingPrice { get; set; }

        public Chicken(string name, double basePurchasePrice, double water_consumption, double min_water_lvl,
            double water_penalty, int prodTime, int disease_prob, double disease_penalty, int PurchasePrice,
            double feed_use_per_turn, double min_feed_lv, double feed_penalty, int escape_probability,
            int min_escape, int max_escape, int sudden_death_probability, int min_sudden_deaths, int max_sudden_deaths,
            int units, double health, double sellingPrice)

            : base(name, basePurchasePrice, water_consumption, min_water_lvl, water_penalty, prodTime, disease_prob, disease_penalty, PurchasePrice,
                  feed_use_per_turn, min_feed_lv, feed_penalty, escape_probability, min_escape, max_escape, sudden_death_probability,
                  min_sudden_deaths, max_sudden_deaths, units)
        {
            this.Name = "Pollo";
            this.BaseSellingPrice = 40000;
            this.WaterConsumptionPerTurn = 100;
            this.MinWaterLv = 400;
            this.WaterPenalty = 27;
            this.ProductionTime = 9;
            this.DiseaseProbability = 10;
            this.DiseasePenalty = 25;
            this.PurchasePrice = 55000;
            this.FeedConsumptionPerTurn = 125;
            this.MinFeedLv = 175;
            this.FeedPenalty = 30;
            this.EscapeProbability = 15;
            this.MinEscape = 4;
            this.MaxEscape = 5;
            this.SuddenDeathProbability = 7;
            this.MinSuddenDeaths = 1;
            this.MaxSuddenDeaths = 5;

            this.Units = units;
            this.Health = health;
            this.SellingPrice = sellingPrice;
        }
    }
}
