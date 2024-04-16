using Docker.DotNet.Models;
using Mars_2024.Pages;
using Mars_2024.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_2024.StepDefinitions
{
    [Binding]
    public class SkillStepDefinitions : CommonDriver
    {
        Login loginobj = new Login();

        [Given(@"user logs into account screen")]
        public void GivenUserLogsIntoAccountScreen()
        {
            //Open Chrome browser
            driver = new ChromeDriver();
            loginobj.LoginProcess(driver, "nkdesai8991@gmail.com", "Nidhi@123");
        }

        [Then(@"user navigate to the home screen")]
        public void ThenUserNavigateToTheHomeScreen()
        {
            HomePage HomeObj = new HomePage();
            HomeObj.SkillNavigater(driver);
        }

        [When(@"user create new skill '([^']*)' '([^']*)'")]
        public void WhenUserCreateNewSkill(string skilltxt, string skillselectlevel)
        {
            Skill skillobj = new Skill();
            skillobj.CreateSkillsmethod(driver, skilltxt,  skillselectlevel);
        }

        [Then(@"User should able to save new skill '([^']*)'")]
        public void ThenUserShouldAbleToSaveNewSkill(string skilltxt)
        {
            Skill skillobj = new Skill();
            skillobj.CreateskillAssert(driver, skilltxt);
            
        }

        [Given(@"user logs into account and navigate to home screen")]
        public void GivenUserLogsIntoAccountAndNavigateToHomeScreen()
        {
            //Open Chrome browser
            driver = new ChromeDriver();
            loginobj.LoginProcess(driver, "nkdesai8991@gmail.com", "Nidhi@123");
            HomePage HomeObj = new HomePage();
            HomeObj.SkillNavigater(driver);
        }

        [When(@"user edit existing skill record '([^']*)' '([^']*)'")]
        public void WhenUserEditExistingSkillRecord(string skilltxt, string skillselectlevel)
        {
            Skill skilleditobj = new Skill();
            skilleditobj.EditSkillRecord(driver, skilltxt, skillselectlevel);

        }

        [Then(@"user should able to update skill record '([^']*)'")]
        public void ThenUserShouldAbleToUpdateSkillRecord(string skilltxt)
        {
            Skill skillobj = new Skill();
            skillobj.EditSkillAssert(driver, skilltxt);
            
        }

        [Given(@"User should log into Mars")]
        public void GivenUserShouldLogIntoMars()
        {

            //Open Chrome browser
            driver = new ChromeDriver();
            loginobj.LoginProcess(driver, "nkdesai8991@gmail.com", "Nidhi@123");
            HomePage HomeObj = new HomePage();
            HomeObj.SkillNavigater(driver);
        }

        [When(@"User delete an existing skill record")]
        public void WhenUserDeleteAnExistingSkillRecord()
        {
            Skill dltskillobj = new Skill();
            dltskillobj.DeleteSkillRecord(driver);
        }

        [Then(@"the record must be deleted")]
        public void ThenTheRecordMustBeDeleted()
        {
            Skill dltskillassertobj = new Skill();
            dltskillassertobj.DeletetSkillAssert(driver);
        }


    }
}
