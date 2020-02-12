using Core;
using OpenQA.Selenium;

namespace VipNetGame
{
    class ProfilePage
    {
        public IWebElement DashboardTab => Driver.WaitUntilVisible(By.ClassName("active"));
        public IWebElement DepositForm => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[2]/a"));
        public IWebElement AccountTab => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[3]/a"));
        public IWebElement BonusesPersonalTab => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[4]/a"));
        public IWebElement ProfileHeaderText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div"));
        public IWebElement SuccessSaveMessage => Driver.WaitUntilVisible(By.CssSelector("#popup-profile-success > div > div > div.popup-cont.pop_up_simple > div.label.hb-btn > button"));
        public IWebElement EnterNewPassOkButton => Driver.WaitUntilVisible(By.XPath(" //*[@id='onesignal-popover-allow-button']"));
        public IWebElement AgreeUkrChackbox => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div/div[1]/div/div[2]/div[2]/div/div[2]/form/div[2]/div[2]/label[2]/span[4]"));
        public IWebElement NameTextBox => Driver.WaitUntilVisible(By.Id("Players_name"));
        public IWebElement SurnameTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_surname']"));
        public IWebElement NicknameTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_nickname']"));
        public IWebElement MaleGenderRadioButton => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_gender_id_0-styler']"));
        public IWebElement DaySelectBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_day-styler']/div[1]"));
        public IWebElement MonthSelectBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_month-styler']/div[1]/div[1]"));
        public IWebElement YearSelectBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_year-styler']/div[1]/div[1]"));
        public IWebElement SaveTitleButton => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[3]/div[1]/div/button"));
        public IWebElement SavePhoneButton => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[5]/div[1]/div/div[3]/div[2]/button"));
        public IWebElement SavePersonalInfoButton => Driver.WaitUntilVisible(By.CssSelector("#profile-form > div.btn-refill > button"));
        public IWebElement PlayerPhoneTextBox => Driver.WaitUntilVisible(By.Id("Players_phone"));
        public IWebElement CountryListBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_country_id-styler']/div[1]"));
        public IWebElement UkraineyListBoxElement => Driver.WaitUntilVisible(By.XPath(" //*[@id='Players_country_id-styler']/div[2]/ul/li[6]"));
        public IWebElement PhoneCountryListBox => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div[1]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div/div/div[1]"));
        public IWebElement PhoneContryListBoxUkraine => Driver.WaitUntilVisible(By.XPath("//*[@id='mCSB_2_container']/li[2]/span[1]"));






        public IWebElement CityTextBox => Driver.WaitUntilVisible(By.Id("Players_city"));
        public IWebElement AddressListBox => Driver.WaitUntilVisible(By.Id("Players_address"));

        public void FillDate()
        {
            DaySelectBox.Click();
            Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_day-styler']/div[2]/ul/li[3]")).Click();

            MonthSelectBox.Click();
            Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_month-styler']/div[2]/ul/li[5]")).Click();

            YearSelectBox.Click();
            Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_year-styler']/div[2]/ul/li[4]")).Click();
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
            webdriver.Url = TestDataResourceVipNetGame.MainPageURL + "/profile/dashboard/";
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


    }
}
