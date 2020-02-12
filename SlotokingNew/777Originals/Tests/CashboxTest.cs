using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Threading;

namespace Vulkan777
{
    class CashboxTest
    {
        VuePage vue;
        Cashbox replenish = new Cashbox();
        [Ignore("не работает")]

        [SetUp]

        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();

            vue = new VuePage();
            vue.Auth(TestDataResource777Originals.CashLogin, false);
            Thread.Sleep(1000);
            replenish.CashboxButton.Click();
            Thread.Sleep(1000);
        }


        [Test]
        public void CashierReplenishmentVisa()
        {

            replenish.CashboxPopupTakeMethodVisa.Click();
            Thread.Sleep(1000);
            replenish.cashbox2000.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpush.Click();

            Assert.NotNull(replenish.cashboxContainerFrame.Displayed);

        }




        [Test]
        public void CashierReplenishmentVisaMaster()
        {
            replenish.CashboxPopupTakeMethodVisaMaster.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentWebmoney()
        {
            replenish.CashboxPopupTakeMethodWebmoney.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentPrivat24()
        {
            replenish.CashboxPopupTakeMethodPrivat24.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentQiwi()
        {

            replenish.CashboxPopupTakeMethodQiwi.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopupInputQiwi.SendKeys(TestDataResource777Originals.QiwiPhone);
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        public void CashierReplenishmentYandex()
        {
            replenish.CashboxPopupTakeMethodYandex.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);

        }

        [Test]
        [Ignore("Нету на сайте")]
        public void CashierReplenishmentWalletOne()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupOpenWalletone.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            replenish.CashboxPopupButtonpush.Click();
            replenish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("999.00 ₴", replenish.CashboxPopupAgreeWalletone.Text);
        }

        [Test]
        public void CashierReplenishmentPayeer()
        {
            //replenish.CashboxPopupOpenAnother.Click();
            if (replenish.CashboxPopupOpenAnother.Displayed)

            {
                int i = 4;
                while (i > 0)
                {

                    replenish.CashboxPopupOpenAnother.Click();
                    i--;

                }

            }
            replenish.CashboxPopupAgreePayeer.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentPsb()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupOpenPsb.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        public void CashierReplenishmentPerfectMoney()
        {
            replenish.CashboxPopupOpenAnother.Click();
            if (replenish.CashboxPopupOpenAnother.Displayed)

            {
                int i = 6;
                while (i > 0)
                {

                    replenish.CashboxPopupOpenAnother.Click();
                    i--;

                }

            }
            replenish.CashboxPopupOpenPerfectMoney.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("")]
        public void CashierReplenishmentAlfaBank()
        {
            {
                int i = 4;
                while (i > 0)
                {

                    replenish.CashboxPopupOpenAnother.Click();
                    i--;

                }

            }


            Thread.Sleep(1000);
            replenish.CashboxPopupOpenAlfaBank.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]

        public void CashierReplenishmentBeeline()

        {


            {
                int i = 4;
                while (i > 0)
                {

                    replenish.CashboxPopupOpenAnother.Click();
                    i--;

                }

            }
            replenish.CashboxPopupTakeMethodBeeline.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            replenish.InpushPush.Click();
            replenish.CashboxPopupInputQiwi.SendKeys("9651999999");
            Thread.Sleep(1000);

            replenish.InpushCheckboxBonus.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentMegafon()
        {

            {
                int i = 4;
                while (i > 0)
                {

                    replenish.CashboxPopupOpenAnother.Click();
                    i--;

                }

            }
            replenish.CashboxPopupTakeMethodMegafon.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopupInputQiwi.SendKeys("9295999997");
            Thread.Sleep(1000);
            replenish.InpushCheckboxBonus.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpush.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        public void CashierReplenishmentAdvancedCash()
        {
            //replenish.CashboxPopupOpenAnother.Click();


            if (replenish.CashboxPopupOpenAnother.Displayed)

            {
                int i = 6;
                while (i > 0)
                {

                    replenish.CashboxPopupOpenAnother.Click();
                    i--;

                }

            }

            replenish.CashboxPopupOpenAdvancedCash.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInput.SendKeys(TestDataResource777Originals.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpush.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            Thread.Sleep(1000);
            StringAssert.AreEqualIgnoringCase("Вход в Advanced Cash для оплаты заказа", replenish.CashboxPopupAgreeAdvancedCash.Text);
        }


        [Test]

        public void CashWithdrawal()
        {
            replenish.CashboxPopupWithdrawButton.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInputSumma.SendKeys(TestDataResource777Originals.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopuprequisite.Clear();
            replenish.CashboxPopuprequisite.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopuprequisite.SendKeys(TestDataResource777Originals.CreditCardVisa);
            Thread.Sleep(1000);
            replenish.CashboxPopupWButton.Click();
            StringAssert.AreEqualIgnoringCase("Заявка на выплату отправлена. Она будет обработана в течение 24-х часов.", replenish.CashboxPopupSucespay.Text);

        }


        [Test]
        public void СancelCashWithdrawal()
        {
            CashWithdrawal();
            replenish.HistoryFrame.Click();
            replenish.СancelWithdrawal.Click();
            replenish.ConfirmationOfCancellationOfOutput.Click();
            Thread.Sleep(1000);
            StringAssert.AreEqualIgnoringCase("Отменен", replenish.OtmenaSdelana.Text);
        }

        [Test]

        public void CPChange()
        {
            replenish.CashboxPopupCPButton.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupCPinput.SendKeys("40");
            Thread.Sleep(1000);
            replenish.CashboxPopupCPButtonOK.Click();
            Thread.Sleep(1000);
            StringAssert.AreEqualIgnoringCase("3.2 RUB", replenish.CashboxPopupCPchangeSuccess.Text);
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