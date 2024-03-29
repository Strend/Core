﻿using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Threading;

namespace Vulkan777
{
    class MainPageTest
    {

        [OneTimeSetUp]
        public void BeforeTestSuit() { }
        ProfilePage prof = new ProfilePage();

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestDataResource777Originals.MainPageURL;
            prof.Scroll_todownToLoad();
        }

        [Test]
        public void Screenshot_MailnPage_LoggedIn()
        {
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.TestUserEmail, false);

            Driver.TakeScreenshot();
        }

        [Test]
        public void Screenshot_MailnPage_LoggedOut()
        {

            Driver.TakeScreenshot();
        }


        [Test]
        public void JackPotContainer()
        {
            ProfilePage prof = new ProfilePage();



            MainPage jackpotblock = new MainPage();
            prof.ScrollToElementButtonReg();
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Red.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Silver.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Gold.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Diamond.Displayed);
        }

        [Test]
        public void JackPotContainerList()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();
            main.scrollToJackpot();
            main.JackpotListmain.Click();

            Assert.NotNull(main.JackpotListmainList.Displayed);

        }

        [Test]
        public void ActiveBonusMainBanner()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            Cashbox replish = new Cashbox();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();
            main.ActiveBonusMain.Click();

            Assert.NotNull(replish.CashboxPopupWithdrawButton.Displayed);

        }

        [Test]
        public void TournamentsPromoContainer()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();


            Assert.NotNull(main.TournamentsPromoContainer.Displayed);

        }

        [Test]
        public void MoreGamesAvtomat()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.MoreGamesButton.Click();
            Assert.NotNull(main.MoreGamesButtonAddGames.Displayed);
        }

        [Test]
        public void MoreGamesLogoutAvtomat()
        {

            MainPage main = new MainPage();
            main.MoreGamesButton.Click();


            Assert.NotNull(main.MoreGamesButtonAddGames.Displayed);
        }


        [Test]
        public void MoreGamesNewGames()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.MoreGamesButtonNew.Click();
            Assert.NotNull(main.MoreGamesButtonAddGamesNew.Displayed);
        }

        [Test]
        public void MoreGamesLogoutNewGames()
        {

            MainPage main = new MainPage();
            main.MoreGamesButtonNew.Click();


            Assert.NotNull(main.MoreGamesButtonAddGamesNew.Displayed);
        }


        [Test]
        public void MostLoverGame()
        {
            GamePage games = new GamePage();

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.LoveGame.Click();
            games.MoveCursorToGame(main.HoverGame);
            StringAssert.AreEqualIgnoringCase("Gold Of Egypt", main.TextLoverGame.Text);
        }


        [Test]
        public void Tooltip()
        {
            GamePage games = new GamePage();

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();


            games.MoveCursorToGameNotClick(main.TooltipMain);
            StringAssert.AreEqualIgnoringCase("Горячая", main.ToltipTextMain.Text);
        }



        [Test]
        public void WeCareForYou()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();
            prof.Scroll_todownToLoad();
            //Assert.NotNull(main.PrivetstveniyPaket.Displayed);
            Assert.NotNull(main.PrivetstveniyPaketBlock1.Displayed);
            Assert.NotNull(main.PrivetstveniyPaketBlock2.Displayed);
            Assert.NotNull(main.PrivetstveniyPaketBlock3.Displayed);

        }


        [Test]
        public void WeCareForYouLogout()
        {

            MainPage main = new MainPage();
            ProfilePage vque = new ProfilePage();
            vque.Scroll_todownToLoad();
            Assert.NotNull(main.PrivetstveniyPaket.Displayed);
            Assert.NotNull(main.PrivetstveniyPaketBlock1.Displayed);
            Assert.NotNull(main.PrivetstveniyPaketBlock2.Displayed);
            Assert.NotNull(main.PrivetstveniyPaketBlock3.Displayed);

        }


        [Test]
        public void WelcomePackLogout()
        {

            MainPage main = new MainPage();

            Assert.NotNull(main.PrivetstveniyPaketLogout.Displayed);
            main.scrollToButtonRegister();
            main.PrivetstveniyPaketLogoutRegisterButton.Click();
            StringAssert.AreEqualIgnoringCase("Регистрация", main.RegisterPopupText.Text);
        }



        [Test]
        public void RegisterDownButton()
        {

            MainPage main = new MainPage();
            main.scrollFooterfirm();

            main.RegisterButtonMain.Click();
            StringAssert.AreEqualIgnoringCase("Регистрация", main.RegisterPopupText.Text);
        }



        [Test]
        public void SeoBlockLogout()
        {

            MainPage main = new MainPage();
                                       
            StringAssert.AreEqualIgnoringCase("Онлайн казино 777 Оригинал приветствует уважаемых гостей на своём сайте!", main.SeoTitle.Text);
            Assert.NotNull(main.SeoBlocksText.Displayed);
        }


        [Test]
        public void SeoBlock()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();


            StringAssert.AreEqualIgnoringCase("Онлайн казино 777 Оригинал приветствует уважаемых гостей на своём сайте!", main.SeoTitle.Text);
            Assert.NotNull(main.SeoBlocksText.Displayed);
        }


        [Test]
        public void TooltipLogout()
        {
            GamePage games = new GamePage();

            MainPage main = new MainPage();

            games.MoveCursorToGame(main.TooltipMain);
            StringAssert.AreEqualIgnoringCase("Горячая", main.ToltipTextMain.Text);
        }






        [Test]
        public void SearchGame()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();


            main.Search.SendKeys("книжка");
            main.BookOfRa.Click();
            StringAssert.AreEqualIgnoringCase("Популярные игры", main.PopularGameButtonGamePopup.Text);
        }

        [Test]
        public void SearchGameLogout()
        {

            MainPage main = new MainPage();

            main.Search.SendKeys("книжка");
            main.BookOfRa.Click();
            StringAssert.AreEqualIgnoringCase("Популярные игры", main.PopularGameButtonGamePopup.Text);
        }




        [Test]
        public void Support()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            Thread.Sleep(5000);
            main.SupportButton.Click();
            Assert.NotNull(main.TextSuportOnline.Displayed);
        }

        [Test]
        public void SupportLogout()
        {

            MainPage main = new MainPage();
            Thread.Sleep(5000);
            main.SupportButton.Click();

            Assert.NotNull(main.TextSuportOnline.Displayed);
        }



        [Test]
        public void NavigatorBlock()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            Assert.NotNull(main.NavigatorMapsLink.Displayed);
        }

        [Test]
        public void NavigatorBlockLogout()
        {

            MainPage main = new MainPage();

            Assert.NotNull(main.NavigatorMapsLink.Displayed);
        }



        [Test]
        public void Licensed()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            Assert.NotNull(main.NavigatorMapsLink.Displayed);
        }

        [Test]
        public void LicensedLogout()
        {

            MainPage main = new MainPage();

            Assert.NotNull(main.NavigatorMapsLink.Displayed);
        }


        [Test]
        public void Privacy()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.privacy.Click();
            StringAssert.AreEqualIgnoringCase("Куда идет информация?", main.privacyText.Text);
        }

        [Test]
        public void PrivacyLogout()
        {

            MainPage main = new MainPage();
            main.scrollpam();
            main.privacy.Click();
            StringAssert.AreEqualIgnoringCase("Куда идет информация?", main.privacyText.Text);
        }



        [Test]
        public void Agreements()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.agreements.Click();
            StringAssert.AreEqualIgnoringCase("2. Регистрация", main.agreementsText.Text);
        }

        [Test]
        public void AgreementsLogout()
        {

            MainPage main = new MainPage();
            main.scrollpam();
            main.agreements.Click();
            System.Threading.Thread.Sleep(1000);
            StringAssert.AreEqualIgnoringCase("2. Регистрация", main.agreementsText.Text);
        }

        [Test]
        public void Supports()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.onlineSupport.Click();
            Assert.NotNull(main.onlineSupportText1.Displayed);
            Assert.NotNull(main.onlineSupportText2.Displayed);
            Assert.NotNull(main.onlineSupportText3.Displayed);
        }

        [Test]
        public void Supportlogout()
        {
            MainPage main = new MainPage();
            main.onlineSupport.Click();
            Assert.NotNull(main.onlineSupportText1.Displayed);
            Assert.NotNull(main.onlineSupportText2.Displayed);
            Assert.NotNull(main.onlineSupportText3.Displayed);

        }



        [Test]
        public void About()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.About.Click();
            StringAssert.AreEqualIgnoringCase("7 преимуществ казино 777 ORIGINAL:", main.AboutText.Text);
        }

        [Test]
        public void AboutLogout()
        {
            MainPage main = new MainPage();
            main.scrollpam();
            main.About.Click();

            StringAssert.AreEqualIgnoringCase("7 преимуществ казино 777 ORIGINAL:", main.AboutText.Text);
        }



        [Test]
        public void Allbonuses()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.AllBonuses.Click();
            StringAssert.AreEqualIgnoringCase("Бонус на 1-й депозит", main.AllBonusesText.Text);
        }


        [Test]
        public void AllbonusesLogout()
        {
            MainPage main = new MainPage();
            main.scrollpam();
            main.AllBonuses.Click();
            System.Threading.Thread.Sleep(1000);
            StringAssert.AreEqualIgnoringCase("Бонус на 1-й депозит", main.AllBonusesText.Text);
        }


        [Test]
        public void PaymentMethod()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.PaymentsMetod.Click();
            StringAssert.AreEqualIgnoringCase("мгновенно", main.PaymentsMetodText.Text);
        }


        [Test]
        public void PaymentMethodLogout()
        {

            MainPage main = new MainPage();
            main.scrollpam();
            main.PaymentsMetod.Click();
            StringAssert.AreEqualIgnoringCase("мгновенно", main.PaymentsMetodText.Text);
        }

        [Test]
        public void FreeGame()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.FreeGame.Click();
            StringAssert.AreEqualIgnoringCase("казино 777 Original", main.FreeGameText.Text);
        }


        [Test]
        public void FreeGameLogout()
        {
            MainPage main = new MainPage();
            main.scrollpam();
            main.FreeGame.Click();
            StringAssert.AreEqualIgnoringCase("казино 777 Original", main.FreeGameText.Text);
        }


        [Test]
        public void ClientForWindows()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();
            main.scrollDownloadBlock();
            main.ClientsForWindows.Click();
            Assert.NotNull(main.ClientsForWindowsText.Displayed);
        }


        [Test]
        public void ClientForWindowsLogout()
        {
            MainPage main = new MainPage();
            main.scrollDownloadBlock();
            main.ClientsForWindows.Click();
            Assert.NotNull(main.ClientsForWindowsText.Displayed);
        }


        [Test]
        public void FooterPartners()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();


            Assert.NotNull(main.FooterPartners.Displayed);
        }


        [Test]
        public void FooterPartnersLogput()
        {
            MainPage main = new MainPage();
            Assert.NotNull(main.FooterPartners.Displayed);
        }


        [Test]
        public void ClientForAndroid()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.ClientForAndroid.Click();
            Assert.NotNull(main.ClientsForAndroidText.Displayed);
        }

        [Test]
        public void ClientForWindowsBlockDownload()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();
            main.scrollDownloadBlock();
            main.InstructionDowsnloadDesktop.Click();
            Assert.NotNull(main.ClientsForWindowsText.Displayed);
        }



        [Test]
        public void ClientForAndroidBlockDownload()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();
            main.scrollDownloadBlock();
            main.InstructionDowsnloadMobile.Click();
            System.Threading.Thread.Sleep(1000);
            Assert.NotNull(main.ClientsForAndroidText.Displayed);
        }

        [Test]
        public void ClientForAndroidLogout()
        {
            MainPage main = new MainPage();
            main.scrollDownloadBlock();
            main.ClientForAndroid.Click();
            Assert.NotNull(main.ClientsForAndroidText.Displayed);
        }



        [Test]
        public void HowToStart()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();
            main.scrollpam();
            main.HowToStart.Click();
            StringAssert.AreEqualIgnoringCase("ШАГ 4.", main.HowToStartText.Text);
        }

        [Test]
        public void HowToStartLogout()
        {
            MainPage main = new MainPage();
            main.scrollpam();
            main.HowToStart.Click();
            StringAssert.AreEqualIgnoringCase("ШАГ 4.", main.HowToStartText.Text);
        }



        [Test]
        public void DownloadClientButtonDesktop()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();
            main.scrollpam();
            main.DownloadAppWindows.Click();
            StringAssert.AreEqualIgnoringCase("Спасибо за скачивание", main.DownloadAppWindowsText.Text);
        }

        [Test]
        [Ignore("wait id")]
        public void DownloadClientButtonMobile()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();
            main.scrollpam();
            main.InputDownloadAppi.SendKeys("637316213");
            main.TakeLinksDownloadAppMobile.Click();
            System.Threading.Thread.Sleep(7000);
            StringAssert.AreEqualIgnoringCase("Cсылка отправлена", main.TakeLinksDownloadAppMobileText.Text);
        }



        [Test]
        public void FilterGameCold()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.FiltrCold.Click();

            StringAssert.AreEqualIgnoringCase("Холодный", main.TitleFilters.Text);

            Assert.NotNull(main.GamesBlogMainpage15.Displayed);


        }



        [Test]
        public void Allbonus()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();

            main.FiltrCold.Click();

            StringAssert.AreEqualIgnoringCase("Холодный", main.TitleFilters.Text);

            Assert.NotNull(main.GamesBlogMainpage15.Displayed);


        }

        [Test]
        public void AllbonusesД()
        {
            MainPage main = new MainPage();

            main.FiltrCold.Click();

            StringAssert.AreEqualIgnoringCase("Холодный", main.TitleFilters.Text);


            Assert.NotNull(main.GamesBlogMainpage15.Displayed);
        }

        [Test]
        public void FilterGameColdHot()
        {
            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            main.logo.Click();


            main.FiltrHot.Click();
            StringAssert.AreEqualIgnoringCase("Горячий", main.TitleFilters.Text);


            Assert.NotNull(main.GamesBlogMainpage15.Displayed);
        }

        [Test]
        public void FilterGameLogoutColdHot()
        {
            MainPage main = new MainPage();

            main.FiltrHot.Click();
            StringAssert.AreEqualIgnoringCase("Горячий", main.TitleFilters.Text);


            Assert.NotNull(main.GameContainer.Displayed);
        }




        [Test]
        public void GameGridMainPage()
        {

            MainPage main = new MainPage();
            VuePage vue = new VuePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            Assert.NotNull(main.GameGrid.Displayed);
        }


        [Test]
        public void UserBarLogin()
        {

            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            Thread.Sleep(1000);
            main.logo.Click();
            Assert.NotNull(main.UserBar.Displayed);
        }

        [Test]
        public void UserBarUnLogin()
        {

            MainPage main = new MainPage();
            Assert.NotNull(main.UserBar.Displayed);
        }

        [Test]
        public void Card_BonusesNoDeposit()
        {

            HeaderMenu header = new HeaderMenu();
            Thread.Sleep(1200);
            header.BonusesLnk.Click();
            BonusPage bonus = new BonusPage();
            Thread.Sleep(1200);
            bonus.ReloadCard.Click();
            StringAssert.AreEqualIgnoringCase("Условия получения бонуса", bonus.ReloadCardNameBonesesBesdep.Text);



        }

        [Test]
        public void Check_ToutnamentBannerButton()
        {

            VuePage vue = new VuePage();

            vue.Registration(false);

            Thread.Sleep(1400);
            Driver.Browser.Url = "https://777originals.com/tournaments/#/";
            TournamentsPage tournament = new TournamentsPage();

            Assert.IsNotNull(tournament.GoToTournament.Displayed);


        }

        [Test]
        public void Banner_WelcomePack()
        {

            MainPage mainPage = new MainPage();

            mainPage.ScrollToMainBlock3();
            StringAssert.AreEqualIgnoringCase("МЫ О ВАС ПОЗАБОТИЛИСЬ", mainPage.Pucket.Text);

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

