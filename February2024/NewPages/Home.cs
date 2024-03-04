using Docker.DotNet.Models;
using February2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2024.NewPages
{
    public class Home
    {
        public void NavigateToTmpage(IWebDriver driver)
        {
            try
            {
                //Navigate to time and Material Module(Click on the Administration Dropdown Menu Link)

                IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                Administration.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")));

                WaitUtils.WaitToBeVisible(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);
                // Click on Time and Mateieral 
                IWebElement TimeMateriral = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
                TimeMateriral.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp Portal dashboard panel is not clickable");
            }

        }
        public void VerifyLoggedInUser(IWebDriver driver)
        {

            //Check if the user has logged in successfully

            IWebElement helloHari = driver.FindElement(By.XPath("//body/div[3]/div[1]/div[1]/form[1]/ul[1]/li[1]/a[1]"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("User Logged in succefully");
            }
            else
            {
                Console.WriteLine("User not able to logged in :( :(");
            }
        }
    }
}
