//// File: PartsUtilities/DriverFactory.cs
//using OpenQA.Selenium;
//using OpenQA.Selenium.Edge;

//namespace PartsUtilities
//{
//    public static class DriverFactory
//    {
//        private static IWebDriver? _driver;

//        public static IWebDriver GetDriver(string url)
//        {
//            if (_driver == null)
//            {
//                var options = new EdgeOptions();
//                _driver = new EdgeDriver(options);
//            }

//            _driver.Navigate().GoToUrl(url);
//            return _driver;
//        }

//        public static void CloseDriver()
//        {
//            if (_driver != null)
//            {
//                _driver.Quit();
//                _driver = null;
//            }
//        }
//    }
//}

// File: PartsUtilities/DriverFactory.cs
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace PartsUtilities
{
    public static class DriverFactory
    {
        public static IWebDriver GetDriver(string url)
        {
            var options = new EdgeOptions();
            var driver = new EdgeDriver(options);
            driver.Navigate().GoToUrl(url);
            return driver;
        }
    }
}

