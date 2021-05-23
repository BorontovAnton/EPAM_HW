using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SEL_ADV.pages
{
    class HomePage : AbstractPage
    {
        public HomePage (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='/Product']")]
        private IWebElement allProduct;

        public ProductsPage allProductsClick()
        {
            allProduct.Click();
            return new ProductsPage(driver);
        }



    }
}
