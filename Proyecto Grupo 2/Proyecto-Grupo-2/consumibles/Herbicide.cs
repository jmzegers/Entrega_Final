using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Herbicide : Consumable
    {
        private string Enemy;
        private double ChanceOfSuccess;

        public Herbicide(int price, string enemy, double chanceOfSuccess) : base(price)
        {
            this.Enemy = enemy;
            this.ChanceOfSuccess = chanceOfSuccess;
        }

        public double GetPrice()
        {
            return Price;
        }

        public bool GetUse()
        {
            return Use;
        }

        public string GetEnemy()
        {
            return Enemy;
        }

        public double GetChanceOfSuccess()
        {
            return ChanceOfSuccess;
        }
    }
}
