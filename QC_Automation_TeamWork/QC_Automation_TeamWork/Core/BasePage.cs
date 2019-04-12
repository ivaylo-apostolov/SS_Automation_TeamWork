using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace QC_Automation_TeamWork.Core
{
    public class BasePage<TM> where TM : BasePageElementMap, new()
    {
        protected IWebDriver driver = Driver.Browser;
                
        protected TM Map
        {
            get
            {
                return new TM();
            }
        }
    }

    public class BasePage<TM, TV> : BasePage<TM>
        where TM : BasePageElementMap, new()
        where TV : BasePageValidator<TM>, new()
    {
        public TV Validate()
        {
            return new TV();
        }
    }
}

