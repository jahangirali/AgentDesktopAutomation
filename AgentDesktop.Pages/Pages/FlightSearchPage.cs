using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AgentDesktopFramework.Pages
{
    public class FlightSearchPage
    {
        private IWebDriver Driver { get; set; }

        public void FromAirportField()
        {
            var fromAirportField = Driver.FindElement(By.Id("from-airport"));
            fromAirportField.Click();
            fromAirportField.SendKeys("LGW" + Keys.Tab);
        }

        public void  ToAirportField()
        {
            var toAirportField = Driver.FindElement(By.Id("to-airport"));
            toAirportField.Click();
            toAirportField.SendKeys("AMS" + Keys.Tab);
        }

    

    //var fromDateField = driver.FindElement(By.Id("from-date"));
    //fromDateField.Click();

    //var noOfAdult = driver.FindElement(By.Id("adults-a"));
    //noOfAdult.Click();
    //noOfAdult.SendKeys("3" + Keys.Tab);

    //var searchButton = driver.FindElement(By.Id("flight-search-button"));
    //searchButton.Click();

    //Thread.Sleep(TimeSpan.FromSeconds(5));

    //var OKButton = driver.FindElement(By.CssSelector("#erorr-modal-type-3 button[class$='btn-accept']"));
    //OKButton.Click();
}
}
