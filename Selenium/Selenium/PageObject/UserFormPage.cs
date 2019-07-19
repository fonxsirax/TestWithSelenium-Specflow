using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.BDD.UIElements;
using Selenium.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageObject
{
    public class UserFormPage
    {
        #region 1 WebElements
        [FindsBy(How = How.XPath, Using = "//*[@id='TitleId']")]
        private IWebElement Title;

        [FindsBy(How = How.XPath, Using = "//*[@id='Initial']")]
        private IWebElement Initial;

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        private IWebElement FirstName;

        [FindsBy(How = How.XPath, Using = "//*[@id='MiddleName']")]
        private IWebElement MiddleName;

        [FindsBy(How = How.XPath, Using = "//*[@id='details']/table/tbody/tr[5]/td[2]/input[1]")]
        private readonly IWebElement GenderMale;

        [FindsBy(How = How.XPath, Using = "//*[@id='details']/table/tbody/tr[5]/td[2]/input[2]")]
        private IWebElement GenderFemale;

        [FindsBy(How = How.XPath, Using = "//*[@id='details']/table/tbody/tr[6]/td[2]/input[1]")]
        private IWebElement LanguageEnglish;

        [FindsBy(How = How.XPath, Using = "//*[@id='details']/table/tbody/tr[6]/td[2]/input[2]")]
        private IWebElement LanguageHindi;

        [FindsBy(How = How.XPath, Using = "//*[@id='details']/table/tbody/tr[7]/td/input")]
        private IWebElement SaveButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='details']/div[2]/p/input")]
        private IWebElement GenerateButton;

        public UserFormPage() {
            PageFactory.InitElements(ObjectRepository.Driver, this);
        }
        #endregion
        #region 2 Actions
        public void FillingFields()
        {
            ComboBoxHelper.SelectElement(Title, 1); //select Mr. from ComboBox
            Initial.SendKeys("RAT");
            FirstName.SendKeys("Roberto");
            MiddleName.SendKeys("Sapucaia");
            GenderFemale.Click();
            LanguageEnglish.Click();
            LanguageHindi.Click();
        }
        public void Save()
        {
            SaveButton.Click();
        }
        public void Generate() {
            GenerateButton.Click();
        }
        public void ConfirmingAlert() {
            ObjectRepository.Driver.SwitchTo().Alert().Accept();
        }
        public bool IsAlertPresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }   
            catch (NoAlertPresentException Ex)
            {
                return false;
            }   
        }
        
        //public void TitleField() {

        //}
        //public void InitialField() {
        //    Initial.SendKeys("RAT");
        //}
        //public void FirstNameField() {
        //    FirstName.SendKeys("Roberto");
        //}
        //public void MiddleNameField() {
        //    MiddleName.SendKeys("Sapucaia");
        //}
        //public void GenderField() {
        //    GenderFemale.Click();
        //}
        //public void LanguagesKnownField() {
        //    LanguageEnglish.Click();
        //    LanguageHindi.Click();
        //}
        #endregion
        #region 3 Navigation

        #endregion
    }
}
