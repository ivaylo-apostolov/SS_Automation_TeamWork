namespace QC_Automation_TeamWork.Data.Models
{
    public class Product
    {
        public Product(string productname)
        {
            Productname = productname;
        }

        public string Productname { get; set; }

        public bool CompareWithAnotherProduct(Product anotherProduct)
        {
            return this.Productname == anotherProduct.Productname;
        }
    }
}
