using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SlotokingNew;
using System;
using System.Threading;

namespace Vulkan777
{
    class VuePage
    {
        //Login
        public IWebElement LoginEmailTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='emailLogin']"));
        public IWebElement LoginEmailErrorText => Driver.WaitUntilVisible(By.CssSelector("#login-type-panel > div > div > div > div > span"));
        public IWebElement LoginPhoneTextBox => Driver.WaitUntilVisible(By.Id("inputLogin"));
        public IWebElement LoginSubmitButton => Driver.WaitUntilVisible(By.CssSelector("#loginForm > div.button-submit"));
        public IWebElement EmailTabLogin => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div:nth-child(1) > div > div > div.modal-registration.modal-registration--right > div > div.mdl-tabs.mdl-js-tabs.mdl-js-ripple-effect.is-upgraded > div > a.mdl-tabs__tab.is-active"));
        public IWebElement EmailTabReg => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/div/a[1]/span"));

        //Registration
        public IWebElement RegistrationEmailTextBox => Driver.WaitUntilClickable(By.XPath("//*[@id='emailReg']"));
        public IWebElement PasswordRegTextBox => Driver.WaitUntilClickable(By.Id("passwordReg"));
        public IWebElement PasswordLoginTextBox => Driver.WaitUntilClickable(By.Id("passwordLogin"));
        public IWebElement RegistrPhoneTextBox => Driver.WaitUntilClickable(By.Id("inputPhoneRegister"));
        public IWebElement RegistrationAgreementLink => Driver.WaitUntilClickable(By.PartialLinkText("положения и условия"));
        public IWebElement RegistrationAgreeCheckBox => Driver.WaitUntilClickable(By.CssSelector("#vuePopup > div:nth-child(1) > div > div > div.modal-registration.modal-registration--right > div > div.mdl-tabs.mdl-js-tabs.mdl-js-ripple-effect.mdl-js-ripple-effect--ignore-events.is-upgraded > form > div.checkbox > label > span.mdl-checkbox__ripple-container.mdl-js-ripple-effect.mdl-ripple--center"));
        public IWebElement RegistrationSubmitButton => Driver.WaitUntilClickable(By.CssSelector("#vuePopup > div:nth-child(1) > div > div > div.modal-registration.modal-registration--right > div > div.mdl-tabs.mdl-js-tabs.mdl-js-ripple-effect.mdl-js-ripple-effect--ignore-events.is-upgraded > form > div.button-submit > button"));

        public IWebElement RegistrationSubmitButtonMobile => Driver.WaitUntilClickable(By.XPath("//*[@id='register - form']/div/button/span"));
        public IWebElement PhoneTabLogin => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div/div[2]/div/div[2]/div/a[2]"));
        public IWebElement EmailReg => Driver.WaitUntilClickable(By.CssSelector("#vuePopup > div:nth-child(1) > div > div > div.modal-registration.modal-registration--right > div > div.mdl-tabs.mdl-js-tabs.mdl-js-ripple-effect.mdl-js-ripple-effect--ignore-events.is-upgraded > div > a:nth-child(2) > span"));
        public IWebElement RestorePassButton => Driver.WaitUntilClickable(By.XPath("//*[@id='loginForm']/div[4]/a"));
        public IWebElement ChangeCountryList => Driver.WaitUntilClickable(By.XPath("//*[@id='login-type-panel']/div/div/div[1]/div"));
        public IWebElement ChangeCountryListReg => Driver.WaitUntilClickable(By.XPath("//*[@id='reg-type-panel']/div/div/div[1]"));
        public IWebElement UARadioButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/form/div[2]/div[2]/label[1]/span[4]"));
        public IWebElement UARadioButtonReg => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/form/div[2]/div[2]/label[1]/span[4]"));
        public IWebElement RURadioButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/form/div[2]/div[2]/label[2]/span[4]"));
        public IWebElement USDRadioButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/form/div[2]/div[2]/label[3]/span[4]"));

