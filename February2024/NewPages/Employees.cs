using Docker.DotNet.Models;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2024.NewPages
{
    public class Employees

    {


        public void CreateEmployee(IWebDriver driver)
        {

            //Click Create New Employees
            
            IWebElement EmployeeCreate = driver.FindElement(By.XPath("//a[contains(text(),'Create')]"));
            EmployeeCreate.Click();
            Thread.Sleep(3000);

            //Enter Name 
            IWebElement NameCreate = driver.FindElement(By.XPath("//input[@id='Name']"));
            NameCreate.SendKeys("Kushant");

            //Enter UserName 
            IWebElement UserNameEnter = driver.FindElement(By.XPath("//input[@id='Name']"));
            UserNameEnter.SendKeys("Kush91");

            //Enter Password
            IWebElement EnterPasswordText = driver.FindElement(By.XPath("///input[@id='RetypePassword']"));
            EnterPasswordText.SendKeys("123123123");

            //Enter RePassword
            IWebElement ReEnterPassword = driver.FindElement(By.XPath("//input[@id='Password']"));
            ReEnterPassword.SendKeys("123123123");

            //Click On Sumbmit Btn
            IWebElement ClickOnSUmitBtn = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            ClickOnSUmitBtn.Click();

        }
    }
}

