using Core;
using OpenQA.Selenium;
using SlotokingNew;
using System;


namespace VipNetGame
{
    class VuePage
    {
        //Login
        public IWebElement LoginEmailTextBox => Driver.WaitUntilClickable(By.Id("emailLogin"));
        public IWebElement LoginEmailErrorText => Driver.WaitUntilClickable(By.XPath("//*[@id='login-type-panel']/div/div/div[2]/span[1]"));
        public IWebElement LoginPhoneTextBox => Driver.WaitUntilClickable(By.Id("inputLogin"));
        public IWebElement LoginSubmitButton => Driver.WaitUntilClickable(By.XPath("//*[@id='loginForm']/div[3]/button/span[2]"));
        public IWebElement EmailTabLogin => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[3]/div/div[2]/div[2]/div/div[2]/div/a[1]/span"));
        public IWebElement EmailTabReg => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/div/a[1]/span"));


        //Registration
        public IWebElement RegistrationEmailTextBox => Driver.WaitUntilClickable(By.XPath("//*[@id='emailReg']"));
        public IWebElement PasswordRegTextBox => Driver.WaitUntilClickable(By.Id("passwordReg"));
        public IWebElement PasswordLoginTextBox => Driver.WaitUntilClickable(By.Id("passwordLogin"));
        public IWebElement RegistrPhoneTextBox => Driver.WaitUntilClickable(By.XPath("//*[@id='inputPhoneRegister']"));
        public IWebElement RegistrationAgreementLink => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/form/div[3]/label/span[1]/a"));
        public IWebElement RegistrationAgreeCheckBox => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/form/div[3]/label/span[4]"));
        public IWebElement RegistrationSubmitButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/form/div[4]/button/span[2]"));
        public IWebElement RegistrationSubmitButtonMobile => Driver.WaitUntilClickable(By.XPath("//*[@id='register - form']/div/button/span"));
        public IWebElement PhoneTabLogin => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[3]/div/div[2]/div[2]/div/div[2]/div/a[2]/span"));
        public IWebElement PhoneTabReg => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/div/a[2]/span"));
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
        public IWebElement VKLoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[3]/div/div[2]/div[2]/div/div[3]/ul/li[2]/a"));
        public IWebElement FacebookLoginButton => Driver.WaitUntilClickable(By.XPath("social-icons__fb"));
        public IWebElement GoogleLoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[3]/div/div[2]/div[2]/div/div[3]/ul/li[1]/a"));
        public IWebElement OKLoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[3]/div/div[2]/div[2]/div/div[3]/ul/li[5]/a"));
        public IWebElement TwitterLoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[3]/div/div[2]/div[2]/div/div[3]/ul/li[4]/a"));
        public IWebElement MailRULoginButton => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div/div[3]/div/div[2]/div[2]/div/div[3]/ul/li[3]/a"));
        public IWebElement ChangeCountryRU => Driver.WaitUntilClickable(By.XPath("//*[@id='login-type-panel']/div/div/div[1]/ul/li[2]/span[1]"));
        public IWebElement ChangeCountryRUReg => Driver.WaitUntilClickable(By.XPath("//*[@id='reg-type-panel']/div/div/div[1]/ul/li[2]/span[1]"));
        public IWebElement RestorePassSuccessMessage => Driver.WaitUntilClickable(By.XPath("//*[@id='loginForm']/div[2]"));
        public IWebElement RestorePassSubmitButton => Driver.WaitUntilClickable(By.XPath("//*[@id='loginForm']/div[3]/button/span[2]"));
        public IWebElement CloseWizzardPopup => Driver.WaitUntilClickable(By.CssSelector("//*[@id='vuePopup']/div[1]/div/div[2]/span"));




        // Random Email
        public void InputRandomEmail()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 99999);
            RegistrationEmailTextBox.SendKeys("test" + randomNumber + "@mail.ru");
        }

        // Random Phone
        public void InputRandomPhoneUa()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000000, 9999999);
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
            Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL;
            RightMenu header = new RightMenu();
            ProfilePage prof = new ProfilePage();
            header.RegistrationButton.Click();
            if (isPhone)
            {
                PhoneTabReg.Click();
                InputRandomPhoneUa();
                PasswordRegTextBox.SendKeys(TestDataResourceVipNetGame.Password);
                RegistrationAgreeCheckBox.Click();
                RegistrationSubmitButton.Click();

            }
            else
            {
                InputRandomEmail();
                PasswordRegTextBox.SendKeys(TestDataResourceVipNetGame.Password);
                prof.AgreeUkrChackbox.Click();
                RegistrationAgreeCheckBox.Click();
                RegistrationSubmitButton.Click();

            }
        }

        public void Auth(string login, bool isPhone)
        {
            Driver.Browser.Url = TestDataResourceVipNetGame.MainPageURL;
            RightMenu menu = new RightMenu();
            menu.LoginButton.Click();
            if (isPhone)
            {
                PhoneTabLogin.Click();
                LoginPhoneTextBox.Click();
                LoginPhoneTextBox.SendKeys(login);
                PasswordLoginTextBox.Click();
                PasswordLoginTextBox.SendKeys(TestDataResourceVipNetGame.Password);
                LoginSubmitButton.Click();
            }
            else
            {
                LoginEmailTextBox.Click();
                LoginEmailTextBox.SendKeys(login);
                PasswordLoginTextBox.SendKeys(TestDataResourceVipNetGame.Password);
                LoginSubmitButton.Click();
            }
        }

        public void ClosePopupWelcomePage()
        {
            WelcomePage welcome = new WelcomePage();
            welcome.WelcomeText.Text.Contains("Ваш подарок");
            welcome.CancelButton.Click();
        }

    }

}
