using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreSearchResultPageValidator : BasePageValidator<StoreSearchResultPageElementMap>
    {
        public void SearchResult()
        {
            Assert.AreEqual(TestData.SearchText, Map.SearchResult.Text);
        }
    }
}
