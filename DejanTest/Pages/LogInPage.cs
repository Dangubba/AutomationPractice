using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DejanTest.Pages
{
    class LogInPage
    {
        public IWebDriver driver;

        public By loginpopup = By.Id("loginModal");

        public By usermail = By.XPath("//input[@type='email']");

        public By password = By.XPath("//input[@type='password']");

        public By subtn = By.XPath("//a[@class='btn btn-primary btn-lg btn-block' and contains(text(), 'Submit')]");

        public By edisplay = By.XPath("//a[@aria-controls='myDetails']");



        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("loginPanel")));

        }

      
    }


}
