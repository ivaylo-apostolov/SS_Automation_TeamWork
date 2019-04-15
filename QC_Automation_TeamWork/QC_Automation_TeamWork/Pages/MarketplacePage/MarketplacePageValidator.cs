using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class MarketplacePageValidator : BasePageValidator<MarketplacePageElementMap>
    {
        internal void SearchForFacebook()
        {
            Assert.AreEqual(TestData.SearchResult, Map.SearchFilterFacebook.Text);
        }
    }
}
