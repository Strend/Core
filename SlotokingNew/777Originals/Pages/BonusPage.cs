using Core;
using OpenQA.Selenium;


namespace Vulkan777
{
    class BonusPage
    {
        public IWebElement ReloadCard => Driver.WaitUntilVisible(By.CssSelector("#bonus-slider > ul > li:nth-child(1) > div > div > div.bonus-card__front > button"));

        public IWebElement ReloadCardNameBonesesBesdep => Driver.WaitUntilVisible(By.CssSelector("#bonus-slider > ul > li:nth-child(1) > div > div > div.bonus-card__back > div.bonus-card__back-wrap > div.bonus-card__content.scrollbar > h4"));




    }
}
