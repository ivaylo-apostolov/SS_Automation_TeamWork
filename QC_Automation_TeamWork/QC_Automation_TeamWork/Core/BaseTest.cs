using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenCartTestsTeamWork.Core
{
    public class BaseTest
    {
        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TestTeardown()
        {
            Driver.StopBrowser();
        }
    }
}
