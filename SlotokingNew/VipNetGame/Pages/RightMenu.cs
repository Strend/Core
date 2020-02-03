using Core;
using OpenQA.Selenium;


namespace VipNetGame
{
    class RightMenu
    {
        public IWebElement LoginButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div[1]/a[1]"));
        public IWebElement RegistrationButton => Driver.WaitUntilClickable(By.XPath("//*[@id='wrapper']/div[2]/div[1]/a[2]"));
        public IWebElement ProfileButton => Driver.WaitUntilClickable(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div[1]/ul/li/a/i"));


        public IWebElement TournamentsLnk => Driver.WaitUntilVisible(By.LinkText("Турниры"));
        public IWebElement BonusesLnk => Driver.WaitUntilVisible(By.LinkText("Бонусы"));
        public IWebElement GamesLnk => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div[3]/ul/li[3]/a"));
        public IWebElement VIPLnk => Driver.WaitUntilVisible(By.LinkText("VIP"));
        public IWebElement PaymentsLnk => Driver.WaitUntilVisible(By.LinkText("Методы оплаты"));
        public IWebElement ProfileLink => Driver.WaitUntilVisible(By.LinkText("Профиль"));
        public IWebElement IncrCash => Driver.WaitUntilVisible(By.PartialLinkText("Пополнить"));
        public IWebElement BalanceText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div[2]/div[1]/span[2]/acv[1]"));


    }
}
