using Core;
using OpenQA.Selenium;

namespace VipNetGame
{
    class MainPage
    {
        public IWebElement Jackpot_Animation_Block_Red => Driver.WaitUntilVisible(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[1]"));
        public IWebElement Jackpot_Animation_Block_Silver => Driver.WaitUntilVisible(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[2]"));
        public IWebElement Jackpot_Animation_Block_Gold => Driver.WaitUntilVisible(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[3]"));
        public IWebElement Jackpot_Animation_Block_Diamond => Driver.WaitUntilVisible(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[4]"));
        public IWebElement GameGrid => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div[2]/div[3]"));
        public IWebElement UserBar => Driver.WaitUntilVisible(By.XPath("//*[@id='vueApp']/section/section/section/section[2]/ul"));
        public IWebElement UserBarUnlogin => Driver.WaitUntilVisible(By.XPath("//*[@id='vueApp']/section/section/section/ul"));






    }
}






