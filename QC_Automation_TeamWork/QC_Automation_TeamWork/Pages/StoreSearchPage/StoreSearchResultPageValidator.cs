using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreSearchPage
{
    public class StoreSearchResultPageValidator : BasePageValidator<StoreSearchResultPageElementMap>
    {
        public void SearchResult()
        {
            Assert.AreEqual(TestData.SearchText, Map.SearchResult.Text);
        }
    }
}
