using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentDesktop.Pages.Data;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Pages;
using Selenium.Pages.Actions;

namespace AgentDesktopFramework.Pages
{
    public class BookingSearchPage : Base
    {
        private IWebDriver Driver { get; set; }

        private const string SearchResultErrorMessage = "No results have been found, please change your search criteria";

        private static readonly By PageSelector = By.Id("travelDocRef");
        public BookingSearchPage(IWebDriver webDriver) : base(webDriver, PageSelector)
        {
            Driver = webDriver;
        }

        [FindsBy(How = How.CssSelector, Using = "button[data-id='searchTitle']")] private IWebElement Title;
        [FindsBy(How = How.CssSelector, Using = "button[data-id='searchTitle'] + div ul li a span")] private IList<IWebElement> Titles;
        [FindsBy(How = How.Id, Using = "firstName")] private IWebElement FirstName;
        [FindsBy(How = How.Id, Using = "lastName")] private IWebElement LastName;
        [FindsBy(How = How.Id, Using = "email")] private IWebElement Email;
        [FindsBy(How = How.Id, Using = "postalCode")] private IWebElement Postcode;
        [FindsBy(How = How.Id, Using = "contactNumber")] private IWebElement ContactNumber;
        [FindsBy(How = How.Id, Using = "passengerDateOfBirth")] private IWebElement DateOfBirth;
        [FindsBy(How = How.CssSelector, Using = "button[data-id='travelDocType']")] private IWebElement TravelDocType;
        [FindsBy(How = How.CssSelector, Using = "button[data-id='travelDocType'] + div ul li a span")] private IList<IWebElement> TravelDocTypeList;
        [FindsBy(How = How.Id, Using = "travelDocRef")] private IWebElement TravelDocRef;
        [FindsBy(How = How.Id, Using = "resultContainer")] private IWebElement ErrorMessage;



        public BookingSearchPage SelectTitle(string title)
        {
            Title.Click();
            ClickTitle(title);
            return this;
        }

        private void ClickTitle(string title)
        {
            Titles.Single(e => e.Text == title).Click();
            //Title.SendKeys(Keys.Enter);
        }

        public BookingSearchPage EnterFirstName(string firstName)
        {
            FirstName.SendKeys(firstName + Keys.Tab);
            return this;
        }

        public BookingSearchPage EnterLastName(string lastName)
        {
            LastName.SendKeys(lastName + Keys.Tab);
            return this;
        }

        public BookingSearchPage EnterEmail(string email)
        {
            Email.SendKeys(email + Keys.Tab);
            return this;
        }

        public BookingSearchPage EnterPostcode(string postcode)
        {
            Postcode.SendKeys(postcode +Keys.Tab);
            return this;
        }

        public BookingSearchPage EnterContactNumber(string contactNumber)
        {
            ContactNumber.SendKeys(contactNumber + Keys.Tab);
            return this;
        }

        public BookingSearchPage EnterDateOfBirth(string dateOfBirth)
        {
            DateOfBirth.SendKeys(dateOfBirth +Keys.Tab);
            return this;
        }


        public BookingSearchPage EnterTravelDocType(string travelDocType)
        {
            TravelDocType.SendKeys(travelDocType+ Keys.Tab +Keys.Enter +Keys.Tab);
            return this;
        }

        public BookingSearchPage EnterTravelDocRef(string travelDocRef)
        {
            TravelDocRef.SendKeys(travelDocRef + Keys.Enter);
            return this;
        }

        public bool DoesErrorMessageDisplay()
        {
            //Console.WriteLine(ErrorMessage.Text);
            ErrorMessage.WaitUntilClickable(Driver);
            return ErrorMessage.Text.Trim() == SearchResultErrorMessage;

            
        }
        
        public BookingSearchPage EnterBookingSearchDetails(SearchForBooking searchForBooking)
        {
            SelectTitle(searchForBooking.Title);
            EnterFirstName(searchForBooking.FirstName);
            EnterLastName(searchForBooking.LastName);
            EnterEmail(searchForBooking.Email);
            EnterPostcode(searchForBooking.Postcode);
            EnterContactNumber(searchForBooking.ContactNumber);
            EnterDateOfBirth(searchForBooking.DateOfBirth);
            EnterTravelDocType(searchForBooking.TravelDocType);
            EnterTravelDocRef(searchForBooking.TravelDocRef);
            
            //ClickSearchButton();
            return this;
        }
    
}
}
