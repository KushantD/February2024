using Docker.DotNet.Models;
using OpenQA.Selenium;
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
