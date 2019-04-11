using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Data.Models
{
    public class Product
    {
        public Product(string firstProduct, string secondProduct)
        {
            this.StoreFirstProductName = firstProduct;
            this.StoreSecondtProductName = secondProduct;
        }

        public string StoreFirstProductName { get; set; }

        public string StoreSecondtProductName { get; set; }
    }
}
