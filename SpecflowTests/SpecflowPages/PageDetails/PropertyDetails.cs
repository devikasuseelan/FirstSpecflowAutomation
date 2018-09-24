using AutoItX3Lib;
using OpenQA.Selenium;
using System.Threading;
using System.Threading.Tasks;

namespace SpecflowPages.Utils
{
    public class PropertyDetails
    {
        public static void Details()
        {
            Driver.driver.FindElement(By.Name("propertyName")).SendKeys("class");
            Driver.driver.FindElement(By.Id("autocomplete")).SendKeys("107 Balmoral Road, Mount Eden,Auckland, 1024");
            Driver.driver.FindElement(By.XPath("//*[@id='street_number']")).SendKeys("107");
            Driver.driver.FindElement(By.XPath("//*[@id='route']")).SendKeys("Balmoral Road");
            Driver.driver.FindElement(By.XPath("(//input[@id='route'])[2]")).SendKeys("Mount Eden");
            Driver.driver.FindElement(By.XPath("(//input[@id='street_number'])[2]")).SendKeys("Mount Eden");
            Driver.driver.FindElement(By.XPath("(//input[@id='street_number'])[3]")).SendKeys("1024");
            Driver.driver.FindElement(By.Id("region")).SendKeys("Auckland");
            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(5) > div > div:nth-child(1) > div.ui.input.full.width > input[type='text']")).SendKeys("350");
            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(6) > div:nth-child(1) > div > input[type='text']")).SendKeys("25");
            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(7) > div:nth-child(1) > div.ui.input.full.width > input[type=text]")).SendKeys("2");
            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(8) > div:nth-child(1) > div.ui.input.full.width > input[type=text]")).SendKeys("1");
            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(8) > div:nth-child(1) > div.ui.input.full.width > input[type=text]")).SendKeys("1");
            Driver.driver.FindElement(By.XPath("//*[@id='property-details']/div[3]/div[2]/div[1]/textarea")).SendKeys("Two bed room house for rent");
            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(5) > div > div:nth-child(2) > div")).Click();
            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(6) > div:nth-child(2) > div > input[type=text]")).SendKeys("1500");
            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(7) > div:nth-child(2) > div.ui.input.full.width > input[type=text]")).SendKeys("1");
            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(8) > div:nth-child(2) > div.ui.input.full.width > input[type=text]")).SendKeys("2003");

            Driver.driver.FindElement(By.CssSelector("#property-details > div:nth-child(9) > div > input")).Click();
            IWebElement fileupload = Driver.driver.FindElement(By.CssSelector("#file-upload"));
            // fileupload.SendKeys(@"C:\Users\Vishwam\Downloads\house-1429409_640");//
            fileupload.Click();
            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("Open");
            autoit.Send(@"C:\Users\house-1429409_640.png");
            Thread.Sleep(1000);
            autoit.Send("{Enter}");
            Driver.driver.FindElement(By.CssSelector("#property-details > div.ui.grid > div > button.ui.teal.button")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Name("purchasePrice")).SendKeys("400000");
            Driver.driver.FindElement(By.Name("mortgagePrice")).SendKeys("300000");
            Driver.driver.FindElement(By.XPath("//*[@id='financeSection']/div[1]/div[3]/div[1]/input")).SendKeys("350000");
            Driver.driver.FindElement(By.XPath("//*[@id='financeSection']/div[8]/button[2]")).Click();

        }
    }
}
