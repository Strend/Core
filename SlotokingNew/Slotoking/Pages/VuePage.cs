using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Slotoking
{
    class VuePage
    {
        //Login
        public IWebElement LoginEmailTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='emailLogin']/label/div[2]/div[1]/div/input"));
        public IWebElement LoginEmailErrorText => Driver.WaitUntilVisible(By.CssSelector("#login-type-panel > div > div > div > div > span"));
        public IWebElement LoginPhoneTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='inputLogin']/label/div[2]/div[1]/div/div[2]/input"));
        public IWebElement LoginSubmitButton => Driver.WaitUntilVisible(By.CssSelector("#loginForm > div.enter-or-forgot-block > div.button-submit > button"));
        public IWebElement EmailTabLogin => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div:nth-child(1) > div > div > div.modal-registration.modal-registration--right > div > div.mdl-tabs.mdl-js-tabs.mdl-js-ripple-effect.is-upgraded > div > a.mdl-tabs__tab.is-active"));
        public IWebElement EmailTabReg => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/div/a[1]/span"));

        //Registration
        public IWebElement RegistrationEmailTextBox => Driver.WaitUntilClickable(By.XPath("//*[@id='inputEmailRegister']/label/div[2]/div[1]/div/input"));
        public IWebElement PasswordRegTextBox => Driver.WaitUntilClickable(By.CssSelector("#reg-type-panel > div.password-field > div > div > label > div.app-form-el__data-holder > div.app-form-el__field-holder > div > input"));
        public IWebElement PasswordLoginTextBox => Driver.WaitUntilClickable(By.XPath("//*[@id='passwordLogin']/label/div[2]/div[1]/div/input"));
        public IWebElement RegistrPhoneTextBox => Driver.WaitUntilClickable(By.CssSelector("#inputPhoneRegister > label > div.app-form-el__data-holder > div.app-form-el__field-holder > div > div.app-phone__field > input"));
        public IWebElement RegistrationAgreementLink => Driver.WaitUntilClickable(By.PartialLinkText("положения и условия"));
        public IWebElement RegistrationAgreeCheckBox => Driver.WaitUntilClickable(By.CssSelector("#authRegistrationCheckbox1 > span.mdl-checkbox__ripple-container.mdl-js-ripple-effect.mdl-ripple--center"));
        public IWebElement RegistrationSubmitButton => Driver.WaitUntilClickable(By.CssSelector("#vuePopup > div:nth-child(1) > div > div > div.modal-registration.modal-registration--right > div > div.mdl-tabs.mdl-js-tabs.mdl-js-ripple-effect.mdl-js-ripple-effect--ignore-events.is-upgraded > form > div.button-submit > button"));


        public IWebElement UahReg => Driver.WaitUntilClickable(By.CssSelector("#vuePopup > div.popups-update-view-tmp > div > div > div.modal-registration.modal-registration--right > div > div.mdl-tabs.mdl-js-tabs.mdl-js-ripple-effect.mdl-js-ripple-effect--ignore-events.is-upgraded > form > div.text-inputs > div.radio-buttons.radio-buttons--currency > label:nth-child(2) > span.mdl-radio__ripple-container.mdl-js-ripple-effect.mdl-ripple--center"));


        
        public IWebElement RegistrationSubmitButtonMobile => Driver.WaitUntilClickable(By.XPath("//*[@id='register - form']/div/button/span"));
        public IWebElement PhoneTabLogin => Driver.WaitUntilClickable(By.Id("loginModalLogin1"));
        public IWebElement EmailReg => Driver.WaitUntilClickable(By.CssSelector("#registrModalRegistration1 > span"));
        public IWebElement RestorePassButton => Driver.WaitUntilClickable(By.Id("authLoginForgotPassword2"));
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
        public IWebElement VKLoginButton => Driver.WaitUntilClickable(By.Id("authLoginSocialLinkVkontakte"));
        public IWebElement FacebookLoginButton => Driver.WaitUntilClickable(By.XPath("social-icons__fb"));
        public IWebElement GoogleLoginButton => Driver.WaitUntilClickable(By.Id("authLoginSocialLinkGoogle"));
        public IWebElement OKLoginButton => Driver.WaitUntilClickable(By.Id("authLoginSocialLinkOdnoklassniki"));
        public IWebElement TwitterLoginButton => Driver.WaitUntilClickable(By.Id("authLoginSocialLinkTwitter"));
        public IWebElement MailRULoginButton => Driver.WaitUntilClickable(By.Id("authLoginSocialLinkMailru"));
        public IWebElement ChangeCountryRU => Driver.WaitUntilClickable(By.XPath("//*[@id='login-type-panel']/div/div/div[1]/ul/li[2]/span[1]"));
        public IWebElement ChangeCountryRUReg => Driver.WaitUntilClickable(By.XPath("//*[@id='reg-type-panel']/div/div/div[1]/ul/li[2]/span[1]"));
        public IWebElement RestorePassSuccessMessage => Driver.WaitUntilClickable(By.XPath("//*[@id='loginForm']/div[2]"));
        public IWebElement RestorePassSubmitButton => Driver.WaitUntilClickable(By.Id("authLoginBtnSubmit"));
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
        public IWebElement PtofileMenuButtonsData => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/nav/ul/li[5]/span"));
        public IWebElement TakeFlags => Driver.WaitUntilClickable(By.XPath("//*[@id='inputLogin']/label/div[2]/div[1]/div/div[1]"));
        public IWebElement UkraineFlags => Driver.WaitUntilClickable(By.Id("ua"));
        public IWebElement TakeFlagsReg => Driver.WaitUntilClickable(By.XPath("//*[@id='inputPhoneRegister']/label/div[2]/div[1]/div/div[1]"));

        public IWebElement CloseBonus => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div[1]/div/button"));









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
            TakeFlagsReg.Click();
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

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            HeaderMenu header = new HeaderMenu();
            ProfilePage prof = new ProfilePage();
            prof.Scroll_todownToLoad();
            System.Threading.Thread.Sleep(1000);
            header.RegistrationButton.Click();
            if (isPhone)
            {
                EmailReg.Click();
                InputRandomPhoneUa();
                PasswordRegTextBox.SendKeys(TestDataResourceSlotoking.Password);
                
                UahReg.Click();
                
                RegistrationAgreeCheckBox.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationSubmitButton.Click();
                Thread.Sleep(10000);

            }
            else
            {
               
                InputRandomEmail();
                PasswordRegTextBox.SendKeys(TestDataResourceSlotoking.Password);
                UahReg.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationSubmitButton.Click();
                Thread.Sleep(10000);
            }
            try
            {
                //PopupPassword.Click();
                //PopupPassword.SendKeys(TestDataResourceSlotoking.Password);
                //PopupPasswordRepeat.Click();
                //PopupPasswordRepeat.SendKeys(TestDataResourceSlotoking.Password);
                //SavePasswordButtonPopup.Click();
                
                VuePage vue = new VuePage();
                vue.FreeSpeens.Click();
                //WelcomePage welcome = new WelcomePage();
                //welcome.CancelButton.Click();

                CashBox replenish = new CashBox();

                replenish.CloseCassa.Click();
                WelcomePage welcome = new WelcomePage();

                welcome.CancelButton.Click();

                
                Driver.Browser.SwitchTo().Frame(Driver.Browser.FindElement(By.Id("frame-cash")));
                //Thread.Sleep(3000);
                replenish.CloseCassa.Click();
                Driver.Browser.SwitchTo().DefaultContent();
            }
            catch
            {
                CloseBonus.Click();

               

            }


        }

        public void Auth(string login, bool isPhone)
        {
            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
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
                PasswordLoginTextBox.SendKeys(TestDataResourceSlotoking.Password);
                LoginSubmitButton.Click();
            }
            else
            {
                LoginEmailTextBox.Click();
                LoginEmailTextBox.SendKeys(login);
                PasswordLoginTextBox.SendKeys(TestDataResourceSlotoking.Password);
                LoginSubmitButton.Click();
            }

            try
            {
                Thread.Sleep(1000);
                ClosePopupWelcomePage();
                WelcomePage welcome = new WelcomePage();
                CashBox replenish = new CashBox();
                //Thread.Sleep(1000);
                replenish.CloseCassa.Click();

                //welcome.CancelButton.Click();
                // Thread.Sleep(1000);

                VuePage vue = new VuePage();
                vue.FreeSpeens.Click();

            }
            catch {


                //CloseBonus.Click();
            }
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





        public void RegistrationMob(bool isPhone)
        {

            Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            HeaderMenu header = new HeaderMenu();
            ProfilePage prof = new ProfilePage();
            prof.Scroll_todownToLoad();
            System.Threading.Thread.Sleep(1000);
            header.RegistrationButtonMob.Click();
            if (isPhone)
            {
                EmailReg.Click();
                InputRandomPhoneUa();
                PasswordRegTextBox.SendKeys(TestDataResourceSlotoking.Password);

               // UahReg.Click();

                RegistrationAgreeCheckBox.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationSubmitButton.Click();
                Thread.Sleep(10000);

            }
            else
            {
                
                InputRandomEmail();
                PasswordRegTextBox.SendKeys(TestDataResourceSlotoking.Password);
                //UahReg.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationSubmitButton.Click();
                Thread.Sleep(10000);

            }
            try
            {
                //PopupPassword.Click();
                //PopupPassword.SendKeys(TestDataResourceSlotoking.Password);
                //PopupPasswordRepeat.Click();
                //PopupPasswordRepeat.SendKeys(TestDataResourceSlotoking.Password);
                //SavePasswordButtonPopup.Click();
                Thread.Sleep(1000);
                VuePage vue = new VuePage();
                vue.FreeSpeens.Click();
                //WelcomePage welcome = new WelcomePage();
                //welcome.CancelButton.Click();

                CashBox replenish = new CashBox();

                replenish.CloseCassa.Click();

               // WelcomePage welcome = new WelcomePage();
                //Thread.Sleep(1000);
                //welcome.CancelButton.Click();

                //Thread.Sleep(1000);
                //Driver.Browser.SwitchTo().Frame(Driver.Browser.FindElement(By.Id("frame-cash")));
                //Thread.Sleep(1000);
                //replenish.CloseCassa.Click();

            }
            catch
            {
                Driver.Browser.Url = TestDataResourceSlotoking.MainPageURL;
            }


        }


    }

}

