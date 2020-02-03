using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Text.RegularExpressions;


namespace VipNetGame
{
    class GamePage
    {
        public IWebElement GameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='main-game-frame']"));
        public IWebElement GameContainerDemo => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div[1]/div/div[1]/a/img"));

        public IWebElement PartnersGameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div[1]/div/div[1]/iframe"));
        public IWebElement PartnersGameContainer777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[1]/iframe"));
        public IWebElement PartnersGameContainerVIP => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div[1]/div/div[1]/iframe"));
        public IWebElement Tom_HornGameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='gameInnerPlaceholder']"));

        ///AllGamesLocators

        public IWebElement Elk_Gold => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Ecuador-Gold.jpg')]"));
        public IWebElement Elk_TheWiz => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'The-Wiz.jpg')]"));
        public IWebElement Elk_Valkyrie => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Valkirie.jpg')]"));
        public IWebElement Ezugi_Baccarat => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Baccarat_342x210-1.jpg')]"));
        public IWebElement Igrosoft_FruitCocktail => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'fruit-cocktail.jpg')]"));
        public IWebElement Igrosoft_Gnome => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'logo_gnome.jpg')]"));
        public IWebElement Igrosoft_PumpkinFairy => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Pumpkin-Fairy-1.jpg')]"));
        public IWebElement King_DiamondShot => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Diamond-Shot-1.jpg')]"));
        public IWebElement King_FruitBar => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'fruit-bar.jpg')]"));
        public IWebElement King_GoldenSkulls => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Golden-Skulls-1.jpg')]"));
        public IWebElement Novomatic_Arriva => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Arriva_342h210.jpg')]"));
        public IWebElement Novomatic_BookOfRa => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'book-of-ra.jpg')]"));
        public IWebElement Novomatic_GoldenSevensDeluxe => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Golden-Sevens_342h210.jpg')]"));
        public IWebElement Quickspin_DivineDreams => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Divine-Dreams.jpg')]"));
        public IWebElement Quickspin_JokerStrike => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'JokerStrike.jpg')]"));
        public IWebElement Quickspin_TicketToTheStars => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Ticket-to-the-Stars.jpg')]"));
        public IWebElement Spinomenal_BookOfGuardians => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'bookOfGuardians.jpg')]"));
        public IWebElement Spinomenal_FruitsDeluxe => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'FruitsDeluxe-1.jpg')]"));
        public IWebElement Spinomenal_lemurDoesVegas => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'LemurDoesVegas-1.jpg')]"));
        public IWebElement ThunderkickCarnivalQueen => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Carnival-Queen.jpg')]"));
        public IWebElement Thunderkick_PinkElephants => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'PinkElephants.jpg')]"));
        public IWebElement TomHorn_JokerPoker => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Joker-4-Hand-Poker.jpg')]"));




        public IWebElement GamePlayButton => Driver.WaitUntilVisible(By.PartialLinkText("ИГРАТЬ"));


        public IWebElement FirstGamePlayButton777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div[4]/div/div[1]/div/div/a[1]"));
        public IWebElement FirstGamePlayButtonVIP => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[3]/div/div[1]/div/a[1]"));
        public IWebElement StartDemoGameButton => Driver.WaitUntilVisible(By.XPath("//*[@id='startDemoGame']"));
        public IWebElement BalanceText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[1]/div[4]/div[1]/span/acv"));
        public IWebElement BalanceTextPartners => Driver.WaitUntilVisible(By.CssSelector("#wrapper > div.sidebar > div.sidebar-auth-pdl > div.sidebar-balance > div:nth-child(1) > span:nth-child(2) > acv:nth-child(1)"));
        public IWebElement BalanceTextPartners777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[3]/div[1]/span"));
        public IWebElement BalanceTextPartnersVIP => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div[2]/div[1]/span[2]/acv[1]"));
        public IWebElement ProgressBar => Driver.WaitUntilVisible(By.XPath("//*[@id='progress-bar']"));
        /// King game providers buttons
        public IWebElement NovomaticButton => Driver.WaitUntilVisible(By.CssSelector("#tags-container > div > div.manufacturers-list > div > ul > li:nth-child(2) > a"));
        public IWebElement IgrosoftButton => Driver.WaitUntilVisible(By.CssSelector("#tags-container > div > div.manufacturers-list > div > ul > li:nth-child(3)"));
        public IWebElement KingButton => Driver.WaitUntilVisible(By.CssSelector("#tags-container > div > div.manufacturers-list > div > ul > li:nth-child(1)"));
        public IWebElement EzugiButton => Driver.WaitUntilVisible(By.CssSelector("#tags-container > div > div.manufacturers-list > div > ul > li:nth-child(4)"));
        public IWebElement QuickspinButton => Driver.WaitUntilVisible(By.CssSelector("#tags-container > div > div.manufacturers-list > div > ul > li:nth-child(7)"));
        public IWebElement ElkButton => Driver.WaitUntilVisible(By.CssSelector("#tags-container > div > div.manufacturers-list > div > ul > li:nth-child(5)"));
        public IWebElement ThunderkickButton => Driver.WaitUntilVisible(By.CssSelector("#tags-container > div > div.manufacturers-list > div > ul > li:nth-child(6)"));
        public IWebElement SpinomenalButton => Driver.WaitUntilVisible(By.CssSelector("#tags-container > div > div.manufacturers-list > div > ul > li:nth-child(8)"));
        public IWebElement TomHornButton => Driver.WaitUntilVisible(By.CssSelector("#tags-container > div > div.manufacturers-list > div > ul > li:nth-child(9)"));

        /// Games containers
        public IWebElement BookOfRaImage => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[3]/div/div[1]/img"));
        public IWebElement BookOfRaPlay => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[3]/div/div[1]/div/a[1]"));
        public IWebElement BookOfRaPlayDemo => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[3]/div/div[1]/div/a[2]"));

        public IWebElement BookOfRaPlay777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div[4]/div/div[1]/div/div/a[1]"));

        // Quickspin
        //public IWebElement StickyBanditsContinueButton => Driver.WaitUntilVisible(By.Id("ContinueButton"));   
        public IWebElement StickyBanditsContinueButton => Driver.WaitUntilVisible(By.XPath("//*[@id='continuebutton_symbol']"));
        public IWebElement StickyBanditsGameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div"));
        public IWebElement StickyBanditsSpin => Driver.WaitUntilVisible(By.Id("DefaultSpinButton"));
        public IWebElement TEST => Driver.WaitUntilVisible(By.CssSelector("//*[@id='tk - s1 - g21 - 1553079508120 - spinButtonClickElement']"));




        public void MoveCursorToGame(IWebElement game)
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(game).Click().Perform();
        }

        public void ButtonClick(IWebElement container, int coordx, int coordy)
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(container, coordx, coordy).Click().Perform();
        }

        public void FullscrinButtonClick()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(GameContainer, 1170, 30).Click().Perform();
        }

        public void LongKeyDown(IWebElement container, int coordx, int coordy)
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(container, coordx, coordy).Perform();
            actions.ClickAndHold().Perform();
            System.Threading.Thread.Sleep(1000);
            actions.Release().Perform();
        }

        public void SpaceClick()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.SendKeys(PartnersGameContainer, Keys.Space).Perform();
        }

        public void ReturnFocus()
        {
            Driver.Browser.Manage().Window.Size = new System.Drawing.Size(0, 0);
            Driver.Browser.Manage().Window.Maximize();
        }
        public IWebElement Bakkaraplay => Driver.WaitUntilVisible(By.XPath("//*[@id='table_101']"));

        public System.Drawing.Size CalcContainerSize() => GameContainer.Size;


    }

    public static class StringExtension
    {
        public static double DoubleParseAdvanced(this string strToParse, char decimalSymbol = ',')
        {
            string tmp = Regex.Match(strToParse, @"([-]?[0-9]+)([\s])?([0-9]+)?[." + decimalSymbol + "]?([0-9 ]+)?([0-9]+)?").Value;

            if (tmp.Length > 0 && strToParse.Contains(tmp))
            {
                var currDecSeparator = System.Windows.Forms.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator;

                tmp = tmp.Replace(".", currDecSeparator).Replace(decimalSymbol.ToString(), currDecSeparator);

                return double.Parse(tmp);
            }

            return 0;
        }
    }
}
