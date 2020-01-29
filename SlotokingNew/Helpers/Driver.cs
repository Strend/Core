using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SlotokingNew.Helpers;
using System;
using System.Threading;

namespace SlotokingNew
{
    public static class Driver
    {
        public static IWebDriver Browser { get; private set; }
        public static WebDriverWait BrowserWait { get; private set; }

        public static IWebElement WaitUntilVisible(By locator) => BrowserWait.Until(ExpectedConditions.ElementIsVisible(locator));
        public static IWebElement WaitUntilClickable(By locator) => BrowserWait.Until(ExpectedConditions.ElementToBeClickable(locator));

        public static void StartBrowser(Platforms platform = Platforms.Desktop, BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 10)
        {
            switch (platform)
            {
                case (Platforms.Desktop):
                    switch (browserType)
                    {
                        case BrowserTypes.Firefox:
                            Browser = new FirefoxDriver();
                            FirefoxProfile profile = new FirefoxProfile();
                            profile.SetPreference("general.useragent.override", "Mozilla/5.0 (compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm)");

                           
                            



                            break;
                        case BrowserTypes.InternetExplorer:
                            Browser = new InternetExplorerDriver();
                            break;
                        case BrowserTypes.Chrome:
                            ChromeOptions options = new ChromeOptions();
                           // options.AddArgument("--user-agent=RiverModal/1.0.0 Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36");
                            options.AddUserProfilePreference("profile.default_content_setting_values.plugins", 1);
                            options.AddUserProfilePreference("profile.content_settings.plugin_whitelist.adobe-flash-player", 1);
                            options.AddUserProfilePreference("profile.content_settings.exceptions.plugins.*,*.per_resource.adobe-flash-player", 1);
                            options.AddArgument("-disable-features=RendererCodeIntegrity");
                            options.AddUserProfilePreference("PluginsAllowedForUrls", "http:/ ");
                            options.AddUserProfilePreference("PluginsAllowedForUrls", TestDataResource.MainPageURL);
                            Browser = new ChromeDriver(options);
                            break;
                        case BrowserTypes.Edge:
                            Browser = new EdgeDriver();
                            break;
                        default:
                            Browser = new ChromeDriver();
                            break;
                    }
                    BrowserWait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(defaultTimeOut));
                    break;
            }
        }

        //public static void StartDeviceAndroid(Platforms platform = Platforms.Android, BrowserTypes browserTypes = BrowserTypes.Chrome, int defaultTimeOut = 30)
        //{
        //    var options = new ChromeOptions();
        //    options.PlatformName = "Android";
        //    options.AddAdditionalCapability("deviceName", "Samsung s7");
        //    options.AddAdditionalCapability("platformVersion", "8.0");
        //    options.AddAdditionalCapability("newCommandTimeout", 600);
        //    options.AddAdditionalCapability("idleTimeout", 900);

        //    //var driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), options.ToCapabilities());
        //}


        public static void StartWebEmulatorMob(Platforms platform = Platforms.WebEmulatorMob, int defaultTimeOut = 15)
        {

            ChromeOptions options = new ChromeOptions();
            options.EnableMobileEmulation("iPad");
            options.AddArgument("start-maximized");
            Browser = new ChromeDriver(options);
            BrowserWait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(defaultTimeOut));


        }





        public static void TakeScreenshot()
        {
            try
            {
                Thread.Sleep(1500);
                string screensLocation = AppDomain.CurrentDomain.BaseDirectory;
                string testName = TestContext.CurrentContext.Test.Name;
                var screenshot = ((ITakesScreenshot)Driver.Browser).GetScreenshot();
                screenshot.SaveAsFile(screensLocation + testName + "_" + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".png");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public static void DisposeBrowser()
        {
            
            if (Driver.Browser != null)
            {
                Browser.Quit();
                Browser = null;
                BrowserWait = null;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        //[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
        //public class RetryDynamicAttribute : RetryAttribute
        //{
        //    private const int DEFAULT_TRIES = 1;
        //    static Lazy<int> numberOfRetries = new Lazy<int>(() =>
        //    {
        //        int count = 0;
        //        return int.TryParse(ConfigurationManager.AppSettings["retryTest"], out count) ? count : DEFAULT_TRIES;
        //    });

        //    public RetryDynamicAttribute() :
        //        base(numberOfRetries.Value)
        //    {
        //    }



    }
        

}


