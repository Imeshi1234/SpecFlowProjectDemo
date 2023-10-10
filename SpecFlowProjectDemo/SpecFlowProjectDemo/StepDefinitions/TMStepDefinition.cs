using OpenQA.Selenium.Chrome;
using SpecFlowProjectDemo.Pages;
using SpecFlowProjectDemo.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectDemo.StepDefinitions
{
    [Binding]
    public class TMStepDefinition : CommonDriver
    {
        LoginPage loginPageobj = new LoginPage();
        HomePage homePageobj = new HomePage();
        TMPage tmPageobj = new TMPage();


        [BeforeScenario]
        public void SetupDriver()
        {
            //Open chrome browser
            driver = new ChromeDriver();
        }


        [Given(@"user logs into TurnUp Portal")]
        public void GivenUserLogsIntoTurnUpPortal()
        {
            loginPageobj.LoginActions(driver);
            homePageobj.VerifyUserLogin(driver);
            
        }

        [Given(@"user navigates to time and material page")]
        public void GivenUserNavigatesToTimeAndMaterialPage()
        {
            homePageobj.GoToTMPage(driver);
        }
        [When(@"user creates a new time and material racord")]
        public void WhenUserCreatesANewTimeAndMaterialRacord()
        {
            //Create new time record
            tmPageobj.CreateTimeRecord(driver);

        }

        [Then(@"turnup portal should save the time and material record")]
        public void ThenTurnupPortalShouldSaveTheTimeAndMaterialRecord()
        {

            tmPageobj.AssertCreateTMRecord(driver);
        }

        [When(@"user edit an existing time and material racord")]
        public void WhenUserEditAnExistingTimeAndMaterialRacord()
        {
            //Edit time record
            tmPageobj.EditTimeRecord(driver);
        }

        [Then(@"turnup portal should save the existing time and material record")]
        public void ThenTurnupPortalShouldSaveTheExistingTimeAndMaterialRecord()
        {
            tmPageobj.AssertEditTMRecord(driver);
        }

        [When(@"user delete an existing time and material racord")]
        public void WhenUserDeleteAnExistingTimeAndMaterialRacord()
        {
            //Delete time record
            tmPageobj.DeleteTimeRecord(driver);
        }

        [Then(@"The time and material record should delete from turnup portal")]
        public void ThenTheTimeAndMaterialRecordShouldDeleteFromTurnupPortal()
        {
            tmPageobj.AsserDeleteTimeRecord(driver);
        }

        [AfterScenario]
        public void closeDriver()
        {
            //Close chrome driver
            driver.Quit();

        }

    }
}
    