        //Generic
        public IWebElement RestorePassFinalText => Driver.WaitUntilClickable(By.XPath("//*[@id='loginForm']/div[2]/div/span"));
        public IWebElement RestorePassFinalSendMore => Driver.WaitUntilClickable(By.XPath("//*[@id='loginForm']/div[2]/div/a"));

        public IWebElement RestorePassByEmailError => Driver.WaitUntilClickable(By.XPath("//*[@id='login-type-panel']/div/div/span[1]"));
        public IWebElement OkButtonRestoreSuccses => Driver.WaitUntilClickable(By.XPath("//*[@id='popup-remind-success']/div/div[2]/a[text()='Ок']"));
        public IWebElement OkButtonRestoreError => Driver.WaitUntilClickable(By.XPath("//*[@id='popup-remind-error']/div/div[2]/a[text()='Ок']"));
        public IWebElement VKLoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div/div[2]/div/div[3]/ul/li[2]/a"));
        public IWebElement FacebookLoginButton => Driver.WaitUntilClickable(By.XPath("social-icons__fb"));
        public IWebElement GoogleLoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div/div[2]/div/div[3]/ul/li[1]/a"));
        public IWebElement OKLoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div/div[2]/div/div[3]/ul/li[5]/a"));
        public IWebElement TwitterLoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div/div[2]/div/div[3]/ul/li[4]/a"));
        public IWebElement MailRULoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div/div[2]/div/div[3]/ul/li[3]/a"));
        public IWebElement ChangeCountryRU => Driver.WaitUntilClickable(By.XPath("//*[@id='login-type-panel']/div/div/div[1]/ul/li[2]/span[1]"));
        public IWebElement ChangeCountryRUReg => Driver.WaitUntilClickable(By.XPath("//*[@id='reg-type-panel']/div/div/div[1]/ul/li[2]/span[1]"));
        public IWebElement RestorePassSuccessMessage => Driver.WaitUntilClickable(By.XPath("//*[@id='loginForm']/div[2]"));
        public IWebElement RestorePassSubmitButton => Driver.WaitUntilClickable(By.CssSelector("#loginForm > div.button-submit"));
        public IWebElement CloseWizzardPopup => Driver.WaitUntilClickable(By.CssSelector("//*[@id='vuePopup']/div[1]/div/div[2]/span"));
        public IWebElement PopupNewPassword => Driver.WaitUntilClickable(By.XPath("//*[@id='popupNewPassword']/div/p"));
        public IWebElement PopupNewPasswordOk => Driver.WaitUntilVisible(By.XPath("//*[@id='popupNewPassword']/div/div/a[1]"));
        public IWebElement Preloader => Driver.WaitUntilVisible(By.CssSelector("body > style"));
        public IWebElement PopupPassword => Driver.WaitUntilVisible(By.XPath("//*[@id='password']"));
        public IWebElement SavePasswordButtonPopup => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/div/div[3]/form/div[3]/button"));
        public IWebElement PopupPasswordRepeat => Driver.WaitUntilVisible(By.XPath("//*[@id='confirmPassword']"));
        public IWebElement FreeSpeens => Driver.WaitUntilClickable(By.CssSelector("#vuePopup > div:nth-child(1) > div > div > button"));
        public IWebElement PtofileMenuButton => Driver.WaitUntilClickable(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(4) > a"));
        public IWebElement PtofileMenuButtons => Driver.WaitUntilClickable(By.Id("userBarAuthBtnProf"));
        public IWebElement PtofileMenuButtonsData => Driver.WaitUntilClickable(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(4) > a"));


        public IWebElement TakeFlags => Driver.WaitUntilClickable(By.Id("intlPhoneInputFlagCont"));
        public IWebElement UkraineFlags => Driver.WaitUntilClickable(By.CssSelector("#intlPhoneInputFlagCont > ul > li:nth-child(1) > span.country-name"));










        // Random Email
        public void InputRandomEmail()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 99999);
            RegistrationEmailTextBox.SendKeys("test" + randomNumber + "@cleacktest.com");
        }

