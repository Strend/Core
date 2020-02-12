using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Slotoking
{
    class AllGamesRun
    {
        AllGames games = new AllGames();
        VuePage vue;
        HeaderMenu header;
        const int DELAY = 38000;


        [SetUp]
        public void BeforeTest()
        {
            
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            // Driver.Browser.Manage().Window.Size = new Size(1280, 768);
            vue = new VuePage();
            header = new HeaderMenu();
            vue.Auth(TestDataResourceSlotoking.GameUserTest, false);
            //Thread.Sleep(1300);

        }

        [Test]
        public void Novomatic2()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            Thread.Sleep(1300);
            games.NovomaticButton.Click();
            Thread.Sleep(1000);
            games.MoveCursorToGame(games.Hover_novomatic1);
           // games.PlaySecondGameNovomatic1.Click();
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
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());




        }

        [Test]
        public void Novomatic_BookOfRa()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.NovomaticButton.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_novomatic2);
          //  games.PlaySecondGameNovomatic2.Click();
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
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Novomatic_GoldenSevensDeluxe()
        {
            header.GamesLnk.Click();
            //Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.NovomaticButton.Click();
            //Thread.Sleep(1000);
            games.MoveCursorToGame(games.Hover_novomatic3);
            //  games.PlaySecondGameNovomatic3.Click();
            games.RightBarGameButton.Click();
            //System.Threading.Thread.Sleep(6000);

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
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Igrosoft2()
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
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }


        [Test]
        public void Igrosoft1()
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
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Igrosoft3()
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
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
       
        public void King1()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.King.Click();
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
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
       
        public void King3()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.King.Click();
            Thread.Sleep(1000);

            games.MoveCursorToGame(games.Hover_FirstGame);
            games.RightBarGameButton.Click();
            System.Threading.Thread.Sleep(15000);
            var balance = games.BalanceTextPartners.Text.DoubleParseAdvanced();

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.GameContainer, 693, 710);

            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(3000);
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        
        public void King2()
        {
            header.GamesLnk.Click();
            Thread.Sleep(1300);
            games.GameProvaider.Click();
            games.King.Click();
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
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Quickspin3()
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
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Quickspin1()
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

            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1192, 775);
            System.Threading.Thread.Sleep(5000);
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Quickspin2e()
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
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Elk1()
        {

            header.GamesLnk.Click();
            Thread.Sleep(1200);
            games.GameProvaider.Click();
            games.ElkButton.Click();
            Thread.Sleep(1000);

            System.Threading.Thread.Sleep(2000);
            games.MoveCursorToGame(games.Hover_FirstGame);
            System.Threading.Thread.Sleep(2000);
            //games.RightBarGameButton.Click();

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
            MainPage king = new MainPage();
            king.GameChangeSidebarActive.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Elk3()
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
            
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Elk2()
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
            
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }


        [Test]
        public void Thunderkick1()
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

            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);

            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Thunderkick2()
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

            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);

            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Spinomenal1()
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
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(3000);
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Spinomenal3()
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
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(5000);
            
            Assert.AreNotEqual(balance, games.BalanceTextPartners.Text.DoubleParseAdvanced());
        }

        [Test]
        public void Spinomenal2()
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
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 693, 650);
            System.Threading.Thread.Sleep(3000);
            
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
            games.ButtonClick(games.GameContainer, 693, 680);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            
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
            games.ButtonClick(games.GameContainer, 693, 680);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(5000);
            
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
            games.ButtonClick(games.GameContainer, 693, 680);
            games.ButtonClick(games.GameContainer, 693, 650);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.GameContainer, 693, 710);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.GameContainer, 693, 710);

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