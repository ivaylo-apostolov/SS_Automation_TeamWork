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

        public static string SearchText
        {
            get
            {
                return "iPhone";
            }
        }

        public static User User
        {
            get
            {
                return new User("demo", "demo");
            }
        }

        public static User UserForNameChange
        {
            get
            {
                return new User("Mladen", "Varbev");
            }
        }

        public static Customer Customer
        {
            get
            {
                return new Customer("Bob Smith");
            }
        }

        public static Product ProductMacBook
        {
            get
            {
                return new Product("MacBook");
            }
        }

        public static Product ProductIPhone
        {
            get
            {
                return new Product("iPhone");
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


        public static string WarningMessage
        {
            get
            {
                return @"Warning: You do not have permission to modify your profile!
×";
            }
        }

        public static string ExpectedCustomer
        {
            get
            {
                return "Bob Smith";
            }
        }

        public static string ExpectedBanner
        {
            get
            {
                return "Community Forum";
            }
        }

        public static string ExpectedTotalPrice
        {
            get
            {
                return "$725.20";
            }
        }

        public static string ExpectedFirstItem
        {
            get
            {
                return "iPhone";
            }
        }

        public static string ExpectedSecondItem
        {
            get
            {
                return "MacBook";
            }
        }

        public static string ExpectedContactUsHeader
        {
            get
            {
                return "Contact Us";
            }
        }

        public static string NameInContactUsForm
        {
            get
            {
                return "Ivaylo Apostolov";
            }
        }

        public static string EmailInContactUsForm
        {
            get
            {
                return "ivaylo.apostolov@gmail.com";
            }
        }

        public static string EnquiryTextInContactUsForm
        {
            get
            {
                return "This is a test";
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

        public static string SuccessfulReview
        {
            get
            {
                return "Thank you for your review. It has been submitted to the webmaster for approval.";
            }
        }


        public static string Pincode
        {
            get
            {
                return "1717";
            }
        }

        public static string Account
        {
            get
            {
                return "Account";
            }
        }

        public static string ResetPasswordMessage
        {
            get
            {
                return "Success: An email with a reset link has been sent your email address!";
            }
        }

        public static string Email
        {
            get
            {
                return "mad17@abv.bg";
            }
        }

        public static LoginWithEmail LoginWithEmail
        {
            get
            {
                return new LoginWithEmail(Email, "englisc");
            }
        }

        public static string ReviewerName
        {
            get
            {
                return "Madlena";
            }
        }

        public static string Review
        {
            get
            {
                return "Very nice product! I like it!";
            }
        }

        public static string AlertText
        {
            get
            {
                return "Error: This subscribe form requires that you fill in a CAPTCHA to be added to the list.";
            }
        }
        public static string SearchFilterValue
        {
            get
            {
                return "facebook";
            }
        }


        public static string SearchResult
        {
            get
            {
                return "Facebook for OpenCart";
            }
        }
    }
}

