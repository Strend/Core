using OpenQA.Selenium;
using SlotokingNew.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotokingNew.Pages
{
    class BonusPage
    {
        public IWebElement ReloadCard => Driver.WaitUntilVisible(By.CssSelector("#bonus-slider > ul > li:nth-child(1) > div > div > div.bonus-card__front > button"));

        public IWebElement ReloadCardNameBonesesBesdep => Driver.WaitUntilVisible(By.CssSelector("#bonus-slider > ul > li:nth-child(1) > div > div > div.bonus-card__back > div.bonus-card__back-wrap > div.bonus-card__content.scrollbar > h4"));
    }
}