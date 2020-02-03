using Core;
using OpenQA.Selenium;

namespace Vulkan777
{

    class WelcomePage
    {
        public IWebElement WelcomeRegisterButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div/a[text()='• Регистрация •']"));
        public IWebElement WelcomeText => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal--bonus-auth > div > div > div.bonus-auth__data-2 > div.bonus-auth__container > div.bonus-auth__title-2"));
        public IWebElement CancelButton => Driver.WaitUntilVisible(By.CssSelector("#vuePopup > div.modal.modal--bonus-auth > div > button"));
        public IWebElement ActivateBonusButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div/div[4]/div/div[2]/div[2]/div/div[3]/a/span"));
        public IWebElement WelcomeStepsBlockTitle => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[1]"));
        public IWebElement WelcomeStepsBlock => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div"));
        public IWebElement GamesPlaybutton => Driver.WaitUntilVisible(By.XPath("//*[contains(@src, 'LuckyHaunter.png')]"));
        public void ScrollToWelcomeStepsBlock() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", WelcomeStepsBlock);

        public void ScroollTogame() => (Driver.Browser as IJavaScriptExecutor).ExecuteScript("arguments[0].scrollIntoView();", GamesPlaybutton);
    }
}

