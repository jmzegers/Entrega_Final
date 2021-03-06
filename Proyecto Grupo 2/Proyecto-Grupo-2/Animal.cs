﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Animal : Product
    {
        protected double FeedConsumptionPerTurn;
        protected double MinFeedLv;
        protected double FeedPenalty;
        protected double EscapeProbability;
        protected int MinEscape;
        protected int MaxEscape;
        protected int EscapedUnits;
        protected double SuddenDeathProbability;
        protected int MinSuddenDeaths;
        protected int MaxSuddenDeaths;
        protected int SuddenlyDeadUnits;

        Random AnimalRand = new Random();

        public Animal(string Name, double BaseSellingPrice, double WaterConsumptionPerTurn,
            double MinWaterLv, double WaterPenalty, int ProductionTime, int DeseaseProbability, double DeseasePenalty, int PurchasePrice,
            double feed_use_per_turn, double min_feed_lv, double feed_penalty, int escape_probability, 
            int min_escape, int max_escape, int sudden_death_probability, int min_sudden_deaths, int max_sudden_deaths, int units)
            : base(Name, BaseSellingPrice, WaterConsumptionPerTurn, MinWaterLv, WaterPenalty, 
                  ProductionTime, DeseaseProbability, DeseasePenalty, PurchasePrice)
        {
            this.FeedConsumptionPerTurn = feed_use_per_turn;
            this.MinFeedLv = min_feed_lv;
            this.FeedPenalty = feed_penalty;
            this.EscapeProbability = escape_probability;
            this.MinEscape = min_escape;
            this.MaxEscape = max_escape;
            this.SuddenDeathProbability = sudden_death_probability;
            this.MinSuddenDeaths = min_sudden_deaths;
            this.MaxSuddenDeaths = max_sudden_deaths;

        }

        public double GetFeedConsumptionPerTurn()
        {
            return FeedConsumptionPerTurn;
        }

        public double GetMinFeedLv()
        {
            return MinFeedLv;
        }

        public double GetFeedPenalty()
        {
            return FeedPenalty;
        }

        public double GetEscapeProbability()
        {
            return EscapeProbability;
        }

        public int GetMinEscape()
        {
            return MinEscape;
        }

        public int GetMaxEscape()
        {
            return MaxEscape;
        }

        public double GetSuddenDeathProbability()
        {
            return SuddenDeathProbability;
        }

        public int GetMinSuddenDeaths()
        {
            return MinSuddenDeaths;
        }

        public int GetMaxSuddenDeaths()
        {
            return MaxSuddenDeaths;
        }

        public void EscapeEvent()
        {
            this.EscapedUnits = AnimalRand.Next(MinEscape, MaxEscape + 1);
        }

        public void SuddenDeathEvent()
        {
            this.SuddenlyDeadUnits = AnimalRand.Next(MinSuddenDeaths, MaxSuddenDeaths + 1);
        }
    }
}
