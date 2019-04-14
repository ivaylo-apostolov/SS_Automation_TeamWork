namespace QC_Automation_TeamWork.Data.Models
{
    public class Customer
    {
        public Customer(string customerName)
        {
            CustomerName = customerName;
        }

        public string CustomerName { get; set; }

    }
}
