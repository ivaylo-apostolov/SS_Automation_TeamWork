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

        public static Product Product
        {
            get
            {
                return new Product("MacBook", "iPhone");
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

        
    }
}


