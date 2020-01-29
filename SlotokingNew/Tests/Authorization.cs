using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SlotokingNew;
using SlotokingNew.Helpers;
using SlotokingNew.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SlotokingNewDesktop
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
                Driver.Browser.Url = TestDataResource.MainPageURL;
                Thread.Sleep(1200);
                menu.LoginButton.Click();

            }

            [Test]
            public void AutorizationEmailSucces()
            {
            
            vue.Auth(TestDataResource.GameUserTest, false);
                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }


            [Test]
            public void AutorizationPhoneSucces()
            {
                vue.Auth(TestDataResource.TestUserPhone, true);
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
                vue.LoginEmailTextBox.SendKeys(TestDataResource.RemindPasswordEmail);
                vue.RestorePassButton.Click();
                vue.RestorePassSubmitButton.Click();
                StringAssert.AreEqualIgnoringCase("Отправить еще раз", vue.RestorePassFinalSendMore.Text);



            }

            [Test]
            public void Authorization_VKLogin_Positive()
            {
            
            vue.VKLoginButton.Click();

                SocialNetworkPages vk = new SocialNetworkPages();
                vk.VKLoginTextBox.SendKeys(TestDataResource.VKLogin);
                vk.VKPassTextBox.SendKeys(TestDataResource.VKPass);
                vk.VKLoginButton.Click();

                StringAssert.AreEqualIgnoringCase("Баланс", menu.ProfileButton.Text);
            }

            [Test]
            [Ignore("not suport")]
            public void Authorization_FacebookLogin_Positive()
            {
                vue.FacebookLoginButton.Click();
                SocialNetworkPages facebook = new SocialNetworkPages();
                facebook.FaceBookLoginTextBox.SendKeys(TestDataResource.FacebookLogin);
                facebook.FaceBookPassTextBox.SendKeys(TestDataResource.FacebookPass);
                facebook.FaceBookLoginButton.Click();

                StringAssert.AreEqualIgnoringCase("Баланс", menu.ProfileButton.Text);
            }

            [Test]
            public void Authorization_GoogleLogin_Positive()
            {
                vue.GoogleLoginButton.Click();

                SocialNetworkPages google = new SocialNetworkPages();
                google.GoogleLoginTextBox.SendKeys(TestDataResource.GoogleLogin);
                google.GoogleNextButton.Click();
                google.GooglePassTextBox.SendKeys(TestDataResource.GooglePass);
                google.GooglePassNextButton.Click();


                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }

            [Test]
            public void Authorization_OK_Positive()
            {
                vue.OKLoginButton.Click();
                SocialNetworkPages ok = new SocialNetworkPages();
                ok.OKLoginTextBox.SendKeys(TestDataResource.OkLogin);
                ok.OKPassTextBox.SendKeys(TestDataResource.OKPass);
                ok.OKLoginButton.Click();

                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }

            [Test]
            public void Authorization_MailRU_Positive()
            {
                vue.MailRULoginButton.Click();
                SocialNetworkPages mail = new SocialNetworkPages();
                mail.MailLoginTextBox.SendKeys(TestDataResource.MailRuLogin);
                mail.MailPassTextBox.SendKeys(TestDataResource.MailRUPass);
                mail.MailRULoginButton.Click();


                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }

            [Test]
            public void Authorization_Twitter_Positive()
            {
                vue.TwitterLoginButton.Click();

                SocialNetworkPages twitter = new SocialNetworkPages();
                twitter.TwitterLoginTextBox.SendKeys(TestDataResource.TwitterLogin);
                twitter.TwitterPassTextBox.SendKeys(TestDataResource.TwitterPass);
                twitter.TwitterLoginButton.Click();

                StringAssert.AreEqualIgnoringCase("Баланс", menu.HeaderBalance.Text);
            }

            [Test]
            public void Authorization_RestorePassPhone_Positive()
            {
                vue.PhoneTabLogin.Click();
                vue.LoginPhoneTextBox.Clear();
                vue.LoginPhoneTextBox.SendKeys(TestDataResource.TestRestoreUserPhone);
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





