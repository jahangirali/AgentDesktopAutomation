using System;
using System.Threading;
using AgentDesktopFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Pages;

namespace AgentDesktopFramework
{
    public class LoginPage : Base
    {
        private IWebDriver Driver { get; set; }
        private static readonly By PageSelector = By.Id("j_username");

        public LoginPage(IWebDriver driver) : base(driver, PageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.Id, Using = "j_username")] private IWebElement Username;
        [FindsBy(How = How.Id, Using = "j_password")] private IWebElement Password;
        [FindsBy(How = How.CssSelector, Using = "button[class='btn btn-primary btn-block']")] private IWebElement SubmitButton;

        private void LoginField(string username)
        {
            Username.SendKeys(username);
        }

        private void PasswordField(string password)
        {
            Password.SendKeys(password);
        }

        private void LoginButtonClick()
        {
            SubmitButton.Click();
        }

        //public MenuPage EnterLoginDetails(string username, string password)
        //{
        //    LoginField(username);
        //    PasswordField(password);
        //    LoginButtonClick();
        //    return new MenuPage(Driver);
        //}

        public MenuPage EnterLoginDetails(UserLogin userLogin)
        {
            LoginField(userLogin.UserName);
            PasswordField(userLogin.UserPassword);
            LoginButtonClick();
            return new MenuPage(Driver);
        }

    }

}
   
