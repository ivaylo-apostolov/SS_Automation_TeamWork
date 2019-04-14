using System.Linq;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{

    public class IphonePage : BasePage<IphoneReviewPageElementMap, IphoneReviewPageValidator>
    {

        private string pageURL = "https://demo.opencart.com/index.php?route=product/product&product_id=40";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageURL);
        }

        public void WriteReview()
        {
            Map.WriteReviewLink.Click();

            Map.ReviewerName.Clear();
            Map.ReviewerName.SendKeys(TestData.ReviewerName);

            Map.Review.Clear();
            Map.Review.SendKeys(TestData.Review);
            
            var goodRatingRadioButton = Map.Rating.ElementAt(4);
            goodRatingRadioButton.Click();

            Map.Continuebutton.Click();
        }
          
    }
}

