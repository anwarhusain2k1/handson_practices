using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using TechTalk.SpecFlow.CommonModels;

namespace login.StepDefinitions
{
    public sealed class loginstepdefinition
    {
        [Given("User gives userid and password")]
        public void GivenUserGivesUseridAndPassword()
        {
            Console.WriteLine($"{nameof(GivenUserGivesUseridAndPassword)}");
        }
        [When("UserClicksLogin")]
        public void WhenUserClicksLogin() {
            Console.WriteLine($"{nameof(WhenUserClicksLogin)}");
        }
        [Then("SuccessfulLogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            Console.WriteLine($"{nameof(ThenSuccessfulLogINMessageShouldDisplay)} : {"login successful"}");
        }
    }
}
