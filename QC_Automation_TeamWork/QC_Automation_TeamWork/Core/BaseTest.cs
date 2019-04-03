using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QC_Automation_TeamWork.Core
{
    class BaseTest
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
