using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SlotokingNew;
using System;


namespace VipNetGame
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
            vue.Registration(false);

            //Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL + "profile/account/";


            ProfilePage account = new ProfilePage();
            account.NameTextBox.SendKeys(TestDataResourceVipNetGame.UserName);
            account.SurnameTextBox.SendKeys(TestDataResourceVipNetGame.UserSurname);
            account.MaleGenderRadioButton.Click();
            account.FillDate();
            account.ChooseMobNumberUkraine();
            account.PlayerPhoneTextBox.SendKeys("500508" + rnd.Next(100, 999).ToString());
            account.ChooseCountry();
            account.CityTextBox.SendKeys("Kyiv");
            account.AddressListBox.SendKeys("23007 Ukraine, Kyiv, Hreschatic 25/12");
            account.Scroll_todown();
            account.SavePersonalInfoButton.Click();


            StringAssert.AreEqualIgnoringCase("Ок", account.SuccessSaveMessage.Text);

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
