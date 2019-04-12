using System.Linq;
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

        public void WriteReview()
        {
            Map.WriteReviewLink.Click();

            Map.ReviewerName.Clear();
            Map.ReviewerName.SendKeys("Madlena");

            Map.Review.Clear();
            Map.Review.SendKeys("Very nice product! I like it!");
            
            var goodRatingRadioButton = Map.Rating.ElementAt(4);
            goodRatingRadioButton.Click();

            Map.Continuebutton.Click();

        }
          
    }
}

