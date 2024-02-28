
using February2024.NewPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//Open Chrome browser

public class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        Login LoginObj = new Login();
        LoginObj.LoginAction(driver);

        Home homeObj = new Home();
        homeObj.NavigateToTmpage(driver);
        
        TimeMaterial timeMaterialObj = new TimeMaterial();
        timeMaterialObj.CreateTmRecord(driver);
        timeMaterialObj.UpdateTmRecord(driver);
        timeMaterialObj.DeleteTmRecord(driver);



    }

       
}