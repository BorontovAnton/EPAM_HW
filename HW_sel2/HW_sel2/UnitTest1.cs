using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_test
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;

        [OneTimeSetUp]

        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
            IWebElement nameStr = driver.FindElement(By.XPath("//input[@id='Name']"));
            IWebElement passStr = driver.FindElement(By.XPath("//input[@id='Password']"));
            IWebElement btnSubmit = driver.FindElement(By.XPath("//input[@type='submit']"));
            nameStr.SendKeys("user");
            passStr.SendKeys("user");
            btnSubmit.Click();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("(//a[@href='/Account/Logout'])")).Text.Contains("Logout"));
        }

        [Test]

        public void Test2()
        {
            IWebElement allproducts = driver.FindElement(By.XPath("//a[@href='/Product']"));
            allproducts.Click();
            IWebElement createnew = driver.FindElement(By.XPath("//a[@class='btn btn-default']"));
            createnew.Click();
            driver.FindElement(By.XPath("//input[@id='ProductName']")).SendKeys("Бычки в томате");
            driver.FindElement(By.XPath("//select[@id='SupplierId']/option[@value='1']")).Click();
            driver.FindElement(By.XPath("//select[@id='CategoryId']/option[@value='8']")).Click();
            driver.FindElement(By.XPath("//input[@id='UnitPrice']")).SendKeys("100");
            driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']")).SendKeys("10");
            driver.FindElement(By.XPath("//input[@id='UnitsInStock']")).SendKeys("5");
            driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']")).SendKeys("3");
            driver.FindElement(By.XPath("//input[@id='ReorderLevel']")).SendKeys("1");
            driver.FindElement(By.XPath("//input[@class='btn btn-default']")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//a[contains(text(),'Бычки в томате')]")).Text.Contains("Бычки в томате"));

        }

        [Test]
        public void Test3()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Бычки в томате')]")).Click();
            Assert.AreEqual("Бычки в томате", driver.FindElement(By.XPath("//input[@id='ProductName']")).GetAttribute("value"));
            Assert.IsTrue(driver.FindElement(By.XPath("//select[@id='CategoryId']/option[@selected]")).Text.Contains("Seafood"));
            Assert.IsTrue(driver.FindElement(By.XPath("//select[@id='SupplierId']/option[@selected]")).Text.Contains("Exotic Liquids"));
            Assert.AreEqual("100,0000", driver.FindElement(By.XPath("//input[@id='UnitPrice']")).GetAttribute("value"));
            Assert.AreEqual("10", driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']")).GetAttribute("value"));
            Assert.AreEqual("5", driver.FindElement(By.XPath("//input[@id='UnitsInStock']")).GetAttribute("value"));
            Assert.AreEqual("3", driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']")).GetAttribute("value"));
            Assert.AreEqual("1", driver.FindElement(By.XPath("//input[@id='ReorderLevel']")).GetAttribute("value"));

        }

        [Test]
        public void Test4()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//h2['Login']")).Text.Contains("Login"));
        }


    }
}