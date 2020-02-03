using Core;
using OpenQA.Selenium;


namespace VipNetGame
{
    class WelcomePage
    {
        public IWebElement WelcomeRegisterButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div/a[text()='• Регистрация •']"));
        public IWebElement WelcomeText => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div/div[4]/div/div[2]/div[1]/div/div[1]"));
        public IWebElement CancelButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div/div[4]/div/div[2]/span"));
        public IWebElement ActivateBonusButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div/div[4]/div/div[2]/div[2]/div/div[3]/a/span"));
        public IWebElement WelcomeStepsBlockTitle => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[1]"));
        public IWebElement WelcomeStepsBlock => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div"));
        public void ScrollToWelcomeStepsBlock() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", WelcomeStepsBlock);


    }
}
