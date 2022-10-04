using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class AddToCartStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public AddToCartStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\Sumit.Rana\\Downloads\\chromedriver_win32");

        [Given(@"Navigate to pizza website")]
        public void GivenNavigateToPizzaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joespizzaweb.azurewebsites.net");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
        }

        [When(@"On clicking Pizza List button")]
        public void WhenOnClickingPizzaListButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
            var ListPizzaButton = chromeDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[2]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", ListPizzaButton);
        }

        [Then(@"Displays lists of Pizza page")]
        public void ThenDisplaysListsOfPizzaPage()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
        }

        [When(@"On clicking a Pizza's Buy button")]
        public void WhenOnClickingAPizzasBuyButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
            var AddToCartButton = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div/div[1]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", AddToCartButton);
        }

        [Then(@"Order Checkout Page will be opened")]
        public void ThenOrderCheckoutPageWillBeOpened()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(35000));
        }

        [Then(@"Checking the Pizza name if it is similar to the added Pizza name")]
        public void ThenCheckingThePizzaNameIfItIsSimilarToTheAddedPizzaName()
        {
            chromeDriver.PageSource.Contains("Pizza Name : Chicken Dominator");

        }
    }
}
