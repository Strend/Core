using Core;
using OpenQA.Selenium;

namespace Vulkan777
{
    class TournamentsPage
    {
        public IWebElement TournamentsTitle => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div[1]/span[2]"));

        //Banner Block
        public IWebElement TournamentBannerButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div[2]/div[1]/a"));

        //Banner Block
        public IWebElement HeroWeekTitle => Driver.WaitUntilVisible(By.ClassName("main-title"));

        public IWebElement GoToTournament => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > div.page-tournament > div > div > div.page-tournament__content > div.page-tournament__content-unit.is-active > div:nth-child(3)"));
        public IWebElement InToTournament => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.content > div.page-tournament > div > div > div.page-tournament__content > div.page-tournament__content-unit.is-active > div:nth-child(3) > div.tournament__container.tournament__container--default > div.tournament__status > div.tournament__status-btn.tournament__status-btn--join"));





        //Games Block
        public IWebElement ManyGamesButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div[2]/div[2]/div[3]/div[8]/div/a/span"));
    }
}
