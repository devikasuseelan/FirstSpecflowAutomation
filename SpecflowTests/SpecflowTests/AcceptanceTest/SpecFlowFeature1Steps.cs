using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using SpecflowTests.Utils;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests 
{
    [Binding]
    public class SpecFlowFeature1Steps 
    {
        [Given(@"I clicked on the Your Properties page")]
        public void GivenIClickedOnTheYourPropertiesPage()
        {
            // Click on the Skip button
            Driver.driver.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]")).Click();
            Thread.Sleep(1000);
            //Click on the Owners tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]")).Click();

            //Click on the your Properties page
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]")).Click();
        }


        [When(@"I search for a property by its (.*)")]
        public void WhenISearchForAPropertyByItsSaniya(string p0)
        {
            //Wait
            Thread.Sleep(1000);

            //Search for property
            Driver.driver.FindElement(By.XPath("//*[@id='SearchBox']")).SendKeys(p0);

            //Click on Search button
            Driver.driver.FindElement(By.XPath("//*[@id='icon-submitt']")).Click();
        }

        [Then(@"I property should appear in the search list")]
        public void ThenIPropertyShouldAppearInTheSearchList()
        {

            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Search a property");


            //Check if the property appears
           // try
           // {
                string ActualResult = "saniya";
                string ExpectedResult = Driver.driver.FindElement(By.PartialLinkText("saniya")).Text;
                Thread.Sleep(500);

                if (ActualResult == ExpectedResult)
                {

                    Thread.Sleep(1000);
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SearchProp");
                }
           // }
           // catch (Exception)
           else
            {
                Console.WriteLine("Property not present");

                Console.WriteLine("Test Failed");
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SearchProp");
            }


          // finally
           //{
               
               // Driver.Close();
           //}

        }
    }
}

