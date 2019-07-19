using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.NavigationTools;
using Selenium.PageObject;
using Selenium.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Selenium.StepDefinition
{
    [Binding]
    public sealed class TestSelenium
    {
        private LoginPage loginPage;
        private UserFormPage userFormPage;

        #region Given
        [Given(@"User is at Login Page")]
        public void GivenUserIsAtLoginPage()
        {
            loginPage = new LoginPage();
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
            Assert.AreEqual("Execute Automation", ObjectRepository.Driver.Title);
        }

        [Given(@"User should be at form page")]
        public void GivenUserShouldBeAtFormPage()
        {//mudar
            Assert.AreEqual("Execute Automation", ObjectRepository.Driver.Title);
        }
        #endregion

        #region When
        [When(@"User type any UserName and Password therefore press Login")]
        public void WhenUserTypeAnyUserNameAndPasswordThereforePressLogin()
        {
            userFormPage = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
        }

        [When(@"User fills: Title: Mr, Initial: RAT, FirstName -Roberto, MiddleName: sapucaia, Gender: Female, LanguagesKnown: unmark English and mark Hindi")]
        public void WhenUserFillsTitleMrInitialRATFirstName_RobertoMiddleNameSapucaiaGenderFemaleLanguagesKnownUnmarkEnglishAndMarkHindi()
        {
            userFormPage.FillingFields();
        }

        [When(@"Press button Save")]
        public void WhenPressButtonSave()
        {
            userFormPage.Save();
        }

        [When(@"Press the button Generate")]
        public void WhenPressTheButtonGenerate()
        {
            userFormPage.Generate();
        }

        [When(@"User press OK")]
        public void WhenUserPressOK()
        {
            userFormPage.ConfirmingAlert();
        }

        [When(@"User press OK the test is done\.")]
        public void WhenUserPressOKTheTestIsDone_()
        {
            userFormPage.ConfirmingAlert();
        }
        #endregion
        #region Then

        [Then(@"A Javascript alert will appear on the screen")]
        public void ThenAJavascriptAlertWillAppearOnTheScreen()
        {
            
        }


        [Then(@"Another Javascript alert will appear on the screen")]
        public void ThenAnotherJavascriptAlertWillAppearOnTheScreen()
        {
            //Assert.IsTrue(userFormPage.ConfirmingAlert());
        }
        #endregion
    }
}
