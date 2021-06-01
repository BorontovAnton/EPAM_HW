using HW_SEL_FW.dto;
using HW_SEL_FW.service;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SEL_ADV.pages
{
    class LoginPage : AbstractPage
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='Name']")]
        private IWebElement userString;

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        private IWebElement passString;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement btnSubmit;

        public HomePage inputLogin()
        {
            //UserLogIn.UserData(userString, passString);
            new Actions(driver).Click(userString).SendKeys("user").Build().Perform();
            new Actions(driver).Click(passString).SendKeys("user").Build().Perform();
            btnSubmit.Click();
            return new HomePage(driver);

        }

        public void InputName(string userStr)
        {
            UserLogIn.UserName(userString);
        }

        public void InputPass(string passStr)
        {
            UserLogIn.UserName(passString);
        }

        public void SubmitBtnClick()
        {
            btnSubmit.Click();
        }
    }
}
