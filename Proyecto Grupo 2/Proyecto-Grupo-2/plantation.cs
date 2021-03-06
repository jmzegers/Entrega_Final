﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    public class Plantation : Edification
    {
        private bool Worms;
        private bool Weeds;
        private int Nutrients;
        private double DiseaseChance;
        private int WormChance;
        private int WeedChance;
        private bool disease;
        private double Health;
        private double Water;
        private int Maturity;

        public Plantation(string name, double purchasePrice, string kind, double diseaseChance, int wormChance, int weedChance, bool disease, double Health, double Water, int maturity) : 
            base(name, (int)purchasePrice, kind)
        {
            Worms = false;
            Weeds = false;
            Nutrients = 100;
            this.DiseaseChance = diseaseChance;
            this.WormChance = wormChance;
            this.WeedChance = weedChance;
            this.Maturity = maturity;
            Health = 100;
            Water = 1;
        }

        public bool Worm(int gu)
        {
            Random R = new Random();
            bool hasWorms = false;
            int gusano = R.Next(0, 101);
            if (gusano <= gu)
            {
                hasWorms = true;
            }
            return hasWorms;
        }

        public bool Weed(int w)
        {
            Random R = new Random();
            bool hasWeeds = false;
            int maleza = R.Next(0, 101);
            if (maleza <= w)
            {
                hasWeeds = true;
            }
            return hasWeeds;
        }

        public int currentNutrients(int nutrientsPerTurn, int nutrientsNow)
        {
            return nutrientsNow - nutrientsPerTurn;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPurchasePrice()
        {
            return PurchasePrice;
        }

        public string GetKind()
        {
            return Kind;
        }

        public double GetDiseaseChance()
        {
            return DiseaseChance;
        }

        public int GetWormChance()
        {
            return WormChance;
        }

        public int GetWeedChance()
        {
            return WeedChance;
        }

        public bool GetWorms()
        {
            return Worms;
        }

        public bool GetWeeds()
        {
            return Weeds;
        }

        public int GetNutrients()
        {
            return Nutrients;
        }

        public int GetSalesPrice()
        {
            return SalesPrice;
        }

        public double GetHealth()
        {
            return Health;
        }

        public double GetWater()
        {
            return Water;
        }

        public int GetMaturity()
        {
            return Maturity;
        }

        public bool GetDisease()
        {
            return disease;
        }
    }
}
