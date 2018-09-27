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
    public class SpecFlowFeature1Steps : Start
    {
        [Given(@"I have entered my individual happiness level")]
        public void GivenIHaveEnteredMyIndividualHappinessLevel()
        {
            // Click on the Emotion

            // Commenting out the selection of emotion until further development
            //Driver.driver.FindElement(By.XPath("//img[@src='images/Angry.jpg']")).Click();

            Thread.Sleep(1000);
        }
        [When(@"I press on the submit button (.*)")]
        public void WhenIPressOnTheSubmitButtonVeryHappy(string p0)
        {
            //Click on Submit button

            //Commenting out submit functionality until further development
            //Driver.driver.FindElement(By.XPath("//*[@id='icon-submitt']")).Click();

            //Checking with the clicking of an image
            Driver.driver.FindElement(By.XPath("//img[@src='images/" + p0 + ".jpg']")).Click();
        }

        
        [Then(@"the hapiness level information should be submitted")]
        public void ThenTheHapinessLevelInformationShouldBeSubmitted()
        {
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Submit Happiness Level");

            //wait
            Thread.Sleep(1000);
            string ActualResult = "Your individual feeling has been successfully logged!";
            string ExpectedResult = Driver.driver.FindElement(By.XPath("//h3[contains(.,'Your individual feeling has been successfully logged!')]")).Text;
            Thread.Sleep(500);
            //Check if the confirmation is displayed             
            if (ActualResult == ExpectedResult)
            {
                Thread.Sleep(1000);
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "IndividualSubmitted");
            }
            else
            {

                Console.WriteLine("Test Failed");
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }
        }



        [When(@"I press on the Cancel button")]
        public void WhenIPressOnTheCancelButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the happiness level selection should not be submitted and saved")]
        public void ThenTheHappinessLevelSelectionShouldNotBeSubmittedAndSaved()
        {
            ScenarioContext.Current.Pending();
        }



        [When(@"I change the initial selection")]
        public void WhenIChangeTheInitialSelection()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the new selection is activated")]
        public void ThenTheNewSelectionIsActivated()
        {
            ScenarioContext.Current.Pending();
        }




        [When(@"I press on the submit button")]
        public void WhenIPressOnTheSubmitButton()
        {
            //Click on Submit button

            //Commenting out submit functionality until further development
            //Driver.driver.FindElement(By.XPath("//*[@id='icon-submitt']")).Click();

            //Checking with the clicking of an image
            Driver.driver.FindElement(By.XPath("//img[@src='images/Angry.jpg']")).Click();
        }

    }
}
