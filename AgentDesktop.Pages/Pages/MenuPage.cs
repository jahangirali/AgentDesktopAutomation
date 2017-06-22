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

        public FlightSearchPage ClickFlightSearch()
        {
            FlightSearch.Click();
            return new FlightSearchPage(Driver);
        }

        [FindsBy(How = How.Id, Using = "customerSearchLink")] private IWebElement CustomerSearch;

        public CustomerSearchPage ClickCustomerSearch()
        {
            CustomerSearch.Click();
            return new CustomerSearchPage(Driver);
        }

        [FindsBy(How = How.Id, Using = "createCustomerLink")] private IWebElement CreateCustomer;
        public CreateCustomerPage ClickCreateCustomer()
        {
            CreateCustomer.Click();
            return new CreateCustomerPage(Driver);
        }

        [FindsBy(How = How.CssSelector, Using = "a[href='/booking-search']")] private IWebElement BookingSearch;
        // [FindsBy(How = How.CssSelector, Using = "button[data-id='title'] + div ul li a span")] private IList<IWebElement> Titles;
        public BookingSearchPage ClickBookingSearch()
        {
            BookingSearch.Click();
            return new BookingSearchPage(Driver);
        }

    }
}
