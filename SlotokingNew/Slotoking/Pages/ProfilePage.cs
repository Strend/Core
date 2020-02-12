using Core;
using OpenQA.Selenium;

namespace Slotoking
{
    class ProfilePage
    {
        public IWebElement DashboardTab => Driver.WaitUntilVisible(By.ClassName("active"));
        public IWebElement DepositForm => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[2]/a"));
        public IWebElement AccountTab => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[3]/a"));
        public IWebElement BonusesPersonalTab => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[4]/a"));
        public IWebElement ProfileHeaderText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div"));
        public IWebElement SuccessSaveMessage => Driver.WaitUntilVisible(By.CssSelector("#popup-profile-success > div > p"));
        public IWebElement EnterNewPassOkButton => Driver.WaitUntilVisible(By.XPath(" //*[@id='onesignal-popover-allow-button']"));
        public IWebElement AgreeUkrChackbox => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/div[2]/div/div[2]/form/div[2]/div[1]/label[2]/span[4]"));
        public IWebElement NameTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div[1]/div[1]/div[1]/label/div[2]/div[1]/div/input"));
        public IWebElement NameTextBoxDisable => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-person-content.scrollbar > div.personal-data-main > div.personal-data-main__column.personal-data-main__column_left > div:nth-child(1) > label > div.app-form-el__data-holder > div.app-form-el__static-holder"));
        public IWebElement PasswordSettingNeed => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > form > div.change-password-start__field-row > div > div > div > span"));



        public IWebElement SurnameTextBox => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-person-content.scrollbar > div.personal-data-main > div.personal-data-main__column.personal-data-main__column_left > div:nth-child(2) > label > div.app-form-el__data-holder > div.app-form-el__field-holder > div > input"));
        public IWebElement NicknameTextBox => Driver.WaitUntilVisible(By.Id("p_playerNickName"));
        public IWebElement MaleGenderRadioButton => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_gender_id_0-styler']"));
        public IWebElement DaySelectBox => Driver.WaitUntilVisible(By.Id("p_playerBirthDay"));
        public IWebElement MonthSelectBox => Driver.WaitUntilVisible(By.Id("p_playerBirthMonth"));
        public IWebElement YearSelectBox => Driver.WaitUntilVisible(By.Id("p_playerBirthYear"));
        public IWebElement SaveTitleButton => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[3]/div[1]/div/button"));
        public IWebElement SavePhoneButton => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[5]/div[1]/div/div[3]/div[2]/button"));
        public IWebElement SavePersonalInfoButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/footer/button"));
        public IWebElement PlayerPhoneTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div[1]/div[1]/div[3]/div[1]/label/div[2]/div[1]/div/div[2]/input"));
        public IWebElement CountryListBox => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-person-content.scrollbar > div.personal-data-main > div.personal-data-main__column.personal-data-main__column_left > div.app-select-country.personal-data-main__row > div > label > div.app-form-el__data-holder > div.app-form-el__field-holder > div > div"));
        public IWebElement UkraineyListBoxElement => Driver.WaitUntilVisible(By.XPath("//*[@id='1']"));
        public IWebElement PhoneCountryListBox => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div[1]/div[1]/div[3]/div[1]/label/div[2]/div[1]/div/div[1]"));
        public IWebElement PhoneContryListBoxUkraine => Driver.WaitUntilVisible(By.XPath("//*[@id='ua']/div/span"));
        public IWebElement PlayersPassword => Driver.WaitUntilVisible(By.Id("Players_password"));
        public IWebElement PlayersPasswordRepeat => Driver.WaitUntilVisible(By.Id("Players_password_repeat"));
        public IWebElement NickName => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div[1]/div[1]/div[6]/label/div[2]/div[1]/div/input"));
        public IWebElement PassportNumber => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div[1]/div[2]/div/form/div/label/div[2]/div[1]/div/input"));
        public IWebElement ButtonReg => Driver.WaitUntilVisible(By.Id("jackpotGuestRegistration"));


        public IWebElement InfoBonusProfile => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div/div/div[1]/div/div[1]/div[2]/header/div[4]"));
        public IWebElement InfoBonusProfileText => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div/div/div[1]/div/div[3]/div/div/div[2]/ol/li[2]"));


