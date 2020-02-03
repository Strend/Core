using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;


namespace Slotoking
{
    class MainPage
    {
        public IWebElement Jackpot_Animation_Block_Red => Driver.WaitUntilVisible(By.XPath("//*[@id='main-page']/section[3]/div/div/div[2]/div/div[1]/div/div[1]"));
        public IWebElement Jackpot_Animation_Block_Silver => Driver.WaitUntilVisible(By.XPath("//*[@id='main-page']/section[3]/div/div/div[2]/div/div[1]/div/div[2]"));
        public IWebElement Jackpot_Animation_Block_Gold => Driver.WaitUntilVisible(By.XPath("//*[@id='main-page']/section[3]/div/div/div[2]/div/div[1]/div/div[3]"));
        public IWebElement Jackpot_Animation_Block_Diamond => Driver.WaitUntilVisible(By.XPath("//*[@id='main-page']/section[3]/div/div/div[2]/div/div[1]/div/div[4]"));
        public IWebElement GameGrid => Driver.WaitUntilVisible(By.CssSelector("#games-container > div"));
        public IWebElement UserBar => Driver.WaitUntilVisible(By.XPath("//*[@id='main-page']/div[1]/div"));
        public IWebElement UserBarUnlogin => Driver.WaitUntilVisible(By.XPath("//*[@id='vueApp']"));
        public IWebElement NoDepositBonusBannerButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[2]/div[1]/a"));
        public IWebElement FooterGameNewLink => Driver.WaitUntilVisible(By.LinkText("Новые"));
        public IWebElement RegistrationSocialAgreementLink => Driver.WaitUntilVisible(By.LinkText("Правилами и условиями"));
        public IWebElement logo => Driver.WaitUntilVisible(By.CssSelector("#header > div > div > a > img"));
        public IWebElement Otigrash => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.game > div > div.game__sidebar.show > div.game__sidebar-content > div > div.game__balance-container.balance.cs-1 > div:nth-child(3) > div.balance-message.balance-message-access > div.balance-text.is-disabled"));
        public IWebElement SeoBlockFooter => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient.section--highlighted > section > div > div > div > div > p:nth-child(4)"));







