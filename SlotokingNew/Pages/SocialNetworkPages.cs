using OpenQA.Selenium;


namespace SlotokingNew.Pages
{
    class SocialNetworkPages
    {
        public IWebElement VKLoginTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='login_submit']/div/div/input[6]"));
        public IWebElement VKLoginTextBoxMobiput => Driver.WaitUntilVisible(By.XPath("//*[@id='mcont']/div/div/div[2]/form/dl[1]/dd/div/input"));
        public IWebElement VKLoginTextBoxMobpass => Driver.WaitUntilVisible(By.XPath("//*[@id='mcont']/div/div/div[2]/form/dl[2]/dd/div/input"));

        public IWebElement VKLoginTextBoxMobpassSubmit => Driver.WaitUntilVisible(By.XPath("//*[@id='mcont']/div/div/div[2]/form/div[1]/div/input"));

        


        public IWebElement VKPassTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='login_submit']/div/div/input[7]"));
        public IWebElement VKLoginButton => Driver.WaitUntilVisible(By.XPath("//*[@id='install_allow']"));
        public IWebElement FaceBookLoginTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='email']"));
        public IWebElement FaceBookPassTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='pass']"));
        public IWebElement FaceBookLoginButton => Driver.WaitUntilVisible(By.XPath("//*[@id='loginbutton']"));
        public IWebElement GoogleLoginTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='identifierId']"));
        public IWebElement GoogleNextButton => Driver.WaitUntilVisible(By.Id("identifierNext"));
        public IWebElement GooglePassTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='password']/div[1]/div/div[1]/input"));
        public IWebElement GoogleLoginButton => Driver.WaitUntilVisible(By.XPath("//*[@id='loginbutton']"));
        public IWebElement GooglePassNextButton => Driver.WaitUntilVisible(By.Id("passwordNext"));
        public IWebElement TwitterLoginTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='username_or_email']"));
        public IWebElement TwitterPassTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='password']"));
        public IWebElement TwitterLoginButton => Driver.WaitUntilVisible(By.XPath("//*[@id='allow']"));
        public IWebElement OKLoginTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='field_email']"));
        public IWebElement OKPassTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='field_password']"));
        public IWebElement OKLoginButton => Driver.WaitUntilVisible(By.CssSelector("#widget-el > div.ext-widget_cnt-w.__center > div > div > div.form-actions > input"));
        public IWebElement MailLoginTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='login']"));
        public IWebElement MailPassTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='password']"));
        public IWebElement MailRULoginButton => Driver.WaitUntilVisible(By.XPath("//*[@id='login-form']/div[2]/button"));
    }
}

