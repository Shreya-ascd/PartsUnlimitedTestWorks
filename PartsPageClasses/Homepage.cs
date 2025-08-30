//using OpenQA.Selenium;

//namespace PartsUnlimited.Tests
//{
//    public class Homepage : IHomepage
//    {
//        private readonly IWebDriver _driver;
//        private readonly string _baseUrl = "http://localhost:5000";

//        public Homepage(IWebDriver driver)
//        {
//            _driver = driver;
//        }

//        public void NavigateToHomePage()
//        {
//            _driver.Navigate().GoToUrl(_baseUrl);
//        }

//        public string GetHomePageTitle()
//        {
//            return _driver.Title;
//        }

//        public bool IsNavbarVisible()
//        {
//            IWebElement navbar = _driver.FindElement(By.ClassName("navbar"));
//            return navbar.Displayed;
//        }

//        public void ClickSearchIcon()
//        {
//            IWebElement searchIcon = _driver.FindElement(By.CssSelector("a[href='/Search']"));
//            searchIcon.Click();
//        }

//        public bool IsSearchResultsPage()
//        {
//            return _driver.Url.Contains("/Search");
//        }

//        public void ClickHomeIcon()
//        {
//            IWebElement homeIcon = _driver.FindElement(By.CssSelector("a[href='/']"));
//            homeIcon.Click();
//        }

//        public void ClickCartIcon()
//        {
//            IWebElement cartIcon = _driver.FindElement(By.CssSelector("a[href='/Cart']"));
//            cartIcon.Click();
//        }

//        public void ClickLoginIcon()
//        {
//            IWebElement loginIcon = _driver.FindElement(By.CssSelector("a[href='/Account/Login']"));
//            loginIcon.Click();
//        }

//        public string GetCurrentUrl()
//        {
//            return _driver.Url;
//        }
//    }
//}

//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using System;

//namespace PartsUnlimited.Tests.Pages
//{
//    public class Homepage : IHomepage
//    {
//        private readonly IWebDriver _driver;
//        private readonly WebDriverWait _wait;

//        // Locators
//        private By Logo => By.CssSelector("a.navbar-brand"); // site logo
//        private By CartIcon => By.XPath("/html/body/header/nav/div[1]/div/div[2]/div[2]/ul/li[3]/a");
//        private By SearchInput => By.XPath("/html/body/header/nav/div[1]/div/div[2]/div[2]/ul/li[1]/div/form/input[1]");
//        private By SearchButton => By.CssSelector("#search-link");

//        public Homepage(IWebDriver driver)
//        {
//            _driver = driver;
//            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//        }

//        public bool IsLogoDisplayed()
//        {
//            return _wait.Until(d => d.FindElement(Logo)).Displayed;
//        }

//        public void ClickCartIcon()
//        {
//            var cart = _wait.Until(d => d.FindElement(CartIcon));
//            cart.Click();
//        }

//        public void SearchForItem(string query)
//        {
//            var searchBox = _wait.Until(d => d.FindElement(SearchInput));
//            searchBox.Clear();
//            searchBox.SendKeys(query);

//            var searchBtn = _wait.Until(d => d.FindElement(SearchButton));
//            searchBtn.Click();
//        }
//    }
//}

using OpenQA.Selenium;

namespace PartsScenarios
{
    public class Homepage : IHomepage
    {
        private readonly IWebDriver _driver;

        // ✅ Updated locators from your provided selectors
        private readonly By _logo = By.XPath("/html/body/header/nav/div[1]/div/div[1]/a/img");
        private readonly By _searchIcon = By.CssSelector("#search-link");
        private readonly By _cartIcon = By.XPath("/html/body/header/nav/div[1]/div/div[2]/div[2]/ul/li[3]/a");

        public Homepage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsLogoVisible()
        {
            return _driver.FindElement(_logo).Displayed;
        }

        public void ClickSearchIcon()
        {
            _driver.FindElement(_searchIcon).Click();
        }

        public void ClickCartIcon()
        {
            _driver.FindElement(_cartIcon).Click();
        }

        public bool IsSearchResultsPage()
        {
            // Example: check if the search box is visible after navigating
            return _driver.FindElement(By.XPath("/html/body/header/nav/div[1]/div/div[2]/div[2]/ul/li[1]/div/form/input[1]")).Displayed;
        }

        public bool IsCartPage()
        {
            // Example: check if cart heading exists
            return _driver.Title.Contains("Cart");
        }
    }
}
