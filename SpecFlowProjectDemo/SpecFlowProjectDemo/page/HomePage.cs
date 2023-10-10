using NUnit.Framework;
using OpenQA.Selenium;


namespace SpecFlowProjectDemo.Pages
{
    public class HomePage
    {
        public void VerifyUserLogin(IWebDriver driver)
        {
            //Verify if the user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            Assert.That(helloHari.Text == "Hello hari!", "Invalid Username/Password");
        }

        public void GoToTMPage(IWebDriver driver)
        {
            //Navigate to the administration dropdown 

            IWebElement administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationdropdown.Click();

            //Select time & materials module 

            IWebElement timematerialoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timematerialoption.Click();
        }
       
    }
}