using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class Animal : Product
    {
        private int FeedConsumptionPerTurn;
        private int MinFeedLv;
        private int FeedPenalty;
        private int Units;
        private int EscapeProbability;
        private int MinEscape;
        private int MaxEscape;
        private int EscapedUnits;
        private int SuddenDeathProbability;
        private int MinSuddenDeaths;
        private int MaxSuddenDeaths;
        private int SuddenlyDeadUnits;

        Random AnimalRand = new Random();

        public Animal(string Name, int PurchasePrice, int BaseSellingPrice, int WaterConsumptionPerTurn,
            int MinWaterLv, int WaterPenalty, int ProductionTime, int DeseaseProbability, int DeseasePenalty,
            int feed_use_per_turn, int min_feed_lv, int feed_penalty, int units, int escape_probability, 
            int min_escape, int max_escape, int sudden_death_probability, int min_sudden_deaths, int max_sudden_deaths)
            : base(Name, PurchasePrice, BaseSellingPrice, WaterConsumptionPerTurn, MinWaterLv, WaterPenalty, 
                  ProductionTime, DeseaseProbability, DeseasePenalty)
        {
            this.FeedConsumptionPerTurn = feed_use_per_turn;
            this.MinFeedLv = min_feed_lv;
            this.FeedPenalty = feed_penalty;
            this.Units = units;
            this.EscapeProbability = escape_probability;
            this.MinEscape = min_escape;
            this.MaxEscape = max_escape;
            this.SuddenDeathProbability = sudden_death_probability;
            this.MinSuddenDeaths = min_sudden_deaths;
            this.MaxSuddenDeaths = max_sudden_deaths;

        }

        public int GetFeedConsumptionPerTurn()
        {
            return FeedConsumptionPerTurn;
        }

        public int GetMinFeedLv()
        {
            return MinFeedLv;
        }

        public int GetFeedPenalty()
        {
            return FeedPenalty;
        }

        public int GetUnits()
        {
            return Units;
        }

        public int GetEscapeProbability()
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

        public int GetSuddenDeathProbability()
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