        // JackPots Block
        public IWebElement JackPotsBlock => Driver.WaitUntilVisible(By.XPath("//*[@id='main-page']/section[2]"));
        public IWebElement JackpotAnimationBlockRed => Driver.WaitUntilVisible(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[1]"));
        public IWebElement JackpotAnimationBlockSilver => Driver.WaitUntilVisible(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[2]"));
        public IWebElement JackpotAnimationBlockGold => Driver.WaitUntilVisible(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[3]"));
        public IWebElement JackpotAnimationBlockDiamond => Driver.WaitUntilVisible(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[4]"));
        public IWebElement JackpotButton => Driver.WaitUntilVisible(By.ClassName("btn-jackpot"));
        public IWebElement JackpotPopUpWindowTable => Driver.WaitUntilVisible(By.XPath("//*[@id='mCSB_1_container']/div/table/tr[1]"));
        public IWebElement JackpotPopUpWindowTableContent => Driver.WaitUntilVisible(By.XPath("//*[@id='mCSB_1_container']/div/table/tr[2]/td[2]"));
        public IWebElement JackpotPopUpButtonLast => Driver.WaitUntilVisible(By.XPath("//*[@id='JPModal']/div/div[3]/div[1]/ul/li[1]/a"));
        public IWebElement JackpotPopUpButtonBig => Driver.WaitUntilVisible(By.XPath("//*[@id='JPModal']/div/div[3]/div[1]/ul/li[2]/a"));
        public IWebElement JackpotPopUpButtonClose => Driver.WaitUntilVisible(By.ClassName("game-close"));
        public IWebElement JackpotListmain => Driver.WaitUntilClickable(By.CssSelector("#main-page > section.section.jackpot > div > div > div.lazy-component > div > div.jackpot__button-wrap > button"));
        public IWebElement JackpotListmainList => Driver.WaitUntilVisible(By.XPath("//*[@id='JPModal']/div/div[2]/div/div/div/div/div[2]/div[6]"));



        //Game Whis Us Main Block 3
        public IWebElement MainBlock3 => Driver.WaitUntilVisible(By.CssSelector("#main-page > section.section.section--gradient.banner"));
        public IWebElement NoDepositBonusBannerButto => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[2]/div[1]/a"));
        public IWebElement WelcomePackBannerButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[2]/div[2]/a"));
        public IWebElement TournamentHeroOfTheWeekLink => Driver.WaitUntilVisible(By.LinkText("Герой недели"));
        public IWebElement TournamentHeroOfTheWeekTable => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[4]/div[2]/div[3]/table[1]/thead/tr"));
        public IWebElement TournamentHeroOfTheWeekTableContent => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[4]/div[2]/div[3]/table[1]/tbody/tr[1]/td[2]"));
        public IWebElement TournamentHeroOfTheWeekTableRegiterButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[4]/div[2]/div[2]/div[2]/a"));

        // Best Games For Us Main Block 1
        public IWebElement MainBlock1 => Driver.WaitUntilVisible(By.ClassName("main-block1"));
        public IWebElement NewGameLink => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[2]/div[1]/ul/li[1]/a"));
        public IWebElement PopularGameLink => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[2]/div[1]/ul/li[2]/a"));
        public IWebElement AutomateGameLink => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[2]/div[1]/ul/li[3]/a"));
        public IWebElement VideoPokerGameLink => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[2]/div[1]/ul/li[4]/a"));
        public IWebElement RoulettePokerGameLink => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[2]/div[1]/ul/li[5]/a"));
        public IWebElement KenoGameLink => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[2]/div[1]/ul/li[6]/a"));
        public IWebElement TableGameLink => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[2]/div[1]/ul/li[7]/a"));
        public IWebElement LiveCasinoGameLink => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[2]/div[1]/ul/li[8]/a"));
        public IWebElement AllGamesButton => Driver.WaitUntilVisible(By.XPath("//*[@id='all_game']"));

        // Download Software Main Block 4
        public IWebElement MainBlock4 => Driver.WaitUntilVisible(By.ClassName("main-block4"));
        public IWebElement DownloadSoftwarePcButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[6]/div/div[1]/div[1]/div[2]/a"));
        public IWebElement InputPlaceholderPhone => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_models_forms_PhoneForm_phone']"));
        public IWebElement SendSmsButton => Driver.WaitUntilVisible(By.XPath("//*[@id='phone-form']/input"));
        public IWebElement PopUpSendSmsText => Driver.WaitUntilVisible(By.XPath("//*[@id='popupSms']/div/div[1]"));
        public IWebElement PopUpSendSmsButtonOk => Driver.WaitUntilVisible(By.XPath("//*[@id='popupSms']/div/div[2]/a[1]"));

        // Seo Text Block
        public IWebElement WelcomeTextTitle => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient.section--highlighted > footer > div.footer__bottom > div > div.footer-partner > ul.footer-partner__list.footer-partner__list--bottom"));

        //Download
        public IWebElement FooterClientForWindowsLink => Driver.WaitUntilVisible(By.LinkText("Игровой клиент для Windows"));

        public IWebElement DownloadWindows => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section.section.section--gradient.section--static > div > div > ul > li:nth-child(3)"));
        public IWebElement FooterClientForAndroidLink => Driver.WaitUntilVisible(By.LinkText("Игровой клиент для Android"));
        public IWebElement DownloadAndroid => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section.section.section--gradient.section--static > div > div > ul > li:nth-child(3)"));


        public IWebElement FooterBannerBonusesNoDeposit => Driver.WaitUntilVisible(By.XPath("/html/body/div[3]/div[1]/div[2]/a"));

        // Scroll the browser to the element's Y position
        public void ScrollToMainBlock1() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", MainBlock1);
        
        public void ScrollToJackPotsBlock() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript(string.Format("window.scrollTo(0, {0});", 1800));
        public void ScrollToMainBlock3() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", MainBlock3);
        public void ScrollToMainBlock4() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", MainBlock4);
        public void ScrollToSeoTextBlock() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", WelcomeTextTitle);
        public void ScrollToFooter() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", FooterGameNewLink);

        public void ScrollToElementBonusBezdep() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", fewfwefew1);


        public IWebElement fewfwefew1 => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section"));
        public IWebElement fewfwefew => Driver.WaitUntilVisible(By.CssSelector("#main-page > section.section.jackpot"));
        public IWebElement ActiveBonusMain => Driver.WaitUntilVisible(By.Id("heroBannerNoActiveBtn"));
        public IWebElement TournamentsPromoContainer => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div.lazy-component.tournament-block-wrap > div"));
        public IWebElement MoreGamesButton => Driver.WaitUntilClickable(By.Id("more-games"));
        public IWebElement MoreGamesButtonAddGames => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(27)"));
        public IWebElement MoreGamesButtonNew => Driver.WaitUntilVisible(By.Id("more-games-promo"));
        public IWebElement MoreGamesButtonAddGamesNew => Driver.WaitUntilVisible(By.CssSelector("#games-container-promo > div > div:nth-child(30)"));
        public IWebElement LoveGame => Driver.WaitUntilVisible(By.CssSelector("#issues-container > ul > li.games-tab__item.games-tab__item--counter"));
        public IWebElement HoverGame => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div > div"));
        public IWebElement TextLoverGame => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div > div > div.game__content > div.game__title-wrap > a.game__title"));
        public IWebElement TooltipMain => Driver.WaitUntilVisible(By.CssSelector("#mobile-games-filter > div.games-filter__title-wrap > div.tooltip"));
        public IWebElement ToltipTextMain => Driver.WaitUntilVisible(By.CssSelector("#mobile-games-filter > div.games-filter__title-wrap > div.tooltip > div.tooltip__content > div > p:nth-child(1) > strong"));
        public IWebElement Search => Driver.WaitUntilVisible(By.CssSelector("#game-search > div.search__input-box > label > input"));
        public IWebElement BookOfRa => Driver.WaitUntilClickable(By.XPath("//*[contains(@src, 'BookOfRaDeluxe6-1.png')]"));
        public IWebElement PopularGameButtonGamePopup => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.game > div > div.game__footer.isShow > div > div.unit.unit-popular"));
        public IWebElement PrivetstveniyPaket => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > div > section > div > div > ul"));
        public IWebElement PrivetstveniyPaketBlock1 => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > div > section > div > div > ul > li:nth-child(1)"));
        public IWebElement PrivetstveniyPaketBlock2 => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > div > section > div > div > ul > li:nth-child(2)"));
        public IWebElement PrivetstveniyPaketBlock3 => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > div > section > div > div > ul > li:nth-child(3)"));
        public IWebElement RegisterButtonMain => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > div > section > div > div.features__button-wrap > a"));
        public IWebElement SupportButton => Driver.WaitUntilVisible(By.Id("supportTrigger"));
        public IWebElement TextSuportOnline => Driver.WaitUntilVisible(By.Id("onlineSupportContainer"));
        public IWebElement SeoTitle => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section.about.section.section--highlighted > div > div > div > div"));
        public IWebElement SeoBlocksText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient > section > div > div > div > div > div:nth-child(2)"));
        public IWebElement PrivetstveniyPaketLogout => Driver.WaitUntilVisible(By.CssSelector("#main-page > section.section.section--gradient.banner"));
        public IWebElement PrivetstveniyPaketLogoutRegisterButton => Driver.WaitUntilVisible(By.CssSelector("#main-page > section.section.section--gradient.banner > div > div.banner__button-wrap > button"));
        public IWebElement RegisterPopupText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div:nth-child(1) > div > div > div.modal-registration.modal-registration--right > div > div.modal-registration__title"));
        public IWebElement FiltrHot => Driver.WaitUntilVisible(By.CssSelector("#hot-cold-container > ul > li:nth-child(1)"));
        public IWebElement FiltrCold => Driver.WaitUntilVisible(By.CssSelector("#hot-cold-container > ul > li:nth-child(2)"));
        public IWebElement GamesBlogMainpage15 => Driver.WaitUntilVisible(By.CssSelector("#games-container > div > div:nth-child(15)"));
        public IWebElement TitleFilters => Driver.WaitUntilVisible(By.Id("title-container"));
        public IWebElement GameContainer => Driver.WaitUntilVisible(By.Id("games-container"));




        //Footer

        public IWebElement ClientForAndroid => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient > footer > div > div > nav > div:nth-child(4) > ul > li:nth-child(2) > a"));
        public IWebElement ClientsForAndroidText => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'dp-app-logo.png')]"));

        public IWebElement ClientsForWindows => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient > footer > div > div > nav > div:nth-child(4) > ul > li:nth-child(1) > a"));
        public IWebElement ClientsForWindowsText => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'dp-app-logo-arrow.png')]"));

        
        public IWebElement FreeGame => Driver.WaitUntilVisible(By.LinkText("Бесплатная игра"));
        public IWebElement FreeGameText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div > div > div.main-content > p:nth-child(3)"));

