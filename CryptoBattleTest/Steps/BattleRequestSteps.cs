using CryptoBattleTest.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CryptoBattleTest.Steps
{
    [Binding]
    public class BattleRequestSteps
    {
        public IWebDriver driver;
        public RequestPageModel requestModel;
        public GameMainPageModel gameMainModel;
        [BeforeScenario]
        public void CreateDriver()
        {
            driver = BaseDriver.GetDriver();
            requestModel = BaseDriver.GetRequestPageModel();
            gameMainModel = BaseDriver.GetGameMainPageModel();
        }
        [When(@"I click Create Request button")]
        public void WhenIClickCreateRequestButton()
        {
            IWebElement creatReqEl;
            creatReqEl = driver.FindElement(requestModel.requestButton);
            creatReqEl.Click();
        }
        [When(@"I select (.*) from list")]
        public void WhenISelectBCHFromList(string warriors)
        {
            IWebElement warSelect = null;
            switch(warriors)
            {
                case "BCH":
                    warSelect = driver.FindElement(requestModel.bchWarriorButton);
                    break;
                case "DASH":
                    warSelect = driver.FindElement(requestModel.dashWarriorButton);
                    break;
                case "EOS":
                    warSelect = driver.FindElement(requestModel.eosWarriorButton);
                    break;
                case "BTC":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
                case "ETH":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
                case "LTC":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
                case "NEO":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
                case "ZEC":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
                case "ZRX":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
                case "WAVES":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
                case "BAT":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
                case "XMR":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
                case "XRP":
                    warSelect = driver.FindElement(requestModel.btcWarriorButton);
                    break;
            }
            warSelect.Click();
        }

        [Then(@"the selected icon should be in the warrior card")]
        public void ThenTheSelectedIconShouldBeInTheWarriorCard()
        {
            IWebElement iconEl;
            iconEl = driver.FindElement(requestModel.warriorSelected);
            Assert.NotNull(iconEl.Displayed);
        }
        [When(@"I click HP points button")]
        public void WhenIClickHPPointsButton()
        {
            IWebElement hpPointEl;
            hpPointEl = driver.FindElement(requestModel.hpPointButton);
            hpPointEl.Click();
        }

        [When(@"I click Creat button")]
        public void WhenIClickCreatButton()
        {
            IWebElement creatButtonEl;
            creatButtonEl = driver.FindElement(requestModel.creatButton);
            creatButtonEl.Click(); ;
        }
        [When(@"I select (.*) from points list")]
        public void WhenISelectFromPointsList(string expRes)
        {
            IWebElement actRes = null;
            switch(expRes)
            {
                case "50":
                    actRes = driver.FindElement(requestModel.hpPoint50);
                    break;
                case "100":
                    actRes = driver.FindElement(requestModel.hpPoint50);
                    break;
                case "150":
                    actRes = driver.FindElement(requestModel.hpPoint50);
                    break;
                case "200":
                    actRes = driver.FindElement(requestModel.hpPoint50);
                    break;
                case "300":
                    actRes = driver.FindElement(requestModel.hpPoint50);
                    break;
                case "500":
                    actRes = driver.FindElement(requestModel.hpPoint50);
                    break;
            }
            Assert.AreEqual(expRes, actRes.Text);
        }
        [Then(@"the new card is created")]
        public void ThenTheNewCardIsCreated()
        {
            IWebElement spinnerIconEl;
            spinnerIconEl = driver.FindElement(requestModel.spinnerIcon);
            Assert.IsNotNull(spinnerIconEl);
        }
        [When(@"I click Logout button")]
        public void WhenIClickLogoutButton()
        {
            IWebElement logOutEl;
            logOutEl = driver.FindElement(requestModel.spinnerIcon);
            logOutEl.Click();
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
