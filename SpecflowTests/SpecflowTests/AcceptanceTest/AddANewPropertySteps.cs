using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using SpecflowTests.Utils;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;
using SpecflowPages.Utils;
using NUnit.Framework;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class AddANewPropertySteps : Start
    {
        [Given(@"I am in the My properties page")]
        
        public void GivenIAmInTheMyPropertiesPage()
        {
            // Click on pop window
            Driver.driver.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]")).Click();
            Thread.Sleep(1000);
            //Click on owners
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]")).Click();
            //Click on properties
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]")).Click();

        }

       

        [When(@"I added a new property")]
        public void WhenIAddedANewProperty()
        {
            //Click on add property
            Driver.driver.FindElement(By.CssSelector("#main-content > div > div:nth-child(1) > div > div:nth-child(4) > div > div.middle.aligned.eight.wide.column > a:nth-child(2)")).Click();
            Thread.Sleep(1000);
            //Add property details
            PropertyDetails.Details();
            
        }


       
        
        [Then(@"I can see it in My properties page")]
        public void ThenICanSeeItInMyPropertiesPage()
        {

            //Thread.Sleep(1000);
            //Assert.That(driver.FindElement(By.PartialLinkText("class")).Displayed);
            //Driver.Close()

           CommonMethods.ExtentReports();
           Thread.Sleep(1000);
           CommonMethods.test = CommonMethods.extent.StartTest("Add a property");
            Thread.Sleep(1000);
            
           //Serach for added property
           Driver.driver.FindElement(By.XPath("//*[@id='SearchBox']")).SendKeys("Class");
           Driver.driver.FindElement(By.XPath("//*[@id='icon-submitt']")).Click();

            try
            {
                string ActualResult = "class";
                string ExpectedResult = Driver.driver.FindElement(By.LinkText("class")).Text;
                //string ExpectedResult = Driver.driver.FindElement(By.LinkText("class")).Text;
                Thread.Sleep(500);

                if (ActualResult == ExpectedResult)
                {

                    Thread.Sleep(1000);
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Property not present");

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