        //vip profile

        public IWebElement VipStatusButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/div/div[1]/div[1]/span/span"));
        public IWebElement VipStatusButtonAbout => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/div[1]/div[1]/div[1]/div/div/div/div[2]/div[2]/div/button"));

        public IWebElement VipStatusButtonAboutKing => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > div > div > section.vip-block > div > div.vip-block__list-wrapper > ul > li:nth-child(7) > p"));


        //prize profile

        public IWebElement TournamentStart => Driver.WaitUntilVisible(By.Id("profileDashboardTournamentJoinTournament"));
        public IWebElement Myprize => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/nav/ul/li[2]/span[1]"));
        public IWebElement UtchastvovatTournament => Driver.WaitUntilVisible(By.XPath("//*[@id='profileDashboardTournamentJoinTournament']/span"));
        public IWebElement PlayUtchastvovatTournament => Driver.WaitUntilVisible(By.Id("profileDashboardTournamentJoinTournament"));
        public IWebElement GonkaNachalas => Driver.WaitUntilVisible(By.Id("profileDashboardTournamentJoinGame"));
        public IWebElement IgraySeychas => Driver.WaitUntilVisible(By.XPath("//*[@id='profileDashboardTournamentJoinGame']/span"));



        
        public IWebElement TournamentTheEnd => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div/div/div/div[2]/div[1]/div[2]/header/div[2]/div/span"));
        public IWebElement TournamentTheEndYouWin => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div/div/div/div[2]/div[1]/div[2]/div/div/div/div/text()"));

        public IWebElement CardTournament => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/section/div/div[2]/div/div/div/div[2]"));


        //Cashback

        public IWebElement DashboardButtonCashback => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/div/div[2]/div[2]/div[2]/div[2]"));

