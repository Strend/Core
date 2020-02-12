using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace VipNetGame

{

    [TestFixture]
        public class Authorization
        {
        
            [OneTimeSetUp]
            public void BeforeTestSuit() { }
                VuePage vue = new VuePage();
                RightMenu menu = new RightMenu();

        [SetUp]
            public void BeforeTest()
            {
                Driver.StartBrowser();
                Driver.Browser.Manage().Window.Maximize();
                Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL;
                menu.LoginButton.Click();

        }

            [Test]
            public void AutorizationEmailSucces()
            {
                vue.Auth(TestDataResourceVipNetGame.GameUserTest, false);
                StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ",menu.ProfileButton.Text);
            }

        
        [Test]
        public void AutorizationPhoneSucces()
        {
            vue.Auth(TestDataResourceVipNetGame.TestUserPhone, true);
            StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ", menu.ProfileButton.Text);
        }


        [Test]
        public void Authorization_RestorePass_Negative()
        {
            vue.PhoneTabLogin.Click();
            vue.RestorePassButton.Click();
            vue.LoginSubmitButton.Click();

            StringAssert.AreEqualIgnoringCase("Поле Телефон обязательно для заполнения.", vue.LoginEmailErrorText.Text);
        }

        [Test]
        public void Authorization_RestorePassEmail_Positive()
        {
            vue.LoginEmailTextBox.Clear();
            vue.LoginEmailTextBox.SendKeys(TestDataResourceVipNetGame.RemindPasswordEmail);
            vue.RestorePassButton.Click();
            vue.RestorePassSubmitButton.Click();
            StringAssert.AreEqualIgnoringCase("Отправить еще раз", vue.RestorePassFinalSendMore.Text);



        }

        [Test]
        public void Authorization_VKLogin_Positive()
        {
            vue.VKLoginButton.Click();

            SocialNetworkPages vk = new SocialNetworkPages();
            vk.VKLoginTextBox.SendKeys(TestDataResourceVipNetGame.VKLogin);
            vk.VKPassTextBox.SendKeys(TestDataResourceVipNetGame.VKPass);
            vk.VKLoginButton.Click();

            StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ", menu.ProfileButton.Text);
        }

        [Test]
        [Ignore("not suport")]
        public void Authorization_FacebookLogin_Positive()
        {
            vue.FacebookLoginButton.Click();
            SocialNetworkPages facebook = new SocialNetworkPages();
            facebook.FaceBookLoginTextBox.SendKeys(TestDataResourceVipNetGame.FacebookLogin);
            facebook.FaceBookPassTextBox.SendKeys(TestDataResourceVipNetGame.FacebookPass);
            facebook.FaceBookLoginButton.Click();

            
            StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ", menu.ProfileButton.Text);
        }

        [Test]
        public void Authorization_GoogleLogin_Positive()
        {
            vue.GoogleLoginButton.Click();

            SocialNetworkPages google = new SocialNetworkPages();
            google.GoogleLoginTextBox.SendKeys(TestDataResourceVipNetGame.GoogleLogin);
            google.GoogleNextButton.Click();
            google.GooglePassTextBox.SendKeys(TestDataResourceVipNetGame.GooglePass);
            google.GooglePassNextButton.Click();

            
            StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ", menu.ProfileButton.Text);
        }

        [Test]
        public void Authorization_OK_Positive()
        {
            vue.OKLoginButton.Click();
            SocialNetworkPages ok = new SocialNetworkPages();
            ok.OKLoginTextBox.SendKeys(TestDataResourceVipNetGame.OkLogin);
            ok.OKPassTextBox.SendKeys(TestDataResourceVipNetGame.OKPass);
            ok.OKLoginButton.Click();

            StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ", menu.ProfileButton.Text);
        }

        [Test]
        public void Authorization_MailRU_Positive()
        {
            vue.MailRULoginButton.Click();
            SocialNetworkPages mail = new SocialNetworkPages();
            mail.MailLoginTextBox.SendKeys(TestDataResourceVipNetGame.MailRuLogin);
            mail.MailPassTextBox.SendKeys(TestDataResourceVipNetGame.MailRUPass);
            mail.MailRULoginButton.Click();

           
            StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ", menu.ProfileButton.Text);
        }

        [Test]
        public void Authorization_Twitter_Positive()
        {
            vue.TwitterLoginButton.Click();

            SocialNetworkPages twitter = new SocialNetworkPages();
            twitter.TwitterLoginTextBox.SendKeys(TestDataResourceVipNetGame.TwitterLogin);
            twitter.TwitterPassTextBox.SendKeys(TestDataResourceVipNetGame.TwitterPass);
            twitter.TwitterLoginButton.Click();

            StringAssert.AreEqualIgnoringCase("ПРОФИЛЬ", menu.ProfileButton.Text);
        }

        [Test]
        public void Authorization_RestorePassPhone_Positive()
        {
            vue.PhoneTabLogin.Click();
            vue.LoginPhoneTextBox.Clear();
            vue.LoginPhoneTextBox.SendKeys(TestDataResourceVipNetGame.TestRestoreUserPhone);
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


