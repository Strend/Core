using OpenQA.Selenium;


namespace SlotokingNew.Pages
{
    class CallbackPage
    {
        public IWebElement ErrorText => Driver.WaitUntilVisible(By.XPath("/html/body/h2"));
    }
}
