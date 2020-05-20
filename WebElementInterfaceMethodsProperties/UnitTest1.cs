using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
namespace WebElementInterfaceMethodsProperties
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WebElementDisplayed()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.techexpozed.co.nz";
            var displayLogo = driver.FindElement(By.ClassName("header__logo")).Displayed;
            Console.WriteLine(displayLogo);
            driver.Quit();
        }

        [TestMethod]
        public void WebElementEnabled()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.techexpozed.co.nz";
            var enableLogo = driver.FindElement(By.ClassName("header__logo")).Enabled;
            Console.WriteLine(enableLogo);
            driver.Quit();
        }

        [TestMethod]
        public void WebElementLocation()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.techexpozed.co.nz";
            Point point= driver.FindElement(By.ClassName("header__logo")).Location;
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);
            driver.Quit();
        }

        [TestMethod]
        public void WebElementSelected()
        {
            IWebDriver driver = new FirefoxDriver();
            Actions actions = new Actions(driver);
            driver.Url = "https://www.facebook.com";
            //driver.FindElement(By.Id("u_0_6")).Click();
            //actions.Click(driver.FindElement(By.Id("u_0_6"))).Perform();
            var selected = driver.FindElement(By.Id("u_0_6")).Selected;
            Console.WriteLine(selected);
            Thread.Sleep(2000);
            driver.Quit();
            
        }

    }
}
