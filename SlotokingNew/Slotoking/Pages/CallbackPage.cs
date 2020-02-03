using Core;
using OpenQA.Selenium;


namespace Slotoking
{
    class CallbackPage
    {
        public IWebElement ErrorText => Driver.WaitUntilVisible(By.XPath("/html/body/h2"));
    }
}
