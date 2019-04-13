using QC_Automation_TeamWork.Data.Models;

namespace QC_Automation_TeamWork.Data
{
    public static class TestData
    {
        public static string ExpectedCamerasPageHeading
        {
            get
            {
                return "Cameras";
            }
        }
        public static User User
        {
            get
            {
                return new User("demo", "demo");
            }
        }

        public static string UserFullName
        {
            get
            {
                return "demo demo";
            }
        }

        public static string UsernameDefaultValue
        {
            get
            {
                return "demo";
            }
        }

        public static string OpenCartHomePageHeading
        {
            get
            {
                return "The best FREE and open-source eCommerce platform";
            }
        }

        public static string LoginPanelDefaultTitle
        {
            get
            {
                return "Please enter your login details.";
            }
        }

        public static string ProductsButtonDefaultName
        {
            get
            {
                return "Products";
            }
        }

        public static string ProductsHomePageTitle
        {
            get
            {
                return "Products";
            }
        }

        public static string ProductsNameFieldTitle
        {
            get
            {
                return "Product Name";
            }
        }

        public static Product Product
        {
            get
            {
                return new Product("Apple");
            }
        }

        public static string ModelFieldTitle
        {
            get
            {
                return "Model";
            }
        }

        public static Model Model
        {
            get
            {
                return new Model("Product 15");
            }
        }

        public static MetaTitle MetaTitle
        {
            get
            {
                return new MetaTitle("Toma");
            }
        }

        public static string FilterButtonTitle
        {
            get
            {
                return " Filter";
            }
        }

        public static string ModelFilterResultField
        {
            get
            {
                return "Product 15";
            }
        }

        public static string SettingsWarningMessage
        {
            get
            {
                return @"Warning: You do not have permission to modify settings!
×";
            }
        }

        public static string ChangedCurrency
        {
            get
            {
                return "518.16€";
            }
        }

        public static string PrintShippingList
        {
            get
            {
                return "Order Details";
            }
        }
    }
}
    

