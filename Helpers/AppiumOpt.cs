using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumDotNet.Helpers
{
    public class AppiumOpt
    {

        public AppiumOpt()
        {
        }

        public AppiumOptions GetAppiumOpt()
        {
            AppiumOptions capabilities = new AppiumOptions();

            capabilities.AddAdditionalCapability("platformName", "Android");
            capabilities.AddAdditionalCapability("deviceName", "Android Emulator");
            capabilities.AddAdditionalCapability("app", "C:\\Apk\\Calc.apk");
            capabilities.AddAdditionalCapability("apppackage", "com.google.android.calculator");
            //capabilities.AddAdditionalCapability("avd", "Pixel_3");

            return capabilities;
        }


    }
}
