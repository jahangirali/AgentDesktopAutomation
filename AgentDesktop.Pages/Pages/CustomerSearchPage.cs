using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentDesktop.Pages.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Pages;

namespace AgentDesktopFramework.Pages
{
    public class CustomerSearchPage : Base
    {
        private IWebDriver Driver { get; set; }

        private static readonly By PageSelector = By.Id("clearCustomerSearchForm");

        public CustomerSearchPage(IWebDriver driver) : base(driver, PageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "button[data-id='title']")] private IWebElement Title;
        [FindsBy(How = How.Id, Using = "firstName")] private IWebElement FirstName;
        [FindsBy(How = How.Id, Using = "lastName")] private IWebElement Surname;
        [FindsBy(How = How.Id, Using = "postcode")] private IWebElement Postcode;
        [FindsBy(How = How.Id, Using = "email")] private IWebElement Email;
        [FindsBy(How = How.Id, Using = "easyjetPlusCardNumber")] private IWebElement EJPlusNumber;
        [FindsBy(How = How.Id, Using = "flightClubNumber")] private IWebElement FlightNumber;
        [FindsBy(How = How.CssSelector, Using = "button[data-container='customerSearchForm']")] private IWebElement SearchButton;
        

        public CustomerSearchPage SelectTitle(string title)
        {
            Title.Click();
            return this;
        }

        public CustomerSearchPage EnterFirstName(string firstName)
        {
            FirstName.SendKeys(firstName + Keys.Tab);
            return this;
        }

        public CustomerSearchPage EnterLastName(string lastName)
        {
            if (lastName != String.Empty)
            {
                Surname.SendKeys(lastName + Keys.Tab);
            }
            return this;
        }

        public CustomerSearchPage EnterPostcode(string postcode)
        {
            Postcode.SendKeys(postcode + Keys.Tab);
            return this;
        }

        public CustomerSearchPage EnterEmail(string email)
        {
            Email.SendKeys(email + Keys.Tab);
            return this;
        }


        public CustomerSearchPage EnterEJPlusNumber(string ejPlusNumber)
        {
            EJPlusNumber.SendKeys(ejPlusNumber + Keys.Tab);
            return this;
        }

        public CustomerSearchPage EnterFlightNumber(string flightNumber)
        {
            FlightNumber.SendKeys(flightNumber + Keys.Tab);
            return this;
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
            
        }

        public void EnterCustomerSearchDetails(SearchforCustomer searchforCustomer)
        {
            EnterFirstName(searchforCustomer.FirstName);
            EnterLastName(searchforCustomer.LastName);
            EnterPostcode(searchforCustomer.Postcode);
            EnterEmail(searchforCustomer.Email);
            EnterEJPlusNumber(searchforCustomer.EJPlusNumber);
            EnterFlightNumber(searchforCustomer.FlightNumber);

        }
    }
}
