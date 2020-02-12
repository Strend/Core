using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Chrome;

namespace VipNetGame
{
    class AllGamesRun
    {
        GamePage games;
        VuePage vue;
        RightMenu header;
        const int DELAY = 16000;


        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            games = new GamePage();
            vue = new VuePage();
            header = new RightMenu();
            vue.Auth(TestDataResourceVipNetGame.GameUserTest, false);
            vue.ClosePopupWelcomePage();
        }

        [Test]
        public void Novomatic_BookOfRa()
        {
            header.GamesLnk.Click();
            games.NovomaticButton.Click();

            games.MoveCursorToGame(games.Novomatic_BookOfRa);
            games.BookOfRaPlay.Click();
            System.Threading.Thread.Sleep(6000);

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();



            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 990, 958);
            System.Threading.Thread.Sleep(1000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Novomatic_Arriva()
        {
            header.GamesLnk.Click();
            games.NovomaticButton.Click();

            games.MoveCursorToGame(games.Novomatic_Arriva);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(6000);

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();



            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 990, 958);
            System.Threading.Thread.Sleep(1000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Novomatic_GoldenSevensDeluxe()
        {
            header.GamesLnk.Click();
            games.NovomaticButton.Click();

            games.MoveCursorToGame(games.Novomatic_GoldenSevensDeluxe);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(6000);

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();



            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 990, 958);
            System.Threading.Thread.Sleep(1000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Igrosoft_PumpkinFairy()
        {
            header.GamesLnk.Click();
            games.IgrosoftButton.Click();

            games.MoveCursorToGame(games.Igrosoft_PumpkinFairy);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(3000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 1800, 533);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1800, 533);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1800, 533);
            System.Threading.Thread.Sleep(2000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }


        [Test]
        public void Igrosoft_FruitCocktail()
        {
            header.GamesLnk.Click();
            games.IgrosoftButton.Click();

            games.MoveCursorToGame(games.Igrosoft_FruitCocktail);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(3000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 1800, 533);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1800, 533);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1800, 533);
            System.Threading.Thread.Sleep(2000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Igrosoft_Gnome()
        {
            header.GamesLnk.Click();
            games.IgrosoftButton.Click();

            games.MoveCursorToGame(games.Igrosoft_Gnome);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(3000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 1800, 533);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1800, 533);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1800, 533);
            System.Threading.Thread.Sleep(2000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void King_GoldenSkulls()
        {
            header.GamesLnk.Click();
            games.KingButton.Click();

            games.MoveCursorToGame(games.King_GoldenSkulls);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 990, 930);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.GameContainer, 990, 958);

            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 990, 958);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 990, 958);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void King_DiamondShot()
        {
            header.GamesLnk.Click();
            games.KingButton.Click();

            games.MoveCursorToGame(games.King_DiamondShot);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 990, 930);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.GameContainer, 990, 958);

            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 990, 958);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 990, 958);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void King_FruitBar()
        {
            header.GamesLnk.Click();
            games.KingButton.Click();

            games.MoveCursorToGame(games.King_FruitBar);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 1700, 1000);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.GameContainer, 1700, 1000);

            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1700, 1000);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1700, 1000);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        [Ignore("")]
        public void Ezugi_Baccarat()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-features=EnableEphemeralFlashPermission");
            chromeOptions.AddUserProfilePreference("profile.content_settings.exceptions.plugins.*, *.setting", 1);
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.plugins", 1);
            chromeOptions.AddUserProfilePreference("profile.content_settings.plugin_whitelist.adobe - flash - player", 1);

            header.GamesLnk.Click();

            games.EzugiButton.Click();
            games.MoveCursorToGame(games.Ezugi_Baccarat);
            games.MoveCursorToGame(games.Ezugi_Baccarat);
            games.GamePlayButton.Click();

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 200, 200);
            System.Threading.Thread.Sleep(10000);
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Quickspin_TicketToTheStars()
        {
            header.GamesLnk.Click();
            games.QuickspinButton.Click();

            games.MoveCursorToGame(games.Quickspin_TicketToTheStars);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 1800, 540);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1600, 1000);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1600, 1000);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1600, 1000);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1600, 1000);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Quickspin_DivineDreams()
        {
            header.GamesLnk.Click();
            games.QuickspinButton.Click();

            games.MoveCursorToGame(games.Quickspin_DivineDreams);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(DELAY);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            games.ButtonClick(games.PartnersGameContainer, 990, 958);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1550, 1000);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1550, 1000);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1550, 1000);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1550, 1000);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Quickspin_JokerStrike()
        {
            header.GamesLnk.Click();
            games.QuickspinButton.Click();

            games.MoveCursorToGame(games.Quickspin_JokerStrike);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(DELAY);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            games.ButtonClick(games.PartnersGameContainer, 960, 940);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1550, 1000);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1550, 1000);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1550, 1000);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1550, 1000);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Elk_Gold()
        {
            header.GamesLnk.Click();
            games.ElkButton.Click();

            games.MoveCursorToGame(games.Elk_Gold);
            games.GamePlayButton.Click();
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(7000);
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 958, 520);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.PartnersGameContainer, 1800, 900);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1800, 900);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1800, 900);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Elk_Valkyrie()
        {
            header.GamesLnk.Click();
            games.ElkButton.Click();

            games.MoveCursorToGame(games.Elk_Valkyrie);
            games.GamePlayButton.Click();
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(7000);
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 958, 520);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.PartnersGameContainer, 1800, 900);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1800, 900);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1800, 900);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Elk_TheWiz()
        {
            header.GamesLnk.Click();
            games.ElkButton.Click();

            games.MoveCursorToGame(games.Elk_TheWiz);
            games.GamePlayButton.Click();
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(7000);
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 958, 520);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.PartnersGameContainer, 1800, 900);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1800, 900);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1800, 900);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }


        [Test]
        public void ThunderkickCarnivalQueen()
        {
            header.GamesLnk.Click();
            games.ThunderkickButton.Click();
            games.MoveCursorToGame(games.ThunderkickCarnivalQueen);
            games.GamePlayButton.Click();

            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(DELAY);

            games.ButtonClick(games.PartnersGameContainer, 1880, 980);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1880, 980);
            System.Threading.Thread.Sleep(4000);

            games.ButtonClick(games.PartnersGameContainer, 1880, 980);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1880, 980);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Thunderkick_PinkElephants()
        {
            header.GamesLnk.Click();
            games.ThunderkickButton.Click();
            games.MoveCursorToGame(games.Thunderkick_PinkElephants);
            games.GamePlayButton.Click();

            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(DELAY);

            games.ButtonClick(games.PartnersGameContainer, 1880, 980);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1880, 980);
            System.Threading.Thread.Sleep(4000);

            games.ButtonClick(games.PartnersGameContainer, 1880, 980);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1880, 980);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Spinomenal_BookOfGuardians()
        {
            header.GamesLnk.Click();
            games.SpinomenalButton.Click();

            games.MoveCursorToGame(games.Spinomenal_BookOfGuardians);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 990, 980);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 990, 958);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 990, 958);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Spinomenal_lemurDoesVegas()
        {
            header.GamesLnk.Click();
            games.SpinomenalButton.Click();

            games.MoveCursorToGame(games.Spinomenal_lemurDoesVegas);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 990, 980);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 990, 958);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 990, 958);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Spinomenal_FruitsDeluxe()
        {
            header.GamesLnk.Click();
            games.SpinomenalButton.Click();

            games.MoveCursorToGame(games.Spinomenal_FruitsDeluxe);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 990, 980);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 990, 958);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 990, 958);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        [Ignore("")]
        public void TomHorn_JokerPoker()
        {
            header.GamesLnk.Click();
            games.TomHornButton.Click();

            games.MoveCursorToGame(games.TomHorn_JokerPoker);
            games.GamePlayButton.Click();
            System.Threading.Thread.Sleep(3000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.Tom_HornGameContainer, 950, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 950, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 700, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 700, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 700, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 700, 730);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        //[Ignore("not complited")]
        public void DemoGameRun_Positive()
        {
            Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL + "games/automate/";
            GamePage games = new GamePage();
            RightMenu header = new RightMenu();

            header.GamesLnk.Click();
            games.NovomaticButton.Click();
            games.MoveCursorToGame(games.BookOfRaImage);
            games.BookOfRaPlayDemo.Click();
            // games.ButtonClick(games.GameContainer, 960, 540);
            games.GameContainerDemo.Click();
            var startSize = new System.Drawing.Size(1400, 800);
            games.ReturnFocus();
            games.FullscrinButtonClick();

            if (games.CalcContainerSize().Height > startSize.Height)
            {
                Assert.Pass();
                return;
            }
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



