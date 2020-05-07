using AppiumDotNet.Fixture;
using AppiumDotNet.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Xunit;

namespace AppiumDotNet.Tests
{
    [Collection("Appium")]
    public class CalculatorTests : IClassFixture<TestFixture>
    {
        
        public AppiumDriver<IWebElement> driver;
        public CalculatorPO calc;

        public CalculatorTests(TestFixture fixture)
        {
            driver = fixture.driver;
            calc = new CalculatorPO(driver);
        }

        [Fact]
        public void Test1()
        {
            calc.number1Btn.Click();
            calc.plusSignBtn.Click();
            calc.number2Btn.Click();

            calc.equalSignBtns.Click();

            string calcResult = calc.resultFieldEdt.Text;
            Assert.Contains("3", calcResult);
        }

    }
}
