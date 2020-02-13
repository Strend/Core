using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Vulkan777
{
    class AllGamesRun
    {
        GamePage games;
        VuePage vue;
        HeaderMenu header;
        const int DELAY = 35000;


        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();

            games = new GamePage();
            vue = new VuePage();
            header = new HeaderMenu();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            Thread.Sleep(1300);

        }

        [Test]
        public void Novomatic_BookOfRa()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            Thread.Sleep(1300);
            games.NovomaticButton.Click();
            Thread.Sleep(1000);
            games.MoveCursorToGame(games.Hover_SecondGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(6000);

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 750);
            games.BalanceTextPartnersRepet.Click();
            System.Threading.Thread.Sleep(5000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());

        }

        [Test]
        public void Novomatic_Arriva()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.NovomaticButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(6000);

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();



            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Novomatic_GoldenSevensDeluxe()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.NovomaticButton.Click();
            Thread.Sleep(1000);
            games.MoveCursorToGame(games.Hover_ThirdGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(6000);

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();



            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 750);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Igrosoft_Garage()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.IgrosoftButton.Click();
            Thread.Sleep(1000);
            games.MoveCursorToGame(games.Hover_SecondGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(3000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 1306, 390);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1306, 390);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1306, 390);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }


        [Test]
        public void Igrosoft_FruitCocktail()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.IgrosoftButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(3000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 1306, 390);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1306, 390);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1306, 390);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Igrosoft_Gnome()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.IgrosoftButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_ThirdGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(3000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 1306, 390);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1306, 390);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 1306, 390);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        //[Ignore("")]
        public void Vulkan_GoldenSkulls()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.Vulkan777.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_ThirdGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 1250, 760);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.GameContainer, 1250, 760);

            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1250, 760);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1250, 760);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Vulkan_DiamondShot()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.Vulkan777.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(15000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 1250, 760);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.GameContainer, 1250, 760);

            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1250, 760);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1250, 760);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Vulkan_FruitBar()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.Vulkan777.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_SecondGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 1235, 760);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.GameContainer, 1235, 760);

            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1235, 760);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1250, 760);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartnersRepet.Click();
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
            Thread.Sleep(1300);
            games.GameProvaider.Click();

            games.EzugiButton.Click();
            games.MoveCursorToGame(games.Hover_FirstGame);
            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();

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
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Quickspin_TicketToTheStars()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.QuickspinButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_ThirdGame);
            games.RightBarGameButton.Click();
            Thread.Sleep(1000);
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Quickspin_DivineDreams()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            Thread.Sleep(1300);
            games.QuickspinButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_FourGame);
            Thread.Sleep(1000);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(5000);
            System.Threading.Thread.Sleep(DELAY);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            games.ButtonClick(games.PartnersGameContainer, 693, 690);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Quickspin_JokerStrike()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1200);
            games.GameProvaider.Click();
            Thread.Sleep(1200);
            games.QuickspinButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_SecondGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(DELAY);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Elk_Birthday()
        {

            header.GamesLnk.Click();
            Thread.Sleep(1200);
            games.GameProvaider.Click();
            games.ElkButton.Click();
            Thread.Sleep(1000);

            System.Threading.Thread.Sleep(2000);
            games.MoveCursorToGame(games.Hover_FirstGame);
            System.Threading.Thread.Sleep(2000);
            games.RightBarGameButton.Click();

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(7000);
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 690, 360);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.PartnersGameContainer, 1315, 691);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1315, 691);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1315, 691);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartnersRepet.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Elk_Valkyrie()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1200);
            games.GameProvaider.Click();
            Thread.Sleep(1500);
            games.ElkButton.Click();
            Thread.Sleep(500);
            games.MoveCursorToGame(games.Hover_ThirdGame);
            games.RightBarGameButton.Click();
            Thread.Sleep(1000);


            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(7000);
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 690, 360);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.PartnersGameContainer, 1315, 691);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1315, 691);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1315, 691);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartnersRepet.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Elk_Kaiju()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1200);
            games.GameProvaider.Click();
            Thread.Sleep(1200);
            games.ElkButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_SecondGame);
            games.RightBarGameButton.Click();
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(7000);
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 690, 360);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.PartnersGameContainer, 1315, 691);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1315, 691);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1315, 691);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartnersRepet.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }


        [Test]
        public void ThunderkickCarnivalQueen()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.ThunderkickButton.Click();
            Thread.Sleep(1000);
            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();

            System.Threading.Thread.Sleep(20000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(DELAY);

            games.ButtonClick(games.PartnersGameContainer, 1355, 720);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1355, 720);
            System.Threading.Thread.Sleep(4000);

            games.ButtonClick(games.PartnersGameContainer, 1355, 720);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1355, 720);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Thunderkick_PinkElephants()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.ThunderkickButton.Click();
            Thread.Sleep(1000);
            games.MoveCursorToGame(games.Hover_SecondGame);
            games.RightBarGameButton.Click();

            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();
            System.Threading.Thread.Sleep(DELAY);

            games.ButtonClick(games.PartnersGameContainer, 1355, 720);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1355, 720);
            System.Threading.Thread.Sleep(4000);

            games.ButtonClick(games.PartnersGameContainer, 1355, 720);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1355, 720);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Spinomenal_BookOfGuardians()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.SpinomenalButton.Click();
            Thread.Sleep(6000);

            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(8000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 693, 705);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 693, 707);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 707);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 707);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 707);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Spinomenal_lemurDoesVegas()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1000);
            games.GameProvaider.Click();
            games.SpinomenalButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_ThirdGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Spinomenal_FruitsDeluxe()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.SpinomenalButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_SecondGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(5000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 693, 680);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 701);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        [Ignore("")]
        public void TomHorn_JokerPoker()
        {
            header.GamesLnk.Click();
            games.GameProvaider.Click();
            games.TomHornButton.Click();

            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();
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
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }




        [Test]
        public void NetGame1()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            Thread.Sleep(1300);
            games.Netgame.Click();
            Thread.Sleep(1000);
            games.MoveCursorToGame(games.Hover_SecondGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(6000);

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            games.BalanceTextPartnersRepet.Click();
            System.Threading.Thread.Sleep(5000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());

        }

        [Test]
        public void NetGame2()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.Netgame.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(6000);

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();



            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void NetGame3()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.Netgame.Click();
            Thread.Sleep(1000);
            games.MoveCursorToGame(games.Hover_ThirdGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(6000);

            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();



            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(5000);
            games.BalanceTextPartnersRepet.Click();
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
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