using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SlotokingNew;
using SlotokingNew.Pages;
using System;


namespace SlotokingNewDesktop
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

            public void Profile_Data()
            {
                VuePage vue = new VuePage();
                Random rnd = new Random();
                ProfilePage account = new ProfilePage();
                HeaderMenu head = new HeaderMenu();
                vue.Registration(false);
                Driver.Browser.Url = TestDataResource.MainPageURL;
                head.ProfileIcon.Click();
                vue.PtofileMenuButtonsData.Click();
                System.Threading.Thread.Sleep(1000);
                account.NameTextBox.SendKeys(TestDataResource.UserName);
                System.Threading.Thread.Sleep(1000);
                account.SurnameTextBox.SendKeys(TestDataResource.UserSurname);
                account.PhoneCountryListBox.Click();
                account.PhoneContryListBoxUkraine.Click();
                account.PlayerPhoneTextBox.SendKeys("500508" + rnd.Next(100, 999).ToString());
                account.ChooseCountry();
                account.NickName.SendKeys("Хаос" + rnd.Next(100, 999).ToString());
                account.PassportNumber.SendKeys("254412");
                account.SavePersonalInfoButton.Click();
                account.MyBonusesButton.Click();
                vue.PtofileMenuButtonsData.Click();
                StringAssert.AreEqualIgnoringCase("Alex", account.NameTextBoxDisable.Text);
            }

            [Test]

            public void MyVipStatus()
            
            {
                VuePage vue = new VuePage();
                HeaderMenu head = new HeaderMenu();
                ProfilePage account = new ProfilePage();
                vue.Registration(false);
                
                Driver.Browser.Url = TestDataResource.MainPageURL;


                head.ProfileIcon.Click();

                account.VipStatusButton.Click();
                account.VipStatusButtonAbout.Click();


                 StringAssert.AreEqualIgnoringCase("Король", account.VipStatusButtonAboutKing.Text);
        }

        [Test]

        public void MyPrizeNewUser()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.Registration(false);
            Driver.Browser.Url = TestDataResource.MainPageURL;
            head.ProfileIcon.Click();

            account.Myprize.Click();
            account.PlayUtchastvovatTournament.Click();

            Assert.NotNull(account.IgraySeychas);

        }

        [Test]

        public void MyPrizeOldUser()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.Auth(TestDataResource.GameUserTest, false);
            Driver.Browser.Url = TestDataResource.MainPageURL;
            head.ProfileIcon.Click();

            account.Myprize.Click();

            Assert.NotNull(account.CardTournament);
            

        }

        [Test]

            public void MyTournaments()
            {
                VuePage vue = new VuePage();
                HeaderMenu head = new HeaderMenu();
                ProfilePage account = new ProfilePage();
                vue.Auth(TestDataResource.GameUserTest, false);
                Driver.Browser.Url = TestDataResource.MainPageURL;
                head.ProfileIcon.Click();
                account.MyTournamentsButton.Click();
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
                vue.Auth(TestDataResource.GameUserTest, false);
                Driver.Browser.Url = TestDataResource.MainPageURL;
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
            vue.Registration(false);
            Driver.Browser.Url = TestDataResource.MainPageURL;
            head.ProfileIcon.Click();
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
            vue.Registration(false);
            Driver.Browser.Url = TestDataResource.MainPageURL;
            head.ProfileIcon.Click();

            account.MyBonusesButton.Click();
            account.InfoBonusProfile.Click();


            Assert.NotNull(account.InfoBonusProfileText.Displayed);
        }



        [Test]

        public void MyCashback()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.Registration(false);
            Driver.Browser.Url = TestDataResource.MainPageURL;
            head.ProfileIcon.Click();

            account.DashboardButtonCashback.Click();
            account.ButtonCashbackInfo.Click();
            StringAssert.AreEqualIgnoringCase("Я могу получить кэшбэк?", account.CashbackInfo.Text);
        }




        [Test]

        public void MyBonusbalance()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.Registration(false);
            Driver.Browser.Url = TestDataResource.MainPageURL;
            head.ProfileIcon.Click();

            Assert.NotNull(account.BonusBalance.Displayed);
        }


        [Test]

        public void MyCashBoxButton()
        {
            VuePage vue = new VuePage();
            HeaderMenu head = new HeaderMenu();
            ProfilePage account = new ProfilePage();
            vue.Registration(false);
            Driver.Browser.Url = TestDataResource.MainPageURL;
            head.ProfileIcon.Click();

            account.MyBonusesCashbackButton.Click();
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
    }


