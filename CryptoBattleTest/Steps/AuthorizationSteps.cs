using CryptoBattleTest.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CryptoBattleTest.Steps
{
    [Binding]
    public class AuthorizationSteps
    {
        public IWebDriver driver;
        public LogInPageModel logInModel;
        public GameMainPageModel gameMainModel;
        [BeforeScenario]
        public void CreateDriver()
        {
            driver = BaseDriver.GetDriver();
            logInModel = BaseDriver.GetLogInPageModel();
            gameMainModel = BaseDriver.GetGameMainPageModel();
        }
        [When(@"I click Log in button")]
        public void WhenIClickLogInButton()
        {
            IWebElement logInEl;
            logInEl = driver.FindElement(logInModel.loginButton);
            logInEl.Click();
        }
        [When(@"I click Google button")]
        public void WhenIClickGoogleButton()
        {
            IWebElement logInEl;
            logInEl = driver.FindElement(logInModel.authorizedWithGoogleButton);
            logInEl.Click();
        }

        [When(@"I click Next button")]
        public void WhenIClickNextButton()
        {
            IWebElement logInEl;
            logInEl = driver.FindElement(logInModel.nextButton);
            logInEl.Click();
        }
        [When(@"I enter email in field")]
        public void WhenIEnterEmailInField()
        {
            string email = "annazabolotnia@gmail.com";
            IWebElement emailEl;
            emailEl = driver.FindElement(logInModel.emailField);
            emailEl.SendKeys(email);
        }

        [When(@"I enter password in field")]
        public void WhenIEnterPasswordInField()
        {
            string password = "spazierengehenshmel";
            IWebElement emailEl;
            emailEl = driver.FindElement(logInModel.passwordField);
            emailEl.SendKeys(password);
        }
        [Then(@"the game label should be in the screen")]
        public void ThenTheGameLabelShouldBeInTheScreen()
        {
            string expLabel = "Crypto battle";
            IWebElement actLabel;
            actLabel = driver.FindElement(gameMainModel.gameLabel);
            Assert.AreEqual(expLabel, actLabel.Text);
        }
        [AfterScenario]
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                BaseDriver.RemoveDriver();
            }
        }
    }
}