        public IWebElement ButtonCashbackInfo => Driver.WaitUntilClickable(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/div/div[2]/div[2]/div[2]/div[3]/div/div/div[2]/div/button/span"));
        public IWebElement CashbackInfo => Driver.WaitUntilClickable(By.XPath("//*[@id='cashback-qa']/div/div[2]/h3"));


        public IWebElement BonusBalance => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/div/div[2]/div[2]/div[1]/div[2]/span[2]"));

        


        public IWebElement DashboardButton => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(1) > a"));

        public IWebElement DashboardCardLeft => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.account-info-content > div > div.dashboard-cards__col.dashboard-cards__col--left"));
        public IWebElement DashboardCardRight => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.account-info-content > div > div.dashboard-cards__col.dashboard-cards__col--right"));






        public IWebElement MyBonusesButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/nav/ul/li[1]/span"));
        public IWebElement MyBonusesCashbackButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/div/div[2]/div[2]/div[2]/div[2]"));
        public IWebElement BunusContainer => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.profile-bonus > div.profile-bonus__container"));
        public IWebElement BunusContainerCashback => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/div/div[2]/div[2]/div[2]/div[3]/div/div/div[2]/div/div"));

        
        public IWebElement MyTournamentsButton => Driver.WaitUntilClickable(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > aside > nav > ul > li:nth-child(3)"));

        public IWebElement MyTournamentYouResoult => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.profile-tournaments"));

        public IWebElement OpenOneResoultTournaments => Driver.WaitUntilVisible(By.Id("profileTournamentsTabsWins"));
        public IWebElement TournamentWin => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content > div > div.profile-tournaments-available-list > div > div > div:nth-child(5)"));



        public IWebElement WinnersTournaments => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.profile-tournaments > div.profile-tournaments__history.history.scrollbar > div > div.p-t__h-unit.unit.is-open.is-short > div.unit__floor.unit__floor--2 > div > div.unit__cell-label.unit__winners-label"));


        public IWebElement MyDocumentsButton => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(5) > a"));


        public IWebElement InputPassportDocuments => Driver.WaitUntilVisible(By.Id("document_id"));





        public IWebElement Cahsbox => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > aside > div > div.balance-info > div.balance-info__money > div.balance-info__money-wrap > button"));
        public IWebElement Cahsbox2 => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/nav/ul/li[4]/span"));

        public IWebElement ExitProfile => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/nav/ul/li[7]/span"));


        


        public IWebElement MySettingsButton => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > aside > nav > ul > li:nth-child(6)"));
        public IWebElement Exit => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(8) > a"));


        public IWebElement SystemChack => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > div.app-form-fieldset.profile-settings-content__subscribe-block > div.app-form-fieldset__container > div:nth-child(1) > label > span.app-checkbox__draw-input"));
        public IWebElement PersonalCheck => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > div.app-form-fieldset.profile-settings-content__subscribe-block > div.app-form-fieldset__container > div:nth-child(2) > label > span.app-checkbox__draw-input"));
        public IWebElement TakeSmsChack => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > div.app-form-fieldset.profile-settings-content__subscribe-block > div.app-form-fieldset__container > div:nth-child(3) > label > span.app-checkbox__draw-input"));
        public IWebElement NextPassword => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > form > div.change-password-start__field-row > button"));
        public IWebElement MySettingsGoogle => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > div.app-form-fieldset.profile-settings-content__social-list > div.app-form-fieldset__container > div > button.social-buttons-list__item.app-btn.app-btn_type_default.app-btn_size_md.app-btn_color_default.social-buttons-list__item_type_gp"));
        public IWebElement MySettingsVK => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > div.app-form-fieldset.profile-settings-content__social-list > div.app-form-fieldset__container > div > button.social-buttons-list__item.app-btn.app-btn_type_default.app-btn_size_md.app-btn_color_default.social-buttons-list__item_type_vk"));
        public IWebElement MySettingsMail => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > div.app-form-fieldset.profile-settings-content__social-list > div.app-form-fieldset__container > div > button.social-buttons-list__item.app-btn.app-btn_type_default.app-btn_size_md.app-btn_color_default.social-buttons-list__item_type_ml"));
        public IWebElement MySettingsTwitter => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > div.app-form-fieldset.profile-settings-content__social-list > div.app-form-fieldset__container > div > button.social-buttons-list__item.app-btn.app-btn_type_default.app-btn_size_md.app-btn_color_default.social-buttons-list__item_type_tw"));
        public IWebElement MySettingsOk => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal_profile.modal--TEST--dashboard > div > div > section > div > div.modal-profile-grid__content.profile-settings-content > div > div.app-form-fieldset.profile-settings-content__social-list > div.app-form-fieldset__container > div > button.social-buttons-list__item.app-btn.app-btn_type_default.app-btn_size_md.app-btn_color_default.social-buttons-list__item_type_ok"));




        public void FillDate()
        {
            DaySelectBox.Click();
            Driver.WaitUntilVisible(By.CssSelector("#p_playerBirthDay > option:nth-child(9)")).Click();

            MonthSelectBox.Click();
            Driver.WaitUntilVisible(By.CssSelector("#p_playerBirthMonth > option:nth-child(5)")).Click();

            YearSelectBox.Click();
            Driver.WaitUntilVisible(By.CssSelector("#p_playerBirthYear > option:nth-child(6)")).Click();
        }

        public void ChooseCountry()
        {
            CountryListBox.Click();
            UkraineyListBoxElement.Click();
        }


        public void ChooseMobNumberUkraine()
        {
            PhoneCountryListBox.Click();
            PhoneContryListBoxUkraine.Click();
        }



        public void Logout(IWebDriver webdriver)
        {
            webdriver.Url = TestDataResourceSlotoking.MainPageURL + "/profile/dashboard/";
            IWebElement logout = webdriver.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[5]/a"));
            logout.Click();
        }

        public void Scroll_toUp()
        {
            (Driver.Browser as IJavaScriptExecutor).ExecuteScript(string.Format("window.scrollTo(0, {0});", 1));
        }

        public void Scroll_todown()
        {
            (Driver.Browser as IJavaScriptExecutor).ExecuteScript(string.Format("window.scrollTo(0, {0});", 1950));
        }


        public void Scroll_todownToLoad() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript(string.Format("window.scrollTo(0, {0});", 50));

        //MainPage jackpotblock = new MainPage();
        public void ScrollToElementButtonReg() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", ButtonReg);
    }
}
