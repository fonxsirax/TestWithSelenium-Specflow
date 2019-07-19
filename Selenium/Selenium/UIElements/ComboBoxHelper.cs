using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.BDD.UIElements
{
    public class ComboBoxHelper
    {
        private static SelectElement select;

        public static void SelectElement(IWebElement element, int index) {
            select = new SelectElement(element);
            select.SelectByIndex(index);
        }
        public static IList<string> GetAllItem(By locator)
        {
            select = new SelectElement(ObjectRepository.Driver.FindElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }
    }
}
