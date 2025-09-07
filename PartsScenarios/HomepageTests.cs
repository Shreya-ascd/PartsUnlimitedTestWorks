//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace PartsUnlimited.Tests
//{
//    [TestFixture]
//    public class HomepageTest
//    {
//        private IWebDriver _driver;
//        private Homepage _homePage;

//        [SetUp]
//        public void Setup()
//        {
//            _driver = new ChromeDriver();
//            _driver.Manage().Window.Maximize();
//            _homePage = new Homepage(_driver);
//        }

//        [Test]
//        public void HomePage_Title_ShouldBeCorrect()
//        {
//            _homePage.NavigateToHomePage();
//            string title = _homePage.GetHomePageTitle();

//            Assert.IsTrue(title.Contains("Parts Unlimited"),
//                $"Expected title to contain 'Parts Unlimited' but got '{title}'");
//        }

//        [Test]
//        public void HomePage_Navbar_ShouldBeVisible()
//        {
//            _homePage.NavigateToHomePage();
//            bool navbarVisible = _homePage.IsNavbarVisible();

//            Assert.IsTrue(navbarVisible,
//                "Expected the navigation bar to be visible on the homepage.");
//        }

//        [Test]
//        public void HomePage_Search_ShouldNavigateToSearchResults()
//        {
//            _homePage.NavigateToHomePage();
//            _homePage.ClickSearchIcon();

//            Assert.IsTrue(_homePage.IsSearchResultsPage(),
//                "Expected navigation to Search Results page after clicking search icon.");
//        }

//        [Test]
//        public void HomePage_HomeIcon_ShouldNavigateToHome()
//        {
//            _homePage.NavigateToHomePage();
//            _homePage.ClickHomeIcon();

//            Assert.IsTrue(_homePage.GetCurrentUrl().EndsWith("/"),
//                "Expected navigation to Home page.");
//        }

//        [Test]
//        public void HomePage_CartIcon_ShouldNavigateToCart()
//        {
//            _homePage.NavigateToHomePage();
//            _homePage.ClickCartIcon();

//            Assert.IsTrue(_homePage.GetCurrentUrl().Contains("/Cart"),
//                "Expected navigation to Cart page.");
//        }

//        [Test]
//        public void HomePage_LoginIcon_ShouldNavigateToLogin()
//        {
//            _homePage.NavigateToHomePage();
//            _homePage.ClickLoginIcon();

//            Assert.IsTrue(_homePage.GetCurrentUrl().Contains("/Account/Login"),
//                "Expected navigation to Login page.");
//        }

//        [TearDown]
//        public void Teardown()
//        {
//            _driver?.Dispose();
//        }
//    }
//}


//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using PartsUnlimited.Tests.Pages;

//namespace PartsUnlimited.Tests.Features
//{
// [TestFixture]
//    public class HomepageTests
//    {
//        private IWebDriver _driver = null!;
//        private Homepage _homepage = null!;

//        [SetUp]
//        public void Setup()
//        {
//            _driver = new ChromeDriver();
//            _driver.Manage().Window.Maximize();
//            _driver.Navigate().GoToUrl("https://localhost:5001/"); // update URL if different
//            _homepage = new Homepage(_driver);
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            _driver.Quit();
//        }

//        [Test]
//        public void HomePage_Logo_ShouldBeVisible()
//        {
//            Assert.That(_homepage.IsLogoDisplayed(), Is.True, "Homepage logo is not visible.");
//        }

//        [Test]
//        public void HomePage_CartIcon_ShouldNavigateToCart()
//        {
//            _homepage.ClickCartIcon();
//            Assert.That(_driver.Url, Does.Contain("Cart"), "Cart page was not opened.");
//        }

//        [Test]
//        public void HomePage_Search_ShouldNavigateToSearchResults()
//        {
//            _homepage.SearchForItem("engine");
//            Assert.That(_driver.Url, Does.Contain("Search"), "Search did not navigate correctly.");
//        }
//    }
//}


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PartsScenarios
{
    [TestFixture]
    public class HomepageTests
    {
        private IWebDriver _driver;
        private Homepage _homepage;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://localhost:5000/");
            _homepage = new Homepage(_driver);
        }

        [Test]
        public void HomePage_Logo_ShouldBeVisible()
        {
            Assert.IsTrue(_homepage.IsLogoVisible(), "Homepage logo is not visible");
        }

        [Test]
        public void HomePage_Search_ShouldNavigateToSearchResults()
        {
            _homepage.ClickSearchIcon();
            Assert.IsTrue(_homepage.IsSearchResultsPage(), "Search results page did not load.");
        }

        [Test]
        public void HomePage_CartIcon_ShouldNavigateToCart()
        {
            _homepage.ClickCartIcon();
            Assert.IsTrue(_homepage.IsCartPage(), "Cart page did not load.");
        }

        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();   // Proper disposal to fix NUnit1032 warning
            }
        }
    }
}
