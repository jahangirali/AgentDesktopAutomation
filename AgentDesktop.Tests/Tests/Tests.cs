﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AgentDesktop.Pages.Data;
using AgentDesktop.Pages.Pages;
using NUnit.Framework;
using AgentDesktopFramework;
using AgentDesktopFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AgentDesktopFramework.Tests
{
    [TestFixture]
    public class Tests
    {
        public IWebDriver driver;

        //private String url = "https://d1adin01webr01/login?userID=defaultagent&password=12341234&site=agentDesktop";
        //private String url = "https://www.easyjet.com/en";
        private String url = "https://ad-in01-frontend.fcp.easyjet.local/login?userID=defaultagent&password=12341234&site=agentDesktop";

        public object ClickSearchButton { get; private set; }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void FlightSearch_Single()
        {

            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails(new UserLogin());

            FlightSearchPage flightSearchPage = menuPage.ClickFlightSearch();

            flightSearchPage.FromAirport("LGW");
            flightSearchPage.ToAirport("AMS");
            flightSearchPage.addAdults("5");
            flightSearchPage.addChildren("1");
            flightSearchPage.addInfantsOwnSeat("1");
            flightSearchPage.addFromDate("01/07/2017");
            flightSearchPage.ClickSubmitButton();

            
        }

        [Test]
        public void FlightSearch_Return()
        {

            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails(new UserLogin());

            FlightSearchPage flightSearchPage = menuPage.ClickFlightSearch();

            flightSearchPage.FromAirport("LTN");
            flightSearchPage.ToAirport("EDI");
            flightSearchPage.addAdults("2");
            flightSearchPage.addChildren("1");
            flightSearchPage.addInfantsOwnSeat("1");
            flightSearchPage.addFromDate("01/08/2017");
            flightSearchPage.addToDate("08/08/2017");
            flightSearchPage.ClickSubmitButton();

            Thread.Sleep(5000);
        }

        [Test]
        public void FindCustomerByTitle()
        {
            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails(new UserLogin());
            CustomerSearchPage customerSearchPage = menuPage.ClickCustomerSearch();

           // var search = new SearchforCustomer() { Title = "Mrs", FirstName = "Kate"};

           customerSearchPage.EnterCustomerSearchDetails(new SearchforCustomer() {Title = "Mrs"});
            
        }

      
        [Test]
        public void FindCustomerByLastName()
        {
            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails(new UserLogin());
            CustomerSearchPage customerSearchPage = menuPage.ClickCustomerSearch();

            customerSearchPage.EnterCustomerSearchDetails(new SearchforCustomer() { LastName = "Ali" });
        }
        [Test]
        public void FindCustomerClearSearch()
        {
            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails(new UserLogin());
            CustomerSearchPage customerSearchPage = menuPage.ClickCustomerSearch();

            customerSearchPage.EnterCustomerSearchDetails(new SearchforCustomer() { Title = "Mrs" });
            customerSearchPage.ClickClearButton();

        }

        [Test]
        public void CreateCustomer()
        {
            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails(new UserLogin());

            CreateCustomerPage createCustomerPage = menuPage.ClickCreateCustomer();
            createCustomerPage.SelectTitle("Ms");
            createCustomerPage.EnterFirstName("Ryu");
            createCustomerPage.EnterLastName("Ali");
            createCustomerPage.EnterAddressLine1("High Street");
            createCustomerPage.EnterTown("Luton");
            createCustomerPage.SelectCountry("Aruba (ABW)");
            createCustomerPage.EnterPostalCode("LU1");
            createCustomerPage.EnterEmail("jahangir.ali@easyjet.com");
            createCustomerPage.EnterPassengerContactNumber("0123456789");

        }
        [Test]
        public void BookingSearchErrorMessageDisplays()
        {
            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails(new UserLogin());
            BookingSearchPage bookingSearchPage = menuPage.ClickBookingSearch();
            
            bookingSearchPage.EnterBookingSearchDetails(new SearchForBooking());
            
            Assert.IsTrue(bookingSearchPage.DoesErrorMessageDisplay());

        }

        [Test]
        public void SearchBooker()
        {
            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails(new UserLogin());
            BookingSearchPage bookingSearchPage = menuPage.ClickBookingSearch();

            bookingSearchPage.EnterBookingSearchDetailsBooker(new SearchForBooking());

        }

        [Test]
        public void TestBackButtonInFindCustomer()
        {
            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails(new UserLogin());
            CustomerSearchPage customerSearchPage = menuPage.ClickCustomerSearch();

            customerSearchPage.SelectBackButton();
            customerSearchPage.SelectCallButton();
        }

        [TearDown]

        public void TestTearDown()
        {
            driver?.Quit();
        }


    }

 }

