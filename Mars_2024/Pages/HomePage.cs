using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Mars_2024.Pages
{
    public class HomePage
    {
        public void HomeScreenNavigation(IWebDriver driver)
        {
            try
            {
                Thread.Sleep(2000);
                //Click on Add language button
                IWebElement ClickOnAdd = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
                ClickOnAdd.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Language button is not working");
            }
        }
        public void EditRecordNavigation(IWebDriver driver)
        {
            try
            {
                Thread.Sleep(2000);
                //Click on Edit language button
                IWebElement ClickonEditBtn = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[1]/i[1]"));
                ClickonEditBtn.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Edit Language button is not working");
            }


        }
        public void SkillNavigater(IWebDriver driver)
        {
            try
            {
                Thread.Sleep(5000);
                // Go to skill feature
                IWebElement Gotoskillfeature = driver.FindElement(By.LinkText("Skills"));
                Gotoskillfeature.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Not able to navigate to skill feature");
            }

            
        }
    }
}


