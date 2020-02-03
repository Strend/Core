using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SlotokingNew;

namespace VipNetGame
{
    [TestFixture]
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
            vue.Auth(TestDataResourceVipNetGame.TestUserEmail, false);

            Driver.TakeScreenshot();
        }

        [Test]
        public void Screenshot_MailnPage_LoggedOut()
        {
            Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL;
            Driver.TakeScreenshot();
        }


        [Test]
        public void JackPotContainer()
        {

            Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL;

            MainPage jackpotblock = new MainPage();

            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Red.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Silver.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Gold.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Diamond.Displayed);
        }

        [Test]
        public void GameGridMainPage()
        {
            Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL;
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            vue.Auth(TestDataResourceVipNetGame.GameUserTest, false);
            Assert.NotNull(main.GameGrid.Displayed);
        }


        [Test]
        public void UserBarLogin()
        {
            Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL;
            VuePage vue = new VuePage();
            MainPage main = new MainPage();
            vue.Auth(TestDataResourceVipNetGame.GameUserTest, false);
            Assert.NotNull(main.UserBar.Displayed);
        }

        [Test]
        public void UserBarUnLogin()
        {
            Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL;
            MainPage main = new MainPage();
            Assert.NotNull(main.UserBarUnlogin.Displayed);
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
