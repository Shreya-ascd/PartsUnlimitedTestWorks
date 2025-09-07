using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartsPageClasses;
using PartsInterfaces;

namespace PartsScenarios
{
    internal class HomeFooterTest
    {
        private IHomeFooter homeFooter;

        [SetUp]
        public void SetUp()
        {
            homeFooter = new HomeFooter();
        }
        //[Test]
        //public void Test() {
        //    homeFooter.Login();
        //    //string exp=""
        //}

        [Test]
        public void TestHomeText()
        {
            homeFooter.Navigate("Home");
            string ExpectedUrl = "http://localhost:5000/";
            string ActualUrl = homeFooter.getUrl();
            Assert.AreEqual(ExpectedUrl, ActualUrl);
        }

        [Test]
        public void TestBrowseText()
        {

            homeFooter.Navigate("Browse");
            string ExpectedUrl = "http://localhost:5000/Store";
            string ActualUrl = homeFooter.getUrl();
            Assert.AreEqual(ExpectedUrl, ActualUrl);
        }

        [Test]
        public void TestManageAccountText()
        {
            homeFooter.Login();
            homeFooter.Navigate("Manage Account");
            string ExpectedUrl = "http://localhost:5000/Account/Manage";
            string ActualUrl = homeFooter.getUrl();
            Assert.AreEqual(ExpectedUrl, ActualUrl);
        }

        [Test]
        public void TestShoppingCartText()
        {
            homeFooter.Login();
            homeFooter.Navigate("Shopping Cart");
            string ExpectedUrl = "http://localhost:5000/ShoppingCart";
            string ActualUrl = homeFooter.getUrl();
            Assert.AreEqual(ExpectedUrl, ActualUrl);
        }

        //[Test]
        //public void TestViewOrdersText()
        //{
        //    homeFooter.Login();
        //    homeFooter.Navigate("View Orders");
        //    string ExpectedUrl = "http://localhost:5000/Orders/Index";
        //    string ActualUrl = homeFooter.getUrl();
        //    Assert.AreEqual(ExpectedUrl, ActualUrl);
        //}
        [Test]
        public void TestViewOrdersText()
        {
            // Step 1: Log in with valid credentials
            homeFooter.Login("hi3@gmail.com","Hi3@user");

            // Step 2: Navigate to View Orders
            homeFooter.Navigate("View Orders");

            // Step 3: Get actual URL
            string ActualUrl = homeFooter.getUrl();

            // Step 4: Assert
            string ExpectedUrl = "http://localhost:5000/Orders/Index";
            Assert.AreEqual(ExpectedUrl, ActualUrl, "User was not redirected to Orders page after login.");
        }


        [TearDown]
        public void TearDown()
        {
            homeFooter.CloseBrowser();
        }

    }
}
