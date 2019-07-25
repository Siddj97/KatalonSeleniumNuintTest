using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Testcase2
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void localhostTest_inputFordMustang2012_ExpectedOutputJDPowerCarURL()
        {
            driver.Navigate().GoToUrl("http://localhost/CarsWeb/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='SEARCH'])[1]/preceding::button[1]")).Click();
            driver.FindElement(By.Name("clientname")).Click();
            driver.FindElement(By.Name("clientname")).Clear();
            driver.FindElement(By.Name("clientname")).SendKeys("singh");
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("waterloo");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("waterloo");
            driver.FindElement(By.Name("phonenumber")).Clear();
            driver.FindElement(By.Name("phonenumber")).SendKeys("123-123-1212");
            driver.FindElement(By.Name("carmade")).Click();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("sfa@gm.com");
            driver.FindElement(By.Name("carmade")).Clear();
            driver.FindElement(By.Name("carmade")).SendKeys("Ford");
            driver.FindElement(By.Name("carmodel")).Clear();
            driver.FindElement(By.Name("carmodel")).SendKeys("Mustang");
            driver.FindElement(By.Name("caryear")).Clear();
            driver.FindElement(By.Name("caryear")).SendKeys("2012");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='CarMadeBy'])[1]/following::td[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='CarYear'])[1]/following::input[2]")).Click();
            driver.FindElement(By.Id("carLink")).Click();
            Assert.AreEqual("Select a 2012 Ford Mustang trim level (2)", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Select Trim'])[1]/following::h2[1]")).Text);
        }

        [Test]
        public void localhostTest_inputEmailnull_ExpectedOutputAlertBox()
        {
            driver.Navigate().GoToUrl("http://localhost/CarsWeb/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='SEARCH'])[1]/preceding::button[1]")).Click();
            driver.FindElement(By.Name("clientname")).Click();
            driver.FindElement(By.Name("clientname")).Clear();
            driver.FindElement(By.Name("clientname")).SendKeys("Ron");
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("Nocker st.");
            driver.FindElement(By.Name("city")).Click();
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("Brussels");
            driver.FindElement(By.Name("phonenumber")).Click();
            driver.FindElement(By.Name("phonenumber")).Clear();
            driver.FindElement(By.Name("phonenumber")).SendKeys("444-888-9997");
            driver.FindElement(By.Name("carmade")).Click();
            driver.FindElement(By.Name("carmade")).Clear();
            driver.FindElement(By.Name("carmade")).SendKeys("Mer");
            driver.FindElement(By.Name("carmade")).SendKeys(Keys.Down);
            driver.FindElement(By.Name("carmade")).Clear();
            driver.FindElement(By.Name("carmade")).SendKeys("Mercedes Benz");
            driver.FindElement(By.Name("carmodel")).Click();
            driver.FindElement(By.Name("carmodel")).Clear();
            driver.FindElement(By.Name("carmodel")).SendKeys("G63 AMG");
            driver.FindElement(By.Name("caryear")).Click();
            driver.FindElement(By.Name("caryear")).Clear();
            driver.FindElement(By.Name("caryear")).SendKeys("2017");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='CarYear'])[1]/following::input[2]")).Click();
            Assert.AreEqual("", driver.FindElement(By.Name("email")).Text);
        }

        [Test]
        public void localhostTest_inputMercedesBenzGClass2018_ExpectedOutputJDPowerCarURL()
        {
            driver.Navigate().GoToUrl("http://localhost/CarsWeb/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='SEARCH'])[1]/preceding::button[1]")).Click();
            driver.FindElement(By.Name("clientname")).Click();
            driver.FindElement(By.Name("clientname")).Clear();
            driver.FindElement(By.Name("clientname")).SendKeys("xyz");
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("xyz");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("xyz");
            driver.FindElement(By.Name("phonenumber")).Clear();
            driver.FindElement(By.Name("phonenumber")).SendKeys("123-123-1231");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("xyz@xyz.com");
            driver.FindElement(By.Name("carmade")).Clear();
            driver.FindElement(By.Name("carmade")).SendKeys("Mercedes Benz");
            driver.FindElement(By.Name("carmodel")).Clear();
            driver.FindElement(By.Name("carmodel")).SendKeys("G Class");
            driver.FindElement(By.Name("caryear")).Clear();
            driver.FindElement(By.Name("caryear")).SendKeys("2018");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='CarYear'])[1]/following::input[2]")).Click();
            driver.FindElement(By.Id("carLink")).Click();
            Assert.AreEqual("Select a 2018 Mercedes-Benz G-Class trim level (4)", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='See less'])[1]/following::h2[1]")).Text);
        }


        [Test]
        public void localhostTest_inputSubmitButtonDisplay_ExpectedOutputDisplayDataToBeRegisted()
        {
            driver.Navigate().GoToUrl("http://localhost/CarsWeb/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='SEARCH'])[1]/preceding::button[1]")).Click();
            driver.FindElement(By.Name("clientname")).Click();
            driver.FindElement(By.Name("clientname")).Clear();
            driver.FindElement(By.Name("clientname")).SendKeys("abc");
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("abc");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("abc");
            driver.FindElement(By.Name("phonenumber")).Clear();
            driver.FindElement(By.Name("phonenumber")).SendKeys("123-123-1231");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("wer@gamil.com");
            driver.FindElement(By.Name("carmade")).Clear();
            driver.FindElement(By.Name("carmade")).SendKeys("Ford");
            driver.FindElement(By.Name("carmodel")).Clear();
            driver.FindElement(By.Name("carmodel")).SendKeys("Explorer");
            driver.FindElement(By.Name("caryear")).Clear();
            driver.FindElement(By.Name("caryear")).SendKeys("2018");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='CarYear'])[1]/following::input[2]")).Click();
            Assert.AreEqual("Carmade=Ford", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='City=abc'])[1]/following::li[1]")).Text);
        }

        [Test]
        public void localhostTest_inputSubmitButton_ExpectedOutputAllSavedData()
        {
            driver.Navigate().GoToUrl("http://localhost/CarsWeb/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='NEW'])[1]/following::button[1]")).Click();
            Assert.AreEqual("Address", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Seller_name'])[1]/following::th[1]")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
