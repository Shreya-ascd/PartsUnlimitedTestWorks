using PartsInterfaces;
using PartsPageClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsScenarios
{
    internal class ManageAccountTest
    {
        private IManageAccount manageAccount;
        [SetUp]
        public void SetUp()
        {
            manageAccount = new ManageAccount();
        }
        //[Test]
        //public void TestChangePassword()
        //{
        //    manageAccount.Login("QWERtyui!@#$5678");
        //    manageAccount.Navigate("Manage Account");
        //    manageAccount.ChangePassword();
        //    manageAccount.CloseBrowser();
        //    SetUp();
        //    manageAccount.Login("ASDFghjk!@#$5678");
        //    string ExpectedUrl = "http://localhost:5000/";
        //    string ActualUrl = manageAccount.getUrl();
        //    Assert.AreEqual(ExpectedUrl, ActualUrl);

        //}
        [Test]
        public void TestChangePassword()
        {
            // Step 1: Login with old password
            manageAccount.Login("QWERtyui!@#$5678");
            manageAccount.Navigate("Manage Account");

            // Step 2: Change password from old -> new
            manageAccount.ChangePassword("QWERtyui!@#$5678", "ASDFghjk!@#$5678");

            // Step 3: Log out (instead of closing browser abruptly)
            manageAccount.Logout();

            // Step 4: Login with new password
            manageAccount.Login("ASDFghjk!@#$5678");

            // Step 5: Verify login successful → redirected to home
            string ExpectedUrl = "http://localhost:5000/";
            string ActualUrl = manageAccount.getUrl();
            Assert.AreEqual(ExpectedUrl, ActualUrl, "Login with new password failed.");
        }


        [TearDown]
        public void TearDown()
        {
            manageAccount.CloseBrowser();
        }
    }
}
