using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Settings;

namespace Selenium.Pages
{
    public class Base
    {
        private IWebDriver WebDriver { get; }

        public Base(IWebDriver webDriver, By bySelector)
        {
            WebDriver = webDriver;
            AssertElementIsDisplayed(bySelector, Timeouts.PageLoadTimeout);
            PageFactory.InitElements(WebDriver, this);
        }

        public Base(ISearchContext contect)
        {
            PageFactory.InitElements(contect, this);
        }

        private void AssertElementIsDisplayed(By elementId, int timeout)
        {
            for (var i = 0; i < timeout; i++)
            {
                try
                {
                    WebDriver.FindElement(elementId);
                    return;
                }
                catch (NoSuchElementException)
                {
                }
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            throw new PageNotFoundException($"Could not find element {elementId} on page {GetType().Name}");
        }
    }
}
