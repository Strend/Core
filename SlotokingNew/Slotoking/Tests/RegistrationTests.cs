using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SlotokingNew;
using System;

namespace Slotoking
{
    class RegistrationTests
    {
        protected ExtentReports _extent;
        protected ExtentTest _test;

        [OneTimeSetUp]
        protected void Setup()
        {
            string dir = TestContext.CurrentContext.TestDirectory + "\\";
            var fileName = this.GetType().ToString() + ".html";
            ExtentV3HtmlReporter htmlReporter = new ExtentV3HtmlReporter(dir + fileName);

            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);
        }
        public void BeforeTestSuit() { }
        HeaderMenu menu = new HeaderMenu();

        [SetUp]
        public void BeforeTest()
        {
            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
        }

        [Test]
        public void Registration_ByEmail_Positive()
        {

            VuePage vue = new VuePage();
            vue.Registration(false);

            StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
        }

        [Test]
        public void Registration_ByPhone_Positive()
        {
            VuePage vue = new VuePage(); ;
            vue.Registration(true);

            //StringAssert.AreEqualIgnoringCase("Введите новый пароль для того, чтобы не потерять доступ к аккаунту", vue.PopupNewPassword.Text);
            StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
        }

        [Test]
        public void Check_SeoTextBlock()
        {
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            MainPage main = new MainPage();
            main.ScrollToSeoTextBlock();
            Assert.NotNull(main.SeoBlockFooter);
        }

        [Test]
        public void Registration_AgreementLinks()
        {
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            // System.Threading.Thread.Sleep(100);
            head.RegistrationButton.Click();
            vue.RegistrationAgreementLink.Click();
            Assert.AreEqual("/agreement/", new Uri(Driver.Browser.Url).PathAndQuery);

        }



        [TearDown]
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success) Driver.TakeScreenshot();
            Driver.DisposeBrowser();
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                    ? ""
                    : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            var mediaModel = MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png");
            _test.Log(logstatus, "Test ended with " + logstatus + stacktrace + mediaModel);
           
            _extent.Flush();
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }
}
    
