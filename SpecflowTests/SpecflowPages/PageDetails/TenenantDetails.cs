using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecflowPages.Utils
{
   public class TenantDetails
    {
        
        public static void Details()
        {
            Driver.driver.FindElement(By.Name("Email")).SendKeys("asdfg@gmail.com");
            Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[3]/div[2]/div/div"));
            Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[4]/div[1]/div[1]/input")).SendKeys("cdef");
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//input[@type='text'])[3]")).SendKeys("derf");
            Thread.Sleep(2000);
            
            //Driver.driver.FindElement(By.Name("StartDate")).Click();
            //Thread.Sleep(1000);
            IWebElement startDate = Driver.driver.FindElement(By.CssSelector("#BasicDetail > div:nth-child(6) > div:nth-child(1) > div.ui.input.full.width > input[type='text']"));
            Thread.Sleep(2000);
            startDate.Clear();
            Thread.Sleep(2000);
            startDate.SendKeys("20/08/2018");
            Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[5]/div/div/div/ul/li/div/div/table/tbody/tr[3]/td")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Name("EndDate")).Click();
            Driver.driver.FindElement(By.Name("RentAmount")).SendKeys("345");
            Driver.driver.FindElement(By.XPath("//input[@type='text'])[7]")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[7]/div/div/div/ul/li/div/div/table/tbody/tr[3]/td[2]")).Click();
            // new SelectElement(driver.FindElement(By.Name("paymentfrequency"))).SelectByText("Fortnightly");
            Driver.driver.FindElement(By.XPath("//input[@value='Next']")).Click();
            // Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[7]/div[2]/div[1]/div")).Click();
            Driver.driver.FindElement(By.CssSelector("a.button-link")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='LiabilityDetail']/div/div/table/tbody/tr/td/div/div[2]/div[3]")).Click();

            Driver.driver.FindElement(By.XPath("(//input[@type='text'])[8]")).SendKeys("340");
            Driver.driver.FindElement(By.XPath("//*[@id='LiabilityDetail']/div[2]/div/button[2]")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='SummaryDetail']/div[10]/div/button[2]")).Click();
        }
    }
}
