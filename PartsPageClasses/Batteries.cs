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
    public class Batteries : IBatteries
    {
        private IWebDriver _driver;


        public Batteries()
        {
            var options = new EdgeOptions();
            //options.UseChromium = true; // Ensure we're using the Chromium-based Edge
            _driver = new EdgeDriver(options);
            _driver.Navigate().GoToUrl("http://localhost:5000/Store/Browse?CategoryId=4");
        }

        public string GetTitle()
        {
            // Retrieve the title of the page from the browser
            string title = _driver.FindElement(By.CssSelector("body > div.container > section > h2")).Text;
            Console.WriteLine(title);
            return title;
        }

        public int GetPartsCount()
        {
            // Find all part elements (assuming parts are listed in <li> elements with a specific class)
            var parentDiv = _driver.FindElement(By.CssSelector(".row"));
            var partElements = parentDiv.FindElements(By.CssSelector(".col-lg-3.col-md-3.col-sm-3.col-xs-12"));
            Console.WriteLine(partElements.Count);
            Console.WriteLine(partElements);
            return partElements.Count;
        }

        public string GetPartName(int partIndex)
        {
            // Retrieve the part name for a specific index (assuming parts are in <li> elements with a class of "brake-part")
            var parentDiv = _driver.FindElement(By.CssSelector(".row"));
            var childElements = parentDiv.FindElements(By.CssSelector(".col-lg-3.col-md-3.col-sm-3.col-xs-12"));

            List<string> h4Texts = new List<string>();

            // Loop through each child element and extract the text inside the <h4> tag
            foreach (var element in childElements)
            {
                try
                {
                    // Find the <h4> tag inside this element and get its text
                    var h4Tag = element.FindElement(By.TagName("h4"));
                    h4Texts.Add(h4Tag.Text);
                }
                catch (NoSuchElementException)
                {
                    // If no <h4> tag is found, handle the exception
                    Console.WriteLine("No <h4> tag found in one of the elements.");
                }
            }


            if (partIndex >= 0 && partIndex < h4Texts.Count)
            {
                return h4Texts[partIndex];
            }
            return null; // Return null if the index is out of bounds
        }

        public void OnClickNavigateToPartDescriptionPage(int partIndex)
        {
            // Click on the part description link or button for a given part
            var parentDiv = _driver.FindElement(By.CssSelector(".row"));
            var childElements = parentDiv.FindElements(By.CssSelector(".col-lg-3.col-md-3.col-sm-3.col-xs-12"));


            if (partIndex >= 0 && partIndex < childElements.Count)
            {
                var part = childElements[partIndex];

                part.Click(); // Click the link/button to navigate to the part description page
            }
        }

        public string GetCurrentUrl()
        {
            return _driver.Url.ToString();
        }

        public void CloseBrowser()
        {
            _driver.Quit(); // Close the browser after the tests are done
        }

    }
}
