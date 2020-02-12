using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Threading;

namespace Slotoking
{
    [TestFixture]
   
    public class AuthorizationMob
    {
              
        [OneTimeSetUp]
        public void BeforeTestSuit() { }
       


        [SetUp]
        public void BeforeTest()
        {
            HeaderMenu menu = new HeaderMenu();
            Driver.StartWebEmulatorMob();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            Thread.Sleep(1200);
            menu.LoginButton.Click();

        }
       
        [Test]
        public void AutorizationEmailSucces()
        {
            HeaderMenu menu = new HeaderMenu();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Assert.NotNull(menu.ProfileIcon.Displayed);
        }

      
        [Test]
        public void AutorizationPhoneSucces()
        {
            HeaderMenu menu = new HeaderMenu();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.TestUserPhone, true);
            Assert.NotNull(menu.ProfileIcon.Displayed);
        }

        
        [Test]
        public void Authorization_RestorePass_Negative()
        {
            VuePage vue = new VuePage();
            vue.PhoneTabLogin.Click();
            vue.RestorePassButton.Click();
            vue.LoginSubmitButton.Click();

            StringAssert.AreEqualIgnoringCase("Поле Номер телефона обязательно для заполнения", vue.LoginEmailErrorText.Text);
        }
        
        [Test]
        public void Authorization_RestorePassEmail_Positive()
        {
            VuePage vue = new VuePage();
            vue.LoginEmailTextBox.Clear();
            vue.LoginEmailTextBox.SendKeys(TestDataResourceSlotoking.RemindPasswordEmail);
            vue.RestorePassButton.Click();
            vue.RestorePassSubmitButton.Click();
            StringAssert.AreEqualIgnoringCase("Отправить еще раз", vue.RestorePassFinalSendMore.Text);

        }
        
        [Test]
        public void Authorization_VKLogin_Positive()
        {
            HeaderMenu menu = new HeaderMenu();
            VuePage vue = new VuePage();
            vue.VKLoginButton.Click();

            SocialNetworkPages vk = new SocialNetworkPages();
            vk.VKLoginTextBoxMobiput.SendKeys(TestDataResourceSlotoking.VKLogin);
            vk.VKLoginTextBoxMobpass.SendKeys(TestDataResourceSlotoking.VKPass);
            vk.VKLoginTextBoxMobpassSubmit.Click();

            Assert.NotNull(menu.ProfileIcon.Displayed);
        }
       
        [Test]
        [Ignore("not suport")]
        public void Authorization_FacebookLogin_Positive()
        {
            HeaderMenu menu = new HeaderMenu();
            VuePage vue = new VuePage();
            vue.FacebookLoginButton.Click();
            SocialNetworkPages facebook = new SocialNetworkPages();
            facebook.FaceBookLoginTextBox.SendKeys(TestDataResourceSlotoking.FacebookLogin);
            facebook.FaceBookPassTextBox.SendKeys(TestDataResourceSlotoking.FacebookPass);
            facebook.FaceBookLoginButton.Click();

            Assert.NotNull(menu.ProfileIcon.Displayed);
        }
       
        [Test]
        public void Authorization_GoogleLogin_Positive()
        {
            HeaderMenu menu = new HeaderMenu();
            VuePage vue = new VuePage();
            vue.GoogleLoginButton.Click();

            SocialNetworkPages google = new SocialNetworkPages();
            google.GoogleLoginTextBox.SendKeys(TestDataResourceSlotoking.GoogleLogin);
            google.GoogleNextButton.Click();
            google.GooglePassTextBox.SendKeys(TestDataResourceSlotoking.GooglePass);
            google.GooglePassNextButton.Click();


            Assert.NotNull(menu.ProfileIcon.Displayed);
        }
        
        [Test]
        public void Authorization_OK_Positive()
        {
            HeaderMenu menu = new HeaderMenu();
            VuePage vue = new VuePage();
            vue.OKLoginButton.Click();
            SocialNetworkPages ok = new SocialNetworkPages();
            ok.OKLoginTextBox.SendKeys(TestDataResourceSlotoking.OkLogin);
            ok.OKPassTextBox.SendKeys(TestDataResourceSlotoking.OKPass);
            ok.OKLoginButton.Click();

            Assert.NotNull(menu.ProfileIcon.Displayed);
        }
        
