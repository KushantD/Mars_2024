using Docker.DotNet.Models;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_2024.Pages
{
    public class Skill
    {
        private readonly By inputskilllocator = By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]");
        IWebElement skillxtbox;
        private readonly By editskilllocator = By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]");
        IWebElement editskilltxtbox;
        private readonly By deleteskilllocator = By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[2]/i[1]");
        IWebElement dltskillrecord;

        private readonly By SkillLevelMainDropdown = By.XPath("//option[contains(text(),'Beginner')]");
        IWebElement SkillMainDrop;
        private readonly By SkillLevelSecondDropdown = By.XPath("//option[contains(text(),'Intermediate')]");
        IWebElement SkillSecondDrop;
        private readonly By SkillLevelThirdDropdown = By.XPath("//option[contains(text(),'Expert')]");
        IWebElement SkillThirdDrop;




        public void CreateSkillsmethod(IWebDriver driver, string skilltxt, string skillselectlevel)
        {

            Thread.Sleep(5000);
            //Click on Add language button
            IWebElement ClickOnAddSkillbtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            ClickOnAddSkillbtn.Click();


            Thread.Sleep(5000);
            //Add Skill description
            IWebElement Inputskilltxt = driver.FindElement(inputskilllocator);
            Inputskilltxt.SendKeys(skilltxt);


            Thread.Sleep(3000);
            //Select Level from dropdown
            IWebElement SelectLevel = driver.FindElement(SkillLevelMainDropdown);
            SelectLevel.Click();
                        
            //Add on submit button
            IWebElement ClickOnAdd = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
            ClickOnAdd.Click();

        }

        public void CreateskillAssert(IWebDriver driver, string skilltxt)
        {
            IWebElement Inputskill = driver.FindElement(By.XPath("//td[contains(text(),'C#')]"));

            Assert.That(Inputskill.Text != "SQL", "New skill hasn't been added. Test failed!");

            driver.Quit();
        }

        public void EditSkillRecord(IWebDriver drive, string skilltxt, string skillselectlevel)
        {

            // Click on edit button
            IWebElement editskillbtn = drive.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[1]"));
            editskillbtn.Click();

            Thread.Sleep(5000);
            //edit Skill description
            IWebElement editskilltxt = drive.FindElement(editskilllocator);
            editskilltxt.Clear();
            editskilltxt.SendKeys(skilltxt);


            Thread.Sleep(3000);
            //Select Level from dropdown
            IWebElement SelectLevel = drive.FindElement(SkillLevelMainDropdown);
            SelectLevel.Click();

            //Update on submit button
            IWebElement ClickOnUpdatebtn = drive.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            ClickOnUpdatebtn.Click();

        }

        public void EditSkillAssert(IWebDriver driver, string skilltxt)
        {
            IWebElement EditSkill = driver.FindElement(By.XPath("//td[contains(text(),'C#')]"));
            Assert.That(EditSkill.Text != "Office1", "New skill hasn't been edited. Test Failed!");
            driver.Quit();
        }

        public void DeleteSkillRecord(IWebDriver driver)
        {
            try
            {
                Thread.Sleep(2000);
                //Click on Delete language button
                IWebElement ClickonDltBtn = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[2]/i[1]"));
                ClickonDltBtn.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Delete skill button is not working");
            }
        }
        public void DeletetSkillAssert(IWebDriver driver)
        {
            IWebElement dltskillassert = driver.FindElement(By.XPath("//td[contains(text(),'C#')]"));
            Assert.That(dltskillassert.Text != "SQL", "Language record hasn't been deleted");
            driver.Quit();
        }

    }
}