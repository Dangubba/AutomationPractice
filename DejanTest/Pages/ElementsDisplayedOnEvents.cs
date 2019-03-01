using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DejanTest.Pages
{
    public class ElementsDisplayedOnEvents
    {
        public IWebDriver driver;

        public By eventsawards = By.XPath("//a[@href='#' and contains(text(), 'Events & Awards')]");
        public By eventbtn = By.XPath("//a[@href='/events' and contains(text(), 'Events')]");
        public By subseasmericas = By.XPath("//div[@id='AllEvents']//a[contains(text(),'Subsea Americas 2018')]");
        public By sponsor1 = By.XPath("//img[@data-id='001D000001zsRRSIA2']");
        public By sponsor2 = By.XPath("//img[@data-id='001D0000029qF1EIAU']");




        public ElementsDisplayedOnEvents(IWebDriver driver)
        {

            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//html[@lang='en-US']")));

        }

    }
}