        public IWebElement PaymentsMetod => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient > footer > div > div > nav > div:nth-child(3) > ul > li:nth-child(3) > a"));
        public IWebElement PaymentsMetodText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div.text-block.scrollbar > div > div > div"));

     
        public IWebElement AllBonuses => Driver.WaitUntilVisible(By.LinkText("Характеристики бонусов"));
        public IWebElement AllBonusesText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div > div > div > table > tbody > tr:nth-child(3) > td:nth-child(1)"));

        public IWebElement Contact => Driver.WaitUntilVisible(By.LinkText("Контакты"));
        public IWebElement ContactBlock => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div.text-block.scrollbar > div > div > div.contacts-block__list-wrap > ul"));


        public IWebElement HowToStart => Driver.WaitUntilVisible(By.LinkText("Как начать играть в казино Кинг"));
        public IWebElement HowToStartText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > h1"));

        public IWebElement About => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div/footer/div[1]/div/nav/div[2]/ul/li[3]/a"));
        public IWebElement AboutText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section.section.section--gradient.section--static > h1"));

        public IWebElement onlineSupport => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient > footer > div > div > nav > div:nth-child(3) > ul > li:nth-child(5) > a"));
        public IWebElement onlineSupportText1 => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div.contacts-block__list-wrap > ul > li:nth-child(1)"));
        public IWebElement onlineSupportText2 => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div.contacts-block__list-wrap > ul > li:nth-child(2)"));
        public IWebElement onlineSupportText3 => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div.contacts-block__list-wrap > ul > li:nth-child(3)"));

