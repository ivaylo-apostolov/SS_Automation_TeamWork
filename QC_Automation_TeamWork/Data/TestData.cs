using QC_Automation_TeamWork.Data.Models;

namespace QC_Automation_TeamWork.Data
{
    public static class TestData
    {
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

        public static string LoginPanelDefaultTitle
        {
            get
            {
                return "Please enter your login details.";
            }
        }
    }
}
