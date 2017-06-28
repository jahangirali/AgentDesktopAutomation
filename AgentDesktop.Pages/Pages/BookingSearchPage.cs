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

        [FindsBy(How = How.CssSelector, Using = "#searchBooker + label")] private IWebElement Booker;
        [FindsBy(How = How.CssSelector, Using = "#searchPassenger + label")] private IWebElement Passenger;
        [FindsBy(How = How.CssSelector, Using = "#searchBoth + label")] private IWebElement Both;
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
        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")] private IWebElement SearchButton;

        private void SelectBookingType(SearchForBooking.BookingType bookingType)
        {
            switch (bookingType)
            {
                case SearchForBooking.BookingType.Booker:
                    Booker.Click();
                    break;
                case SearchForBooking.BookingType.Passenger:
                    Passenger.Click();
                    break;
                case SearchForBooking.BookingType.Both:
                    Both.Click();
                    break;
            }
        }

        private void SelectTitle(string title)
        {
            Title.Click();
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

        public BookingSearchPage EnterLastName(string lastName)
        {
            LastName.SendKeys(lastName + Keys.Tab);
            return this;
        }

        private void EnterEmail(string email)
        {
            Email.SendKeys(email + Keys.Tab);
        }

        private void EnterPostcode(string postcode)
        {
            Postcode.SendKeys(postcode +Keys.Tab);
        }

        private void EnterContactNumber(string contactNumber)
        {
            ContactNumber.SendKeys(contactNumber + Keys.Tab);
        }

        private void EnterDateOfBirth(string dateOfBirth)
        {
            DateOfBirth.SendKeys(dateOfBirth +Keys.Tab);
        }

        private void EnterTravelDocType(string travelDocType)
        {
            TravelDocType.SendKeys(travelDocType+ Keys.Tab +Keys.Enter +Keys.Tab);
        }

        private void EnterTravelDocRef(string travelDocRef)
        {
            TravelDocRef.SendKeys(travelDocRef + Keys.Enter);
           
        }

        private void ClickSearchButton()
        {
            SearchButton.Click();
        }

        public bool DoesErrorMessageDisplay()
        {
            //Console.WriteLine(ErrorMessage.Text);
            ErrorMessage.WaitUntilClickable(Driver);
            return ErrorMessage.Text.Trim() == SearchResultErrorMessage;
        }
        
        public BookingSearchPage EnterBookingSearchDetails(SearchForBooking searchForBooking)
        {
            SelectBookingType(searchForBooking.Booker);
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

        public BookingSearchPage EnterBookingSearchDetailsBooker(SearchForBooking searchForBooking)
        {
            SelectBookingType(searchForBooking.Booker);
            ClickSearchButton();
            return this;
        }
    }
}
