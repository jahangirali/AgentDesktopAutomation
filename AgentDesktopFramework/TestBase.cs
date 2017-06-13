using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Selenium.Settings;

namespace AgentDesktopFramework
{
    public class TestBase
    {
        public IWebDriver WebDriver { get; set; }

        private static List<string> RequiredCookies => new List<string>
        {
            "CMSPOD",
            "RBKPOD",
            "cookies.js",
            "idb*",
            "lang2012",
            "odb*",
            "sc.ASP.NET_SESSIONID",
            "sc.Status"
        };

        [OneTimeSetUp]
        public virtual void OneTimeSetup()
        {
            //SelectBrowser();
            WebDriver = new ChromeDriver();
        }

        [SetUp]
        public void Setup()
        {
            WebDriver.Navigate().GoToUrl(SeleniumSettings.SystemUnderTest);
            DeleteTempCookies();
        }

        [TearDown]
        public void TearDown()
        {
            DeleteTempCookies();
        }

        [OneTimeTearDown]
        public virtual void OneTimeTearDown()
        {
            DeleteAllCookies();
            WebDriver?.Quit();
        }

        private void SelectBrowser()
        {
            DesiredCapabilities caps = null;
            switch (SeleniumSettings.Browser.ToLower())
            {

                case "chrome":

                    caps = BrowserCapabilities.GetChromeSettings;
                    break;
                case "firefox":
                    caps = BrowserCapabilities.GetFirefoxSettings;
                    break;
                case "internetexplorer":
                    caps = BrowserCapabilities.GetInternetExplorerSettings;
                    break;
            }
            WebDriver = new RemoteWebDriver(SeleniumSettings.GridWebDriverUrl, caps, TimeSpan.FromSeconds(150));
            WebDriver.Manage().Window.Maximize();
        }
       

        private void DeleteAllCookies()
        {
            try
            {
                if (WebDriver.Manage().Cookies.AllCookies.Count != 0)
                {
                    WebDriver.Manage().Cookies.DeleteAllCookies();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void DeleteTempCookies()
        {
            var cookies = WebDriver.Manage().Cookies.AllCookies;
            foreach (var cookie in cookies)
            {
                if (!RequiredCookies.Contains(cookie.Name))
                {
                    WebDriver.Manage().Cookies.DeleteCookie(cookie);
                }
            }
        }
    }
}
