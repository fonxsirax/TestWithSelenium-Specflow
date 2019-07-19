using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageObject
{
    public class LoginPage
    {
        #region 1 WebElements
        [FindsBy(How = How.XPath,Using = "//*[@id='userName']/p[1]/input")]
        private IWebElement UserNameTextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='userName']/p[2]/input")]
        private IWebElement PasswordTextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='userName']/p[3]/input")]
        private IWebElement LoginButton;

        #endregion

        public LoginPage() {
            //Initializing all the web elements.
            PageFactory.InitElements(ObjectRepository.Driver, this);
        }

        #region 2 Actions
        public UserFormPage Login(string UserName, string Password) {

            UserNameTextBox.SendKeys(UserName);
            PasswordTextBox.SendKeys(Password);
            LoginButton.Click();
            return new UserFormPage();
        }
        #endregion
        #region 3 Navigation
        //none
        #endregion
    }
}
