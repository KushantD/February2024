using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace February2024.NewPages
{
    public class Login
    {
        private readonly By usernameTextBoxLocator = By.Id("UserName"); 
        IWebElement TextBoxUser;

        private readonly By passwordTextBoxLocator = By.Id("Password");
        IWebElement PasswordTextBox;

        private readonly By loginButton = By.XPath("//body/div[@id='container']/div[1]/div[1]/section[1]/form[1]/div[3]/input[1]");
        IWebElement LoginBtn;



        public void LoginAction(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();

            //Identify username textbox and enter valid username

             TextBoxUser = driver.FindElement(By.Id("UserName"));
             TextBoxUser.SendKeys("hari");

            //Identify password textbox and enter password

               PasswordTextBox = driver.FindElement(By.Id("Password"));
               PasswordTextBox.SendKeys("123123");


            // Thread.Sleep(100000);

            //Identify login button and click on login Button

            IWebElement loginButton = driver.FindElement(By.XPath("//body/div[@id='container']/div[1]/div[1]/section[1]/form[1]/div[3]/input[1]"));
            loginButton.Click();

        }
    }
}
