using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartsInterfaces;
using PartsPageClasses;
using NUnit.Framework;
using OpenQA.Selenium;


namespace PartsScenarios
{
	public class LightningTest
	{
		private ILightning _lightningPage;

		[SetUp]
		public void SetUp()
		{
			_lightningPage = new Lightning();
		}

		[Test]
		public void TestGetTitle()
		{
			// Act
			string title = _lightningPage.GetTitle();
			string expectedTitle = "Lighting";
			// Assert
			//  Assert.IsNotEmpty(title, "The title of the page should not be empty.");
			Assert.AreEqual(expectedTitle, title, "The title of the page should match the expected value.");
		}

		[Test]
		public void TestGetPartsCount()
		{
			// Act
			int partsCount = _lightningPage.GetPartsCount();
			int expectedPartsCount = 3;
			// Assert
			Assert.AreEqual(expectedPartsCount, partsCount);
		}

		[Test]
		public void TestGetPartName_ValidIndex()
		{
			// Act
			string partName1 = _lightningPage.GetPartName(0); // Retrieve the name of the second part
			string expectedPartName1 = "Halogen Headlights (2 Pack)";
			// Assert
			Assert.IsNotNull(partName1, "The part name should not be null.");
			Assert.AreEqual(expectedPartName1, partName1, "The part name not matched");

			// Act
			string partName2 = _lightningPage.GetPartName(1); // Retrieve the name of the second part
			string expectedPartName2 = "Bugeye Headlights (2 Pack)";
			// Assert
			Assert.IsNotNull(partName2, "The part name should not be null.");
			Assert.AreEqual(expectedPartName2, partName2, "The part name not matched");

			//Act
			string partName3 = _lightningPage.GetPartName(2); // Retrieve the name of the second part
			string expectedPartName3 = "Turn Signal Light Bulb";
			// Assert
			Assert.IsNotNull(partName3, "The part name should not be null.");
			Assert.AreEqual(expectedPartName3, partName3, "The part name not matched");
		}



		[Test]
		public void TestOnClickNavigateToPartDescriptionPage_ValidIndex()
		{
			// Act and Assert: Simulate clicking on the first part and navigating to its description

			_lightningPage.OnClickNavigateToPartDescriptionPage(0); // Click on the first part 
			string currentUrl0 = _lightningPage.GetCurrentUrl();
			string expectedUrl = "http://localhost:5000/Store/Details/1";

			// Assuming the navigation redirects to a description page, check if the title or URL has changed
			Assert.AreEqual(currentUrl0, expectedUrl, "Url is not matched");


		}


		[TearDown]
		public void TearDown()
		{
			// Cleanup resources after each test
			_lightningPage.CloseBrowser();
		}

	}
}
