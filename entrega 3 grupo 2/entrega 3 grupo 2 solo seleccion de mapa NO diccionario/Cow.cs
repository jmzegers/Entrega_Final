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
            double feed_use_per_turn = 150, double min_feed_lv = 200, double feed_penalty = 25, int escape_probability,
            int min_escape, int max_escape, int sudden_death_probability, int min_sudden_deaths, int max_sudden_deaths, int units, 
            double health, double purchasePrice)

            : base(name, basePurchasePrice, water_consumption, min_water_lvl, water_penalty, prodTime, disease_prob, disease_penalty,
                  feed_use_per_turn, min_feed_lv, feed_penalty, escape_probability, min_escape, max_escape, sudden_death_probability, 
                  min_sudden_deaths, max_sudden_deaths)
        {
            this.Units = units;
            this.Health = health;
            this.PurchasePrice = purchasePrice;
        }
    }
}
