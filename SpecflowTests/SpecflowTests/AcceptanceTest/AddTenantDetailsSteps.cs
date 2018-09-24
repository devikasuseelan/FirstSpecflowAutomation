using SpecflowTests.Utils;
using System;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System.Threading;
using TechTalk.SpecFlow;
using SpecflowPages.Utils;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests
{
    [Binding]
    public class AddATenant
    {
        [Given(@"I am in my properties page")]
        public void GivenIAmInMyPropertiesPage()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]")).Click();

        }

        [Given(@"I searched for a property")]
        public void GivenISearchedForAProperty()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("SearchBox")).SendKeys("class");
            Driver.driver.FindElement(By.Id("icon-submitt")).Click();
        }  


        [When(@"I added tenant details")]
        public void WhenIAddedTenantDetails()
        {
            Driver.driver.FindElement(By.LinkText("Add Tenant")).Click();
            TenantDetails.Details();
        }

        [Then(@"I should get tenant successfuly added message")]
        public void ThenIShouldGetTenantSuccessfulyAddedMessage()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add tenant details");
                string ActualResult = "Tenant Added Successfully";
                IAlert alert = Driver.driver.SwitchTo().Alert();
                string ExpectedResult = alert.Text;
                Thread.Sleep(500);

                if (ActualResult == ExpectedResult)
                {

                    Thread.Sleep(1000);
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Tenant not added");

                Console.WriteLine("Test Failed");
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }


            finally
            {
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SearchProp");
                Driver.Close();
            }

        }
    }
}
