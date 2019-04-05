using OpenCartTestsTeamWork.Data.Models;

namespace OpenCartTestsTeamWork.Data
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

        public static string OpenCartHomePageHeading
        {
            get
            {
                return "The best FREE and open-source eCommerce platform";

        public static string ExpectedCamerasPageHeading
        {
            get
            {
                return "Cameras";
            }
        }
    }
}
