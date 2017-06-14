using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Pages;

namespace AgentDesktopFramework.Pages
{
    public class MenuPage : Base
    {
        private IWebDriver Driver { get; set; }
        private static readonly By PageSelector = By.Id("flightSearchLink");

        public MenuPage(IWebDriver driver) : base(driver, PageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.Id, Using = "flightSearchLink")] private IWebElement FlightSearch;

        public void ClickFlightSearch()
        {
           FlightSearch.Click();
        }
    }
}
