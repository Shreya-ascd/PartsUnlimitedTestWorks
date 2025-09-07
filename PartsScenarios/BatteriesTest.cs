//using PartsInterfaces;
//using SQLitePCL;

//namespace PUScenarios
//{
//    public class BatteriesTest
//    {
//        private IBatteries _BatteriesPage;

//        [SetUp]
//        public void SetUp()
//        {
//            _BatteriesPage = new Batteries();
//        }

//        [Test]
//        public void TestGetTitle()
//        {
//            // Act
//            string title = _BatteriesPage.GetTitle();
//            string expectedTitle = "Batteries";
//            // Assert
//            //  Assert.IsNotEmpty(title, "The title of the page should not be empty.");
//            Assert.AreEqual(expectedTitle, title, "The title of the page should match the expected value.");
//        }

//        [Test]
//        public void TestGetPartsCount()
//        {
//            // Act
//            int partsCount = _BatteriesPage.GetPartsCount();
//            int expectedPartsCount = 3;
//            // Assert
//            Assert.AreEqual(expectedPartsCount, partsCount);
//        }

//        [Test]
//        public void TestGetPartName_ValidIndex()
//        {
//            // Act
//            string partName1 = _BatteriesPage.GetPartName(0); // Retrieve the name of the second part
//            string expectedPartName1 = "12-Volt Calcium Battery";
//            // Assert
//            Assert.IsNotNull(partName1, "The part name should not be null.");
//            Assert.AreEqual(expectedPartName1, partName1, "The part name not matched");

//            // Act
//            string partName2 = _BatteriesPage.GetPartName(1); // Retrieve the name of the second part
//            string expectedPartName2 = "Spiral Coil Battery";
//            // Assert
//            Assert.IsNotNull(partName2, "The part name should not be null.");
//            Assert.AreEqual(expectedPartName2, partName2, "The part name not matched");

//            //Act
//            string partName3 = _BatteriesPage.GetPartName(2); // Retrieve the name of the second part
//            string expectedPartName3 = "Jumper Leads";
//            // Assert
//            Assert.IsNotNull(partName3, "The part name should not be null.");
//            Assert.AreEqual(expectedPartName3, partName3, "The part name not matched");
//        }



//        [Test]
//        public void TestOnClickNavigateToPartDescriptionPage_ValidIndex()
//        {
//            // Act and Assert: Simulate clicking on the first part and navigating to its description

//            _BatteriesPage.OnClickNavigateToPartDescriptionPage(0); // Click on the first part 
//            string currentUrl0 = _BatteriesPage.GetCurrentUrl();
//            string expectedUrl = "http://localhost:5001/Store/Details/13";

//            // Assuming the navigation redirects to a description page, check if the title or URL has changed
//            Assert.AreEqual(currentUrl0, expectedUrl, "Url is not matched");


//        }


//        [TearDown]
//        public void TearDown()
//        {
//            // Cleanup resources after each test
//            _BatteriesPage.CloseBrowser();
//        }

//    }
//}

using NUnit.Framework;
using PartsInterfaces;
using PartsPageClasses;

namespace PartsScenarios
{
    [TestFixture]
    public class BatteriesTest
    {
        private IBatteries _batteriesPage;

        [SetUp]
        public void SetUp()
        {
            _batteriesPage = new Batteries();
        }

        [Test]
        public void Test_GetTitle_ShouldReturnCorrectTitle()
        {
            // Act
            string title = _batteriesPage.GetTitle();

            // Assert
            Assert.AreEqual("Batteries", title, "The page title should be 'Batteries'.");
        }

        [Test]
        public void Test_GetPartsCount_ShouldReturnExpectedCount()
        {
            // Act
            int partsCount = _batteriesPage.GetPartsCount();

            // Assert (Update expected count if UI changes)
            Assert.AreEqual(3, partsCount, "The number of battery parts should match the expected value.");
        }

        [Test]
        public void Test_GetPartName_WithValidIndexes_ShouldReturnCorrectNames()
        {
            // Arrange
            string[] expectedNames = { "12-Volt Calcium Battery", "Spiral Coil Battery", "Jumper Leads" };

            for (int i = 0; i < expectedNames.Length; i++)
            {
                // Act
                string partName = _batteriesPage.GetPartName(i);

                // Assert
                Assert.IsNotNull(partName, $"Part name at index {i} should not be null.");
                Assert.AreEqual(expectedNames[i], partName, $"Part name at index {i} did not match.");
            }
        }

        [Test]
        public void Test_GetPartName_WithInvalidIndex_ShouldReturnNull()
        {
            // Act
            string partName = _batteriesPage.GetPartName(10);

            // Assert
            Assert.IsNull(partName, "Invalid index should return null.");
        }

        [Test]
        public void Test_OnClickNavigateToPartDescriptionPage_ShouldNavigateToCorrectUrl()
        {
            // Act
            _batteriesPage.OnClickNavigateToPartDescriptionPage(0);
            string currentUrl = _batteriesPage.GetCurrentUrl();

            // Assert (Update expected URL if product IDs change)
            Assert.AreEqual("http://localhost:5000/Store/Details/13", currentUrl,
                "Clicking on the first battery part should navigate to the correct description page.");
        }

        [TearDown]
        public void TearDown()
        {
            _batteriesPage.CloseBrowser();
        }
    }
}