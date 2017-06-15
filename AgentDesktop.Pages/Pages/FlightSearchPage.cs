using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Pages;

namespace AgentDesktopFramework.Pages
{
    public class FlightSearchPage : Base
    {
        private IWebDriver Driver { get; set; }

        private static readonly By PageSelector = By.Id("from-airport");

        public FlightSearchPage(IWebDriver driver) : base(driver, PageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.Id, Using = "from-airport")] private IWebElement DepartingAirport;
        [FindsBy(How = How.Id, Using = "to-airport")] private IWebElement ArrivalAirport;
        [FindsBy(How = How.Id, Using = "adults-a")] private IWebElement AdultPassenger;
        [FindsBy(How = How.Id, Using = "flight-search-button")] private IWebElement SearchFlights;
        [FindsBy(How = How.Id, Using = "child-2-15")] private IWebElement ChildPassenger;
        [FindsBy(How = How.Id, Using = "infant-seats")] private IWebElement InfantPassenger;
        [FindsBy(How = How.Id, Using = "from-date")] private IWebElement FromDate;

        public FlightSearchPage FromAirport(string fromAirport)
        {
            DepartingAirport.SendKeys(fromAirport + Keys.Tab);
            return this;
        }

       public FlightSearchPage ToAirport(string toAirport)
        {
            ArrivalAirport.SendKeys(toAirport + Keys.Tab);
            return this;
        }

        public FlightSearchPage addAdults(string addAdultPassenger)
        {
            AdultPassenger.SendKeys(addAdultPassenger + Keys.Tab);
            return this;
        }


        public FlightSearchPage addChildren(string addChildrenPassenger)
        {
            ChildPassenger.SendKeys(addChildrenPassenger + Keys.Tab);
            return this;
        }

        public FlightSearchPage addInfantsOwnSeat(string addInfantsOnSeat)
        {
            InfantPassenger.SendKeys(addInfantsOnSeat);
            return this;
        }

        
        public FlightSearchPage addFromDate(string addOriginDate)
        {
            FromDate.Clear();
            FromDate.SendKeys(addOriginDate);
            return this;
        }


        public void ClickSubmitButton()
        {
            SearchFlights.Click();
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
