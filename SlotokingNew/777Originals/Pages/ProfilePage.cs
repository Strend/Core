using Core;
using OpenQA.Selenium;

namespace Vulkan777
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
        public IWebElement NameTextBox => Driver.WaitUntilVisible(By.Id("p_playerFirstName"));
        public IWebElement SurnameTextBox => Driver.WaitUntilVisible(By.Id("p_playerLastName"));
        public IWebElement NicknameTextBox => Driver.WaitUntilVisible(By.Id("p_playerNickName"));
        public IWebElement MaleGenderRadioButton => Driver.WaitUntilVisible(By.Id("//*[@id='Players_gender_id_0-styler']"));
        public IWebElement DaySelectBox => Driver.WaitUntilVisible(By.Id("p_playerBirthDay"));
        public IWebElement MonthSelectBox => Driver.WaitUntilVisible(By.Id("p_playerBirthMonth"));
        public IWebElement YearSelectBox => Driver.WaitUntilVisible(By.Id("p_playerBirthYear"));
        public IWebElement SaveTitleButton => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[3]/div[1]/div/button"));
        public IWebElement SavePhoneButton => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[5]/div[1]/div/div[3]/div[2]/button"));
        public IWebElement SavePersonalInfoButton => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.profile-edit > div > div > div.profile-cards__col.profile-cards__col--left > div > form > div.profile-cards__content > div.profile-submit"));
        public IWebElement PlayerPhoneTextBox => Driver.WaitUntilVisible(By.Id("p_inputConfirmPhone"));
        public IWebElement CountryListBox => Driver.WaitUntilVisible(By.Id("p_playerCountry"));
        public IWebElement UkraineyListBoxElement => Driver.WaitUntilVisible(By.Id("profileEditCountry1"));
        public IWebElement PhoneCountryListBox => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.profile-edit > div > div > div.profile-cards__col.profile-cards__col--left > div > form > div.profile-cards__content > div.form__input-wrap.getmdl-select.select-flag.select-country.profile-input"));
        public IWebElement PhoneContryListBoxUkraine => Driver.WaitUntilVisible(By.Id("profileEditCountry1"));
        public IWebElement PlayersPassword => Driver.WaitUntilVisible(By.Id("Players_password"));
        public IWebElement PlayersPasswordRepeat => Driver.WaitUntilVisible(By.Id("Players_password_repeat"));
        public IWebElement CityTextBox => Driver.WaitUntilVisible(By.Id("p_playerCity"));
        public IWebElement AddressListBox => Driver.WaitUntilVisible(By.Id("p_playerAddress"));
        public IWebElement ButtonReg => Driver.WaitUntilVisible(By.Id("jackpotGuestRegistration"));






        public IWebElement DashboardButton => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(1) > a"));

        public IWebElement DashboardButtonCashbox => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.account-info-content > div > div.dashboard-cards__col.dashboard-cards__col--left > div.dashboard-card-container.balance-card > div > div.dashboard-cards__title > div.dashboard-cards__title-col.dashboard-cards__title-col--right > button"));
        public IWebElement DashboardCardLeft => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.account-info-content > div > div.dashboard-cards__col.dashboard-cards__col--left"));
        public IWebElement DashboardCardRight => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.account-info-content > div > div.dashboard-cards__col.dashboard-cards__col--right"));






        public IWebElement MyBonusesButton => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(2) > a"));
        public IWebElement BunusContainer => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.profile-bonus > div.profile-bonus__container"));


        public IWebElement MyTournamentsButton => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(3) > a"));

        public IWebElement MyTournamentYouResoult => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.profile-tournaments"));

        public IWebElement OpenOneResoultTournaments => Driver.WaitUntilVisible(By.XPath("//*[@id='profileEdit']/div[2]/div[2]/div[1]/div[3]/div/div[1]/div[1]"));

        public IWebElement WinnersTournaments => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-content.profile__container > div.profile__content.scrollbar > div.profile-tournaments > div.profile-tournaments__history.history.scrollbar > div > div.p-t__h-unit.unit.is-open.is-short > div.unit__floor.unit__floor--2 > div > div.unit__cell-label.unit__winners-label"));


        public IWebElement MyDocumentsButton => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(5) > a"));


        public IWebElement InputPassportDocuments => Driver.WaitUntilVisible(By.Id("document_id"));





        public IWebElement Cahsbox => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(6) > a"));
        public IWebElement MySettingsButton => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(7) > a"));
        public IWebElement Exit => Driver.WaitUntilVisible(By.CssSelector("#profileEdit > div.modal-account-info-menu > ul > li:nth-child(8) > a"));





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
            webdriver.Url = TestDataResource777Originals.MainPageURL + "/profile/dashboard/";
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

       // MainPage jackpotblock = new MainPage();
        public void ScrollToElementButtonReg() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", ButtonReg);
    }
}