        [Test]
        public void Authorization_MailRU_Positive()
        {
            HeaderMenu menu = new HeaderMenu();
            VuePage vue = new VuePage();
            vue.MailRULoginButton.Click();
            SocialNetworkPages mail = new SocialNetworkPages();
            mail.MailLoginTextBox.SendKeys(TestDataResourceSlotoking.MailRuLogin);
            mail.MailPassTextBox.SendKeys(TestDataResourceSlotoking.MailRUPass);
            mail.MailRULoginButton.Click();


             Assert.NotNull(menu.ProfileIcon.Displayed);
        }
      
        [Test]
        public void Authorization_Twitter_Positive()
        {
            HeaderMenu menu = new HeaderMenu();
            VuePage vue = new VuePage();
            vue.TwitterLoginButton.Click();

            SocialNetworkPages twitter = new SocialNetworkPages();
            twitter.TwitterLoginTextBox.SendKeys(TestDataResourceSlotoking.TwitterLogin);
            twitter.TwitterPassTextBox.SendKeys(TestDataResourceSlotoking.TwitterPass);
            twitter.TwitterLoginButton.Click();

             Assert.NotNull(menu.ProfileIcon.Displayed);
        }
        
        [Test]
        public void Authorization_RestorePassPhone_Positive()
        {
            VuePage vue = new VuePage();
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
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }


    [TestFixture]
   
    class MainPageTestMob
    {
       
        [OneTimeSetUp]
        public void BeforeTestSuit() { }


        [SetUp]
        public void BeforeTest()
        {
            Driver.StartWebEmulatorMob();
            Driver.Browser.Manage().Window.Maximize();

        }

        [Test]
        public void Screenshot_MailnPage_LoggedIn()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.TestUserEmail, false);

