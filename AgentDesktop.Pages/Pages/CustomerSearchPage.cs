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
    public class CustomerSearchPage : Base
    {
        private IWebDriver Driver { get; set; }

        private static readonly By PageSelector = By.Id("clearCustomerSearchForm");

        public CustomerSearchPage(IWebDriver driver) : base(driver, PageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.Id, Using = "firstName")] private IWebElement FirstName;
        [FindsBy(How = How.Id, Using = "lastName")] private IWebElement Surname;
        [FindsBy(How = How.Id, Using = "postcode")] private IWebElement Postcode;
        [FindsBy(How = How.Id, Using = "email")] private IWebElement Email;

        public CustomerSearchPage EnterFirstName(string firstName)
        {
            FirstName.SendKeys(firstName + Keys.Tab);
            return this;
        }

        public CustomerSearchPage EnterLastName(string lastName)
        {
            Surname.SendKeys(lastName + Keys.Tab);
            return this;
        }

        public CustomerSearchPage EnterPostcode(string postcode)
        {
            Postcode.SendKeys(postcode + Keys.Tab);
            return this;
        }





    }
}