        // Random Phone
        public void InputRandomPhoneUa()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000000, 9999999);
            TakeFlags.Click();
            UkraineFlags.Click();
            RegistrPhoneTextBox.Click();
            RegistrPhoneTextBox.SendKeys("63" + randomNumber.ToString());
        }

        public void InputRandomPhoneRu()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000000, 9999999);

            ChangeCountryListReg.Click();
            ChangeCountryRUReg.Click();
            RegistrPhoneTextBox.Click();
            RegistrPhoneTextBox.SendKeys("495" + randomNumber.ToString());
        }

        public void Registration(bool isPhone)
        {

            Driver.Browser.Url = TestDataResource777Originals.MainPageURL;
            HeaderMenu header = new HeaderMenu();
            ProfilePage prof = new ProfilePage();
            prof.Scroll_todownToLoad();
            System.Threading.Thread.Sleep(1000);
            header.RegistrationButton.Click();
            if (isPhone)
            {
                EmailReg.Click();
                InputRandomPhoneUa();
                prof.AgreeUkrChackbox.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationSubmitButton.Click();

            }
            else
            {
                
                InputRandomEmail();
                RegistrationAgreeCheckBox.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationSubmitButton.Click();

            }
            try
            {
                //PopupPassword.Click();
                //PopupPassword.SendKeys(TestDataResource777Originals.Password);
                //PopupPasswordRepeat.Click();
                //PopupPasswordRepeat.SendKeys(TestDataResource777Originals.Password);
                //SavePasswordButtonPopup.Click();
                Thread.Sleep(3000);
                VuePage vue = new VuePage();
                vue.FreeSpeens.Click();
                WelcomePage welcome = new WelcomePage();
                welcome.CancelButton.Click();

                Cashbox replenish = new Cashbox();

                replenish.CloseCassa.Click();



            }
            catch
            {
                Cashbox replenish = new Cashbox();
                Driver.Browser.SwitchTo().Frame(Driver.Browser.FindElement(By.Id("frame-cash")));
                replenish.CloseNewCahsbox.Click();
                Driver.Browser.SwitchTo().DefaultContent();

            }


        }

        public void Auth(string login, bool isPhone)
        {
            Driver.Browser.Url = TestDataResource777Originals.MainPageURL;
            HeaderMenu menu = new HeaderMenu();
            ProfilePage prof = new ProfilePage();
            prof.Scroll_todownToLoad();
            System.Threading.Thread.Sleep(1000);
            menu.LoginButton.Click();
            if (isPhone)
            {
                PhoneTabLogin.Click();
                TakeFlags.Click();
                UkraineFlags.Click();
                LoginPhoneTextBox.Click();
                LoginPhoneTextBox.SendKeys(login);
                PasswordLoginTextBox.Click();
                PasswordLoginTextBox.SendKeys(TestDataResource777Originals.Password);
                LoginSubmitButton.Click();
            }
            else
            {
                LoginEmailTextBox.Click();
                LoginEmailTextBox.SendKeys(login);
                PasswordLoginTextBox.SendKeys(TestDataResource777Originals.Password);
                LoginSubmitButton.Click();
            }

            try
            {
                //Thread.Sleep(1000);
                ClosePopupWelcomePage();
                WelcomePage welcome = new WelcomePage();
                Cashbox replenish = new Cashbox();
                //Thread.Sleep(1000);
                replenish.CloseCassa.Click();

                //welcome.CancelButton.Click();
                // Thread.Sleep(1000);

                VuePage vue = new VuePage();
                vue.FreeSpeens.Click();

            }
            catch { }
        }

        public void ClosePopupWelcomePage()
        {
            WelcomePage welcome = new WelcomePage();
            welcome.WelcomeText.Text.Contains("Ваш подарок");
            welcome.CancelButton.Click();
        }



        public void MoveCursorToGame(IWebElement game)
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(game).Click().Perform();
        }


    }

}

