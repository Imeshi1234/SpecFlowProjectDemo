using OpenQA.Selenium;


namespace SpecFlowProjectDemo.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //Launch turnup portal and navigate to login page 
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

            //Identify Username textbox and enter valid username
            IWebElement usernametxtbox = driver.FindElement(By.Id("UserName"));
            usernametxtbox.SendKeys("hari");

            //Identify password textbox and enter valid password
            IWebElement passwordtxtbox = driver.FindElement(By.Id("Password"));
            passwordtxtbox.SendKeys("123123");

            //Identify login button and click on the button
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbutton.Click();
        }
    }
} 