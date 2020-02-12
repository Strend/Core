using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace Vulkan777
{
    class ProfileTests

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

        public void Profile_Filling()
        {
            VuePage vue = new VuePage();
            Random rnd = new Random();
            ProfilePage account = new ProfilePage();
            vue.Registration(false);
            Driver.Browser.Url = "https://777originals.com/#/";
            vue.PtofileMenuButtons.Click();
            vue.PtofileMenuButtonsData.Click();
            System.Threading.Thread.Sleep(1000);
            account.NameTextBox.SendKeys(TestDataResource777Originals.UserName);
            System.Threading.Thread.Sleep(1000);
            account.SurnameTextBox.SendKeys(TestDataResource777Originals.UserSurname);
            account.PlayerPhoneTextBox.SendKeys("500508" + rnd.Next(100, 999).ToString());
            account.ChooseCountry();
            account.CityTextBox.SendKeys("Kyiv");
            account.AddressListBox.SendKeys("Hreschatic 25/12");
            account.SavePersonalInfoButton.Click();
            Assert.IsFalse(account.NameTextBox.Enabled);
        }

        [Test]

        public void MyBonuses()
        {
            VuePage vue = new VuePage();
            ProfilePage account = new ProfilePage();
            vue.Registration(false);

            vue.PtofileMenuButtons.Click();

            account.MyBonusesButton.Click();
            Assert.NotNull(account.BunusContainer.Displayed);
        }

        [Test]

        public void MyTournaments()
        {
            VuePage vue = new VuePage();
            ProfilePage account = new ProfilePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            System.Threading.Thread.Sleep(1000);
            vue.PtofileMenuButtons.Click();
            account.MyTournamentsButton.Click();
            account.OpenOneResoultTournaments.Click();


            StringAssert.AreEqualIgnoringCase("Победители", account.WinnersTournaments.Text);
        }

        [Test]

        public void MyCashbox()
        {
            Cashbox replish = new Cashbox();
            VuePage vue = new VuePage();
            ProfilePage account = new ProfilePage();
            vue.Auth(TestDataResource777Originals.GameUserTest, false);
            System.Threading.Thread.Sleep(2000);
            vue.PtofileMenuButtons.Click();
            account.Cahsbox.Click();

            Assert.NotNull(replish.CashboxPopupWithdrawButton.Displayed);
        }

        //[Test]

        //public void MyBonuses()
        //{
        //    VuePage vue = new VuePage();
        //    Random rnd = new Random();
        //    ProfilePage account = new ProfilePage();
        //    vue.Registration(false);
        //    System.Threading.Thread.Sleep(2000);
        //    vue.PtofileMenuButton.Click();







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
        //    vue.PtofileMenuButton.Click();







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
        //    vue.PtofileMenuButton.Click();







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
}