        public IWebElement agreements => Driver.WaitUntilVisible(By.LinkText("Положения и условия"));

       
        public IWebElement agreementsText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div > div > div > div:nth-child(1)"));

        public IWebElement privacy => Driver.WaitUntilVisible(By.LinkText("Политика конфиденциальности"));
        public IWebElement privacyText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div > div > div > div:nth-child(2)"));
        public IWebElement licensed => Driver.WaitUntilVisible(By.LinkText("Лицензия"));


        



        public IWebElement licensedText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div > div > div > p:nth-child(2)"));
        public IWebElement NavigatorMapsLink => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient > footer > div > div > nav > div:nth-child(1)"));



        public IWebElement CardOne => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section > div > div > div > div > div:nth-child(1) > div.app-bonus-card__front > div.app-bonus-card__front-inner > header > div.app-bonus-card__header-condition"));
        public IWebElement CardTwo => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section > div > div > div > div > div:nth-child(2) > div.app-bonus-card__front > div.app-bonus-card__front-inner > header > div.app-bonus-card__header-condition"));
        public IWebElement CardThree => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section > div > div > div > div > div:nth-child(3) > div.app-bonus-card__front > div.app-bonus-card__front-inner > header > a"));



        public IWebElement OpisanieBonusa => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section > div > div > div > div > div:nth-child(1) > div.modal.modal_bonus-condition > div > div > div.bonus-condition-window__content-wrap > ol > li:nth-child(2)"));

        public IWebElement OpisanieBonusa2 => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section > div > div > div > div > div:nth-child(2) > div.modal.modal_bonus-condition > div > div > div.bonus-condition-window__content-wrap > ol > li:nth-child(2)"));






        


