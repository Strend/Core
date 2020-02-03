using Core;
using OpenQA.Selenium;


namespace Slotoking
{
    class HeaderMenu
    {
        public IWebElement LoginButton => Driver.WaitUntilVisible(By.XPath("//*[@id='header']/div/div/div[2]/div/button[2]/span"));
        public IWebElement RegistrationButton => Driver.WaitUntilClickable(By.CssSelector("#header > div > div > div.header__col.header__col--right > div > button.user-bar__btn.hide-on-md.app-btn.app-btn_uppercase.app-btn_type_default.app-btn_size_md.app-btn_color_default"));
        public IWebElement ProfileButton => Driver.WaitUntilClickable(By.CssSelector("#header > div > div > div.header__col.header__col--right > div > ul > li:nth-child(1) > span.user-bar__item-title"));
        public IWebElement TournamentsLnk => Driver.WaitUntilVisible(By.CssSelector("#mobile-menu > ul > li:nth-child(1)"));
        public IWebElement BonusesLnk => Driver.WaitUntilVisible(By.CssSelector("#mobile-menu > ul > li:nth-child(2)"));
        public IWebElement GamesLnk => Driver.WaitUntilClickable(By.CssSelector("#mobile-menu > ul > li:nth-child(3)"));
        public IWebElement VIPLnk => Driver.WaitUntilVisible(By.CssSelector("#mobile-menu > ul > li:nth-child(4)"));
        public IWebElement LotteryLnk => Driver.WaitUntilVisible(By.CssSelector("# mobile-menu > ul > li:nth-child(5)"));
        public IWebElement PaymentsLnk => Driver.WaitUntilVisible(By.LinkText("Методы оплаты"));
        public IWebElement ProfileLink => Driver.WaitUntilVisible(By.CssSelector("#header > div > div > div:nth-child(3) > div > div.user-bar.is-login > div > div > button.user-bar__profile-button"));
        public IWebElement IncrCash => Driver.WaitUntilVisible(By.PartialLinkText("Касса"));
        public IWebElement BalanceText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div[2]/div[1]/span[2]/acv[1]"));
        public IWebElement HeaderBalance => Driver.WaitUntilVisible(By.CssSelector("#header > div > div > div.header__col.header__col--right > div > ul > li:nth-child(1) > span.user-bar__item-title"));
        public IWebElement Preloader => Driver.WaitUntilVisible(By.CssSelector("# vuePopup > transition > div"));

        public IWebElement ProfileIcon => Driver.WaitUntilVisible(By.XPath("//*[@id='header']/div/div/div[2]/div/button[1]"));

        public IWebElement RegistrationButtonMob => Driver.WaitUntilClickable(By.XPath("//*[@id='main-page']/section[1]/div[1]/div[2]/button/span"));




        public void Preloaders()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.Browser;

            jse.ExecuteScript("arguments[0].scrollIntoView()", GamesLnk);
        }


    }
}
