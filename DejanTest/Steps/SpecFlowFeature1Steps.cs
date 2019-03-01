using System;
using DejanTest.Helpers;
using DejanTest.Pages;
using TechTalk.SpecFlow;

namespace DejanTest.Steps
{
    [Binding]
    public class CheckIfLoginIsPosibleSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        LogInPage log = new LogInPage(Driver);


        [Given(@"I am on login form pop up")]
        public void GivenIAmOnLoginFormPopUp()
        {
           ut.ClickOnElement(log.loginpopup);
        }


        [When(@"I enter valid email address")]
        public void WhenIEnterValidEmailAddress()
        {
            ut.EnterTextInElement(log.usermail, TestConstants.Username);
        }
        

        [When(@"I enter valid password")]
        public void WhenIEnterValidPassword()
        {
            ut.EnterTextInElement(log.password, TestConstants.Password);
        }
        

        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            ut.ClickOnElement(log.subtn);
        }
        

        [Then(@"My account page is diplayed")]
        public void ThenMyAccountPageIsDiplayed()
        {
            ut.ElementDisplayed(log.edisplay);
        }
    }
}
