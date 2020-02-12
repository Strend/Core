using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Threading;

namespace Vulkan777
{
    [TestFixture]
    public class Authorization
    {

        [OneTimeSetUp]
        public void BeforeTestSuit() { }
        VuePage vue = new VuePage();
        HeaderMenu menu = new HeaderMenu();

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestDataResource777Originals.MainPageURL;
            Thread.Sleep(1200);
            menu.LoginButton.Click();

        }

        [Test]
        public void AutorizationEmailSucces()
        {
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
        }


        [Test]
        public void AutorizationPhoneSucces()
        {
            vue.Auth(TestDataResource777Originals.TestUserPhone, true);
            StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
        }


        [Test]
        public void Authorization_RestorePass_Negative()
        {
            vue.PhoneTabLogin.Click();
            vue.RestorePassButton.Click();
            vue.LoginSubmitButton.Click();

            StringAssert.AreEqualIgnoringCase("Поле Телефон обязательно для заполнения", vue.LoginEmailErrorText.Text);
        }

        [Test]
        public void Authorization_RestorePassEmail_Positive()
        {
            vue.LoginEmailTextBox.Clear();
            vue.LoginEmailTextBox.SendKeys(TestDataResource777Originals.RemindPasswordEmail);
            vue.RestorePassButton.Click();
            vue.RestorePassSubmitButton.Click();
            StringAssert.AreEqualIgnoringCase("Отправить еще раз", vue.RestorePassFinalSendMore.Text);



        }

        [Test]
        public void Authorization_VKLogin_Positive()
        {
            vue.VKLoginButton.Click();

            SocialNetworkPages vk = new SocialNetworkPages();
            vk.VKLoginTextBox.SendKeys(TestDataResource777Originals.VKLogin);
            vk.VKPassTextBox.SendKeys(TestDataResource777Originals.VKPass);
            vk.VKLoginButton.Click();

            StringAssert.AreEqualIgnoringCase("Баланс", menu.ProfileButton.Text);
        }

        [Test]
        [Ignore("not suport")]
        public void Authorization_FacebookLogin_Positive()
        {
            vue.FacebookLoginButton.Click();
            SocialNetworkPages facebook = new SocialNetworkPages();
            facebook.FaceBookLoginTextBox.SendKeys(TestDataResource777Originals.FacebookLogin);
            facebook.FaceBookPassTextBox.SendKeys(TestDataResource777Originals.FacebookPass);
            facebook.FaceBookLoginButton.Click();

            StringAssert.AreEqualIgnoringCase("Баланс", menu.ProfileButton.Text);
        }

        [Test]
        public void Authorization_GoogleLogin_Positive()
        {
            vue.GoogleLoginButton.Click();

            SocialNetworkPages google = new SocialNetworkPages();
            google.GoogleLoginTextBox.SendKeys(TestDataResource777Originals.GoogleLogin);
            google.GoogleNextButton.Click();
            google.GooglePassTextBox.SendKeys(TestDataResource777Originals.GooglePass);
            google.GooglePassNextButton.Click();


            StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
        }

        [Test]
        public void Authorization_OK_Positive()
        {
            vue.OKLoginButton.Click();
            SocialNetworkPages ok = new SocialNetworkPages();
            ok.OKLoginTextBox.SendKeys(TestDataResource777Originals.OkLogin);
            ok.OKPassTextBox.SendKeys(TestDataResource777Originals.OKPass);
            ok.OKLoginButton.Click();

            StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
        }

        [Test]
        public void Authorization_MailRU_Positive()
        {
            vue.MailRULoginButton.Click();
            SocialNetworkPages mail = new SocialNetworkPages();
            mail.MailLoginTextBox.SendKeys(TestDataResource777Originals.MailRuLogin);
            mail.MailPassTextBox.SendKeys(TestDataResource777Originals.MailRUPass);
            mail.MailRULoginButton.Click();


            StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
        }

        [Test]
        public void Authorization_Twitter_Positive()
        {
            vue.TwitterLoginButton.Click();

            SocialNetworkPages twitter = new SocialNetworkPages();
            twitter.TwitterLoginTextBox.SendKeys(TestDataResource777Originals.TwitterLogin);
            twitter.TwitterPassTextBox.SendKeys(TestDataResource777Originals.TwitterPass);
            twitter.TwitterLoginButton.Click();

            StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
        }

        [Test]
        public void Authorization_RestorePassPhone_Positive()
        {
            vue.PhoneTabLogin.Click();
            vue.LoginPhoneTextBox.Clear();
            vue.LoginPhoneTextBox.SendKeys(TestDataResource777Originals.TestRestoreUserPhone);
            vue.RestorePassButton.Click();
            vue.RestorePassSubmitButton.Click();

            StringAssert.AreEqualIgnoringCase("Отправить еще раз", vue.RestorePassFinalSendMore.Text);
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




