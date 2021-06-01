using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_SEL_ADV.pages
{
    class ProductEditing : AbstractPage
    {
        public ProductEditing(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ProductName")]
        private IWebElement productName;

        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement unitPrice;

        [FindsBy(How = How.Id, Using = "QuantityPerUnit")]
        private IWebElement quantityPerUnit;

        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        private IWebElement unitsInStock;

        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        private IWebElement unitsOnOrder;

        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        private IWebElement reorderLevel;

        [FindsBy(How = How.XPath, Using = "//input[@class='btn btn-default']")]
        private IWebElement sendBtn;

        [FindsBy(How = How.XPath, Using = ("//a[contains(text(),'Logout')]"))]
        private IWebElement logoutBtn;


        public ProductsPage sendProduct(String nameProd, String uPrice, String qPerUn, String uInStock, String uOnOrder, String rLevel)
        {
            new Actions(driver).Click(productName).SendKeys(nameProd).Build().Perform();
            driver.FindElement(By.XPath("//select[@id='SupplierId']/option[@value='1']")).Click();
            driver.FindElement(By.XPath("//select[@id='CategoryId']/option[@value='8']")).Click();
            new Actions(driver).Click(unitPrice).SendKeys(uPrice).Build().Perform();
            new Actions(driver).Click(quantityPerUnit).SendKeys(qPerUn).Build().Perform();
            new Actions(driver).Click(unitsInStock).SendKeys(uInStock).Build().Perform();
            new Actions(driver).Click(unitsOnOrder).SendKeys(uOnOrder).Build().Perform();
            new Actions(driver).Click(reorderLevel).SendKeys(rLevel).Build().Perform();
            sendBtn.Click();
            return new ProductsPage(driver);
        }

        public LoginPage Logout()
        {
            logoutBtn.Click();
            return new LoginPage(driver);

        }

    }



}
