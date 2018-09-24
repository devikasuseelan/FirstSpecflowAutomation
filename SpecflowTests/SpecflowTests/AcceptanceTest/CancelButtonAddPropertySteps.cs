using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;
using SpecflowPages.Utils;
using NUnit.Framework;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class CancelButtonAddPropertySteps
    {
        [Given(@"I am in the add property page")]
        public void GivenIAmInTheAddPropertyPage()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]")).Click();

        }

        [When(@"I clicked the cancel button")]
        public void WhenIClickedTheCancelButton()
        {
            //click on Add property
            Driver.driver.FindElement(By.CssSelector("#main-content > div > div:nth-child(1) > div > div:nth-child(4) > div > div.middle.aligned.eight.wide.column > a:nth-child(2)")).Click();
            Thread.Sleep(1000);
            //Click on cancel 
            Driver.driver.FindElement(By.CssSelector("#property-details > div.ui.grid > div > button:nth-child(2)")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//*[@id='myModal']/div/div/div[3]/button[1]")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"I must be taken to my properties page")]
        public void ThenIMustBeTakenToMyPropertiesPage()
        {
            Thread.Sleep(1000);
            
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Cancel button add Property");
            Thread.Sleep(1000);

            try
            {
                string ActualResult = "My Properties";
                string ExpectedResult = Driver.driver.FindElement(By.LinkText("My Properties")).Text;
                Thread.Sleep(500);

                if (ActualResult == ExpectedResult)
                {

                    Thread.Sleep(1000);
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Element not present");

                Console.WriteLine("Test Failed");
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }


            finally
            {
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SearchProp");

            }


        }
    }
}
