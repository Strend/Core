using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RestSharp;
using SlotokingNew.Pages;

namespace SlotokingNew.Tests
{
    class ModalWindow
    {

        [OneTimeSetUp]
        public void BeforeTestSuit() { }


        [SetUp]
        public void BeforeTest() { }

        [Test]
        [Ignore("test")]
        public void Login()
        {


            for (int i = 0; i < 1; i++)
            {
                Driver.StartBrowser();
                Driver.Browser.Manage().Window.Maximize();
                ModalLocators mod = new ModalLocators();
                Driver.Browser.Url = "http://slotoking.com/login";
                mod.ModalInputLogin.SendKeys("+380637316713");
                mod.ModalInputPasswordLogin.SendKeys("blDkwVKX");
                //mod.InputRandom();
                mod.ModalInputButtonSubmit.Click();
                RestClient restClient = new RestClient(baseUrl:"http://slotoking.com/login");
                RestRequest restRequest = new RestRequest("200", Method.GET);
                IRestResponse restResponse = restClient.Execute(restRequest);
                int StatusCode = (int)restResponse.StatusCode;

                Assert.AreEqual(200, StatusCode, "Status code is not 200");
               

            }

        }



        [Test]
        [Ignore("test")]

        public static void Remind()
        {
           
            for (int i = 0; i < 1; i++)
            {
                Driver.StartBrowser();
                Driver.Browser.Manage().Window.Maximize();
                ModalLocators mod = new ModalLocators();
                Driver.Browser.Url = "http://slotoking.com/remind";
                mod.InputRandomRemaind();

                mod.ModalInputButtonremaind.Click();
                RestClient restClient = new RestClient(baseUrl: "http://slotoking.com/remind/");
                RestRequest restRequest = new RestRequest("200", Method.GET);
                IRestResponse restResponse = restClient.Execute(restRequest);
                int StatusCode = (int)restResponse.StatusCode;

                Assert.AreEqual(200, StatusCode, "Status code is not 200");
                

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





