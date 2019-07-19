using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Selenium.Configuration;
using Selenium.Exeptions;
using Selenium.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.BaseClass
{
    [TestClass]
   public class BaseClass
   {
        private static IWebDriver GetChromeDriver() {
            IWebDriver driver = new ChromeDriver();
                return driver;
        }
        private static IWebDriver GetFirefoxDriver() {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc) {
            ObjectRepository.Config = new AppConfigReader();
            if (ObjectRepository.Config.GetBrowser() == BrowserType.Chrome)
            {
                ObjectRepository.Driver = GetChromeDriver();
            }
            else if (ObjectRepository.Config.GetBrowser() == BrowserType.Firefox)
            {
                ObjectRepository.Driver = GetFirefoxDriver();
            }
            else {
                throw new DriverNotFound("Driver not found : " + ObjectRepository.Config.GetBrowser().ToString());
            }

        }
        [AssemblyCleanup]
        public static void ShutDown() {
            if (ObjectRepository.Driver != null) {
                //ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }

        }

    }
}
