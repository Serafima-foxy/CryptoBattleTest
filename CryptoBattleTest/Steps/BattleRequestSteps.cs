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
        public LogInPageModel logInModel;
        [BeforeScenario]
        public void CreateDriver()
        {
            driver = BaseDriver.GetDriver();
            requestModel = BaseDriver.GetRequestPageModel();
            gameMainModel = BaseDriver.GetGameMainPageModel();
            logInModel = BaseDriver.GetLogInPageModel();
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

        [Then(@"the (.*) should be in the warrior card")]
        public void ThenTheShouldBeInTheWarriorCard(string selectedIcon)
        {
            IWebElement iconEl = null;
            switch(selectedIcon)
            {
                case "BCH icon":
                    iconEl = driver.FindElement(requestModel.bchWarriorSelected);
                    break;
                case "DASH icon":
                    iconEl = driver.FindElement(requestModel.dashWarriorSelected);
                    break;
                case "EOS icon":
                    iconEl = driver.FindElement(requestModel.eosWarriorSelected);
                    break;
                case "BTC icon":
                    iconEl = driver.FindElement(requestModel.btcWarriorSelected);
                    break;
                case "ETH icon":
                    iconEl = driver.FindElement(requestModel.ethWarriorSelected);
                    break;
                case "LTC icon":
                    iconEl = driver.FindElement(requestModel.ltcWarriorSelected);
                    break;
                case "NEO icon":
                    iconEl = driver.FindElement(requestModel.neoWarriorSelected);
                    break;
                case "ZEC icon":
                    iconEl = driver.FindElement(requestModel.zecWarriorSelected);
                    break;
                case "ZRX icon":
                    iconEl = driver.FindElement(requestModel.zrxWarriorSelected);
                    break;
                case "WAVE icon":
                    iconEl = driver.FindElement(requestModel.wavesWarriorSelected);
                    break;
                case "BAT icon":
                    iconEl = driver.FindElement(requestModel.batWarriorSelected);
                    break;
                case "XMR icon":
                    iconEl = driver.FindElement(requestModel.xmrWarriorSelected);
                    break;
                case "XRP icon":
                    iconEl = driver.FindElement(requestModel.xrpWarriorSelected);
                    break;
            }
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

        [Then(@"the Log in button should be in the new card")]
        public void ThenTheLogInButtonShouldBeInTheNewCard()
        {
            IWebElement logInEl;
            logInEl = driver.FindElement(logInModel.logInInCardButton);
            Assert.IsNotNull(logInEl);
        }

        [Then(@"the Create request button is not found")]
        public void ThenTheCreateRequestButtonIsNotFound()
        {
            try
            {
                IWebElement buttonEl;
                buttonEl = driver.FindElement(requestModel.requestButton);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [When(@"another player card exist")]
        public void WhenAnotherPlayerCardExist()
        {
            IWebElement anotherCardEl;
            anotherCardEl = driver.FindElement(requestModel.anotherPlayerCard);
            Assert.IsNotNull(anotherCardEl);
        }

        [Then(@"the Connect button should be in that card")]
        public void ThenTheConnectButtonShouldBeInThatCard()
        {
            string expRes = "Connect";
            IWebElement actRes;
            actRes = driver.FindElement(requestModel.connectButton);
            Assert.AreEqual(expRes, actRes.Text);
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
