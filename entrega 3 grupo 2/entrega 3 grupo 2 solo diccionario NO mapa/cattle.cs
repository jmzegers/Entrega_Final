using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    public class Cattle : Edification
    {
        private int Unidad;
        private int food;
        private double ScapeChance;
        private double SuddenDeathChance;
        private bool Death;
        private new double Health;
        private new double Water;
        private new int Maturity;
        private int amountofland;

        // falta un poco revisar aqui
        public Cattle(string name, double purchasePrice, string kind, int unidad, double scapeChance, double suddenDeathChance) :
            base(name, (int)purchasePrice, kind)
        {
            this.Unidad = unidad;
            this.ScapeChance = scapeChance;
            this.SuddenDeathChance = suddenDeathChance;
        }

        public int CurrentNutrients(int nutrientsPerTurn, int nutrientsNow)
        {
            return nutrientsNow - nutrientsPerTurn;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetPurchasePrice()
        {
            return PurchasePrice;
        }

        public string GetKind()
        {
            return Kind;
        }

        public int GetUnidad()
        {
            return Unidad;
        }
        public double GetScapeChance()
        {
            return ScapeChance;
        }
        public double GetSuddenDeathChance()
        {
            return SuddenDeathChance;
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

        public int Getamountofland()
        {
            return amountofland;
        } 
    }

}


