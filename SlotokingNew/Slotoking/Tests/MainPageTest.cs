using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Threading;

namespace Slotoking
{
    class MainPageTest
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

        public void OtigrashBlock()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL + "/?game=book-of-ra&isMoney=true";
            MainPage king = new MainPage();

            StringAssert.AreEqualIgnoringCase("Отыгрыш бонуса", king.Otigrash.Text);

        }

        [Test]

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

        public void GamePopupHideShow()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL + "/?game=book-of-ra&isMoney=true";
            AllGames games = new AllGames();
            MainPage king = new MainPage();
            king.HideGamePopup.Click();
            king.HideGamePopup.Click();
            king.GameChangeSidebarActive.Click();
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
            AllGames games = new AllGames();

            main.SearchIcon.Click();
            main.SearchIcon.SendKeys("Книжки");
            main.GameIconBookOfRa.Click();
            Assert.NotNull(games.MainFrame);

        }

        [Test]
        public void SearchGameTestLaunchGame()
        {
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            AllGames games = new AllGames();
            MainPage king = new MainPage();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            main.SearchIcon.Click();
            main.SearchIcon.SendKeys("Книжки");
            main.GameIconBookOfRa.Click();
            king.GameChangeSidebarActive.Click();
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
    public class FooterLinks
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


}










