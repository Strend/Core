using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace VipNetGame
{
    class CashboxTest
    {
        VuePage vue;
        Cashbox replenish;


        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();

            vue = new VuePage();
            vue.Auth(TestDataResourceVipNetGame.CashLogin, false);
            vue.ClosePopupWelcomePage();
            replenish = new Cashbox();
            replenish.EnterCashbox();
        }


        [Test]
        public void CashierReplenishmentVisa()
        {
            replenish.CashboxPopupTakeMethodVisa.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();

            Assert.NotNull(replenish.FrameVisa.Displayed);

        }

        [Test]
        public void CashierReplenishmentVisaMaster()
        {
            replenish.CashboxPopupTakeMethodVisaMaster.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgreePrivat24.Text);
        }

        [Test]
        public void CashierReplenishmentWebmoney()
        {
            replenish.CashboxPopupTakeMethodWebmoney.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgreePrivat24.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentPrivat24()
        {
            replenish.CashboxPopupTakeMethodPrivat24.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgreePrivat24.Text);
        }

        [Test]
        public void CashierReplenishmentQiwi()
        {
            replenish.CashboxPopupTakeMethodQiwi.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupInputQiwi.SendKeys(TestDataResourceVipNetGame.QiwiPhone);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgreePrivat24.Text);
        }

        [Test]
        public void CashierReplenishmentYandex()
        {
            replenish.CashboxPopupTakeMethodYandex.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgreePrivat24.Text);

        }

        [Test]
        public void CashierReplenishmentWalletOne()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupOpenWalletone.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();
            replenish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("999.00 ₴", replenish.CashboxPopupAgreeWalletone.Text);
        }

        [Test]
        public void CashierReplenishmentPayeer()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupAgreePayeer.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgreePrivat24.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentPsb()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupOpenPsb.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgreePrivat24.Text);
        }

        [Test]
        public void CashierReplenishmentPerfectMoney()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupOpenPerfectMoney.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();
            replenish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("Perfect Money®", replenish.CashboxPopupAgreePerfectMoney.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentAlfaBank()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupOpenAlfaBank.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgreePrivat24.Text);
        }

        [Test]
        public void CashierReplenishmentAdvancedCash()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupOpenAdvancedCash.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopupButtonpush.Click();
            replenish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("Вход в Advanced Cash для оплаты заказа", replenish.CashboxPopupAgreeAdvancedCash.Text);
        }


        [Test]

        public void CashWithdrawal()
        {
            replenish.CashboxPopupWithdrawButton.Click();
            replenish.CashboxPopupSelectW.Click();
            replenish.CashboxPopupSelectWMaster.Click();

            replenish.CashboxPopupInputSumma.SendKeys(TestDataResourceVipNetGame.Payments);
            replenish.CashboxPopuprequisite.Clear();

            replenish.CashboxPopuprequisite.SendKeys(TestDataResourceVipNetGame.CreditCardVisa);
            replenish.CashboxPopupWButton.Click();
            StringAssert.AreEqualIgnoringCase("Заявка на выплату отправлена. Она будет обработана в течение 24-х часов.", replenish.CashboxPopupSucespay.Text);
            replenish.ClosePopupVivod.Click();
        }

        [Test]
        public void СancelCashWithdrawal()
        {
            CashWithdrawal();
            replenish.HistoryFrame.Click();
            replenish.СancelWithdrawal.Click();
            replenish.ConfirmationOfCancellationOfOutput.Click();
            StringAssert.AreEqualIgnoringCase("Успешно", replenish.OtmenaSdelana.Text);
        }

        [Test]

        public void CPChange()
        {
            replenish.CashboxPopupCPButton.Click();
            replenish.CashboxPopupCPinput.SendKeys("40");
            replenish.CashboxPopupCPButtonOK.Click();
            StringAssert.AreEqualIgnoringCase("Недостаточно CP для обмена", replenish.CashboxPopupCPchangeSuccess.Text);

        }

        [TearDown]
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success) Driver.TakeScreenshot();
            Driver.DisposeBrowser();
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }
}