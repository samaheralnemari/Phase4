using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver())
            {
                //Selenium - Check if method retrive Menu
                driver.Navigate().GoToUrl(@"localhost");
                var PizzName = driver.PageSource.Contains("Veggie");
                Assert.IsNotNull(PizzName);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            using (var driver = new ChromeDriver())
            {
                //Selenium - Check if method retrive Menu
                driver.Navigate().GoToUrl(@"localhost");
                var confirmationButton = driver.FindElementById("checkout");
                confirmationButton.Click();
            }
        }
    }
}
