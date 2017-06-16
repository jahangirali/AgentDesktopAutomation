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
    public class CreateCustomerPage : Base
    {
        private IWebDriver Driver { get; set; }

        private static readonly By PageSelector = By.Id("clearCreateCustomerForm");

        public CreateCustomerPage(IWebDriver driver) : base(driver, PageSelector)
        {
            Driver = driver;
        }
       

        [FindsBy(How = How.Id, Using = "firstName")] private IWebElement FirstName;
        [FindsBy(How = How.Id, Using = "lastName")] private IWebElement LastName;
        [FindsBy(How = How.Id, Using = "addressLine1")] private IWebElement AddressLine1;
        [FindsBy(How = How.Id, Using = "town")] private IWebElement Town;
        [FindsBy(How = How.Id, Using = "postalCode")] private IWebElement PostalCode;
        [FindsBy(How = How.Id, Using = "email")] private IWebElement Email;
        [FindsBy(How = How.Id, Using = "passengerContactNumber")] private IWebElement PassengerContactNumber;

        public CreateCustomerPage EnterFirstName(string firstName)
        {
            FirstName.SendKeys(firstName + Keys.Tab);
            return this;
        }

        public CreateCustomerPage EnterLastName(string lastName)
        {
            LastName.SendKeys(lastName + Keys.Tab);
            return this;
        }

        public CreateCustomerPage EnterAddressLine1(string addressLine1)
        {
            AddressLine1.SendKeys(addressLine1 + Keys.Tab);
            return this;
        }

        public CreateCustomerPage EnterTown(string town)
        {
            Town.SendKeys(town + Keys.Tab);
            return this;
        }
        public CreateCustomerPage EnterPostalCode(string postCode)
        {
            PostalCode.SendKeys(postCode + Keys.Tab);
            return this;
        }

        public CreateCustomerPage EnterEmail(string email)
        {
            Email.SendKeys(email + Keys.Tab);
            return this;
        }
        public CreateCustomerPage EnterPassengerContactNumber(string passengerContactNumber)
        {
            PassengerContactNumber.SendKeys(passengerContactNumber + Keys.Tab);
            return this;
        }

    }
}

