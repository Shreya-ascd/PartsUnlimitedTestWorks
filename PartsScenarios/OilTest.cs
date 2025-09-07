using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PartsInterfaces;
using PartsPageClasses;

namespace PartsScenarios
{
    internal class OilTest
    {
        private IOil _OilPage;

        [SetUp]
        public void SetUp()
        {
            _OilPage = new Oil();
        }

        [Test]
        public void TestGetTitle()
        {
            // Act
            string title = _OilPage.GetTitle();
            string expectedTitle = "Oil";
            // Assert
            //  Assert.IsNotEmpty(title, "The title of the page should not be empty.");
            Assert.AreEqual(expectedTitle, title, "The title of the page should match the expected value.");
        }

        [Test]
        public void TestGetPartsCount()
        {
            // Act
            int partsCount = _OilPage.GetPartsCount();
            int expectedPartsCount = 3;
            // Assert
            Assert.AreEqual(expectedPartsCount, partsCount);
        }

        [Test]
        public void TestGetPartName_ValidIndex()
        {
            // Act
            string partName1 = _OilPage.GetPartName(0);
            string expectedPartName1 = "Filter Set";
            // Assert
            Assert.IsNotNull(partName1, "The part name should not be null.");
            Assert.AreEqual(expectedPartName1, partName1, "The part name not matched");

            // Act
            string partName2 = _OilPage.GetPartName(1);
            string expectedPartName2 = "Oil and Filter Combo";
            // Assert
            Assert.IsNotNull(partName2, "The part name should not be null.");
            Assert.AreEqual(expectedPartName2, partName2, "The part name not matched");

            //Act
            string partName3 = _OilPage.GetPartName(2);
            string expectedPartName3 = "Synthetic Engine Oil";
            // Assert
            Assert.IsNotNull(partName3, "The part name should not be null.");
            Assert.AreEqual(expectedPartName3, partName3, "The part name not matched");
        }



        [Test]
        public void TestOnClickNavigateToPartDescriptionPage_ValidIndex()
        {
            // Arrange: get the expected URL from href before clicking
            string expectedUrl = _OilPage.GetPartUrl(0);

            // Act: click on the first part
            _OilPage.OnClickNavigateToPartDescriptionPage(0);
            string actualUrl = _OilPage.GetCurrentUrl();

            // Assert
            Assert.AreEqual(expectedUrl, actualUrl, "URL is not matched after navigation.");
        }


        [TearDown]
        public void TearDown()
        {
            // Cleanup resources after each test
            _OilPage.CloseBrowser();
        }


    }
}
