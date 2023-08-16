using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Utility
{
    public class Controlhelper
    {
        public static void ButtonClick(By Locator)
        {
            module._driver.FindElement(Locator).Click();
        }

        public static string GetText(By Locator)
        {
            return module._driver.FindElement(Locator).Text;
        }
    }


}
