using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class StorageBuilding
    {
        private string Name;
        private int PurchasePrice;
        private int SalePrice;
        private int MaxCapacity;

        public StorageBuilding(string name, int purchasePrice, int salePrice, int maxCapacity)
        {
            this.Name = name;
            this.PurchasePrice = purchasePrice;
            this.SalePrice = salePrice;
            this.MaxCapacity = maxCapacity;
        }

        public string NameBuilding()
        {
            return Name;
        }

        public int GetPurchasePrice()
        {
            return PurchasePrice;
        }

        public int GetSalePrice()
        {
            return SalePrice * -1;
        }

        public int GetMaxCapacity()
        {
            return MaxCapacity;
        }
    }
}
