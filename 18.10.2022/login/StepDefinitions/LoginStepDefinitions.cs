using System;
using TechTalk.SpecFlow;

namespace login.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"User gives userid and password")]
        public void GivenUserGivesUseridAndPassword()
        {
            Console.WriteLine($"{nameof(GivenUserGivesUseridAndPassword)}");
        }

        [When(@"UserClicksLogin")]
        public void WhenUserClicksLogin()
        {

            Console.WriteLine($"{nameof(WhenUserClicksLogin)}");

        }
        [Then(@"SuccessfulLogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
                Console.WriteLine($"{nameof(ThenSuccessfulLogINMessageShouldDisplay)} : {"login successful"}");
            }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            Console.WriteLine($"{nameof(WhenUserLogOutFromTheApplication)}");
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            Console.WriteLine($"{nameof(ThenSuccessfulLogOutMessageShouldDisplay)} : {"log Out successful"}");
        }
    }
}
