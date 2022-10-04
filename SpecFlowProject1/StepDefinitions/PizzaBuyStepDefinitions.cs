using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PizzaBuyStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public PizzaBuyStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\Sumit.Rana\\Downloads\\chromedriver_win32");

        [Given(@"Navigating to pizza website")]
        public void GivenNavigatingToPizzaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joespizzaweb.azurewebsites.net");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
        }

        [When(@"On clicking Pizza List")]
        public void WhenOnClickingPizzaList()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
            var ListPizzaButton = chromeDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[2]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", ListPizzaButton);
        }

        [Then(@"Shows Pizza List")]
        public void ThenShowsPizzaList()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
        }

        [When(@"On clicking Buy Button")]
        public void WhenOnClickingBuyButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
            var AddToCartButton = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div/div[1]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", AddToCartButton);
        }

        [Then(@"Order Checkout Page displays")]
        public void ThenOrderCheckoutPageDisplays()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
            
        }

        [When(@"On clicking Confirm Order")]
        public void WhenOnClickingConfirmOrder()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
            var ConfirmButton = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", ConfirmButton);
        }

        [Then(@"Confirmation Page is displayed")]
        public void ThenConfirmationPageIsDisplayed()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
        }
    }
}
