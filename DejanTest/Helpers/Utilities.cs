using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DejanTest.Helpers
{


    class Utilities
    {

        public IWebDriver driver;



        public Utilities(IWebDriver driver)

        {
            this.driver = driver;
        } 


        public void EnterTextInElement(By selector, string text)

        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).SendKeys(text);
        }


        public void ClickOnElement(By selector)

        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(selector)).Click();
        }


        public bool ElementDisplayed(By selector)

        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).Displayed;
        }


    }
}
