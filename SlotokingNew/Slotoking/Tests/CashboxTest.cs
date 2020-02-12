using Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.Threading;

namespace Slotoking
{
    class CashboxTest_V3
    {
        VuePage vue = new VuePage();
        CashBox replenish = new CashBox();



        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();


            vue.Auth(TestDataResourceSlotoking.CashLogin, false);


            replenish.CashboxButton.Click();
            Driver.Browser.SwitchTo().Frame(Driver.Browser.FindElement(By.Id("frame-cash")));

        }



        [Test]
        [Ignore("Отсутствует")]
        public void NewCashierReplenishmentVisaMaster()
        {

            replenish.CashboxPopupTakeMethodVisaMaster.Click();

            replenish.CashboxPopupAgreeVisaMasterUah.Click();

            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            Assert.NotNull(replenish.VisaPagePay.Displayed);

        }

        [Test]
        //[Ignore("нету на сайте")]
        public void NewCashierReplenishmentVisa()
        {
            replenish.CashboxPopupTakeMethodVisa.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.TakeUAH.Click();

            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.AgreePaymentsLast.Click();
            

            Assert.NotNull(replenish.FrameVisa.Displayed);

        }



       



        [Test]
        public void NewCashierReplenishmentWebmoney()
        {
            replenish.CashboxPopupTakeMethodWebmoney.Click();
            replenish.CashboxPopupTakeMethodWebmoneyWMR.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            Assert.NotNull(replenish.WebMoney);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void NewCashierReplenishmentPrivat24()
        {
            replenish.CashboxPopupTakeMethodPrivat24.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты.", replenish.CashboxPopupAgreePrivat24.Text);
        }

        [Test]
        [Ignore("")]
        //[Ignore("нету на сайте")]
        public void NewCashierReplenishmentQiwi()

        {
            replenish.CashboxPopupTakeMethodQiwi.Click();
            replenish.CashboxPopupTakeMethodQiwiRub.Click();
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.CashboxPopupInputQiwi.SendKeys(TestDataResourceSlotoking.QiwiPhone);
            replenish.AgreePaymentsLast.Click();
            if (replenish.Gregregreger != null)
            {
                replenish.CashboxPopupInputQiwi.Clear();
                replenish.CashboxPopupInputQiwi.SendKeys(TestDataResourceSlotoking.QiwiPhone);
                replenish.AgreePaymentsLast.Click();
                Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
                Driver.Browser.SwitchTo().Frame(Driver.Browser.FindElement(By.Id("frame-cash")));
                Assert.NotNull(replenish.QIWI);
            }
            else
            {

                Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
                Driver.Browser.SwitchTo().Frame(Driver.Browser.FindElement(By.Id("frame-cash")));
                Assert.NotNull(replenish.QIWI);

            }
            try
            {

            }
            catch { }
        }

        [Test]
        //[Ignore("нету на сайте")]
        public void NewCashierReplenishmentYandex()
        {
            replenish.CashboxPopupTakeMethodYandex.Click();
            replenish.CashboxPopupTakeMethodYandexRub.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Take1000Money.Click();
            replenish.Take1000Money.Click();
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            Assert.NotNull(replenish.Yandex);

        }

        [Test]
        [Ignore("нету на сайте")]
        public void NewCashierReplenishmentWalletOne()
        {

            replenish.CashboxPopupOpenWalletone.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.CashboxPopupnextSteppush.Click();
            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            Assert.NotNull(replenish.Wolletone);
        }

        [Test]
        //[Ignore("нету на сайте")]
        public void NewCashierReplenishmentPayeer()
        {

            replenish.CashboxPopupAgreePayeer.Click();
            replenish.CashboxPopupTakeMethodQiwiRub.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            Assert.NotNull(replenish.Payeer);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void NewCashierReplenishmentPsb()
        {

            replenish.CashboxPopupOpenPsb.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgreePrivat24.Text);
        }

        [Test]
        public void NewCashierReplenishmentPerfectMoney()
        {

            replenish.CashboxPopupOpenPerfectMoney.Click();
            replenish.CashboxPopupTakeMethodQiwiRub.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
            //replenish.CashboxPopupnextSteppush.Click();
            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            Assert.NotNull(replenish.PerfectMoney);
           



        }

        [Test]

        public void NewCashierReplenishmentAlfaBank()
        {

            replenish.CashboxPopupOpenAlfaBank.Click();
            replenish.CashboxPopupTakeMethodAlfaBank.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Cashboxru.Click();
            replenish.CashboxPopupButtonpush.Click();
            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            Assert.NotNull(replenish.Alfaclick);
        }

        [Test]
        public void NewCashierReplenishmentAdvancedCash()
        {

            replenish.CashboxPopupOpenAdvancedCash.Click();
            replenish.CashboxPopupAgreeVisaMasterUah.Click();
            //replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.Take1000Money.Click();
            replenish.CashboxPopupButtonpush.Click();
           

            replenish.AgreePaymentsLast.Click();
            replenish.CashboxPopupnextSteppushend.Click();
            Driver.Browser.SwitchTo().DefaultContent();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            System.Threading.Thread.Sleep(1000);
            Assert.NotNull(replenish.AdvancedCash);
        }


        [Test]
        [Ignore("нету на сайте")]
        public void CashWithdrawal()
        {
            replenish.CashboxPopupWithdrawButton.Click();
            replenish.CashboxPopupSelectW.Click();
            replenish.CashboxPopupSelectWMaster.Click();

            replenish.CashboxPopupInputSumma.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.CashboxPopuprequisite.Clear();

            replenish.CashboxPopuprequisite.SendKeys(TestDataResourceSlotoking.CreditCardVisa);
            replenish.CashboxPopupWButton.Click();
            StringAssert.AreEqualIgnoringCase("Заявка на выплату отправлена. Она будет обработана в течение 24-х часов.", replenish.CashboxPopupSucespay.Text);
            replenish.ClosePopupVivod.Click();
        }

        [Test]
        [Ignore("нету на сайте")]
        public void СancelCashWithdrawal()
        {
            CashWithdrawal();
            replenish.HistoryFrame.Click();
            replenish.СancelWithdrawal.Click();
            replenish.ConfirmationOfCancellationOfOutput.Click();
            StringAssert.AreEqualIgnoringCase("Успешно", replenish.OtmenaSdelana.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
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


    class CashboxTest_V2
    {
        VuePage vue = new VuePage();
        CashBox replenish = new CashBox();



        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();


            vue.Auth(TestDataResourceSlotoking.CashLogin, false);

            HeaderMenu head = new HeaderMenu();
            head.ProfileIcon.Click();


            
            replenish.ProfileCashBoxV2.Click();
            
        }


        [Test]
        [Ignore("")]
        public void CashierReplenishmentVisa()
        {

            replenish.CashboxPopupTakeMethodVisa.Click();
            Thread.Sleep(1000);
            replenish.Cashbox2000.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpushV2.Click();

            Assert.NotNull(replenish.CashboxContainerFrame.Displayed);

        }




        [Test]
        [Ignore("")]
        public void CashierReplenishmentVisaMaster()
        {
            replenish.CashboxPopupTakeMethodVisaMaster.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpushV2.Click();
            replenish.CashboxPopupnextSteppushV2.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentWebmoney()
        {
            replenish.CashboxPopupTakeMethodWebmoney.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.CashboxPopupButtonpushV2.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentPrivat24()
        {
            replenish.CashboxPopupTakeMethodPrivat24.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.CashboxPopupButtonpushV2.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentQiwi()
        {

            replenish.CashboxPopupTakeMethodQiwi.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopupInputQiwi.SendKeys(TestDataResourceSlotoking.QiwiPhone);
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpushV2.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("")]
        public void CashierReplenishmentYandex()
        {
            replenish.CashboxPopupTakeMethodYandex.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.CashboxPopupButtonpushV2.Click();
            replenish.CashboxPopupnextSteppushV2.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);

        }

        [Test]
        [Ignore("Нету на сайте")]
        public void CashierReplenishmentWalletOne()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupOpenWalletone.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.CashboxPopupButtonpushV2.Click();
            replenish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("999.00 ₴", replenish.CashboxPopupAgreeWalletone.Text);
        }

        [Test]
        [Ignore("")]
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
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.CashboxPopupButtonpushV2.Click();
            replenish.CashboxPopupnextSteppushV2.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("нету на сайте")]
        public void CashierReplenishmentPsb()
        {
            replenish.CashboxPopupOpenAnother.Click();
            replenish.CashboxPopupOpenPsb.Click();
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.CashboxPopupButtonpushV2.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("")]
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
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.CashboxPopupButtonpushV2.Click();
            replenish.CashboxPopupnextSteppushV2.Click();

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
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpushV2.Click();

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
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            replenish.InpushPush.Click();
            replenish.CashboxPopupInputQiwi.SendKeys("9651999999");
            Thread.Sleep(1000);

            replenish.InpushCheckboxBonus.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpushV2.Click();

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
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
            Thread.Sleep(1000);
            replenish.CashboxPopupInputQiwi.SendKeys("9295999997");
            Thread.Sleep(1000);
            replenish.InpushCheckboxBonus.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupButtonpushV2.Click();

            StringAssert.AreEqualIgnoringCase("Для завершения платежа Вы будете перенаправлены на страницу оплаты", replenish.CashboxPopupAgree.Text);
        }

        [Test]
        [Ignore("")]
        public void CashierReplenishmentAdvancedCash()
        {
            //replenish.CashboxPopupOpenAnother.Click();


            if (replenish.CashboxPopupOpenAnother.Displayed)

            {
                int i = 7;
                while (i > 0)
                {

                    replenish.CashboxPopupOpenAnother.Click();
                    i--;

                }

            }

            replenish.CashboxPopupOpenAdvancedCash.Click();
            
            replenish.CashboxPopupInput.SendKeys(TestDataResourceSlotoking.Payments);
           
            replenish.CashboxPopupButtonpush.Click();
            
            replenish.CashboxPopupButtonpushV2.Click();
            replenish.CashboxPopupnextSteppushV2.Click();

            

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            Thread.Sleep(1000);
            StringAssert.AreEqualIgnoringCase("Вход в Advanced Cash для оплаты заказа", replenish.CashboxPopupAgreeAdvancedCash.Text);
        }


        [Test]

        public void CashWithdrawal()
        {
            replenish.CashboxPopupWithdrawButton.Click();
            Thread.Sleep(1000);
            replenish.CashboxPopupInputSumma.SendKeys(TestDataResourceSlotoking.Payments);
            Thread.Sleep(1000);
           
            replenish.CashboxPopupWButton.Click();
           

            try {
                StringAssert.AreEqualIgnoringCase("Заявка на выплату отправлена. Она будет обработана в течение 24-х часов.", replenish.CashboxPopupSucespay.Text);
            }
            catch {
                replenish.CashboxPopupInputSumma.Clear();
                replenish.CashboxPopupInputSumma.SendKeys(TestDataResourceSlotoking.Payments);
                replenish.CashboxPopuprequisite.Click();
                replenish.CashboxPopupWButton.Click();
                StringAssert.AreEqualIgnoringCase("Заявка на выплату отправлена. Она будет обработана в течение 24-х часов.", replenish.CashboxPopupSucespay.Text);
            }

        }


        [Test]
        [Ignore("")]
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
            
            replenish.CashboxPopupCPinput.SendKeys("40");
            
            replenish.CashboxPopupCPButtonOK.Click();
            
            
            try {

                StringAssert.AreEqualIgnoringCase("4 UAH", replenish.CashboxPopupCPchangeSuccess.Text);
            }

            catch {

                replenish.CashboxPopupCPinput.Clear();
                replenish.CashboxPopupCPinput.SendKeys("40");
                replenish.CashboxPopupCPButtonOK.Click();
                StringAssert.AreEqualIgnoringCase("4 UAH", replenish.CashboxPopupCPchangeSuccess.Text);
            }
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