        //DownloadBlock
        public IWebElement DownloadAppWindows => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section > div > div.download__content > div > div.download__list > div.download-box.download-box--pc > div.download-box__col.download-box__col--buttons > a.btn.btn--blue.btn--small.download-box__button"));
        public IWebElement DownloadAppWindowsText => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section > div > div.download__content > div > div.download__list > div.download-box.download-box--pc > div.download-box__col.download-box__col--buttons > a.btn.btn--blue.btn--small.download-box__button.download-box__button--active"));
        public IWebElement InstructionDowsnloadDesktop => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section > div > div.download__content > div > div.download__list > div.download-box.download-box--pc > div.download-box__col.download-box__col--buttons > a.download-box__link.link"));
        public IWebElement InputDownloadAppi => Driver.WaitUntilVisible(By.Id("p_inputConfirmPhone"));
        public IWebElement TakeLinksDownloadAppMobile => Driver.WaitUntilVisible(By.XPath("//*[@id='main-page']/section[5]/div/div[2]/div/div[2]/div[2]/div[2]/button"));
        public IWebElement TakeLinksDownloadAppMobileText => Driver.WaitUntilVisible(By.CssSelector("#main-page > section.section.section--gradiend.section--download > div > div.download__content > div > div.download__list > div.download-box.download-box--android > div.download-box__col.download-box__col--buttons > button"));

        public IWebElement InstructionDowsnloadMobile => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > section > div > div.download__content > div > div.download__list > div.download-box.download-box--android > div.download-box__col.download-box__col--buttons > a"));
        public IWebElement FooterPartners => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient > footer > div > div > div.footer-partner"));

        public IWebElement Footerfirm => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient > footer > div > div > div.footer-copyright"));

        public IWebElement SearchIcon => Driver.WaitUntilVisible(By.CssSelector("#game-search > div.search__input-box > label > input"));

        public IWebElement GameIconBookOfRa => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'BookofRa.jpg')]"));



        public IWebElement gameChangeSidebarActiveBonus => Driver.WaitUntilVisible(By.Id("gameChangeSidebarActiveBonus"));
        public IWebElement UserBarActivity => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div[3]/div[2]/div/div/div"));


        public IWebElement gameChangeSidebarActiveTournament => Driver.WaitUntilVisible(By.Id("gameChangeSidebarActiveTournament"));
        public IWebElement gameChangeSidebarActiveTournamentTimer => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div[3]/div[2]/div/div[1]/div/div[1]"));

        public IWebElement HideGamePopup => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.game > div > span"));
        public IWebElement support => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div/footer/div[1]/div/nav/div[3]/ul/li[1]/a"));

        public IWebElement supportPage => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div > div > div > div.contacts-block__list-wrap > ul > li:nth-child(1)"));
        public IWebElement supportPage1 => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div > div > div > div.contacts-block__list-wrap > ul > li:nth-child(2)"));
        public IWebElement supportPage2 => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div > section > div > div > div > div > div > div > div.contacts-block__list-wrap > ul > li:nth-child(3)"));


        public IWebElement GameChangeSidebarActive => Driver.WaitUntilVisible(By.Id("gameChangeSidebarActive"));

        

        public IWebElement PayMetod => Driver.WaitUntilVisible(By.LinkText("Методы оплаты"));
        public IWebElement PayMetodText => Driver.WaitUntilVisible(By.LinkText("Методы оплаты"));



        public void scrollToJackpot()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(fewfwefew);
            actions.Perform();
        }

        public void scrollpam()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(SeoTitle);
            actions.Perform();
        }


        public void scrollFooterfirm()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(Footerfirm);
            actions.Perform();
        }

        public void ClickLinnk()
        {

            IWebElement elem = Driver.Browser.FindElement(By.XPath("//*[@id='main-page']/section[5]/div/div[2]/div/div[2]/div[2]/div[2]/button"));
            String js = "arguments[0].style.height='auto'; arguments[0].style.visibility='visible';";
            ((IJavaScriptExecutor)Driver.Browser).ExecuteScript(js, elem);
            elem.Click();

        }



        public void scrollDownloadBlock()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(ClientForAndroid);
            actions.Perform();
        }





        public void scrollToButtonRegister()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(PrivetstveniyPaketLogoutRegisterButton);
            actions.Perform();
        }

        //Seo Text Block
        public IWebElement SeoText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.section.section--gradient.section--highlighted > section > div > div > div > div > div"));

        public IWebElement Pucket => Driver.WaitUntilVisible(By.CssSelector("#main-page > div.mobile-feature-position > div > section > div > div.features__container > h2"));

    }
}


