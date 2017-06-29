using System;
using System.Collections.Generic;
using System.Drawing.Text;
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

        [FindsBy(How = How.ClassName, Using = "button-back")] private IWebElement BackButton;
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
        [FindsBy(How = How.Id, Using = "clearCustomerSearchForm")] private IWebElement ClearButton;
        [FindsBy(How = How.ClassName, Using = "call-button")] private IWebElement CallButton;


        public  CustomerSearchPage SelectBackButton()
        {
            BackButton.Click();
            return this;
        }

        private void SelectTitle(string title)
        {
            TitleDropdown.Click();
            ClickTitle(title);
        }

        private void ClickTitle(string title)
        {
            Titles.Single(e => e.Text == title).Click();
        }

        private void EnterFirstName(string firstName)
        {
            FirstName.SendKeys(firstName + Keys.Tab);
        }

        private void EnterLastName(string lastName)
        {
            if (lastName != String.Empty)
            {
                Surname.SendKeys(lastName + Keys.Tab);
            }
        }

        private void SelectCountry(string country)
        {
            CountryDropdown.Click();
            ClickCountry(country);
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

        private void EnterPostcode(string postcode)
        {
            Postcode.SendKeys(postcode + Keys.Tab);
        }

        private void EnterEmail(string email)
        {
            Email.SendKeys(email + Keys.Tab);
        }


        private void EnterEJPlusNumber(string ejPlusNumber)
        {
            EJPlusNumber.SendKeys(ejPlusNumber + Keys.Tab);
        }

        private void EnterFlightNumber(string flightNumber)
        {
            FlightNumber.SendKeys(flightNumber + Keys.Tab);
        }

        public void ClickClearButton()
        {
            ClearButton.Click();
        }

        private void ClickSearchButton()
        {
            SearchButton.Click();            
        }

        public CustomerSearchPage SelectCallButton()
        {
            CallButton.Click();
            return this;
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
