using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoWeb.Test
{
    [Binding]
    public class ContactSteps : SeleniumTestBase
    {
        [Given(@"Goto Contact Page")]
        public void GivenGotoContactPage()
        {
            SetupTest();

            d.GoToUrl("/Home/Contact");


        }

        [Then(@"the Contact page should be displayed on the screen")]
        public void ThenTheContactPageShouldBeDisplayedOnTheScreen()
        {
            var ContactsHeaderElement = d.FindElementByXPath("/html/body/div[2]/h2");

            Assert.AreEqual("Contact.", ContactsHeaderElement.Text);

            TeardownTest();
        }
    }
}
