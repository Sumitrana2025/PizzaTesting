using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PizzaTitleStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public PizzaTitleStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\Sumit.Rana\\Downloads\\chromedriver_win32");

        [Given(@"open pizza website")]
        public void GivenOpenPizzaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joespizzaweb.azurewebsites.net");
            Assert.IsTrue(chromeDriver.Title.Contains("Home page - Joes Pizza"));

        }

        [Then(@"check the website title")]
        public void ThenCheckTheWebsiteTitle()
        {
            
        }
    }
}
