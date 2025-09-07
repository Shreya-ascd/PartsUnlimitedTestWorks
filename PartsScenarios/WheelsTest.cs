using PartsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartsPageClasses;

namespace PartsScenarios
{
    internal class WheelsTest
    {
        private IWheels _WheelsPage;

        [SetUp]
        public void SetUp()
        {
            _WheelsPage = new Wheels();
        }

        [Test]
        public void TestGetTitle()
        {
            // Act
            string title = _WheelsPage.GetTitle();
            string expectedTitle = "Wheels & Tires";
            // Assert
            //  Assert.IsNotEmpty(title, "The title of the page should not be empty.");
            Assert.AreEqual(expectedTitle, title, "The title of the page should match the expected value.");
        }

        [Test]
        public void TestGetPartsCount()
        {
            // Act
            int partsCount = _WheelsPage.GetPartsCount();
            int expectedPartsCount = 6;
            // Assert
            Assert.AreEqual(expectedPartsCount, partsCount);
        }

        [Test]
        public void TestGetPartName_ValidIndex()
        {
            // Act
            string partName1 = _WheelsPage.GetPartName(0); // Retrieve the name of the second part
            string expectedPartName1 = "Matte Finish Rim";
            // Assert
            Assert.IsNotNull(partName1, "The part name should not be null.");
            Assert.AreEqual(expectedPartName1, partName1, "The part name not matched");

            // Act
            string partName2 = _WheelsPage.GetPartName(1); // Retrieve the name of the second part
            string expectedPartName2 = "Blue Performance Alloy Rim";
            // Assert
            Assert.IsNotNull(partName2, "The part name should not be null.");
            Assert.AreEqual(expectedPartName2, partName2, "The part name not matched");

            //Act
            string partName3 = _WheelsPage.GetPartName(2); // Retrieve the name of the second part
            string expectedPartName3 = "High Performance Rim";
            // Assert
            Assert.IsNotNull(partName3, "The part name should not be null.");
            Assert.AreEqual(expectedPartName3, partName3, "The part name not matched");

            string partName4 = _WheelsPage.GetPartName(3); // Retrieve the name of the second part
            string expectedPartName4 = "Wheel Tire Combo";
            // Assert
            Assert.IsNotNull(partName4, "The part name should not be null.");
            Assert.AreEqual(expectedPartName4, partName4, "The part name not matched");

            string partName5 = _WheelsPage.GetPartName(4); // Retrieve the name of the second part
            string expectedPartName5 = "Chrome Rim Tire Combo";
            // Assert
            Assert.IsNotNull(partName5, "The part name should not be null.");
            Assert.AreEqual(expectedPartName5, partName5, "The part name not matched");

            string partName6 = _WheelsPage.GetPartName(5); // Retrieve the name of the second part
            string expectedPartName6 = "Wheel Tire Combo (4 Pack)";
            // Assert
            Assert.IsNotNull(partName6, "The part name should not be null.");
            Assert.AreEqual(expectedPartName6, partName6, "The part name not matched");
        }



        [Test]
        public void TestOnClickNavigateToPartDescriptionPage_ValidIndex()
        {
            // Act and Assert: Simulate clicking on the first part and navigating to its description

            _WheelsPage.OnClickNavigateToPartDescriptionPage(0); // Click on the first part 
            string currentUrl0 = _WheelsPage.GetCurrentUrl();
            string expectedUrl = "http://localhost:5000/Store/Details/4";

            // Assuming the navigation redirects to a description page, check if the title or URL has changed
            Assert.AreEqual(currentUrl0, expectedUrl, "Url is not matched");


        }


        [TearDown]
        public void TearDown()
        {
            // Cleanup resources after each test
            _WheelsPage.CloseBrowser();
        }


    }
}
