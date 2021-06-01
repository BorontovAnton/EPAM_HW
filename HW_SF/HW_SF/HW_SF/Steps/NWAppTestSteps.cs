using HW_SEL_ADV.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HW_SF.Steps
{
    [Binding]
    public class NWAppTestSteps
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
        }
        
        [When(@"I type name and password")]
        public void WhenITypeNameAndPassword()
        {
            new LoginPage(driver).inputLogin();
        }
        
        [When(@"i check login")]
        public void WhenICheckLogin()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("(//a[@href='/Account/Logout'])")).Text.Contains("Logout"));
        }
        
        [When(@"I click on all products button")]
        public void WhenIClickOnAllProductsButton()
        {
            new HomePage(driver).allProductsClick();
        }
        
        [When(@"I click on create new button")]
        public void WhenIClickOnCreateNewButton()
        {
            new ProductsPage(driver).productEditing();
        }
        
        [When(@"I enter parameters in to fields")]
        public void WhenIEnterParametersInToFields()
        {
            new ProductEditing(driver).sendProduct();
        }
        
        [When(@"I click on new product")]
        public void WhenIClickOnNewProduct()
        {
            new ProductsPage(driver).productCheck();
        }
        
        [When(@"I check product parameters")]
        public void WhenICheckProductParameters()
        {
            Assert.AreEqual("Gobies in tomato", driver.FindElement(By.XPath("//input[@id='ProductName']")).GetAttribute("value"));
            Assert.IsTrue(driver.FindElement(By.XPath("//select[@id='CategoryId']/option[@selected]")).Text.Contains("Seafood"));
            Assert.IsTrue(driver.FindElement(By.XPath("//select[@id='SupplierId']/option[@selected]")).Text.Contains("Exotic Liquids"));
            Assert.AreEqual("100,0000", driver.FindElement(By.XPath("//input[@id='UnitPrice']")).GetAttribute("value"));
            Assert.AreEqual("1000", driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']")).GetAttribute("value"));
            Assert.AreEqual("10", driver.FindElement(By.XPath("//input[@id='UnitsInStock']")).GetAttribute("value"));
            Assert.AreEqual("5", driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']")).GetAttribute("value"));
            Assert.AreEqual("1", driver.FindElement(By.XPath("//input[@id='ReorderLevel']")).GetAttribute("value"));
        }
        
        [When(@"I logout")]
        public void WhenILogout()
        {
            new ProductEditing(driver).Logout();
        }
        
        [Then(@"end test")]
        public void ThenEndTest()
        {
            driver.Quit();
        }
    }
}
