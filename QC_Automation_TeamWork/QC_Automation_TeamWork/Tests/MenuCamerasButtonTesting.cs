using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages.StoreCamerasPage;
using QC_Automation_TeamWork.Pages.StoreHomePage;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class MenuCamerasButtonTesting : BaseTest
    {
        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test01NavigateToCameraPage()
        {
            var homePage = new StoreHomePage();
            homePage.Navigate();
            homePage.ClickCamerasButton();

            var camerasPage = new StoreCamerasPage();
            camerasPage.LocateCamerasPageHeader();

            camerasPage.Validate().CamerasPage();

            //Assert.AreEqual(TestData.ExpectedCamerasPageHeading, camerasPage.LocateCamerasPageHeader());
        }
    }
}
