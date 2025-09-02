using OpenQA.Selenium.BiDi.Communication;
using System;
using System.Collections.Generic;
using PartsInterfaces;
using PartsPageClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsScenarios
{
    internal class BrakesTestprivate
    {
        private IBrakes _brakesPage;

   [SetUp]
    public void SetUp()
    {
        // Initialize BrakesPage class before each test
        _brakesPage = new Brakes();
    }

    [Test]
    public void TestGetTitle()
    {
        // Act
        string title = _brakesPage.GetTitle();
        string expectedTitle = "Brakes";
        // Assert
        //  Assert.IsNotEmpty(title, "The title of the page should not be empty.");
        Assert.AreEqual(expectedTitle, title, "The title of the page should match the expected value.");
    }

    [Test]
    public void TestGetPartsCount()
    {
        // Act
        int partsCount = _brakesPage.GetPartsCount();
        int expectedPartsCount = 3;
        // Assert
        Assert.AreEqual(expectedPartsCount, partsCount);
    }

    [Test]
    public void TestGetPartName_ValidIndex()
    {
        // Act
        string partName1 = _brakesPage.GetPartName(0); // Retrieve the name of the second part
        string expectedPartName1 = "Disk and Pad Combo";
        // Assert
        Assert.IsNotNull(partName1, "The part name should not be null.");
        Assert.AreEqual(expectedPartName1, partName1, "The part name at index 1 should be 'Brake Disc'.");

        // Act
        string partName2 = _brakesPage.GetPartName(1); // Retrieve the name of the second part
        string expectedPartName2 = "Brake Rotor";
        // Assert
        Assert.IsNotNull(partName2, "The part name should not be null.");
        Assert.AreEqual(expectedPartName2, partName2, "The part name at index 1 should be 'Brake Disc'.");

        // Act
        string partName3 = _brakesPage.GetPartName(2); // Retrieve the name of the second part
        string expectedPartName3 = "Brake Disk and Calipers";
        // Assert
        Assert.IsNotNull(partName3, "The part name should not be null.");
        Assert.AreEqual(expectedPartName3, partName3, "The part name at index 1 should be 'Brake Disc'.");
    }



    [Test]
    public void TestOnClickNavigateToPartDescriptionPage_ValidIndex()
    {
        // Act and Assert: Simulate clicking on the first part and navigating to its description

        _brakesPage.OnClickNavigateToPartDescriptionPage(0); // Click on the first part "Brake Pad"
        string currentUrl0 = _brakesPage.GetCurrentUrl();

        // Assuming the navigation redirects to a description page, check if the title or URL has changed
        Assert.AreEqual(currentUrl0, "http://localhost:5000/Store/Details/10", "Url is not matched");


    }

    //[Test]
    //public void TestOnClickNavigateToPartDescriptionPage_InvalidIndex()
    //{
    //    // Act and Assert: Simulate clicking on an invalid part index
    //    try
    //    {
    //        _brakesPage.OnClickNavigateToPartDescriptionPage(99); // Invalid index
    //        Assert.Pass("Navigating to an invalid part index did not cause an error.");
    //    }
    //    catch (Exception)
    //    {
    //        Assert.Fail("An error should not occur when navigating to an invalid part.");
    //    }
    //}

    [TearDown]
    public void TearDown()
    {
        // Cleanup resources after each test
        _brakesPage.CloseBrowser();
    }
    }
}
