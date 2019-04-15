using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class MarketPlacePageTests : BaseTest
    {  
            [TestCategory("MadlenaIvanovaTests")]
            [TestMethod]
            public void SearchForFacebook()
            {
                var marketplacepage = new MarketplacePage();

                marketplacepage.Navigate();
                marketplacepage.UseSearchFilter();
                marketplacepage.Validate().SearchForFacebook();
            }
        }
    }
