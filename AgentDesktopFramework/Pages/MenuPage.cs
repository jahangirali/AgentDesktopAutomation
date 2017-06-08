using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AgentDesktopFramework.Pages
{
    class MenuPage
    {
        private IWebDriver Driver { get; set; }

        public void FlightSearchLink()
        {
            var flightSearchLink = Driver.FindElement(By.Id("flightSearchLink"));
            flightSearchLink.Click();
        }
    }
}
