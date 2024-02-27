
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//Open Chrome browser

IWebDriver driver = new ChromeDriver();


//Lainch TurnUp portal and navigate to website login page

driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
driver.Manage().Window.Maximize();

//Identify username textbox and enter valid username

IWebElement TextBoxUser = driver.FindElement(By.Id("UserName"));
TextBoxUser.SendKeys("hari");

//Identify password textbox and enter password

IWebElement PasswordTextBox = driver.FindElement(By.Id("Password"));
PasswordTextBox.SendKeys("123123");
//Identify login button and click on login Button

IWebElement loginButton = driver.FindElement(By.XPath("//body/div[@id='container']/div[1]/div[1]/section[1]/form[1]/div[3]/input[1]"));
loginButton.Click();


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