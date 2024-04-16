using Mars_2024.Pages;
using Mars_2024.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_2024.StepDefinitions
{
    [Binding]
    public class LanguagesStepDefinitions : CommonDriver
    {
        Login loginobj = new Login();

        [Given(@"user logs into account portal")]
        public void GivenUserLogsIntoAccountPortal()
        {
            //Open Chrome browser
            driver = new ChromeDriver();
            loginobj.LoginProcess(driver, "nkdesai8991@gmail.com", "Nidhi@123");
        }

        [Then(@"user navigates to the home screen")]
        public void ThenUserNavigatesToTheHomeScreen()
        {
            HomePage HomeObj = new HomePage();
            HomeObj.HomeScreenNavigation(driver);
            
        }

        [When(@"user create a new Language '([^']*)'")]
        public void WhenUserCreateANewLanguage(string LanguageTxt)
        {
            Languages languagesobj = new Languages();
            languagesobj.Createlanguages(driver, LanguageTxt);
        }

        [Then(@"system should save Language '([^']*)'")]
        public void ThenSystemShouldSaveLanguage(string LanguageTxt)
        {
            Languages languagesobj = new Languages();
            languagesobj.CreateLanguageAssert(driver, LanguageTxt);
        }

                [Given(@"User logs")]
        public void GivenUserLogs()
        {
            //Open Chrome browser
            driver = new ChromeDriver();
            loginobj.LoginProcess(driver, "nkdesai8991@gmail.com", "Nidhi@123");
        }

        [Then(@"User go to the home screen")]
        public void ThenUserGoToTheHomeScreen()
        {
            HomePage HomeObj = new HomePage();
            HomeObj.EditRecordNavigation(driver);
        }

        [When(@"User able to edit the record '([^']*)'")]
        public void WhenUserAbleToEditTheRecord(string editlanguagetxt)
        {
            Languages editlanguageobj = new Languages();
            editlanguageobj.EditLanguages(driver, editlanguagetxt);
        }

        [Then(@"User able to update record in language page '([^']*)'")]
        public void ThenUserAbleToUpdateRecordInLanguagePage(string editlanguagetxt)
        {
            Languages editlanguageobj = new Languages();
            editlanguageobj.EditLanguageAssert(driver, editlanguagetxt);
        }

        [Given(@"User log into Mars")]
        public void GivenUserLogIntoMars()
        {
            //Open Chrome browser
            driver = new ChromeDriver();
            loginobj.LoginProcess(driver, "nkdesai8991@gmail.com", "Nidhi@123");
        }

        [When(@"User delete an existing Language record")]
        public void WhenUserDeleteAnExistingLanguageRecord()
        {
            Languages dltlanguageobj = new Languages();
            dltlanguageobj.DeleteLanguage(driver);
        }

        [Then(@"the record should be deleted '([^']*)'")]
        public void ThenTheRecordShouldBeDeleted(string dltlanguagercod)
        {
            Languages dltlanguageobj = new Languages();
            dltlanguageobj.DltlanguageAssert(driver, dltlanguagercod);
            driver.Quit();
        }




    }
}
