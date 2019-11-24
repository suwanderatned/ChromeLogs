using System;
using System.Collections.Specialized;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using ChromeLogger;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace ChromeLogs
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Browser, LogLevel.Warning);
            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www-au.computershare.com/Employee/Login/CompanyIntroduction.aspx?lang=en&issuerid=SCAUCPU&cc=AU");
            var logs = driver.Manage().Logs;
            var log1=driver.Manage().GetType();

            var logsS = driver.Manage().Logs.GetLog(LogType.Browser);

            foreach (var log in logsS)
            {
                Console.WriteLine(log.ToString());
            }

        }





        }
}
