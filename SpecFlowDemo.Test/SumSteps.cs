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
            calc.valA = p0;
        }

        [Given(@"Again I have entered (.*) into the calculator")]
        public void ThenAgainIHaveEnteredIntoTheCalculator(int p0)
        {
            calc.valB = p0;
        }

        [Given(@"Once Again I have entered (.*) into the calculator")]
        public void ThenOnceAgainIHaveEnteredIntoTheCalculator(int p0)
        {
            calc.valC = p0;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //ScenarioContext.Current.Pending();
            calc.Deduct();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, calc.result);
        }
    }
}
