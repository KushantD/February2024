
using February2024.NewPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//Open Chrome browser

public class Program
{
    private static void Main(string[] args)
    {
        //Open Chrome Browser
        IWebDriver driver = new ChromeDriver();

        LoginPage LoginObj = new LoginPage();
        LoginObj.LoginAction(driver, "hari", "123123");

        Home homeObj = new Home();
        homeObj.NavigateToTmpage(driver);
        homeObj.VerifyLoggedInUser(driver);

        TimeMaterial timeMaterialObj = new TimeMaterial();
        timeMaterialObj.CreateTmRecord(driver);
        timeMaterialObj.EditTmRecord(driver);
        timeMaterialObj.DeleteTmRecord(driver);

    }


}