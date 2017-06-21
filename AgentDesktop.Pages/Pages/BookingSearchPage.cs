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
    class BookingSearchPage : Base
    {
        private IWebDriver Driver { get; set; }

        private static readonly By PageSelector = By.Id("travelDocRef");
        public BookingSearchPage(IWebDriver webDriver) : base(webDriver, PageSelector)
        {
            Driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "searchTitle")] private IWebElement Title;
        [FindsBy(How = How.CssSelector, Using = "button[data-id='title'] + div ul li a span")] private IList<IWebElement> Titles;
        [FindsBy(How = How.Id, Using = "firstName")] private IWebElement FirstName;
        [FindsBy(How = How.Id, Using = "lastName")] private IWebElement Surname;
        [FindsBy(How = How.Id, Using = "email")] private IWebElement Email;
        [FindsBy(How = How.Id, Using = "postalcode")] private IWebElement Postcode;
        [FindsBy(How = How.Id, Using = "contactNumber")] private IWebElement ContactNumber;
        [FindsBy(How = How.Id, Using = "passengerDateOfBirth")] private IWebElement DateOfBirth;
        [FindsBy(How = How.CssSelector, Using = "button[data-id='travelDocType']")] private IWebElement TravelDocType;
        [FindsBy(How = How.CssSelector, Using = "button[data-id='travelDocType'] + div ul li a span")] private IList<IWebElement> TravelDocTypeList;
        [FindsBy(How = How.Id, Using = "travelDocRef")] private IWebElement TravelDocRef;



        public BookingSearchPage SelectTitle(string title)
        {
            Title.Click();
            ClickTitle(title);
            return this;
        }

        private void ClickTitle(string title)
        {
            Titles.Single(e => e.Text == title).Click();

        }

        public BookingSearchPage EnterFirstName(string firstName)
        {
            FirstName.SendKeys(firstName + Keys.Tab);
            return this;
        }
    }
}
