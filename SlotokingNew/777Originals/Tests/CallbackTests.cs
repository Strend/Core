using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Vulkan777
{
    [TestFixture]
    public class CallbackTests
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
        public void Callback_Positive()
        {
            Driver.Browser.Url = "http://callback.vulkanoriginals.com/";
            CallbackPage callback = new CallbackPage();

            StringAssert.AreEqualIgnoringCase("Невозможно обработать запрос \"\".", callback.ErrorText.Text);
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

