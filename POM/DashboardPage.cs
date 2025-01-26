using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeBDD.POM
{
    [Binding]
    public class DashboardPage
    {
        private IWebDriver driver;

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement DashboardTitleEle => driver.FindElement(By.XPath("//*[@id=\"topbar\"]/ul[1]/li[2]/div"));

        public void VerifyDashboardTitle()
        {
            var dashboardElementText = DashboardTitleEle.Text;
            Assert.AreEqual("Employee Management", dashboardElementText, $"Expected text 'Employee Management' does not match actual text '{dashboardElementText}'");
        }
    }
}
