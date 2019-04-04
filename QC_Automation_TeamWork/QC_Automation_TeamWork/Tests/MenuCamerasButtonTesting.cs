using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages.StoreCamerasPage;
using QC_Automation_TeamWork.Pages.StoreHomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    class MenuCamerasButtonTesting : BaseTest
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
        }
    }
}
