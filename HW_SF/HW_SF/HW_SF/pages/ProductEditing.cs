using HW_SEL_FW.service;
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

        [FindsBy(How = How.Id, Using = "CategoryId")]
        private IWebElement categoryId;

        [FindsBy(How = How.Id, Using = "SupplierId")]
        private IWebElement supplierId;

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

        public ProductsPage sendProduct()
        {
            InitProduct.ParamProduct(productName, categoryId, supplierId, unitPrice, quantityPerUnit, unitsInStock, unitsOnOrder, reorderLevel);
            sendBtn.Click();
            return new ProductsPage(driver);
        }


        //public ProductsPage sendProduct(String nameProd, String catId, String supId,  String uPrice, String qPerUn, String uInStock, String uOnOrder, String rLevel)
        //{
        //    new Actions(driver).Click(productName).SendKeys(nameProd).Build().Perform();
        //    Thread.Sleep(2000);
        //    new Actions (driver).Click(categoryId).SendKeys(catId).Build().Perform();
        //    Thread.Sleep(2000);
        //    new Actions (driver).Click(supplierId).SendKeys(supId).Build().Perform();
        //    Thread.Sleep(2000);
        //    new Actions(driver).Click(unitPrice).SendKeys(uPrice).Build().Perform();
        //    Thread.Sleep(2000);
        //    new Actions(driver).Click(quantityPerUnit).SendKeys(qPerUn).Build().Perform();
        //    Thread.Sleep(2000);
        //    new Actions(driver).Click(unitsInStock).SendKeys(uInStock).Build().Perform();
        //    Thread.Sleep(2000);
        //    new Actions(driver).Click(unitsOnOrder).SendKeys(uOnOrder).Build().Perform();
        //    Thread.Sleep(2000);
        //    new Actions(driver).Click(reorderLevel).SendKeys(rLevel).Build().Perform();
        //    Thread.Sleep(2000);
        //    sendBtn.Click();
        //    Thread.Sleep(2000);
        //    return new ProductsPage(driver);
        //}

        public LoginPage Logout()
        {
            logoutBtn.Click();
            return new LoginPage(driver);

        }

    }



}