using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;
using AutoItX3Lib;
using NUnit.Framework;
using SpecflowPages.PageDetails;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class ListARentalSteps
    {
        [Given(@"I am in My properties page")]
        public void GivenIAmInMyPropertiesPage()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]")).Click();

        }

        [When(@"I entered detais for renting")]
        public void WhenIEnteredDetaisForRenting()
        {
            Thread.Sleep(1000);
            ListRentalDetails.ListRental();
           

        }

        [Then(@"I should be able to list it")]
        public void ThenIShouldBeAbleToListIt()
        {

            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("List A Rental");
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
