using Core;
using OpenQA.Selenium;

namespace Vulkan777
{
    class HeaderMenu
    {
        public IWebElement LoginButton => Driver.WaitUntilVisible(By.CssSelector("#header > div > div > div:nth-child(3) > div > div.user-bar > div > div > button.btn.btn--extra-small.btn--blue.user-bar__btn"));
        public IWebElement RegistrationButton => Driver.WaitUntilClickable(By.CssSelector("#header > div > div > div:nth-child(3) > div > div.user-bar > div > div > button:nth-child(1)"));
        public IWebElement ProfileButton => Driver.WaitUntilClickable(By.CssSelector("#header > div > div > div:nth-child(3) > div > div.user-bar.is-login > div > div > ul > li:nth-child(1) > span.user-bar__item-title"));
        public IWebElement TournamentsLnk => Driver.WaitUntilVisible(By.Id("headerNavLink1"));
        public IWebElement BonusesLnk => Driver.WaitUntilVisible(By.Id("headerNavLink2"));
        public IWebElement GamesLnk => Driver.WaitUntilClickable(By.CssSelector("#header > div > div > div:nth-child(1) > nav.nav > ul > li:nth-child(3) > a"));
        public IWebElement VIPLnk => Driver.WaitUntilVisible(By.LinkText("VIP"));
        public IWebElement PaymentsLnk => Driver.WaitUntilVisible(By.LinkText("Методы оплаты"));
        public IWebElement ProfileLink => Driver.WaitUntilVisible(By.CssSelector("#header > div > div > div:nth-child(3) > div > div.user-bar.is-login > div > div > button.user-bar__profile-button"));
        public IWebElement IncrCash => Driver.WaitUntilVisible(By.PartialLinkText("Касса"));
        public IWebElement BalanceText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div[2]/div[1]/span[2]/acv[1]"));
        public IWebElement HeaderBalance => Driver.WaitUntilVisible(By.CssSelector("#header > div > div > div:nth-child(3) > div > div.user-bar.is-login > div > div > ul > li:nth-child(1) > span.user-bar__item-title"));
        public IWebElement Preloader => Driver.WaitUntilVisible(By.CssSelector("# vuePopup > transition > div"));


        public void Preloaders()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.Browser;

            jse.ExecuteScript("arguments[0].scrollIntoView()", GamesLnk);
        }


    }
}
