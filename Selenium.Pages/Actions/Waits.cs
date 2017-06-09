using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Settings;

namespace Selenium.Pages.Actions
{
    class Waits
    {
        internal static void WaitUntilClickable(this IWebElement element, IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(Timeouts.ControlTimeout))
                .Until(ExpectedConditions.ElementToBeClickable(element));
        }

        internal static void WaitForDrawerToClose(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(Timeouts.ControlTimeout))
                .Until(ExpectedConditions.ElementExists(
                    By.CssSelector("div[class='drawer drawer-angular anim-slide-rtr ng-hide']")));
        }

        internal static void WaitForAngularToFinish(IWebDriver driver)
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
