using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;


namespace Exc2_Automation
{
   public class Program 
    {
        #region
        By CreateNewAccount = By.PartialLinkText("nueva");
        By FirstNameField = By.Name("firstname");
        By LastNameField = By.Name("lastname");
        By MobileNumberField = By.Name("reg_email__");
        By NewPwdField = By.Id("password_step_input");
        By BirthdayDay = By.Name("birthday_day");
        By BirthdayMonth = By.Name("birthday_month");
        By BirthdayYear = By.Name("birthday_year");
        By GenderFem = By.XPath("//*[@id='u_2_o_wW']/span[1]");
        By SelectDayOfBirth = By.XPath("//*[@id='day']/option[27]");
        By SelectMonthOfBirth = By.XPath("//*[@id='month']/option[9]");
        By SelectYearOfBirth = By.XPath("//*[@id='year']/option[9]");
        #endregion
        static void Main(string[] args)
        {

            IWebElement element;
            IWebDriver driver = new ChromeDriver("C:\\chrome.driver");
            Program program = new Program();
            Browser browser = new Browser();
            driver = browser.SetUpDriver();
            driver.Url = "https://www.facebook.com/";

            

            var element1 = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[1]/h2"));
            Assert.IsTrue(element1.Displayed);
            Console.WriteLine("The Text :", element1, "is the same as the log in screen");


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            
            element = driver.FindElement(program.CreateNewAccount);
            browser.Click(element);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            element = driver.FindElement(program.FirstNameField);
            browser.EnterText(element, "Rodrigo Alonso");


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            element = driver.FindElement(program.LastNameField);
            browser.EnterText(element, "Alfaro");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            element = driver.FindElement(program.MobileNumberField);
            browser.EnterText(element, "1234567890");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            element = driver.FindElement(program.NewPwdField);
            browser.EnterText(element, "Unosquare090921");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            element = driver.FindElement(program.BirthdayDay);
            browser.Click(element);
            element = driver.FindElement(program.SelectDayOfBirth);
            browser.Click(element);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            element = driver.FindElement(program.BirthdayMonth);
            browser.Click(element);
            element = driver.FindElement(program.SelectMonthOfBirth);
            browser.Click(element);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            element = driver.FindElement(program.BirthdayYear);
            browser.Click(element);
            element = driver.FindElement(program.SelectYearOfBirth);
            browser.Click(element);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            element = driver.FindElement(program.GenderFem);
            browser.Click(element);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var tittle2 = driver.FindElement(By.XPath("//*[@id='facebook']/head/meta[7]"));
            Assert.IsTrue(tittle2.Displayed);
            Console.WriteLine("Inicia sesión en Facebook para empezar a compartir y conectarte con tus amigos, tus familiares y las personas que conoces.");


        }
    }
}
