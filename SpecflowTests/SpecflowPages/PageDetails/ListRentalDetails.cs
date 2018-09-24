using AutoItX3Lib;
using OpenQA.Selenium;
using System.Threading;
using System.Threading.Tasks;

namespace SpecflowPages.PageDetails
{
    public class ListRentalDetails
    {
        public static void ListRental()
        {
            Thread.Sleep(1000);
            //Driver.driver.FindElement(By.XPath("//*[@id='main - content]/div/div[1]/div/div[2]/div/div[2]/a[1]")).Click();
            Driver.driver.FindElement(By.XPath("//div[@id='main-content']/div/div/div/div[2]/div/div[2]/a")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.CssSelector("#main-content > div > form > fieldset > div.field > select")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.CssSelector("#main-content > div > form > fieldset > div.field > select > option:nth-child(493)")).Click();
            Driver.driver.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(4) > div:nth-child(1) > input[type='text']:nth-child(2)")).SendKeys("House for rent");
            Driver.driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys("1600");
            Driver.driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys("235");
            Driver.driver.FindElement(By.Name("AvailableDate")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//div[@id='main-content']/div/form/fieldset/div[5]/div/div/ul/li/div/div/table/tbody/tr[4]/td[2]")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[6]/div[1]/input")).SendKeys("2");
            Driver.driver.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(4) > div:nth-child(2) > textarea")).SendKeys("Single bedroom house for rent");
            Driver.driver.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(5) > div:nth-child(2) > input[type='text']")).SendKeys("yes");
            Driver.driver.FindElement(By.CssSelector("#main-content > div > form > fieldset > div:nth-child(6) > div:nth-child(2) > input[type='text']")).SendKeys("Students");
            // photo upload
            IWebElement fileupload = Driver.driver.FindElement(By.CssSelector("#file-upload"));
            fileupload.Click();
            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("Open");
            autoit.Send(@"C:\Users\house-1429409_640.png");
            Thread.Sleep(1000);
            autoit.Send("{Enter}");
            Thread.Sleep(1000);

            Driver.driver.FindElement(By.CssSelector("#main-content > div > form > fieldset > div.ui.grid > div > button.teal.ui.button")).Click();

            Thread.Sleep(1000);
            IAlert alert = Driver.driver.SwitchTo().Alert();
            alert.Accept();
            Thread.Sleep(1000);


        }
    }
}
