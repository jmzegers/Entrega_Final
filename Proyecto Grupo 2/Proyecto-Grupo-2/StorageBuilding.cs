using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class StorageBuilding : Edification
    {

        private double SalePrice;
        private int MaxCapacity;
        private int Quality;
        public StorageBuilding(string name, int purchasePrice, int salePrice, int maxCapacity, string kind, int quality) :
            base(name, purchasePrice, kind)

        {
            this.Name = name;
            this.PurchasePrice = purchasePrice;
            this.SalePrice = salePrice;
            this.MaxCapacity = maxCapacity;
            this.Quality = quality;
        }

        public string NameBuilding()
        {
            return Name;
        }

        public int GetPurchasePrice()
        {
            return PurchasePrice;
        }

        public double GetSalePrice()
        {
            return SalePrice * -1;
        }

        public int GetMaxCapacity()
        {
            return MaxCapacity;
        }
        public string GetKind()
        {
            return Kind;
        }
        public int GetQuality()
        {
            return Quality;
        }
    }
}
