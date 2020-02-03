using Core;
using OpenQA.Selenium;

namespace Vulkan777
{
    public class Cashbox
    {
        public IWebElement CashboxButton => Driver.WaitUntilVisible(By.CssSelector("#header > div > div > div:nth-child(3) > div > div.user-bar.is-login > div > div > button.btn.btn--extra-small.user-bar__btn"));
        public IWebElement CashboxPopupTakeMethodVisa => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'V-M-CardAltern.png')]"));
        public IWebElement CashboxPopupTakeMethodVisaMaster => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'VisaM.png')]"));
        public IWebElement CashboxPopupAgreeVisaMaster => Driver.WaitUntilVisible(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/span/span[2]"));
        public IWebElement CashboxPopupTakeMethodMegafon => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'megafon.png')]"));
        public IWebElement CashboxPopupAgreeMegafon => Driver.WaitUntilVisible(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/span/span[2]"));
        public IWebElement CashboxPopupTakeMethodBeeline => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'beeline.png')]"));
        public IWebElement CashboxPopupAgreebilayn => Driver.WaitUntilVisible(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/span/span[2]"));
        public IWebElement CashboxPopupTakeMethodWebmoney => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'visa.png')]"));
        public IWebElement CashboxPopupAgreeWebmoney => Driver.WaitUntilVisible(By.XPath("//*[@id='signedloginform']/div[1]/div/label"));
        public IWebElement CashboxPopupTakeMethodPrivat24 => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'visa.png')]"));
        public IWebElement CashboxPopupAgree => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll.cash-content-hidden > div > div.cash-modal.cash-history-modal > div > div.cash-modal-title"));
        public IWebElement CashboxPopupInputQiwi => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[3]/div/input"));
        public IWebElement CashboxPopupTakeMethodQiwi => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'qiwi.png')]"));
        public IWebElement CashboxPopupAgreeQiwi => Driver.WaitUntilVisible(By.XPath("//*[@id='Mode-QIWI']/div[2]/span[1]"));
        public IWebElement CashboxPopupTakeMethodYandex => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'yandexn.png')]"));
        public IWebElement CashboxPopupAgreeYandex => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[2]/div[1]/div[1]/div[1]/div/div/h1"));
        public IWebElement CashboxPopupOpenAnother => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[1]/div/div[2]/span"));
        public IWebElement CashboxPopupOpenWalletone => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'visa.png')]"));
        public IWebElement CashboxPopupAgreeWalletone => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/div[1]/div[1]/div[5]/div[2]"));
        public IWebElement CashboxPopupOpenSberBank => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'visa.png')]"));
        public IWebElement CashboxPopupAgreeSberBank => Driver.WaitUntilVisible(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/h2"));
        public IWebElement CashboxPopupOpenPsb => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'visa.png')]"));
        public IWebElement CashboxPopupAgreePsb => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[1]/div[1]/div/div/div[2]/span[2]"));
        public IWebElement CashboxPopupOpenAlfaBank => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'alfa.png')]"));
        public IWebElement CashboxPopupAgreeAlfaBank => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div/div[1]/div/div[1]/div/div/div/div[1]/div/div[1]/div"));
        public IWebElement CashboxPopupOpenPerfectMoney => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'perfectMoney.png')]"));
        public IWebElement CashboxPopupAgreePerfectMoney => Driver.WaitUntilVisible(By.XPath("//*[@id='auth']/table[2]/tbody/tr/td[2]/table/tbody/tr[1]/td/table[2]/tbody/tr/td/table/tbody/tr/td/div/form/table[1]/tbody/tr/td[1]/h1/font"));
        public IWebElement CashboxPopupOpenAdvancedCash => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'advcash.png')]"));
        public IWebElement CashboxPopupAgreeAdvancedCash => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/h1"));
        public IWebElement CashboxPopupOpenPayeer => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Payeer.png')]"));
        public IWebElement CashboxPopupAgreePayeer => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'Payeer.png')]"));
        public IWebElement CashboxPopupInput => Driver.WaitUntilVisible(By.XPath("//*[@id='vueCash']/div/div[2]/div[4]/div/div[2]/div/input"));
        public IWebElement CashboxPopuptakeBonus => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-srcr']/div[1]/div[1]"));
        public IWebElement CashboxPopuptakeBonusSelect => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-srcr']/div[2]/ul/li[2]"));
        public IWebElement CashboxPopupButtonpush => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-button.cash-fill-btn.view-1 > button"));
        public IWebElement CashboxPopupnextSteppush => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll.cash-content-hidden > div > div.cash-modal.cash-history-modal > div > div.cash-button.view-2 > button"));
        public IWebElement Cashbox200ua => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement Paymentspage => Driver.WaitUntilVisible(By.XPath("//*[@id='form-submit']/div[1]/div/p/span"));
        public IWebElement CashboxPopup => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement CashboxPopupWithdrawButton => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > nav > ul > li:nth-child(2)"));
        public IWebElement CashboxPopupSelectW => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-select > div.cash-select-toggle"));
        public IWebElement CashboxPopupInputSumma => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-push-out > div.cash-input.amount > input"));
        public IWebElement CashboxPopupSelectWMaster => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-select.is-open > div.cash-select-list.cs-1 > div:nth-child(4)"));
        public IWebElement CashboxPopuprequisite => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-input > input"));
        public IWebElement CashboxPopupWButton => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-button.cash-push-btn.view-1 > button"));
        public IWebElement CashboxPopupSucespay => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll.cash-content-hidden > div > div.cash-modal.cash-push-modal > div > div.cash-modal-title"));
        public IWebElement CashboxPopupCPButton => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > nav > ul > li:nth-child(3)"));
        public IWebElement CashboxPopupCPinput => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-input.cash-exchange-input > input"));
        public IWebElement CashboxPopupCPButtonOK => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-button.cash-exchange-button.view-1 > button"));
        public IWebElement CashboxPopupCPchangeOK => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-exchange-success']/div/div/div[3]/a"));
        public IWebElement CashboxPopupCPchangeSuccess => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll.cash-content-hidden > div > div.cash-modal.cash-exchange-modal > div > div.cash-modal-title > span"));
        public IWebElement CashboxPopupCPchangeSuccessClose => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement CashboxPopupWBonusinFirstdepositMainpage => Driver.WaitUntilVisible(By.CssSelector("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement ClosePopupVivod => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-out-success']/div/div/div[3]/a"));
        public IWebElement HistoryFrame => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > nav > ul > li:nth-child(4)"));
        public IWebElement СancelWithdrawal => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.history-content.cash-scroll > div:nth-child(1) > div.cash-transaction-content > div.status > span"));
        public IWebElement ConfirmationOfCancellationOfOutput => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll.cash-content-hidden > div > div.cash-modal.cash-history-modal > div > div.cash-button.view-2 > button"));
        public IWebElement FrameVisa => Driver.WaitUntilVisible(By.Id("frame-cash-inner"));
        public IWebElement DepositTerms => Driver.WaitUntilVisible(By.XPath("//*[@id='payments -in -form']/div[4]/div[1]/div[1]"));
        public IWebElement CloseCassa => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > span"));

        public IWebElement InpushPush => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-fill-phone > div > div"));

        public IWebElement InpushCheckboxBonus => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-fill-bonus > div.cash-checkbox.bonus-checkbox > div"));

        public IWebElement OtmenaSdelana => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.history-content.cash-scroll > div:nth-child(1) > div.cash-transaction-content > div.status > div"));
        public IWebElement gregregreger => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-push-out > div.cash-input.amount.is-error.is-focus > div.error"));
        public IWebElement gregregreger1 => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-push-out > div.cash-input.amount.is-error.is-focus > div.error"));
        public IWebElement gregregreger2 => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div.cash-input.is-error.is-focus > div.error"));
        public IWebElement cashbox2000 => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > ul > li:nth-child(5)"));
        public IWebElement cashboxContainerFrame => Driver.WaitUntilVisible(By.CssSelector("#vueCash > div > div.cash-container > div.cash-content.cash-scroll > div > div"));



        public IWebElement CloseNewCahsbox => Driver.WaitUntilVisible(By.CssSelector("body > div > div.cash3__header > div"));






        public void EnterCashbox()
        {
            CashboxButton.Click();
            //Driver.Browser.SwitchTo().Frame("frame-cash");
        }
    }
}