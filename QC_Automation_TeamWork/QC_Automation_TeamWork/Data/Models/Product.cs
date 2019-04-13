using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;
using System.Collections.ObjectModel;

namespace QC_Automation_TeamWork.Data.Models
{
    public class Product
    {
        public Product(string productname)
        {
            Productname = productname;
        }

        public string Productname { get; set; }
    }
}

