using AppiumDotNet.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AppiumDotNet.Fixture
{
    public class TestFixture : IDisposable
    {
        
        public AppiumDriver<IWebElement> driver;
        public AppiumOpt capabilities;

        public TestFixture()
        {
            capabilities = new AppiumOpt();
            
            Uri uri = new Uri("http://127.0.0.1:4723/wd/hub");
            driver = new AndroidDriver<IWebElement>(uri, capabilities.GetAppiumOpt());
        }

        public void Dispose()
        {
            driver.Quit();
        }


    }
}