            Driver.TakeScreenshot();
        }

        [Test]
        public void Screenshot_MailnPage_LoggedOut()
        {
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            Driver.TakeScreenshot();

        }

        [Test]
        public void JackPotContainer()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            MainPage jackpotblock = new MainPage();

            main.ScrollToJackPotsBlock();
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Red.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Silver.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Gold.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Diamond.Displayed);


        }

        [Test]
        public void JackPotContainerNotRegistered()
        {

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            MainPage jackpotblock = new MainPage();
            MainPage main = new MainPage();
            main.ScrollToJackPotsBlock();
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Red.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Silver.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Gold.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Diamond.Displayed);


        }

        [Test]
        public void SearchGameTestAuth()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            //main.SearchIcon.Click();
            main.SearchIcon.SendKeys("Книжки");
            Assert.NotNull(main.GameIconBookOfRa);

        }


        [Test]
        public void MoreGameMainPage()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            Assert.NotNull(main.MoreGamesButton);

        }

        [Test]
        [Ignore("в новой версии не реализовано")]
        public void BlockDownloadClient()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            //main.ScrollToElementBannerTournaments();


            //Assert.NotNull(main.BlockClientDownload);

        }


        [Test]
        [Ignore("в новой версии не реализовано")]
        public void OtigrashBlock()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL + "/?game=book-of-ra&isMoney=true";
            MainPage king = new MainPage();

            StringAssert.AreEqualIgnoringCase("Отыгрыш бонуса", king.Otigrash.Text);

        }

        [Test]
        [Ignore("")]
        public void TournamentGamePopup()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL + "/?game=book-of-ra&isMoney=true";
            MainPage king = new MainPage();
            king.gameChangeSidebarActiveTournament.Click();
            Assert.NotNull(main.gameChangeSidebarActiveTournamentTimer);

        }

        [Test]
        [Ignore("")]
        public void GamePopupUserWin()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL + "/?game=book-of-ra&isMoney=true";
            MainPage king = new MainPage();
            king.gameChangeSidebarActiveBonus.Click();
            Assert.NotNull(king.UserBarActivity);

        }


        [Test]
        [Ignore("")]
        public void GamePopupHideShow()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL + "/?game=book-of-ra&isMoney=true";
            AllGames games = new AllGames();
            MainPage king = new MainPage();
            king.HideGamePopup.Click();
            king.HideGamePopup.Click();
            Assert.NotNull(games.BalanceTextPartners);


        }

        [Test]
        public void BlockBonusNotRegister()
        {
            
            MainPage main = new MainPage();
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToElementBonusBezdep();

            Assert.NotNull(main.fewfwefew1);

        }

        [Test]
        public void BlockBonusWelcomeBonusAuth()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToElementBonusBezdep();
            main.CardOne.Click();
            Assert.NotNull(main.OpisanieBonusa);


        }


        [Test]
        public void BlockBonusWelcomeBonusNotRegister()
        {
            
            MainPage main = new MainPage();
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToElementBonusBezdep();
            main.CardOne.Click();
            Assert.NotNull(main.OpisanieBonusa);

        }

        [Test]
        public void BlockUserBarAuth()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            Assert.NotNull(main.UserBar);
        }


        [Test]
        public void BlockUserBarNotRegister()
        {
            MainPage main = new MainPage();
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            Assert.NotNull(main.UserBar);
        }

        [Test]
        [Ignore("не реализовано на новом кинге")]
        public void SupportAuth()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            Thread.Sleep(3000);
            main.SupportButton.Click();
            Assert.NotNull(main.TextSuportOnline);
        }


        [Test]
        [Ignore("не реализовано на новом кинге")]
        public void SupportNotRegister()
        {
            
            MainPage main = new MainPage();
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            Thread.Sleep(3000);
            main.SupportButton.Click();
            Assert.NotNull(main.TextSuportOnline);
        }



        [Test]
        public void BlockBonusTournamentCardAuth()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToElementBonusBezdep();
            main.CardTwo.Click();
            Assert.NotNull(main.OpisanieBonusa2);

        }


        [Test]
        public void BlockBonusTournamentCardNotRegister()
        {
            
            MainPage main = new MainPage();
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToElementBonusBezdep();
            main.CardTwo.Click();
            Assert.NotNull(main.OpisanieBonusa2);

        }


        [Test]
        [Ignore("не реализовано на новом кинге")]
        public void BlockDownloadClientSendSmsNotRegister()
        {
           
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            //main.ScrollToElementBannerTournaments();

            //main.InpuPhonetDownloadClient.SendKeys("0637316713");
            //main.InpuPhonetDownloadClientButton.Click();
            //main.CloseEnterVue.Click();
            //StringAssert.AreEqualIgnoringCase("Твое персональное казино у тебя в телефоне", main.TextDownloadClienPhone.Text);

        }

        [Test]
        [Ignore("не реализовано на новом кинге")]
        public void BlockDownloadClientSendSmsAuth()
        {
            VuePage vue = new VuePage();
           // MainPage main = new MainPage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            //main.ScrollToElementBannerTournaments();
            //main.InpuPhonetDownloadClient.Clear();
            //main.InpuPhonetDownloadClient.SendKeys("0637316713");
            //main.InpuPhonetDownloadClientButton.Click();

            //StringAssert.AreEqualIgnoringCase("Ссылка выслана на указанный телефон", main.SendSmsPopup.Text);

        }

        [Test]
        [Ignore("не реализовано на новом кинге")]
        public void BlockDownloadClientHowDownloadPhone()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            //main.ScrollToElementBannerTournaments();
            //main.BlockGameDownloadPhone.Click();

            //StringAssert.AreEqualIgnoringCase("Твое персональное казино у тебя в телефоне", main.TextDownloadClienPhone.Text);

        }

        [Test]

        [Ignore("не реализовано на новом кинге")]
        public void BlockDownloadClientHowDownloadWindows()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            //main.ScrollToElementBannerTournaments();
            //main.BlockGameDownloadWindows.Click();

            //StringAssert.AreEqualIgnoringCase("ПК-клиент для комфортной игры", main.TextDownloadClienWindows.Text);

        }

        [Test]
        [Ignore("не реализовано на новом кинге")]
        public void BlockDownloadClientNotRegistered()
        {
           
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            //main.ScrollToElementBannerTournaments();
            //Assert.NotNull(main.BlockClientDownload);

        }

        [Test]
        public void MoreGameMainPageNotRegistered()
        {
           
            MainPage main = new MainPage();
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            Assert.NotNull(main.MoreGamesButton);
        }

        [Test]
        public void SearchGameTestNotRegistered()
        {
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            main.SearchIcon.Click();
            Thread.Sleep(1000);

            main.SearchIcon.Click();
            main.SearchIcon.SendKeys("Книжки");
            Assert.NotNull(main.GameIconBookOfRa.Displayed);

        }

        [Test]
        [Ignore("в новой версии не реализовано")]
        public void SearchGameTestLaunchGame()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            AllGames games = new AllGames();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.SearchIcon.Click();
            main.SearchIcon.SendKeys("Книжки");
            main.GameIconBookOfRa.Click();
            Assert.NotNull(games.BalanceTextPartners);

        }


        //[Test]
        //public void Check50FS()
        //{
        //    VuePage vue = new VuePage();
        //    MainPage main = new MainPage();

        //    vue.Auth(TestDataResourceSlotoking.NewUserWithFS, false);

        //    Assert.NotNull(main.CoinMain);

        //}


        //[Test]
        //public void Check50FSUserBar()
        //{
        //    VuePage vue = new VuePage();
        //    MainPage main = new MainPage();

        //    vue.Auth(TestDataResourceSlotoking.NewUserWithFS, false);

        //    Assert.NotNull(main.CoinMain);

        //}

        [Test]
        public void Check_SeoTextBlock()
        {
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            MainPage main = new MainPage();

            Assert.NotNull(main.SeoBlockFooter);
        }



        [Test]
        [Ignore("нет функционала")]
        public void OtigrashFsanatherGame()
        {
            AllGames games = new AllGames();
            VuePage vue = new VuePage();

            vue.Auth(TestDataResourceSlotoking.NewUserWithFS, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            games.GameProvaider.Click();
            games.IgrosoftButton.Click();

            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();


            // StringAssert.AreEqualIgnoringCase("В данной игре бонусный баланс недоступен\r\nи бонус не отыгрывается", main.ZavershiteOtigrashFSNotouerGame.Text);

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

   
    [TestFixture]
   
    public class FooterLinksMob
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartWebEmulatorMob();
            Driver.Browser.Manage().Window.Maximize();
        }

        [Test]
        public void Licensed()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.licensed.Click();

            Assert.NotNull(main.licensedText);
        }

        [Test]
        [Ignore("не реализовано на новой версии ")]
        public void About()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.About.Click();

            Assert.NotNull(main.AboutText);
        }



        [Test]
        public void PayMetodLogout()
        {

           
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.PayMetod.Click();

            Assert.NotNull(main.PaymentsMetodText);
        }


        [Test]
        public void Contact()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.Contact.Click();

            Assert.NotNull(main.ContactBlock);
        }


        [Test]
        public void ContactLogout()
        {

            
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.Contact.Click();

            Assert.NotNull(main.ContactBlock);
        }


        [Test]
        public void PayMetod()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.PayMetod.Click();

            Assert.NotNull(main.PaymentsMetodText);
        }



        [Test]
        public void Agreement()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.agreements.Click();

            StringAssert.AreEqualIgnoringCase("Пользовательское соглашение", main.agreementsText.Text);
        }

        [Test]
        public void Privacy()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.privacy.Click();

            StringAssert.AreEqualIgnoringCase("Сбор личной информации", main.privacyText.Text);
        }

        [Test]
        public void Allbonus()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.AllBonuses.Click();

            StringAssert.AreEqualIgnoringCase("Бонус на 1-й депозит", main.AllBonusesText.Text);
        }

        [Test]
        [Ignore("не реализовано на новой версии ")]
        public void Responsibility()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            //main.responsibility.Click();

            //StringAssert.AreEqualIgnoringCase("Защита несовершеннолетних", main.responsibilityPage.Text);
        }


        [Test]
        public void Support()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.support.Click();

            Assert.NotNull(main.supportPage);
            Assert.NotNull(main.supportPage1);
            Assert.NotNull(main.supportPage2);
        }


        [Test]

        public void How_to_start()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.HowToStart.Click();

            Assert.NotNull(main.HowToStartText);

        }

        [Test]
        public void Free_game()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.FreeGame.Click();

            Assert.NotNull(main.FreeGameText);

        }

        [Test]
        [Ignore("не реализовано")]
        public void Cashback()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            //main.cashback.Click();

            //StringAssert.AreEqualIgnoringCase("-  БОЛЬШЕ ШАНСОВ НА ПОБЕДУ  -", main.cashbackPage.Text);

        }


        [Test]
        [Ignore("не реализовано")]
        public void Client_for_windows()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.FooterClientForWindowsLink.Click();

            Assert.NotNull(main.DownloadWindows);

        }

        [Test]
        [Ignore("не реализовано на новой версии ")]
        public void Client_for_android()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.ScrollToFooter();
            main.FooterClientForAndroidLink.Click();

            Assert.NotNull(main.DownloadAndroid);

        }

        [Test]

        [Ignore("нет на сайте")]
        public void Sitemap()
        {

           
           // MainPage main = new MainPage();

            //vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            //main.ScrollToFooter();
            //main.sitemap.Click();

            //StringAssert.AreEqualIgnoringCase("Бонусы", main.sitemapPage.Text);

        }


        [Test]
        public void LicensedLogout()
        {

            
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.licensed.Click();

            Assert.NotNull(main.licensedText);
        }



        [Test]
        [Ignore("не реализовано на новой версии ")]
        public void AboutLogout()
        {

            
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.About.Click();

            Assert.NotNull(main.AboutText);
        }

        [Test]
        public void AgreementLogout()
        {

            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.agreements.Click();

            StringAssert.AreEqualIgnoringCase("Пользовательское соглашение", main.agreementsText.Text);
        }

        [Test]
        public void PrivacyLogout()
        {

            
            MainPage main = new MainPage();
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            main.ScrollToFooter();
            main.privacy.Click();

            StringAssert.AreEqualIgnoringCase("Сбор личной информации", main.privacyText.Text);
        }

        [Test]
        public void AllbonusLogout()
        {

           
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.AllBonuses.Click();

            StringAssert.AreEqualIgnoringCase("Бонус на 1-й депозит", main.AllBonusesText.Text);
        }

        [Test]
        [Ignore("не реализовано")]
        public void ResponsibilityLogout()
        {

            
            MainPage main = new MainPage();
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            main.ScrollToFooter();
            //main.responsibility.Click();

            //StringAssert.AreEqualIgnoringCase("Защита несовершеннолетних", main.responsibilityPage.Text);
        }


        [Test]
        public void SupportLogout()
        {

           
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.support.Click();

            Assert.NotNull(main.supportPage);
            Assert.NotNull(main.supportPage1);
            Assert.NotNull(main.supportPage2);
        }


        [Test]
        public void How_to_startLogout()
        {

            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.HowToStart.Click();

            Assert.NotNull(main.HowToStartText);

        }

        [Test]
        public void Free_gameLogout()
        {

            
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.FreeGame.Click();

            Assert.NotNull(main.FreeGameText);

        }

        [Test]
        [Ignore("не реализовано")]
        public void CashbackLogout()
        {

            
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            //main.cashback.Click();

            //StringAssert.AreEqualIgnoringCase("-  БОЛЬШЕ ШАНСОВ НА ПОБЕДУ  -", main.cashbackPage.Text);

        }


        [Test]
        [Ignore("не реализовано")]
        public void Client_for_windowsLogout()
        {

            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.FooterClientForWindowsLink.Click();

            Assert.NotNull(main.DownloadWindows);

        }

        [Test]
        [Ignore("не реализовано")]
        public void Client_for_androidLogout()
        {

            
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();
            main.FooterClientForAndroidLink.Click();

            Assert.NotNull(main.DownloadAndroid);

        }

        [Test]
        [Ignore("нет на сайте")]
        public void SitemapLogout()
        {

           
           // MainPage main = new MainPage();

            //Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            //main.ScrollToFooter();
            //main.sitemap.Click();

            //StringAssert.AreEqualIgnoringCase("Бонусы", main.sitemapPage.Text);

        }

        [Test]
        public void LinksScrollLogout()
        {

            
            MainPage main = new MainPage();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            main.ScrollToFooter();


            Assert.NotNull(main.FooterGameNewLink);

        }

        [Test]

        public void LinksScroll()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();

            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);


            main.ScrollToFooter();


            Assert.NotNull(main.FooterGameNewLink);

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


    [TestFixture]
   
    class ProfileTestsMob
    {
       
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartWebEmulatorMob();
            Driver.Browser.Manage().Window.Maximize();

        }

        [Test]

        public void Profile_Data()
        {
            VuePage vue = new VuePage();
            Random rnd = new Random();
            ProfilePage account = new ProfilePage();
            HeaderMenu head = new HeaderMenu();
            vue.RegistrationMob(false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            head.ProfileIcon.Click();
            Thread.Sleep(1000);
            vue.PtofileMenuButtonsData.Click();
            System.Threading.Thread.Sleep(1000);
            account.NameTextBox.SendKeys(TestDataResourceSlotoking.UserName);
            System.Threading.Thread.Sleep(1000);
            account.SurnameTextBox.SendKeys(TestDataResourceSlotoking.UserSurname);
            Thread.Sleep(1000);
            account.PhoneCountryListBox.Click();
            account.PhoneContryListBoxUkraine.Click();
            Thread.Sleep(1000);
            account.PlayerPhoneTextBox.SendKeys("500508" + rnd.Next(100, 999).ToString());
            account.ChooseCountry();
            account.NickName.SendKeys("Хаос" + rnd.Next(100, 999).ToString());
            account.PassportNumber.SendKeys("254412");
            account.SavePersonalInfoButton.Click();
            //account.MyBonusesButton.Click();
           // Thread.Sleep(1000);
          //  vue.PtofileMenuButtonsData.Click();
            Thread.Sleep(1000);
            StringAssert.AreEqualIgnoringCase("Alex", account.NameTextBoxDisable.Text);
        }

        [Test]

        public void MyVipStatus()

        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.RegistrationMob(false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;


            head.ProfileIcon.Click();
            Thread.Sleep(1000);
            account.VipStatusButton.Click();
            Thread.Sleep(1000);
            account.VipStatusButtonAbout.Click();


            StringAssert.AreEqualIgnoringCase("Король", account.VipStatusButtonAboutKing.Text);
        }

        [Test]

        public void MyPrizeNewUser()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.RegistrationMob(false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;

            head.ProfileIcon.Click();
            Thread.Sleep(1000);
            account.Myprize.Click();

            Thread.Sleep(1000);
            account.PlayUtchastvovatTournament.Click();
            Assert.NotNull(account.GonkaNachalas);
                      
        }

        [Test]

        public void MyPrizeOldUser()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            head.ProfileIcon.Click();
            Thread.Sleep(1000);
            account.Myprize.Click();
            
            Assert.NotNull(account.CardTournament);


        }

        [Test]

        public void MyTournaments()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            head.ProfileIcon.Click();
            Thread.Sleep(1000);
            account.MyTournamentsButton.Click();
            Thread.Sleep(1000);
            account.OpenOneResoultTournaments.Click();
            Assert.NotNull(account.TournamentWin);


        }

        [Test]

        public void MyCashBox()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            CashBox replenis = new CashBox();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            head.ProfileIcon.Click();

            account.Cahsbox.Click();

            replenis.CloseCassa2.Click();


            account.Cahsbox2.Click();


            replenis.CloseCassa2.Click();



            Assert.NotNull(account.ExitProfile.Displayed);
        }



        [Test]

        public void MySetting()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.RegistrationMob(false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            head.ProfileIcon.Click();
            Thread.Sleep(1000);
            account.MySettingsButton.Click();
            account.PersonalCheck.Click();
            account.TakeSmsChack.Click();
            account.NextPassword.Click();
            account.MySettingsGoogle.Click();
            account.MySettingsVK.Click();
            account.MySettingsMail.Click();
            account.MySettingsTwitter.Click();
            account.MySettingsOk.Click();


            StringAssert.AreEqualIgnoringCase("Поле обязательно для заполнения", account.PasswordSettingNeed.Text);
        }
       
        [Test]

        public void MyBonuses()
        {
            
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.RegistrationMob(false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            head.ProfileIcon.Click();
            Thread.Sleep(1000);
            account.MyBonusesButton.Click();
            Thread.Sleep(1000);
            account.InfoBonusProfile.Click();


            Assert.NotNull(account.InfoBonusProfileText.Displayed);
        }



        [Test]

        public void MyCashback()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.RegistrationMob(false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            head.ProfileIcon.Click();
            Thread.Sleep(1000);
            account.DashboardButtonCashback.Click();
            Thread.Sleep(1000);
            account.ButtonCashbackInfo.Click();
            StringAssert.AreEqualIgnoringCase("Я могу получить кэшбэк?", account.CashbackInfo.Text);
        }




        [Test]

        public void MyBonusbalance()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.RegistrationMob(false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            head.ProfileIcon.Click();

            Assert.NotNull(account.BonusBalance.Displayed);
        }


        [Test]

        public void MyCashBoxButton()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.RegistrationMob(false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            head.ProfileIcon.Click();
            Thread.Sleep(1000);
            account.MyBonusesCashbackButton.Click();
            Thread.Sleep(1000);
            Assert.NotNull(account.BunusContainerCashback.Displayed);
        }


        //[Test]

        //public void MyBonuses()
        //{
        //    VuePage vue = new VuePage();
        //    Random rnd = new Random();
        //    ProfilePage account = new ProfilePage();
        //    vue.Registration(false);
        //    System.Threading.Thread.Sleep(2000);
        //    head.ProfileIcon.Click();







        //    Assert.IsFalse(account.NameTextBox.Enabled);
        //}

        //[Test]

        //public void MyBonuses()
        //{
        //    VuePage vue = new VuePage();
        //    Random rnd = new Random();
        //    ProfilePage account = new ProfilePage();
        //    vue.Registration(false);
        //    System.Threading.Thread.Sleep(2000);
        //    head.ProfileIcon.Click();







        //    Assert.IsFalse(account.NameTextBox.Enabled);
        //}

        //[Test]

        //public void MyBonuses()
        //{
        //    VuePage vue = new VuePage();
        //    Random rnd = new Random();
        //    ProfilePage account = new ProfilePage();
        //    vue.Registration(false);
        //    System.Threading.Thread.Sleep(2000);
        //   head.ProfileIcon.Click();







        //    Assert.IsFalse(account.NameTextBox.Enabled);
        //}






        [TearDown]
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success) Driver.TakeScreenshot();
            Driver.DisposeBrowser();
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }

    [TestFixture]
   
    class RegistrationTestsMob
    {
       
        [OneTimeSetUp]
        public void BeforeTestSuit() { }
        

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartWebEmulatorMob();
            Driver.Browser.Manage().Window.Maximize();
        }

        [Test]
        public void Registration_ByEmail_Positive()
        {
            HeaderMenu menu = new HeaderMenu();
            VuePage vue = new VuePage();
            vue.RegistrationMob(false);

            Assert.NotNull(menu.ProfileIcon.Displayed);
        }

        [Test]
        public void Registration_ByPhone_Positive()
        {
            VuePage vue = new VuePage(); ;
            vue.RegistrationMob(true);
            HeaderMenu menu = new HeaderMenu();

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            //StringAssert.AreEqualIgnoringCase("Введите новый пароль для того, чтобы не потерять доступ к аккаунту", vue.PopupNewPassword.Text);
            Assert.NotNull(menu.ProfileIcon.Displayed);
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

            
            HeaderMenu head = new HeaderMenu();
            VuePage vue = new VuePage(); ;
            head.RegistrationButtonMob.Click();
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
    



















