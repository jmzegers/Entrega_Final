using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class FinishedProduct 
    {
        private string ProductType;
        private int ProductQuality;
        
        public FinishedProduct(string product_type)
        {
            this.ProductType = product_type;
        }

        public string GetProductType()
        {
            return ProductType;
        }

        public int GetProductQuality()
        {
            return ProductQuality;
        }
    }
}
