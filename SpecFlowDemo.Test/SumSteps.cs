using System;
using TechTalk.SpecFlow;
using SpecFlowDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowDemo.Test
{
    [Binding]
    public class SumSteps
    {
        Calculator calc = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calc.rusult += p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, calc.rusult);
        }
    }
}
