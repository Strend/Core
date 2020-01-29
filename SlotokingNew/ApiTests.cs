using NUnit.Framework;
using RestSharp;
using SlotokingNew;


namespace API
{
    class ApiTests
    {
        [Test]
        public void ApiPing()
        {
            RestClient restClient = new RestClient(TestDataResource.MainPageURL);
            RestRequest restRequest = new RestRequest("/rest/player/getnodepbonus/", Method.GET);
            // Executing request to server and checking server response to the it
            IRestResponse restResponse = restClient.Execute(restRequest);
            string response = restResponse.Content;
            if (!response.Contains("false"))
                Assert.Fail("ping fail");
        }




        [Test]
        public void Inf200()
        {
            RestClient restClient = new RestClient(TestDataResource.MainPageURL);
            RestRequest restRequest = new RestRequest("200", Method.GET);
            IRestResponse restResponse = restClient.Execute(restRequest);


            int StatusCode = (int)restResponse.StatusCode;

            Assert.AreEqual(404, StatusCode, "Status code is not 200");
        }

        [Test]
        public void Error404()
        {
            RestClient restClient = new RestClient(TestDataResource.MainPageURL);
            RestRequest restRequest = new RestRequest("44444", Method.GET);
            IRestResponse restResponse = restClient.Execute(restRequest);


            int StatusCode = (int)restResponse.StatusCode;

            Assert.AreEqual(404, StatusCode);
        }
    }
}
