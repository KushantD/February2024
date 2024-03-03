using OpenQA.Selenium;


namespace February2024.NewPages
{
    public class LoginPage
    {
        private readonly By usernameTextBoxLocator = By.Id("UserName");
        IWebElement TextBoxUser;

        private readonly By passwordTextBoxLocator = By.Id("Password");
        IWebElement PasswordTextBox;

        private readonly By loginButtonLocator = By.XPath("//body/div[@id='container']/div[1]/div[1]/section[1]/form[1]/div[3]/input[1]");
        IWebElement LoginBtn;



        public void LoginAction(IWebDriver driver, string username,string password)
        {
            string baseURL = "http://horse.industryconnect.io/";
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Identify username textbox and enter valid username

            TextBoxUser = driver.FindElement(usernameTextBoxLocator);
            TextBoxUser.SendKeys(username);

            //Identify password textbox and enter password

            PasswordTextBox = driver.FindElement(passwordTextBoxLocator);
            PasswordTextBox.SendKeys(password);

            //Identify login button and click on login Button

            IWebElement loginButton = driver.FindElement(loginButtonLocator);
            loginButton.Click();

        }
    }
}
