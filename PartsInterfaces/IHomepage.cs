//namespace PartsUnlimited.Tests
//{
//    public interface IHomepage
//    {
//        void NavigateToHomePage();
//        string GetHomePageTitle();
//        bool IsNavbarVisible();
//        void ClickSearchIcon();
//        bool IsSearchResultsPage();
//        void ClickHomeIcon();
//        void ClickCartIcon();
//        void ClickLoginIcon();
//        string GetCurrentUrl();
//    }
//}

using OpenQA.Selenium;

//namespace PartsUnlimited.Tests.Pages
//{
//    public interface IHomepage
//    {
//        bool IsLogoDisplayed();
//        void ClickCartIcon();
//        void SearchForItem(string query);
//    }
//}

namespace PartsScenarios
{
    public interface IHomepage
    {
        bool IsLogoVisible();
        void ClickSearchIcon();
        void ClickCartIcon();
        bool IsSearchResultsPage();
        bool IsCartPage();
    }
}
