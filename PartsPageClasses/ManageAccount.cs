using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using PartsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsPageClasses
{
    public class ManageAccount : IManageAccount
    {
        private IWebDriver _driver;
        public ManageAccount()
        {
            _driver = new EdgeDriver();
            _driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        public void Navigate(string text)
        {
            _driver.FindElement(By.XPath($"//footer//a[text()='{text}']")).Click();
        }

        public string getUrl()
        {
            return _driver.Url;
        }

        public void CloseBrowser()
        {
            _driver.Quit(); // Close the browser after the tests are done
        }

        public void Login(string p)
        {
            _driver.Navigate().GoToUrl("http://localhost:5000/Account/Login");

            IWebElement usernameField = _driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
            IWebElement passwordField = _driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            //IWebElement loginButton = _driver.FindElement(By.CssSelector("input[type='submit'][value='Login']"));
            //loginButton.Click();

            // Enter valid credentials
            usernameField.SendKeys("change@asd.com");
            passwordField.SendKeys(p);

            IWebElement LogInButton = _driver.FindElement(By.XPath("//input[@value='Login']"));
            LogInButton.Click();

        }

        //public void ChangePassword()
        //{

        //    _driver.FindElement(By.XPath("//*[@id=\"manage-page\"]/div/dl/dd[1]/a")).Click();
        //    IWebElement oldPass = _driver.FindElement(By.XPath("//*[@id=\"OldPassword\"]"));
        //    IWebElement newPass = _driver.FindElement(By.XPath("//*[@id=\"NewPassword\"]"));
        //    IWebElement confirmNewPass = _driver.FindElement(By.XPath("//*[@id=\"ConfirmPassword\"]"));

        //    oldPass.SendKeys("ASDFghjk!@#$5678");
        //    newPass.SendKeys("QWERtyui!@#$5678");
        //    confirmNewPass.SendKeys("QWERtyui!@#$5678");

        //    IWebElement ChangePass = _driver.FindElement(By.XPath("/html/body/div[1]/section/div/div[1]/form/div[4]/div/input"));
        //    ChangePass.Click();
        //}

        public void ChangePassword(string oldPassword, string newPassword)
        {
            // Enter old/current password
            _driver.FindElement(By.Id("OldPassword")).SendKeys(oldPassword);

            // Enter new password
            _driver.FindElement(By.Id("NewPassword")).SendKeys(newPassword);

            // Confirm new password
            _driver.FindElement(By.Id("ConfirmPassword")).SendKeys(newPassword);

            // Click the Change Password button
            _driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        public void ChangePassword()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }

}
