
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{

    public class IphonePage : BasePage<IphoneReviewPageElementMap, IphoneReviewPageValidator>
    {

        private string pageURL = "https://demo.opencart.com/index.php?route=product/product&product_id=40";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageURL);
        }
    }
}

