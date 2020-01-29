using System;

using AventStack.ExtentReports.Reporter;

using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace AventStack.ExtentReports.Tests
{
    [SetUpFixture]
    public abstract class Base
    {
        protected ExtentReports _extent;
        protected ExtentTest _test;

        [OneTimeSetUp]
        protected void Setup()
        {
            string dir = TestContext.CurrentContext.TestDirectory + "\\";
            var fileName = this.GetType().ToString() + ".html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dir + fileName);

            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            Console.WriteLine("in teardown");
            _extent.Flush();
        }

        [SetUp]
        public void BeforeTest()
        {
            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void AfterTest()
        {
            
        }
    }
}






