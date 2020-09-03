﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class PestControl : Consumable
    {
        private string Enemy;
        private double ChanceOfSuccess;
        
        public PestControl(int price, string enemy, double chanceOfSuccess) : base(price)
        {
            this.Enemy = enemy;
            this.ChanceOfSuccess = chanceOfSuccess;
        }

        public int GetPrice()
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
