using Selenium.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.NavigationTools
{
    class NavigationHelper
    {
        public static void NavigateToURL(string url) {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
        }
    }
}
