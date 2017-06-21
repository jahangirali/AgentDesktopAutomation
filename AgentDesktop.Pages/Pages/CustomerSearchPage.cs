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
        [FindsBy(How = How.CssSelector, Using = "button[data-id='title']")] private IWebElement TitleDropdown;
        [FindsBy(How = How.CssSelector, Using = "button[data-id='title'] + div ul li a span")] private IList<IWebElement> Titles;
        [FindsBy(How = How.Id, Using = "firstName")] private IWebElement FirstName;
        [FindsBy(How = How.Id, Using = "lastName")] private IWebElement Surname;
        [FindsBy(How = How.Id, Using = "countryField_custom")] private IWebElement CountryDropdown;
        [FindsBy(How = How.CssSelector, Using = "input[type='search']")] private IWebElement CountryTextBox;
        [FindsBy(How = How.CssSelector, Using = "button[id='countryField_custom'] + div ul li a")] private IList<IWebElement> Country;
        [FindsBy(How = How.Id, Using = "postcode")] private IWebElement Postcode;
        [FindsBy(How = How.Id, Using = "email")] private IWebElement Email;
        [FindsBy(How = How.Id, Using = "easyjetPlusCardNumber")] private IWebElement EJPlusNumber;
        [FindsBy(How = How.Id, Using = "flightClubNumber")] private IWebElement FlightNumber;
        [FindsBy(How = How.CssSelector, Using = "button[data-container='customerSearchForm']")] private IWebElement SearchButton;
        

     
        public CustomerSearchPage SelectTitle(string title)
        {
            TitleDropdown.Click();
            ClickTitle(title);
            return this;
        }

        private void ClickTitle(string title)
        {
            Titles.Single(e => e.Text == title).Click();

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

        public CustomerSearchPage SelectCountry(string country)
        {
            CountryDropdown.Click();
            ClickCountry(country);
           
            return this;
        }
        private void ClickCountry(string country)
        {
            Country.Single(e => e.Text == country).Click();

        }

        private void EnterCountry(string country)
        {
            CountryDropdown.Click();
            CountryTextBox.SendKeys(country +Keys.Enter +Keys.Enter);

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

        private void ClickSearchButton()
        {
            SearchButton.Click();
            
        }

        public CustomerSearchPage EnterCustomerSearchDetails(SearchforCustomer searchforCustomer)
        {
            SelectTitle(searchforCustomer.Title);
            EnterFirstName(searchforCustomer.FirstName);
            EnterLastName(searchforCustomer.LastName);
            EnterCountry(searchforCustomer.Country);
            EnterPostcode(searchforCustomer.Postcode);
            EnterEmail(searchforCustomer.Email);
            EnterEJPlusNumber(searchforCustomer.EJPlusNumber);
            EnterFlightNumber(searchforCustomer.FlightNumber);

            ClickSearchButton();
            return this;
        }
    }
}
