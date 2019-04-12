using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

<<<<<<< HEAD
=======

>>>>>>> Madlen_feature
namespace QC_Automation_TeamWork.Pages
{
    public class StoreHomePageElementMap : BasePageElementMap
    {
        public IWebElement SearchTextBoxElement
        {
            get
            {
                return GetElement(By.XPath("//*[@id='search']/input"));
            }
        }

        public IWebElement CamerasButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='menu']/div[2]/ul/li[7]/a"));
            }

        }
            
        public IWebElement Iphone
        {
            get
            {
                return GetElement(By.CssSelector("#content>div.row>div:nth-child(2)>div>div.image>a>img"));
            }
        }
        public IWebElement SearchButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='search']/span/button"));
            }
        }

        public IWebElement MacBookAddToCard
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[3]/button[1]"));
            }
        }

        public IWebElement IPhoneAddToCard
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[2]/div/div[3]/button[1]"));
            }
        }

        public IWebElement BasketButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='cart']/button"));
            }
        }

        public IWebElement TotalPrice
        {
            get
            {
                return GetElement(By.XPath("//*[@id='cart']/ul/li[2]/div/table/tbody/tr[4]/td[2]"));
            }
        }

        public IWebElement FirstItemInBasket
        {
            get
            {
                return GetElement(By.XPath("//*[@id='cart']/ul/li[1]/table/tbody/tr[1]/td[2]/a"));
            }
        }

        public IWebElement SecondItemInBasket
        {
            get
            {
                return GetElement(By.XPath("//*[@id='cart']/ul/li[1]/table/tbody/tr[2]/td[2]/a"));
            }
        }

        public IWebElement FooterContactUsButton
        {
            get
            {
                return GetElement(By.PartialLinkText("Contact Us"));
            }
        }

        public IWebElement CompareFirstProductButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[3]/button[3]"));
            }
        }

        public IWebElement FirstProductName
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[2]/h4/a"));
            }
        }

        public string TextFirstProduct
        {
            get
            {
                return FirstProductName.Text;
            }
        }

        public IWebElement CompareSecondProductButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[2]/div/div[3]/button[3]"));
            }
        }

        public IWebElement SecondProductName
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[2]/div/div[2]/h4/a"));
            }
        }

        public string TextSecondProduct
        {
            get
            {
                return SecondProductName.Text;
            }
        }

        public IWebElement ProductComparisonButton
        {
            get
            {
                return GetElement(By.PartialLinkText("product comparison"));
            }
        }
    }
}
