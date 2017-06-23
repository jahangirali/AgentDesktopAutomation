using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;
using Selenium.Settings;

namespace Selenium.Pages.Actions
{
    public static class Waits
    {
        public static void WaitUntilClickable(this IWebElement element, IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(Timeouts.ControlTimeout))
                .Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void WaitForDrawerToClose(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(Timeouts.ControlTimeout))
                .Until(ExpectedConditions.ElementExists(
                    By.CssSelector("div[class='drawer drawer-angular anim-slide-rtr ng-hide']")));
        }

        public static void WaitForAngularToFinish(IWebDriver driver)
        {
            try
            {
                var ngDriver = new NgWebDriver(driver);
                ngDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(10);
                ngDriver.WaitForAngular();
                Thread.Sleep(500);
            }
            catch
            {
                // ignored
            }
        }
    }
}
