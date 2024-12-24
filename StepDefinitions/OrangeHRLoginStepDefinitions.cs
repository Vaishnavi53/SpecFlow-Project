using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowPractise.StepDefinitions
{
    [Binding]
    public class OrangeHRLoginStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public OrangeHRLoginStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        [When(@"User enters the username and password in the textbox")]
        public void WhenUserEntersTheUsernameAndPasswordInTheTextbox()
        {
            IWebElement username = _driver.FindElement(By.XPath("//input[@placeholder='Username']"));
            username.SendKeys("Admin");
            IWebElement password = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            password.SendKeys("Admin123");


        }


        [Then(@"user is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            loginbutton.Click();
        }
    }
}
