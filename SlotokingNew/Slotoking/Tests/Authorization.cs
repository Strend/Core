using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SlotokingNew;
using System.Threading;


namespace Slotoking
{


    [TestFixture]
    public class Authorization
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
            VuePage vue = new VuePage();
            HeaderMenu menu = new HeaderMenu();

            [SetUp]
            public void BeforeTest()
            {
            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Driver.StartBrowser();
                Driver.Browser.Manage().Window.Maximize();
                Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
                Thread.Sleep(1200);
                menu.LoginButton.Click();

            }

            [Test]
            public void AutorizationEmailSucces()
            {
            
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }


            [Test]
            public void AutorizationPhoneSucces()
            {
                vue.Auth(TestDataResourceSlotoking.TestUserPhone, true);
                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }


            [Test]
            public void Authorization_RestorePass_Negative()
            {
                vue.PhoneTabLogin.Click();
                vue.RestorePassButton.Click();
                vue.LoginSubmitButton.Click();

                StringAssert.AreEqualIgnoringCase("Поле Номер телефона обязательно для заполнения", vue.LoginEmailErrorText.Text);
            }

            [Test]
            public void Authorization_RestorePassEmail_Positive()
            {
                vue.LoginEmailTextBox.Clear();
                vue.LoginEmailTextBox.SendKeys(TestDataResourceSlotoking.RemindPasswordEmail);
                vue.RestorePassButton.Click();
                vue.RestorePassSubmitButton.Click();
                StringAssert.AreEqualIgnoringCase("Отправить еще раз", vue.RestorePassFinalSendMore.Text);



            }

            [Test]
            public void Authorization_VKLogin_Positive()
            {
            
            vue.VKLoginButton.Click();

                SocialNetworkPages vk = new SocialNetworkPages();
                vk.VKLoginTextBox.SendKeys(TestDataResourceSlotoking.VKLogin);
                vk.VKPassTextBox.SendKeys(TestDataResourceSlotoking.VKPass);
                vk.VKLoginButton.Click();

                StringAssert.AreEqualIgnoringCase("Баланс", menu.ProfileButton.Text);
            }

            [Test]
            [Ignore("not suport")]
            public void Authorization_FacebookLogin_Positive()
            {
                vue.FacebookLoginButton.Click();
                SocialNetworkPages facebook = new SocialNetworkPages();
                facebook.FaceBookLoginTextBox.SendKeys(TestDataResourceSlotoking.FacebookLogin);
                facebook.FaceBookPassTextBox.SendKeys(TestDataResourceSlotoking.FacebookPass);
                facebook.FaceBookLoginButton.Click();

                StringAssert.AreEqualIgnoringCase("Баланс", menu.ProfileButton.Text);
            }

            [Test]
            public void Authorization_GoogleLogin_Positive()
            {
                vue.GoogleLoginButton.Click();

                SocialNetworkPages google = new SocialNetworkPages();
                google.GoogleLoginTextBox.SendKeys(TestDataResourceSlotoking.GoogleLogin);
                google.GoogleNextButton.Click();
                google.GooglePassTextBox.SendKeys(TestDataResourceSlotoking.GooglePass);
                google.GooglePassNextButton.Click();


                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }

            [Test]
            public void Authorization_OK_Positive()
            {
                vue.OKLoginButton.Click();
                SocialNetworkPages ok = new SocialNetworkPages();
                ok.OKLoginTextBox.SendKeys(TestDataResourceSlotoking.OkLogin);
                ok.OKPassTextBox.SendKeys(TestDataResourceSlotoking.OKPass);
                ok.OKLoginButton.Click();

                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }

            [Test]
            public void Authorization_MailRU_Positive()
            {
                vue.MailRULoginButton.Click();
                SocialNetworkPages mail = new SocialNetworkPages();
                mail.MailLoginTextBox.SendKeys(TestDataResourceSlotoking.MailRuLogin);
                mail.MailPassTextBox.SendKeys(TestDataResourceSlotoking.MailRUPass);
                mail.MailRULoginButton.Click();


                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }

            [Test]
            public void Authorization_Twitter_Positive()
            {
                vue.TwitterLoginButton.Click();

                SocialNetworkPages twitter = new SocialNetworkPages();
                twitter.TwitterLoginTextBox.SendKeys(TestDataResourceSlotoking.TwitterLogin);
                twitter.TwitterPassTextBox.SendKeys(TestDataResourceSlotoking.TwitterPass);
                twitter.TwitterLoginButton.Click();

                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }

            [Test]
            public void Authorization_RestorePassPhone_Positive()
            {
                vue.PhoneTabLogin.Click();
                vue.LoginPhoneTextBox.Clear();
                vue.LoginPhoneTextBox.SendKeys(TestDataResourceSlotoking.TestRestoreUserPhone);
                vue.RestorePassButton.Click();
                vue.RestorePassSubmitButton.Click();

                StringAssert.AreEqualIgnoringCase("Отправить еще раз", vue.RestorePassFinalSendMore.Text);
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

            _test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            _extent.Flush();
        }

            [OneTimeTearDown]
        protected void TearDown()
        {          
        }
        public void AfterTestSuit() { }
        }
    }





