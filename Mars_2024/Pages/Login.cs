using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_2024.Pages
{
    public class Login
    {

        private readonly By usernameTextBoxLocator = By.XPath("//body/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]");
        IWebElement UserTextBox;

        private readonly By passwordTextBoxLocator = By.XPath("//body/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]");
        IWebElement PasswordTextBox;

        private readonly By loginButtonLocator = By.XPath("//button[contains(text(),'Login')]");
        IWebElement LoginBtn;

        public void LoginProcess(IWebDriver driver, string UserNameText, string PasswordText)
        {
            string baseURL = "http://localhost:5000/Home";
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            //Click on Singin Button
            IWebElement SinginObj = driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
            SinginObj.Click();


            //Login User

            UserTextBox = driver.FindElement(usernameTextBoxLocator);
            UserTextBox.SendKeys(UserNameText);
            Thread.Sleep(3000);

            //Password Textbox

            PasswordTextBox = driver.FindElement(passwordTextBoxLocator);
            PasswordTextBox.SendKeys(PasswordText);

            //Click on Submit Button

            LoginBtn = driver.FindElement(loginButtonLocator);
            LoginBtn.Click();

        }

    }
}

