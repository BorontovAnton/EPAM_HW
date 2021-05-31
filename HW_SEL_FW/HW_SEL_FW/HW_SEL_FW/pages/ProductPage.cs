using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SEL_ADV.pages
{
    class ProductsPage : AbstractPage
    {
        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = ("//a[@class='btn btn-default']"))]
        private IWebElement createBtn;

        [FindsBy(How = How.XPath, Using = ("//a[contains(text(),'Gobies in tomato')]"))]
        private IWebElement testProduct;


        public ProductEditing productEditing()
        {
            createBtn.Click();
            return new ProductEditing(driver);
        }

        public ProductEditing productCheck()
        {
            testProduct.Click();
            return new ProductEditing(driver);
        }



    }
}
