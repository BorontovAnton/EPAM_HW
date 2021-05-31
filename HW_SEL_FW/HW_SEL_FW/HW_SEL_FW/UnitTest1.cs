using HW_SEL_ADV.pages;
using HW_SEL_FW.dto;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace HW_SEL_ADV
{
    public class Tests
    {
        private IWebDriver driver;
        
        [OneTimeSetUp]

        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }


        [Test]
        public void TestLogin()
        {
            LoginPage loginPage = new LoginPage(driver);
            Thread.Sleep(2000);

            HomePage homePage = loginPage.inputLogin();
            Thread.Sleep(2000);


            Assert.IsTrue(driver.FindElement(By.XPath("(//a[@href='/Account/Logout'])")).Text.Contains("Logout"));

        }

        [Test]
        public void TestProduct()
        {
            HomePage homePage = new HomePage(driver);
            Thread.Sleep(2000);

            ProductsPage productsPage = homePage.allProductsClick();
            Thread.Sleep(2000);

            ProductEditing productEditing = productsPage.productEditing();
            Thread.Sleep(2000);

            ProductsPage productsPage1 = productEditing.sendProduct();
            Thread.Sleep(2000);

            Assert.IsTrue(driver.FindElement(By.XPath("//a[contains(text(),'Gobies in tomato')]")).Text.Contains("Gobies in tomato"));
            Thread.Sleep(2000);

        }

        [Test]
        public void TestProductCheck()
        {
            ProductsPage productsPage = new ProductsPage(driver);

            ProductEditing productEditing = productsPage.productCheck();

            Assert.AreEqual("Gobies in tomato", driver.FindElement(By.XPath("//input[@id='ProductName']")).GetAttribute("value"));
            Assert.IsTrue(driver.FindElement(By.XPath("//select[@id='CategoryId']/option[@selected]")).Text.Contains("Seafood"));
            Assert.IsTrue(driver.FindElement(By.XPath("//select[@id='SupplierId']/option[@selected]")).Text.Contains("Exotic Liquids"));
            Assert.AreEqual("100,0000", driver.FindElement(By.XPath("//input[@id='UnitPrice']")).GetAttribute("value"));
            Assert.AreEqual("1000", driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']")).GetAttribute("value"));
            Assert.AreEqual("10", driver.FindElement(By.XPath("//input[@id='UnitsInStock']")).GetAttribute("value"));
            Assert.AreEqual("5", driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']")).GetAttribute("value"));
            Assert.AreEqual("1", driver.FindElement(By.XPath("//input[@id='ReorderLevel']")).GetAttribute("value"));

        }

        [Test]
        public void TestUProductLogout()
        {
            ProductEditing productEditing = new ProductEditing(driver);

            LoginPage loginPage = productEditing.Logout();

            Assert.IsTrue(driver.FindElement(By.XPath("//h2['Login']")).Text.Contains("Login"));

        }
    }
}