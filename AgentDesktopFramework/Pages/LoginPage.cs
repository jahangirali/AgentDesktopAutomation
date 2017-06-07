using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AgentDesktopFramework
{
    public class LoginPage
    {
        private IWebDriver Driver { get; set; }

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void ExitButton()
        {
            var exitButton = Driver.FindElement(By.Id("close-drawer-link"));
            exitButton.Click();
        }
        public void LoginField()
        {
            var loginField = Driver.FindElement(By.Id("j_username"));
            loginField.Click();
        }

        public void PasswordField()
        {
            var passwordField = Driver.FindElement(By.Id("j_password"));
            passwordField.Click();
            passwordField.SendKeys("12341234");
        }

        public void LoginButtonClick()
        {
            var loginbutton = Driver.FindElement(By.CssSelector("button[type*='submit']"));
            loginbutton.Click();
        }


    }
}
   
