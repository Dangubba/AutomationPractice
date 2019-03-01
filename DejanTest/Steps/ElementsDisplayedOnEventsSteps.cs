using System;
using DejanTest.Helpers;
using DejanTest.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DejanTest.Steps
{


    

    [Binding]
    public class ElementsDisplayedOnEventsSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        ElementsDisplayedOnEvents ed = new ElementsDisplayedOnEvents(Driver);


        [Given(@"User is on homepage")]
        public void GivenUserIsOnHomepage()
        {
            
        }
        
        [When(@"User click on Events link in Navbar")]
        public void WhenUserClickOnEventsLinkInNavbar()
        {
            ut.ClickOnElement(ed.eventsawards);
            ut.ClickOnElement(ed.eventbtn);
        }
        
        [When(@"User click Subsea Americas (.*) event")]
        public void WhenUserClickSubseaAmericasEvent(int p0)
        {
            ut.ClickOnElement(ed.subseasmericas);
        }
        
        [Then(@"Silver sponsors are displayed")]
        public void ThenSilverSponsorsAreDisplayed()
        {
            ut.ElementDisplayed(ed.sponsor1);
            ut.ElementDisplayed(ed.sponsor2);
        }
    }
}
