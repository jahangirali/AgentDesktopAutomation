using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace AgentDesktopFramework
{
    [TestFixture]
    public class FlightSearchPage

    {
        public IWebDriver driver;
        private String url = "https://d1adin01webr01/login?userID=defaultagent&password=12341234&site=agentDesktop";
        //private String url = "https://www.easyjet.com/en";
        
        [SetUp]
            public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
        }

        [Test]
        public void Test1()
        {
            var loginField = driver.FindElement(By.Id("j_username"));
            loginField.Click();
            loginField.SendKeys("rachel");
            
            var passwordField = driver.FindElement(By.Id("j_password"));
            passwordField.Click();
            passwordField.SendKeys("12341234");

            var loginbutton = driver.FindElement(By.CssSelector("button[type*='submit']"));
            loginbutton.Click();

            Thread.Sleep(5);

            var flightSearchLink = driver.FindElement(By.Id("flightSearchLink"));
            flightSearchLink.Click();

            var fromAirportField = driver.FindElement(By.Id("from-airport"));
            fromAirportField.Click();
            fromAirportField.SendKeys("LGW"+Keys.Tab);

            var toAirportField = driver.FindElement(By.Id("to-airport"));
            toAirportField.Click();
            toAirportField.SendKeys("AMS"+Keys.Tab);

            var fromDateField = driver.FindElement(By.Id("from-date"));
            fromDateField.Click();

            var noOfAdult = driver.FindElement(By.Id("adults-a"));
            noOfAdult.Click();
            noOfAdult.SendKeys("3"+Keys.Tab);

            var searchButton = driver.FindElement(By.Id("flight-search-button"));
            searchButton.Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));  
              
            var OKButton = driver.FindElement(By.CssSelector("#erorr-modal-type-3 button[class$='btn-accept']"));
            OKButton.Click();

        }
    }
}
