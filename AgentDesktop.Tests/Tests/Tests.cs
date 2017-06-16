using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test01FlightSearch()
        {

            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails("Rachel", "12341234");

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
        public void Test02FindCustomer()
        {
            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails("Rachel", "12341234");

            CustomerSearchPage customerSearchPage = menuPage.ClickCustomerSearch();

            customerSearchPage.ClickSearchButton();
            customerSearchPage.EnterFirstName("Ryu");
            customerSearchPage.EnterLastName("Ali");
            customerSearchPage.EnterPostcode("LU1");
            customerSearchPage.EnterEmail("jahangir.ali@easyjet.com");
            customerSearchPage.EnterEJPlusNumber("12345678");
            customerSearchPage.EnterFlightNumber("012345678");
            customerSearchPage.ClickSearchButton();

        }


        [Test]
        public void Test03CreateCustomer()
        {
            LoginPage loginPage = new LoginPage(driver);
            MenuPage menuPage = loginPage.EnterLoginDetails("Rachel", "12341234");

            CreateCustomerPage createCustomerPage = menuPage.ClickCreateCustomer();

            createCustomerPage.EnterFirstName("Ryu");
            createCustomerPage.EnterLastName("Ali");
            createCustomerPage.EnterAddressLine1("High Street");
            createCustomerPage.EnterTown("Luton");
            createCustomerPage.EnterPostalCode("LU1");
            createCustomerPage.EnterEmail("jahangir.ali@easyjet.com");
            createCustomerPage.EnterPassengerContactNumber("0123456789");

        }

        [TearDown]

       public void TestTearDown() 
        {
           // driver?.Quit();
        }
         

            //var flightSearchLink = driver.FindElement(By.Id("flightSearchLink"));
            //flightSearchLink.Click();

            //var fromAirportField = driver.FindElement(By.Id("from-airport"));
            //fromAirportField.Click();
            //fromAirportField.SendKeys("LGW" + Keys.Tab);

            //var toAirportField = driver.FindElement(By.Id("to-airport"));
            //toAirportField.Click();
            //toAirportField.SendKeys("AMS" + Keys.Tab);

            //var fromDateField = driver.FindElement(By.Id("from-date"));
            //fromDateField.Click();

            //var noOfAdult = driver.FindElement(By.Id("adults-a"));
            //noOfAdult.Click();
            //noOfAdult.SendKeys("3" + Keys.Tab);

            //var searchButton = driver.FindElement(By.Id("flight-search-button"));
            //searchButton.Click();

            //Thread.Sleep(TimeSpan.FromSeconds(5));

            //var OKButton = driver.FindElement(By.CssSelector("#erorr-modal-type-3 button[class$='btn-accept']"));
            //OKButton.Click();

        }
    }

