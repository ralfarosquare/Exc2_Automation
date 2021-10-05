using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exc2_Automation
{
    public class Browser
    {
        
        IWebDriver driver;
        public IWebDriver SetUpDriver()
        {

            driver = new ChromeDriver("C:\\chrome.driver");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            return driver;
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public void Enter(IWebElement element)
        {
            element.SendKeys("{ENTER}");
        }

       

    }
}

