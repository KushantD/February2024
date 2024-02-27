
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


// Thread.Sleep(100000);

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


// GO to Administration 

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

if(TimeMaterirals.Text == "TimeMateriral!")

{
Console.WriteLine("User Create record succefully");
}
else
{
Console.WriteLine("Not Create succeffully :( :(");
}