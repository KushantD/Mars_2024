using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_2024.Pages
{
    public class Languages
    {
        private readonly By inputlanguagelocator = By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]");
        IWebElement languagetxtbox;
        private readonly By editlanguagelocator = By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]");
        IWebElement editlanguagetxtbox;
        private readonly By deletelanguagelocator = By.XPath("//td[contains(text(),'Hindi')]");
        IWebElement dltlanguagerecord;




        public void Createlanguages(IWebDriver driver, string LanguageTxt)
        {


            //Add Language description
            IWebElement Inputlanguage = driver.FindElement(inputlanguagelocator);
            Inputlanguage.SendKeys(LanguageTxt);
            Thread.Sleep(3000);

            //Select Level from dropdown
            IWebElement SelectLevel = driver.FindElement(By.XPath("//option[contains(text(),'Basic')]"));
            SelectLevel.Click();

            //Add on submit button
            IWebElement ClickOnAdd = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            ClickOnAdd.Click();

        }

        public void CreateLanguageAssert(IWebDriver driver, string LanguageTxt)
        {
            IWebElement Inputlanguage1 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]"));

            Assert.That(Inputlanguage1.Text != "Gujarati", "New lanaguage hasn't been added. Test failed!");
        }

        public void EditLanguages(IWebDriver driver, string editlanguagetxt)
        {


            //Change Language description
            IWebElement EditlanguageDsc = driver.FindElement(editlanguagelocator);
            EditlanguageDsc.Clear();
            EditlanguageDsc.SendKeys(editlanguagetxt);
            Thread.Sleep(5000);

            //Change Language Level
            IWebElement Editlanguagelevel = driver.FindElement(By.XPath("//option[contains(text(),'Conversational')]"));
            Editlanguagelevel.Click();

            //Click on update button
            IWebElement ClickonUpdatebtn = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            ClickonUpdatebtn.Click();
        }

        public void EditLanguageAssert(IWebDriver driver, string editlanguagetxt)
        {
            IWebElement Editlanguagerecord = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            Assert.That(Editlanguagerecord.Text != editlanguagetxt, "Language record hasn't been updated");
        }

        public void DeleteLanguage(IWebDriver driver)
        {
            try
            {
                Thread.Sleep(2000);
                //Click on Delete language button
                IWebElement ClickonEditBtn = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[2]/i[1]"));
                ClickonEditBtn.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Delete Language button is not working");
            }
        }
        public void DltlanguageAssert(IWebDriver driver, string dltlanguagercod)
        {
            IWebElement dltlanguageassert = driver.FindElement(By.XPath("//td[contains(text(),'Hindi')]"));
            Assert.That(dltlanguageassert.Text == dltlanguagercod, "Language record hasn't been deleted");
        }


    }


}
