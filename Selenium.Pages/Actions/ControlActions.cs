using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium.Pages.Actions
{
    class ControlActions
    {
        internal static void Click(this IWebElement element, IWebDriver driver)
        {
            element.WaitUntilClickable(driver);
            element.Click();
        }

        internal static void SendKeys(this IWebElement element, IWebDriver driver, string text, bool clearExistingText)
        {
            if (clearExistingText && (element.Text.Length != 0 || element.GetAttribute("value") != null))
            {
                element.Clear();
            }

            element.SendKeys(text);
        }

        public static IWebElement ScrollToElement(this IWebElement element, IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
    }
}
