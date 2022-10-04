using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PizzaListStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public PizzaListStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\Sumit.Rana\\Downloads\\chromedriver_win32");


        [Given(@"I have navigate to pizza website")]
        public void GivenIHaveNavigateToPizzaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joespizzaweb.azurewebsites.net");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));

        }

        [When(@"I click on List pizza button")]
        public void WhenIClickOnListPizzaButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var ListPizzaButton = chromeDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[2]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", ListPizzaButton);

        }

        [Then(@"It shows lists of Pizza")]
        public void ThenItShowsListsOfPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2500));
        }
    }
}
