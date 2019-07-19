using OpenQA.Selenium;
using Selenium.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.UIElements
{
    public class TextBox
    {
        public static IWebElement element;

        public static void Type(By locator,string text) {
            element = ObjectRepository.Driver.FindElement(locator);
            element.SendKeys(text);
        }
        public static void Clear() {
            element.Clear();
        }

    }
}
