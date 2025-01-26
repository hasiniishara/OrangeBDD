using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeBDD.POM
{
    [Binding]
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement UserNameEle => driver.FindElement(By.Id("txtUsername"));
        private IWebElement UserPWdEle => driver.FindElement(By.Id("txtPassword"));
        private IWebElement LoginSubmitEle => driver.FindElement(By.XPath("//*[@id=\"frmLogin\"]/div[4]/button"));

        public void EnterUserName(string userName)
        {
            UserNameEle.SendKeys(userName);
        }

       public void EnterPassword(string password)
       {
            UserPWdEle.SendKeys(password);
       }

       public void ClickLoginBtn()
        {
            LoginSubmitEle.Click();
        }
    }
}
