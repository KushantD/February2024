using February2024.NewPages;
using February2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace February2024.Test
{
    [TestFixture]
    public class TMTest : CommonDriver
    {

        [SetUp]
        public void SetUpTimeAndMaterial()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();
            LoginPage LoginObj = new LoginPage();
            LoginObj.LoginAction(driver, "hari", "123123");
        }
        [Test, Order(1), Description("TimeMaterial Create with valid data")]
        public void TestCreateTimeMaterialRecord()
        {
            Home homeObj = new Home();
            homeObj.NavigateToTmpage(driver);
            homeObj.VerifyLoggedInUser(driver);
            TimeMaterial timeMaterialObj = new TimeMaterial();
            timeMaterialObj.CreateTmRecord(driver);
        }
        [Test, Order(2), Description("TimeMaterial Edit with valid data")]
        public void TestEditTimeMaterialRecord()
        {
            Home homeObj = new Home();
            homeObj.NavigateToTmpage(driver);
            TimeMaterial timeMaterialObj = new TimeMaterial();
            timeMaterialObj.EditTmRecord(driver);


        }
        [Test, Order(3), Description("TimeMaterial Deteted Successfully")]
        public void TestDeleteMaterialRecord()
        {
            Home homeObj = new Home();
            homeObj.NavigateToTmpage(driver);
            TimeMaterial timeMaterialObj = new TimeMaterial();
            timeMaterialObj.DeleteTmRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

        // Employees EmployeesObj = new Employees();
        // EmployeesObj.CreateEmployee(driver);
    }
}
