using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumDotNet.PageObjects
{
    public class CalculatorPO
    {
        
        public AppiumDriver<IWebElement> driver;

        public CalculatorPO(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }

        public IWebElement number1Btn => driver.FindElement(By.Id("digit_1"));
        public IWebElement number2Btn => driver.FindElement(By.Id("digit_2"));
        public IWebElement number3Btn => driver.FindElement(By.Id("digit_3"));
        public IWebElement number4Btn => driver.FindElement(By.Id("digit_4"));
        public IWebElement number5Btn => driver.FindElement(By.Id("digit_5"));
        public IWebElement number6Btn => driver.FindElement(By.Id("digit_6"));
        public IWebElement number7Btn => driver.FindElement(By.Id("digit_7"));
        public IWebElement number8Btn => driver.FindElement(By.Id("digit_8"));
        public IWebElement number9Btn => driver.FindElement(By.Id("digit_9"));
        public IWebElement plusSignBtn => driver.FindElement(By.Id("op_add"));
        public IWebElement equalSignBtns => driver.FindElement(By.Id("eq"));
        public IWebElement resultFieldEdt => driver.FindElement(By.Id("result_final"));


    }
}
