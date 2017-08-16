using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;


namespace GoppAutomation.StepGeneration
{
    
    [Binding]
    public class SignupTestSteps: Base.BaseCls
    {
        
        [Given(@"User filles the fields with  for registration")]
        public void GivenUserFillesTheFieldsWithForRegistration()
        {
            IWebDriver wd = new FirefoxDriver();
            //wd.get("http://jsfiddle.net/SAWsA/11/show/");
            IWebElement input = wd.FindElement(By.TagName("FirstName"));
            input.SendKeys("hello");
            //input = wd.findElement(By.tagName("input"));
            //System.out.println("fieldValue=" + input.getAttribute("value"));
            wd.Quit();




            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var  firstName = _driver.FindElement(By.CssSelector("input[ng-model='FirstName']"));
          firstName.SendKeys("GenRandomString()");
        }

        
        //[Given(@"User selects  ""(.*)"" and click Next")]
        //public void GivenUserSelectsAndClickNext(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"User  select from  ""(.*)"" and click Next")]
        //public void GivenUserSelectFromAndClickNext(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"User is navigated  to next page ""(.*)"" and has  clicked next")]
        //public void GivenUserIsNavigatedToNextPageAndHasClickedNext(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"User  selects from  ""(.*)"" and click Next")]
        //public void GivenUserSelectsFromAndClickNext(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"User selects ""(.*)"" option and click Next")]
        //public void GivenUserSelectsOptionAndClickNext(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"User is navigated  to next page ""(.*)"" and click Next")]
        //public void GivenUserIsNavigatedToNextPageAndClickNext(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"User is navigated  to then next page by selecting  ""(.*)""")]
        //public void GivenUserIsNavigatedToThenNextPageBySelecting(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"""(.*)"" page is loaded")]
        //public void GivenPageIsLoaded(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"User selects ""(.*)""")]
        //public void ThenUserSelects(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"New user is loged in  Successfully")]
        //public void ThenNewUserIsLogedInSuccessfully()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"User selects ""(.*)"" and get new page\.")]
        //public void ThenUserSelectsAndGetNewPage_(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
