using System;
using TechTalk.SpecFlow;
using GoppAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace GoppAutomation.StepGeneration
{
    [Binding]
    public class LoginActionSteps: Base.BaseCls
    {
        
            [Before]
            [Given(@"User is on Goppa Home Page")]

            public void GivenUserIsOnGoppaHomePage()
            {

                _driver.Url = " https://goppa.benivo.com/goppa/signup";


                //var homePage = new GoppAutomation.Utils.LoginTest();
                //homePage.HomePage();
            }

            [When(@"User Navigate to LogIn Page")]
            public void WhenUserNavigateToLogInPage()
            {

                //var homePage = new GoppAutomation.Utils.LoginTest();
                //homePage.NavigateLogin();
                var loginbtn = _driver.FindElement(By.XPath(".//*[@id='btnDiv']/button"));
                loginbtn.Click();


                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [When(@"User enters ""(.*)"" and ""(.*)""")]
            public void WhenUserEntersAnd(string username, string password)
            {
            
              _driver.FindElement(By.XPath(".//*[@id='username']")).SendKeys(username);
              _driver.FindElement(By.XPath(".//*[@id='password']")).SendKeys(password);
              _driver.FindElement(By.XPath(".//*[@id='vipSignIn']/div[2]/div[5]/div/input")).Click();

        }

        //[When(@"User LogOut from the Goppa")]
        //    public void WhenUserLogOutFromTheGoppa()
        //    {
        //        ScenarioContext.Current.Pending();
        //    }

            //[Then(@"New user is loged in  Successfully")]
            //public void ThenNewUserIsLogedInSuccessfully()
            //{
            //    ScenarioContext.Current.Pending();
            //}

            //[Then(@"LogOut is done Successfully")]
            //public void ThenLogOutIsDoneSuccessfully()
            //{
            //    ScenarioContext.Current.Pending();
            //}
        }
    }

