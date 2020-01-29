using OpenQA.Selenium;


namespace SlotokingNew.Pages
{
    class CashBox
    {
        public IWebElement CashboxButton => Driver.WaitUntilVisible(By.XPath("//*[@id='header']/div/div/div[2]/div/button[2]/span"));
        public IWebElement CashboxPopupTakeMethodVisa => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'VisaM.png')]"));
        public IWebElement CashboxPopupTakeMethodVisaMaster => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'VMCardAlt.png')]"));
        public IWebElement CashboxPopupAgreeVisaMaster => Driver.WaitUntilVisible(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/span/span[2]"));
        public IWebElement CashboxPopupAgreeVisaMasterUah => Driver.WaitUntilVisible(By.CssSelector("#step-1 > div > ul > li.cash3__method-currency.cash3__method-currency--expanded > div > div > button:nth-child(1)"));

        public IWebElement CashboxPopupTakeMethodWebmoney => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'webmoney.png')]"));
        public IWebElement CashboxPopupTakeMethodWebmoneyWMR => Driver.WaitUntilVisible(By.CssSelector("#step-1 > div > ul > li.cash3__method-currency.cash3__method-currency--expanded > div > div > button:nth-child(1)"));
        public IWebElement CashboxPopupTakeMethodQiwiRub => Driver.WaitUntilVisible(By.CssSelector("#step-1 > div > ul > li.cash3__method-currency.cash3__method-currency--expanded > div > div > button:nth-child(1)"));
        public IWebElement CashboxPopupTakeMethodAlfaBank => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'alfa.png')]"));
       
        public IWebElement CashboxPopupAgreeWebmoney => Driver.WaitUntilVisible(By.XPath("//*[@id='signedloginform']/div[1]/div/label"));
        public IWebElement CashboxPopupTakeMethodPrivat24 => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[1]/span[4]"));
        public IWebElement CashboxPopupAgreePrivat24 => Driver.WaitUntilVisible(By.CssSelector("#step-7 > div > h5"));
        public IWebElement CashboxPopupInputQiwi => Driver.WaitUntilVisible(By.CssSelector("#step-3 > div.cash3__step-content.cash3__step-content--base > div.cash3__step-content > div > div > div > label > input"));
        public IWebElement CashboxPopupTakeMethodQiwi => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'qiwi.png')]"));
        public IWebElement CashboxPopupAgreeQiwi => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'qiwi.png')]"));
        public IWebElement CashboxPopupTakeMethodYandex => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'yandexn.png')]"));
        public IWebElement CashboxPopupTakeMethodYandexRub => Driver.WaitUntilVisible(By.CssSelector("#step-1 > div > ul > li.cash3__method-currency.cash3__method-currency--expanded > div > div > button"));
        public IWebElement CashboxPopupAgreeYandex => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'yandexn.png')]"));
        public IWebElement CashboxPopupOpenAnother => Driver.WaitUntilVisible(By.XPath("//*[@id='cash - swiper']/div[2]/span"));
        public IWebElement CashboxPopupOpenWalletone => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'wallelonen.png')]"));
        public IWebElement CashboxPopupAgreeWalletone => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/div[1]/div[1]/div[5]/div[2]"));
        public IWebElement CashboxPopupOpenSberBank => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[2]/div/span[2]"));
        public IWebElement CashboxPopupAgreeSberBank => Driver.WaitUntilVisible(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/h2"));
        public IWebElement CashboxPopupOpenPsb => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[2]/div/span[4]"));
        public IWebElement CashboxPopupAgreePsb => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[1]/div[1]/div/div/div[2]/span[2]"));
        public IWebElement CashboxPopupOpenAlfaBank => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'alfa.png')]"));
        public IWebElement CashboxPopupAgreeAlfaBank => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div/div[1]/div/div[1]/div/div/div/div[1]/div/div[1]/div"));
        public IWebElement CashboxPopupOpenPerfectMoney => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'PM.png')]"));
        public IWebElement CashboxPopupAgreePerfectMoney => Driver.WaitUntilVisible(By.XPath("//*[@id='auth']/table[2]/tbody/tr/td[2]/table/tbody/tr[1]/td/table[2]/tbody/tr/td/table/tbody/tr/td/div/form/table[1]/tbody/tr/td[1]/h1/font"));
        public IWebElement CashboxPopupOpenAdvancedCash => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'advcash.png')]"));
        public IWebElement CashboxPopupAgreeAdvancedCash => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/h1"));
        public IWebElement CashboxPopupOpenPayeer => Driver.WaitUntilVisible(By.XPath("//*[contains(@style, 'Payeer.png')]"));
        public IWebElement CashboxPopupAgreePayeer => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Payeer.png')]"));
        public IWebElement CashboxPopupInput => Driver.WaitUntilVisible(By.Id("another-amount"));
        public IWebElement CashboxPopuptakeBonus => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-styler']/div[1]/div[1]"));
        public IWebElement CashboxPopuptakeBonusSelect => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-styler']/div[2]/ul/li[2]"));
        public IWebElement CashboxPopupButtonpush => Driver.WaitUntilVisible(By.CssSelector("#step-2 > div > div.stick-to-bottom.cash3__form-submit > div"));
        public IWebElement CashboxPopupnextSteppushV2 => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[7]/div/div[3]/button"));


        public IWebElement CashboxPopupButtonpushV2 => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-button.cash-fill-btn.view-1"));

        

        public IWebElement CashboxPopupnextSteppush => Driver.WaitUntilVisible(By.CssSelector("#popup-next-step > div > div > div.uk-modal-buttons > a"));
        public IWebElement CashboxPopupnextSteppushend => Driver.WaitUntilVisible(By.CssSelector("#step-7 > div > div > button"));
        public IWebElement Cashboxru => Driver.WaitUntilVisible(By.CssSelector("#step-1 > div > ul > li.cash3__method-currency.cash3__method-currency--expanded > div > div > button"));

        
        public IWebElement Cashbox200ua => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement Paymentspage => Driver.WaitUntilVisible(By.XPath("//*[@id='form-submit']/div[1]/div/p/span"));
        public IWebElement CashboxPopup => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement CashboxPopupWithdrawButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/nav/ul/li[2]"));
        public IWebElement CashboxPopupSelectW => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_output_id-styler']/div[1]/div[1]"));
        public IWebElement CashboxPopupInputSumma => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[2]/div[1]/input"));
        public IWebElement CashboxPopupSelectWMaster => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_output_id-styler']/div[2]/ul/li[6]"));
        public IWebElement CashboxPopuprequisite => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[4]/input"));
        public IWebElement CashboxPopupWButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[5]/button"));
        public IWebElement CashboxPopupSucespay => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[7]/div/div[2]"));
        public IWebElement CashboxPopupCPButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/nav/ul/li[3]"));
        public IWebElement CashboxPopupCPinput => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[2]/input"));
        public IWebElement CashboxPopupCPButtonOK => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[4]/button"));
        public IWebElement CashboxPopupCPchangeOK => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-exchange-success']/div/div/div[3]/a"));
        public IWebElement CashboxPopupCPchangeSuccess => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[6]/div/div[2]/span"));
        public IWebElement CashboxPopupCPchangeSuccessClose => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement CashboxPopupWBonusinFirstdepositMainpage => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement ClosePopupVivod => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-out-success']/div/div/div[3]/a"));
        public IWebElement HistoryFrame => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[4]/a"));
        public IWebElement СancelWithdrawal => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div/div[2]/div[2]/div[2]/div/div/div[2]/table/tbody/tr[2]/td[7]/a"));
        public IWebElement ConfirmationOfCancellationOfOutput => Driver.WaitUntilVisible(By.CssSelector("#popup-cancel > div > div > div.uk-modal-buttons > a.btn-green-frame"));
        public IWebElement FrameVisa => Driver.WaitUntilVisible(By.Id("frame-cash-inner")); 
        public IWebElement DepositTerms => Driver.WaitUntilVisible(By.XPath("//*[@id='payments -in -form']/div[4]/div[1]/div[1]"));
        public IWebElement OtmenaSdelana => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-success']/div/div/div[1]"));
        public IWebElement AgreePaymentsLast => Driver.WaitUntilVisible(By.CssSelector("#step-3 > div.cash3__step-content.cash3__step-content--base > div.stick-to-bottom.cash3__form-submit > div"));
        public IWebElement Take1000Money => Driver.WaitUntilVisible(By.CssSelector("#step-2 > div > div.cash3__step-content > div:nth-child(2) > div > label:nth-child(4) > div"));
        public IWebElement VisaMasterAlternative => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]"));
        public IWebElement ProfileIcon => Driver.WaitUntilVisible(By.CssSelector("#a-profile-block > div:nth-child(1)"));

        //New Cashbox
        public IWebElement ButtonNewCashbox => Driver.WaitUntilVisible(By.CssSelector("#a-profile-block > div.apb-block.user-bar-cash > a"));
        public IWebElement Gregregreger => Driver.WaitUntilVisible(By.CssSelector("#step-3 > div.cash3__step-content.cash3__step-content--base > div.cash3__step-content > div > div > div"));

        //payments metod

        public IWebElement WebMoney => Driver.WaitUntilVisible(By.XPath("/html/body/div/div[3]"));
        public IWebElement QIWI => Driver.WaitUntilVisible(By.CssSelector("#step-4"));
        public IWebElement Yandex => Driver.WaitUntilVisible(By.XPath("/html/body"));
        public IWebElement Wolletone => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[1]/div[1]"));
        public IWebElement Alfaclick => Driver.WaitUntilVisible(By.XPath("/html/body"));
        public IWebElement PerfectMoney => Driver.WaitUntilVisible(By.XPath("//*[@id='auth']/table[2]/tbody/tr/td[2]/table/tbody/tr[1]/td/table[2]/tbody/tr/td/table/tbody/tr/td/div/form/table[1]/tbody/tr/td[1]/h1/font"));
        public IWebElement AdvancedCash => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div/div[1]"));
        public IWebElement Payeer => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]"));
        public IWebElement CloseCassa => Driver.WaitUntilVisible(By.XPath("/html/body/div/div[1]/div"));
        public IWebElement CloseCassa2 => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/span"));
        public IWebElement VisaPagePay => Driver.WaitUntilVisible(By.XPath("/html/body"));
        public IWebElement ProfileCashBoxV2 => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div/div/aside/nav/ul/li[4]"));
        public IWebElement Cashbox2000 => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > ul > li:nth-child(5)"));
        public IWebElement CashboxContainerFrame => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div"));
        public IWebElement CashboxPopupAgree => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll.cash-content-hidden > div > div.cash-modal.cash-history-modal > div > div.cash-modal-title"));
        public IWebElement CashboxPopupTakeMethodBeeline => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'beeline.png')]"));
        public IWebElement CashboxPopupTakeMethodMegafon => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'megafon.png')]"));
        public IWebElement InpushCheckboxBonus => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-fill-bonus > div.cash-checkbox.bonus-checkbox > div"));
        public IWebElement InpushPush => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-fill-phone > div > div"));



    }
}