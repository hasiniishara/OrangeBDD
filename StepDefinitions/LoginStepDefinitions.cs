using NUnit.Framework;
using OpenQA.Selenium;
using OrangeBDD.POM;
using OrangeBDD.Utils;
using System;
using TechTalk.SpecFlow;

namespace OrangeBDD.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;
        private readonly LoginPage LoginPageObject;
        private readonly DashboardPage DashboardPageObject;
        public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            LoginPageObject = new LoginPage(driver);
            DashboardPageObject = new DashboardPage(driver);
        }

        [Given(@"User on system login page")]
        public void GivenUserOnSystemLoginPage()
        {
            driver.Url = "https://hasiniishara-trials714.orangehrmlive.com";
        }

        [When(@"User enter valid credentials")]
        public void WhenUserEnterValidCredentials(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
            LoginPageObject.EnterUserName(dictionary["userName"]);
            LoginPageObject.EnterPassword(dictionary["userPwd"]);
            LoginPageObject.ClickLoginBtn();
        }

        [Then(@"User should be able to see the Dashboard screen")]
        public void ThenUserShouldBeAbleToSeeTheDashboardScreen()
        {
            DashboardPageObject.VerifyDashboardTitle();
        }
    }
}
