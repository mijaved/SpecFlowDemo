using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SpecFlowDemoWeb.Test
{
    public class SeleniumTestBase
    {
        public RemoteWebDriver d;
        public StringBuilder verificationErrors;
        //private string baseURL;
        public bool acceptNextAlert = true;

        public IOptions opt;
        public ITimeouts timeouts;
        public WebDriverWait wait;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            //baseURL = "http://localhost:53013/";
            verificationErrors = new StringBuilder();

            d = new ChromeDriver();
            //d.Manage().Window.Maximize();
            opt = d.Manage();
            timeouts = opt.Timeouts();
            timeouts.ImplicitWait = TimeSpan.FromSeconds(10);

            wait = new WebDriverWait(d, TimeSpan.FromSeconds(10));

        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                d.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }


    }


}
