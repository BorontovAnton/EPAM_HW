using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_SEL_FW.dto;
using OpenQA.Selenium;

namespace HW_SEL_FW.service
{
    class UserLogIn
    {
        public static void UserData(IWebElement name, IWebElement pass)
        {
            User user = new User();
            name.SendKeys(user.name);
            pass.SendKeys(user.pass);
        }
    }
}
