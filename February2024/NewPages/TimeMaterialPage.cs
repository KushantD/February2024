using February2024.Utilities;
using OpenQA.Selenium;

namespace February2024.NewPages
{
    public class TimeMaterial
    {

        public void CreateTmRecord(IWebDriver driver)
        {

            //Click Create New time and material

            IWebElement TimeMateriralCreate = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            TimeMateriralCreate.Click();

            // Select typecode
            IWebElement SelectTypeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            SelectTypeCode.Click();

            //Add Code
            IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
            CodeTextBox.SendKeys("KKK02");

            //Add DescriptionTextBox
            IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
            DescriptionTextBox.SendKeys("KKK02");

            //Add PricePerUnit
          
            WaitUtils.WaitToBeClickable(driver, "XPath", "//body/div[@id='container']/form[@id='TimeMaterialEditForm']/div[1]/div[4]/div[1]/span[1]/span[1]/input[1]", 3);
            IWebElement PricePerUnit = driver.FindElement(By.XPath("//body/div[@id='container']/form[@id='TimeMaterialEditForm']/div[1]/div[4]/div[1]/span[1]/span[1]/input[1]"));
            PricePerUnit.SendKeys("02");

            //Clcik On SaveBtn
            WaitUtils.WaitToBeVisible(driver, "Id", "SaveButton", 2);
            IWebElement SaveBtn = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            SaveBtn.Click();

            WaitUtils.WaitToBeVisible(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]"));
            goToLastPageButton.Click();


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

        public void EditTmRecord(IWebDriver driver)
        {
            Thread.Sleep(3000);
            //Code for edit Time Record
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]"));
            goToLastPageButton.Click();
            Thread.Sleep(3000);

            //Click on Edit Button
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[3]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(3000);

            //Edit Code in Code Textbox
            IWebElement editCodeText = driver.FindElement(By.XPath("//input[@id='Code']"));
            editCodeText.Clear();
            editCodeText.SendKeys("Kushant");

            //Edit Description in Description TextBox
            IWebElement editDescriptionTextBox = driver.FindElement(By.XPath("//input[@id='Description']"));
            editDescriptionTextBox.Clear();
            editDescriptionTextBox.SendKeys("Kushant");

            //Edit Price in Price TextBox
            IWebElement editpriceOverlappingTag = driver.FindElement(By.XPath("//body/div[@id='container']/form[@id='TimeMaterialEditForm']/div[1]/div[4]/div[1]/span[1]/span[1]/input[1]"));
            IWebElement EditPriceTextBox = driver.FindElement(By.Id("Price"));
            editpriceOverlappingTag.Click();
            EditPriceTextBox.Clear();
            editpriceOverlappingTag.Click();
            EditPriceTextBox.SendKeys("500");

            //Click on Save Button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(3000);

            //Clock on goTOLastPage Button
            IWebElement editGoToLastPageButton = driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]"));
            editGoToLastPageButton.Click();

            IWebElement editCode = driver.FindElement(By.XPath("//tbody/tr[3]/td[1]"));
            IWebElement EditDescription = driver.FindElement(By.XPath("//tbody/tr[3]/td[3]")); 

            if (editCode.Text == "Kushant" && EditDescription.Text == "Kushant")
            {
                Console.WriteLine("Time record has been updated");

            }
            else
            {
                Console.WriteLine("Time record not been updated");
            }

        }
        public void DeleteTmRecord(IWebDriver driver)
        {
            //Code for delete Time Record
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]"));
            goToLastPageButton.Click();
            Thread.Sleep(3000);

            //Click on Delete Button
            IWebElement dltbutton = driver.FindElement(By.XPath("//tbody/tr[3]/td[5]/a[2]"));
            dltbutton.Click();
            Thread.Sleep(3000);

            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();

            IWebElement LastCodeInTable = driver.FindElement(By.XPath("//tbody/tr[3]/td[1]"));
            if(LastCodeInTable.Text == "Kushant")
            {
                Console.WriteLine("Time Record has not been deleted");
            }
            else
            {
                Console.WriteLine("Time Record has been deleted");
            }
        }

    }
}

