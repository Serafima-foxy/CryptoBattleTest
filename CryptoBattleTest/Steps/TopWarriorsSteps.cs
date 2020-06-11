using CryptoBattleTest.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using TechTalk.SpecFlow;
using AutoIt;
using System.Threading;
using System.Drawing.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace CryptoBattleTest.Steps
{
    [Binding]
    public class TopWarriorsSteps
    {
        public IWebDriver driver;
        public static IWebDriver driverOpt;
        public static GameMainPageModel gameMainModel;
        public static LogInPageModel logInPage;


        [Given(@"the game crypto-battle is opened in Google Chrome")]
        public void GivenTheGameCrypto_BattleIsOpenedInGoogleChrome()
        {
            gameMainModel = BaseDriver.GetGameMainPageModel();
            driver = BaseDriver.GetDriver();
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.Url = "http://crypto-battle.pp.ua/";
        }

        //[Given(@"the game crypto-battle is opened in Google Chrome with player autorization")]
        //public void GivenTheGameCrypto_BattleIsOpenedInGoogleChromeWithPlayerAutorization()
        //{
        //    logInPage = BaseDriver.GetLogInPageModel();
        //    IWebElement logInEl;
        //    System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\SERA\PHOTO");
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://crypto-battle.pp.ua/");
        //    logInEl = driver.FindElement(logInPage.loginButton);
        //    logInEl.Click();
        //    String parentWindow = driver.CurrentWindowHandle;
        //    driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/button[2]")).Click();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);



        //    //    IWebElement logInEl;
        //    //    IWebElement googleEl;
        //    //    logInPage = BaseDriver.GetLogInPageModel();
        //    //    //IWebDriver driver = new ChromeDriver();
        //    //    var url = "http://crypto-battle.pp.ua/";
        //    //    IWebDriver driver = new ChromeDriver();
        //    //    driver.Manage().Window.Maximize();
        //    //    driver.Navigate().GoToUrl(url);
        //    //    logInEl = driver.FindElement(logInPage.loginButton);
        //    //    logInEl.Click();
        //    //    //driver.SwitchTo().Alert().Accept();
        //    //    //AutoItX.WinWaitActive("Авторизоваться");
        //    //    driver.SwitchTo().Alert().Accept();
        //    //    string authEl = driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/div")).Text.ToString();
        //    //    driver.SwitchTo().Window(authEl);
        //    //    googleEl = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/button[2]"));
        //    //    googleEl.Click();
        //    //    //AutoItX.Run("SciTE.exe", "C:\\Program Files (x86)\\AutoIt3\\SciTE", 1);
        //    //    //driver.SwitchTo().Alert().Accept();


        //    //    //driver.SwitchTo().Alert().Accept();
        //    //    AutoItX.WinWaitActive("Вход");
        //    //    AutoItX.Send("annazabolotnia@gmail.com");
        //    //    AutoItX.Send("{Enter}");
        //    //    AutoItX.Send("spazierengehenshmel");
        //    //    AutoItX.Send("{Enter}");
        //    //    Thread.Sleep(1000);
        //}

        [Then(@"the Top Warrior should be a label")]
        public void ThenTheTopWarriorShouldBeALabel()
        {
            string label = "TOP Warriors";
            IWebElement topWarriorsLabel;
            topWarriorsLabel = driver.FindElement(gameMainModel.topWarriorsLabel);
            Assert.AreEqual(label, topWarriorsLabel.Text);
        }

        [Then(@"the (.*) should be in the name field")]
        public void ThenTheShouldBeInTheNameField(string expRes)
        {
            IWebElement nameEl = null;
            switch(expRes)
            {
                case "Андрей_Беличенко!!!":
                    nameEl = driver.FindElement(gameMainModel.firstPlaceName);
                    break;
                case "Not_Funny":
                    nameEl = driver.FindElement(gameMainModel.secondPlaceName);
                    break;
                case "Andrey Belichenko":
                    nameEl = driver.FindElement(gameMainModel.thirdPlaceName);
                    break;
                case "Diana":
                    nameEl = driver.FindElement(gameMainModel.fourthPlaceName);
                    break;
                case "Андрій Бєліченко444":
                    nameEl = driver.FindElement(gameMainModel.fifthPlaceName);
                    break;
                case "Borik":
                    nameEl = driver.FindElement(gameMainModel.sixthPlaceName);
                    break;
                case "Борис":
                    nameEl = driver.FindElement(gameMainModel.seventhPlaceName);
                    break;
                case "Андрей Беличенко":
                    nameEl = driver.FindElement(gameMainModel.ninthPlaceName);
                    break;
                case "Роман Криптоман":
                    nameEl = driver.FindElement(gameMainModel.eighthPlaceName);
                    break;
                case "Наташа Хайдар":
                    nameEl = driver.FindElement(gameMainModel.tenthPlaceName);
                    break;
            }
            Assert.AreEqual(expRes, nameEl.Text);
        }
        
        [Then(@"the (.*) should be in the score field")]
        public void ThenTheShouldBeInTheScoreField(string expRes)
        {
            IWebElement scoreEl;
            switch(expRes)
            {
                case "23":
                    scoreEl = driver.FindElement(gameMainModel.firstPlaceScore);
                    Assert.AreEqual(expRes, scoreEl.Text);
                    break;
                case "18":
                    scoreEl = driver.FindElement(gameMainModel.secondPlaceScore);
                    Assert.AreEqual(expRes, scoreEl.Text);
                    break;
                case "17":
                    scoreEl = driver.FindElement(gameMainModel.thirdPlaceScore);
                    Assert.AreEqual(expRes, scoreEl.Text);
                    break;
                case "14":
                    scoreEl = driver.FindElement(gameMainModel.fourthPlaceScore);
                    Assert.AreEqual(expRes, scoreEl.Text);
                    break;
                case "12_A":
                    IWebElement firstEl_12;
                    string res_1 = "12";
                    firstEl_12 = driver.FindElement(gameMainModel.fifthPlaceScore);
                    Assert.AreEqual(res_1, firstEl_12.Text);
                    break;
                case "12_B":
                    IWebElement secondEl_12;
                    string res_2 = "12";
                    secondEl_12 = driver.FindElement(gameMainModel.sixthPlaceScore);
                    Assert.AreEqual(res_2, secondEl_12.Text);
                    break;
                case "11":
                    scoreEl = driver.FindElement(gameMainModel.seventhPlaceScore);
                    Assert.AreEqual(expRes, scoreEl.Text);
                    break;
                case "8":
                    scoreEl = driver.FindElement(gameMainModel.eighthPlaceScore);
                    Assert.AreEqual(expRes, scoreEl.Text);
                    break;
                case "7":
                    scoreEl = driver.FindElement(gameMainModel.ninthPlaceScore);
                    Assert.AreEqual(expRes, scoreEl.Text);
                    break;
                case "5":
                    scoreEl = driver.FindElement(gameMainModel.tenthPlaceScore);
                    Assert.AreEqual(expRes, scoreEl.Text);
                    break;
            }
        }

        [Then(@"the player name should be in the name list")]    
        public void ThenThePlayerNameShouldBeInTheScoreList()
        {
            string expRes = "Anna Zabolotnia";
            IWebElement actRes;
            actRes = driver.FindElement(gameMainModel.playerPlaceName);
            Assert.AreEqual(expRes, actRes.Text);
        }
        [Then(@"the player score should be in the score list")]
        public void ThenThePlayerScoreShouldBeInTheScoreList()
        {
            string expRes = "1";
            IWebElement actRes;
            actRes = driver.FindElement(gameMainModel.playerPlaceScore);
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
