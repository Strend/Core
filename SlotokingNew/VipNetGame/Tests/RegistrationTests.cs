using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace VipNetGame
{
    class RegistrationTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
        }

        [Test]
        public void Registration_ByEmail_Positive()
        {
            VuePage vue = new VuePage();
            RightMenu hdr = new RightMenu();
            vue.Registration(false);
            StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ", hdr.ProfileButton.Text);
        }

        [Test]
        public void Registration_ByPhone_Positive()
        {
            VuePage vue = new VuePage(); ;
            RightMenu hdr = new RightMenu();
            vue.Registration(true);
            StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ", hdr.ProfileButton.Text);
        }



        [TearDown]
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success) Driver.TakeScreenshot();
            Driver.DisposeBrowser();
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }
}
