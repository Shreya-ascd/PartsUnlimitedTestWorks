using PartsInterfaces;
using PartsPageClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsScenarios
{
    internal class MoreTest
    {
        private IMore _MorePage;

        [SetUp]
        public void SetUp()
        {
            _MorePage = new More();
        }

        [Test]
        public void TestGetTitle()
        {
            // Act
            string title = _MorePage.GetTitle();
            string expectedTitle = "Browse Categories";
            // Assert
            //  Assert.IsNotEmpty(title, "The title of the page should not be empty.");
            Assert.AreEqual(expectedTitle, title, "The title of the page should match the expected value.");
        }

        [Test]
        public void TestGetPartsCount()
        {
            // Act
            int partsCount = _MorePage.GetPartsCount();
            int expectedPartsCount = 5;
            // Assert
            Assert.AreEqual(expectedPartsCount, partsCount);
        }

        [Test]
        public void TestGetPartName_ValidIndex()
        {
            // Act
            string partName1 = _MorePage.GetPartName(0); // Retrieve the name of the second part
            string expectedPartName1 = "Brakes";
            // Assert
            Assert.IsNotNull(partName1, "The part name should not be null.");
            Assert.AreEqual(expectedPartName1, partName1, "The part name not matched");

            // Act
            string partName2 = _MorePage.GetPartName(1); // Retrieve the name of the second part
            string expectedPartName2 = "Lighting";
            // Assert
            Assert.IsNotNull(partName2, "The part name should not be null.");
            Assert.AreEqual(expectedPartName2, partName2, "The part name not matched");

            //Act
            string partName3 = _MorePage.GetPartName(2); // Retrieve the name of the second part
            string expectedPartName3 = "Wheels & Tires";
            // Assert
            Assert.IsNotNull(partName3, "The part name should not be null.");
            Assert.AreEqual(expectedPartName3, partName3, "The part name not matched");

            string partName4 = _MorePage.GetPartName(3); // Retrieve the name of the second part
            string expectedPartName4 = "Batteries";
            // Assert
            Assert.IsNotNull(partName4, "The part name should not be null.");
            Assert.AreEqual(expectedPartName4, partName4, "The part name not matched");

            string partName5 = _MorePage.GetPartName(4); // Retrieve the name of the second part
            string expectedPartName5 = "Oil";
            // Assert
            Assert.IsNotNull(partName5, "The part name should not be null.");
            Assert.AreEqual(expectedPartName5, partName5, "The part name not matched");
        }



        [Test]
        public void TestOnClickNavigateToPartDescriptionPage_ValidIndex()
        {
            // Act and Assert: Simulate clicking on the first part and navigating to its description

            _MorePage.OnClickNavigateToPartDescriptionPage(0); // Click on the first part 
            string currentUrl0 = _MorePage.GetCurrentUrl();
            string expectedUrl = "http://localhost:5000/Store/Browse?categoryId=1";

            // Assuming the navigation redirects to a description page, check if the title or URL has changed
            Assert.AreEqual(currentUrl0, expectedUrl, "Url is not matched");


        }


        [TearDown]
        public void TearDown()
        {
            // Cleanup resources after each test
            _MorePage.CloseBrowser();
        }


    }
}
