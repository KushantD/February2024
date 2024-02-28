using Docker.DotNet.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2024.NewPages
{
    public class TimeMaterial
    {

        public void CreateTmRecord(IWebDriver driver)
        {
            IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administration.Click();

            // Click on Time and Mateieral 

            IWebElement TimeMateriral = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMateriral.Click();

            //Click Create New time and material

            IWebElement TimeMateriralCreate = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            TimeMateriralCreate.Click();

            // Select typecode
            IWebElement SelectTypeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            SelectTypeCode.Click();

            //Add Code

            IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
            CodeTextBox.SendKeys("K2312");

            //Add DescriptionTextBox

            IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
            DescriptionTextBox.SendKeys("Time Data has been added");

            //Add PricePerUnit


            IWebElement PricePerUnit = driver.FindElement(By.Id("Description"));
            PricePerUnit.SendKeys("25.12");

            //Clcik On SaveBtn

            IWebElement SaveBtn = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            SaveBtn.Click();

            IWebElement TimeMaterirals = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));

            if (TimeMaterirals.Text == "TimeMateriral!")

            {
                Console.WriteLine("User Create record succefully");
            }
            else
            {
                Console.WriteLine("Not Create succeffully :( :(");
            }

        }

            public void UpdateTmRecord(IWebDriver driver)
            {

            }
            public void DeleteTmRecord(IWebDriver driver) 
        {
        }
        }
    }

