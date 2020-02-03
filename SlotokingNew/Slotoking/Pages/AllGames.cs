using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Text.RegularExpressions;
using System.Threading;

namespace Slotoking
{
    class AllGames
    {
            public IWebElement GameContainer => Driver.WaitUntilVisible(By.Id("casinoClient"));
            public IWebElement GameContainerDemo => Driver.WaitUntilVisible(By.XPath("//*[@id='demoGame']/div"));
            public IWebElement GameProvaider => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtn"));
            public IWebElement PartnersGameContainer => Driver.WaitUntilVisible(By.Id("casinoClient"));
            public IWebElement PartnersGameContainer777 => Driver.WaitUntilVisible(By.XPath("//*[@id='game']"));
            public IWebElement PartnersGameContainerVIP => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div[1]/div/div[1]/iframe"));
            public IWebElement Tom_HornGameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='gameInnerPlaceholder']"));

            public IWebElement GamePlayButton => Driver.WaitUntilClickable(By.XPath("//*[contains(@src, 'play.svg')]"));


            public IWebElement StartDemoGameButton => Driver.WaitUntilVisible(By.XPath("//*[@id='startDemoGame']"));
            public IWebElement BalanceText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[1]/div[4]/div[1]/span/acv"));
            public IWebElement BalanceTextPartners => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div[3]/div[2]/div/div[1]/div[2]"));
            public IWebElement BalanceTextPartners777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[3]/div[1]/span"));
            public IWebElement BalanceTextPartnersVIP => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div[2]/div[1]/span[2]/acv[1]"));
            public IWebElement ProgressBar => Driver.WaitUntilVisible(By.XPath("//*[@id='progress-bar']"));
            public IWebElement BalanceTextPartnersRepet => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.game > div > div.game__sidebar.show > div.game__sidebar-content > div > div.game__balance-container.balance.cs-1 > div.is-disabled > div.balance-scale"));
            public IWebElement MainFrame => Driver.WaitUntilVisible(By.Id("main-game-frame"));

        
            /// Vulkan game providers buttons
            public IWebElement NovomaticButton => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnnovomatic"));
            public IWebElement IgrosoftButton => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnigrosoft"));
            public IWebElement King => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnking"));
            public IWebElement EzugiButton => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnezugi"));
            public IWebElement QuickspinButton => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnquickspin"));

            public IWebElement ElkButton => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnelk-studios"));
            public IWebElement ThunderkickButton => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnthunderkick"));
            public IWebElement SpinomenalButton => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnspinomenal"));
            public IWebElement TomHornButton => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtntom-horn"));
            public IWebElement BlueprintGaming => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnblueprint-gaming"));
            public IWebElement RightBarGameButton => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.game > div > div.game__sidebar.show > div.game__sidebar-nav > div.unit.unit-balance"));

            public IWebElement Netgame => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnnetgame"));
            public IWebElement EvolutionGaming => Driver.WaitUntilVisible(By.Id("gamesTagsMenuDropBtnevolution"));

        

            ///AllGamesLocators

            //ELK Studio

            public IWebElement Hover_FirstGame => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(1)"));
            public IWebElement PlayFirstGame => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(1) > div > div.game__content > div.game__play"));




            public IWebElement Hover_SecondGame => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(2)"));
            public IWebElement PlaySecondGame => Driver.WaitUntilVisible(By.CssSelector("##games-container > div > div:nth-child(2) > div > div.game__content > div.game__play"));



            public IWebElement Hover_novomatic1 => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(4)"));
            public IWebElement PlaySecondGameNovomatic1 => Driver.WaitUntilVisible(By.CssSelector("##games-container > div > div:nth-child(4) > div > div.game__content > div.game__play"));

            public IWebElement Hover_novomatic2 => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(5)"));
            public IWebElement PlaySecondGameNovomatic2 => Driver.WaitUntilVisible(By.CssSelector("##games-container > div > div:nth-child(5) > div > div.game__content > div.game__play"));

            public IWebElement Hover_novomatic3 => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(6)"));
            public IWebElement PlaySecondGameNovomatic3 => Driver.WaitUntilVisible(By.CssSelector("##games-container > div > div:nth-child(6) > div > div.game__content > div.game__play"));



            public IWebElement Hover_ThirdGame => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(3)"));
            public IWebElement PlayThirdGame => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(3) > div > div.game__content > div.game__play"));


            public IWebElement Hover_FourGame => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(4)"));

            public IWebElement PlayFourGame => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(4) > div > div.game__content > a.game__play > img"));



            public IWebElement Ezugi_Baccarat => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Baccarat_250h280.jpg')]"));
            public IWebElement Igrosoft_FruitCocktail => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'FruitCocktail.jpg')]"));
            public IWebElement Igrosoft_Gnome => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Gnome.jpg')]"));
            public IWebElement Igrosoft_Garage => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Garage.jpg')]"));
            public IWebElement King_DiamondShot => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Diamond-Shot-1.jpg')]"));
            public IWebElement King_FruitBar => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Fruit-Bar.jpg')]"));
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



            /// Games containers
            public IWebElement BookOfRaImage => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'BookofRa.jpg')]"));
            public IWebElement BookOfRaPlay => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[3]/div/div[1]/div/a[1]"));
            public IWebElement BookOfRaPlayDemo => Driver.WaitUntilVisible(By.LinkText("ДЕМО"));

            public IWebElement BookOfRaPlay777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div[4]/div/div[1]/div/div/a[1]"));

            // Quickspin
            //public IWebElement StickyBanditsContinueButton => Driver.WaitUntilVisible(By.Id("ContinueButton"));   
            public IWebElement StickyBanditsContinueButton => Driver.WaitUntilVisible(By.XPath("//*[@id='continuebutton_symbol']"));
            public IWebElement StickyBanditsGameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div"));
            public IWebElement StickyBanditsSpin => Driver.WaitUntilVisible(By.Id("DefaultSpinButton"));
            public IWebElement TEST => Driver.WaitUntilVisible(By.CssSelector("//*[@id='tk - s1 - g21 - 1553079508120 - spinButtonClickElement']"));
            public IWebElement MoreGames => Driver.WaitUntilVisible(By.Id("more-games"));



            public void MoveCursorToGame(IWebElement game)
            {
                Actions actions = new Actions(Driver.Browser);
                actions.MoveToElement(game).Click().Perform();
            }


            public void MoveCursorToGameNotClick(IWebElement game)
            {
                Actions actions = new Actions(Driver.Browser);
                actions.MoveToElement(game).Perform();
            }


            public void ButtonClick(IWebElement container, int coordx, int coordy)
            {
                Actions actions = new Actions(Driver.Browser);
                actions.MoveToElement(container, coordx, coordy).Click().Perform();
            }


            public void FullscrinButtonClick()
            {
                Actions actions = new Actions(Driver.Browser);
                actions.MoveToElement(GameContainer, 66, 798).Click().Perform();
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

                var currDecSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

                tmp = tmp.Replace(".", currDecSeparator).Replace(decimalSymbol.ToString(), currDecSeparator);

                    return double.Parse(tmp);
                }

                return 0;
            }

        }
    }

