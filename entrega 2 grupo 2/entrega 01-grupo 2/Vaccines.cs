﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class Vaccines : Consumable
    {
        private double ChanceOfSuccess;
        
        public Vaccines(int price, double chanceOfSuccess) : base(price)
        {
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

        public double GetChanceOfSuccess()
        {
            return ChanceOfSuccess;
        }
    }
}
