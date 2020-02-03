using Core;
using OpenQA.Selenium;

namespace Vulkan777
{
    public class CallbackPage
    {
        public IWebElement ErrorText => Driver.WaitUntilVisible(By.XPath("/html/body/h2"));
    }
}

