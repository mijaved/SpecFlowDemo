using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemoWeb.Test
{
    public static class DriverExtentions
    {
        static string baseURL = "http://localhost:52030";

        public static void FillText(this RemoteWebDriver d, string fieldName, string value)
        {
            var element = d.FindElementByName(fieldName);
            element.Clear();
            element.SendKeys(value);
        }

        public static void GoToUrl(this RemoteWebDriver d, string urlWithoutBase)
        {
            d.Navigate().GoToUrl(baseURL + urlWithoutBase);
        }

        public static void ClickMainGridAddButton(this RemoteWebDriver d)
        {
            d.FindElementByClassName("add-button").Click();
        }
        public static void ClickButton(this RemoteWebDriver d, string caption)
        {
            d.FindElementByClassName(caption).Click();
        }
    }
}
