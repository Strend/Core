using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace Vulkan777
{
    class RegistrationTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }
        HeaderMenu menu = new HeaderMenu();

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
            vue.Registration(false);

            //StringAssert.AreEqualIgnoringCase("Введите новый пароль для того, чтобы не потерять доступ к аккаунту", vue.PopupNewPassword.Text);
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
            Driver.Browser.Url = TestDataResource777Originals.RegistrationPageUrl;

            MainPage main = new MainPage();
            main.ScrollToSeoTextBlock();
            StringAssert.AreEqualIgnoringCase("Онлайн казино 777 Оригинал приветствует уважаемых гостей на своём сайте!", main.SeoText.Text);
        }

        [Test]
        public void Registration_AgreementLinks()
        {
            Driver.Browser.Url = TestDataResource777Originals.MainPageURL;

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
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }
}
