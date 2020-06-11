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

namespace CryptoBattleTest.Steps
{
    [Binding]
    public class TopWarriorsSteps
    {
        public IWebDriver driver;
        public static IWebDriver driverOpt;
        public static GameMainPageModel gameMainModel;
        public static LogInPageModel logInPage;
        //game opened without autorized user
        [Given(@"the game crypto-battle is opened in Google Chrome")]
        public void GivenTheGameCrypto_BattleIsOpenedInGoogleChrome()
        {
            gameMainModel = BaseDriver.GetGameMainPageModel();
            driver = BaseDriver.GetDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.Url = "http://crypto-battle.pp.ua/";
        }
        // Game opened with autorized user
        //[Given(@"the game crypto-battle is opened in Google Chrome with player autorization")]
        //public void GivenTheGameCrypto_BattleIsOpenedInGoogleChromeWithPlayerAutorization()
        //{
        //    gameMainModel = BaseDriver.GetGameMainPageModel();
        //    IWebDriver driver = new ChromeDriver();
        //    try
        //    {
        //        driver.Navigate().GoToUrl("http://crypto-battle.pp.ua/");
        //        driver.Manage().Cookies.AddCookie(new Cookie("LSID", "doritos|lso|o.calendar.google.com|o.mail.google.com|o.myaccount.google.com|o.smartlock.google.com|o.takeout.google.com|s.PL|s.UA|s.blogger|s.youtube|wise:xgdjoXgvg9EIMJQ2qs9EZtqJsCIDfxyi9-5KIACOcHTCe0t_4eRkDup_B0GrDu3FlcIz6w."));
        //        driver.Manage().Cookies.AddCookie(new Cookie("__Host-3PLSID", "doritos|lso|o.calendar.google.com|o.mail.google.com|o.myaccount.google.com|o.smartlock.google.com|o.takeout.google.com|s.PL|s.UA|s.blogger|s.youtube|wise:xgdjoXgvg9EIMJQ2qs9EZtqJsCIDfxyi9-5KIACOcHTCe0t_x-Ma4VrQxhiYlmiUViE7pA."));
        //        driver.Manage().Cookies.AddCookie(new Cookie("ACCOUNT_CHOOSER", "AFx_qI5R2wNPwl6B0-DsYw_KoHi77EAQdo7HxTmQAMe-5ZkJqQjbpuKRTDEWPfLCBVBlQGCyQhJ82HZRkCm9ngFTdidUMBaWEQnRKWKi_NYxuMxlC8AalwXJV4e6yH4kSRr936rXIzE5z0juRLCARRAuC23rdbetpw"));
        //        driver.Manage().Cookies.AddCookie(new Cookie("user_id", "114484356221566662250"));
        //        //driver.Manage().Cookies.AddCookie(new Cookie("", ""));
        //        //driver.Manage().Cookies.AddCookie(new Cookie("oauth2_cs::http://crypto-battle.pp.ua::411912187634-09e2pudtp337atlucsnlfaeb13ie4ntj.apps.googleusercontent.com", "{\"cookieHash\":\" - 852233897\",\"cachedValue\":{\"user\":\"AJDLj6L47OIC7DsGjmfIJ1eMKJgkUe32XIHqZy7lfo - FZwwW063fMfiU_TPbAdu6wKTrhaiPPl2pT5zBIYaGs0jlUDSNqLszIaA3JN - PJg2J_c0rp2iE62k\",\"session\":{\"extraQueryParams\":{\"authuser\":\"0\"}}}}"));
        //        //driver.Manage().Cookies.AddCookie(new Cookie("oauth2_tr::http://crypto-battle.pp.ua::411912187634-09e2pudtp337atlucsnlfaeb13ie4ntj.apps.googleusercontent.com::_tr_", "{\"cookieHash\":\" - 852233897\",\"cachedValue\":{\"ha\":{\"token_type\":\"Bearer\",\"access_token\":\"ya29.a0AfH6SMA0pil06DgXufjXvkSwG6JM - O0qRKQ4fTifgYLMCFGxr5HGtl4qGCIn0kKPhNgwVITOmGU1gO9uVfReBKQgSoZuVmX4k41AcVT5MLjZwFb5mH8fzUMsI2jdt94Wb8RXIRUokfVXAScBhEMe5jpZ9pYct6Jb1oR4\",\"scope\":\"email profile https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/userinfo.profile openid\",\"login_hint\":\"AJDLj6L47OIC7DsGjmfIJ1eMKJgkUe32XIHqZy7lfo-FZwwW063fMfiU_TPbAdu6wKTrhaiPPl2pT5zBIYaGs0jlUDSNqLszIaA3JN-PJg2J_c0rp2iE62k","expires_in\":3599,\"id_token\":\"eyJhbGciOiJSUzI1NiIsImtpZCI6ImIxNmRlMWIyYWIwYzE2YWMwYWNmNjYyZWYwMWY3NTY3ZTU0NDI1MmEiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJhY2NvdW50cy5nb29nbGUuY29tIiwiYXpwIjoiNDExOTEyMTg3NjM0LTA5ZTJwdWR0cDMzN2F0bHVjc25sZmFlYjEzaWU0bnRqLmFwcHMuZ29vZ2xldXNlcmNvbnRlbnQuY29tIiwiYXVkIjoiNDExOTEyMTg3NjM0LTA5ZTJwdWR0cDMzN2F0bHVjc25sZmFlYjEzaWU0bnRqLmFwcHMuZ29vZ2xldXNlcmNvbnRlbnQuY29tIiwic3ViIjoiMTE0NDg0MzU2MjIxNTY2NjYyMjUwIiwiZW1haWwiOiJhbm5hemFib2xvdG5pYUBnbWFpbC5jb20iLCJlbWFpbF92ZXJpZmllZCI6dHJ1ZSwiYXRfaGFzaCI6IkxUME5wSXBNdXJoY0ZxOU5zbG1rLUEiLCJuYW1lIjoiQW5uYSBaYWJvbG90bmlhIiwicGljdHVyZSI6Imh0dHBzOi8vbGgzLmdvb2dsZXVzZXJjb250ZW50LmNvbS9hLS9BT2gxNEdncVpxZF9Yd3Y3TV9sWHJOZ1luVi04VG1XYUdHeG55UUMxLXk4d0l3PXM5Ni1jIiwiZ2l2ZW5fbmFtZSI6IkFubmEiLCJmYW1pbHlfbmFtZSI6IlphYm9sb3RuaWEiLCJsb2NhbGUiOiJ1ayIsImlhdCI6MTU5MTgxNjY2MywiZXhwIjoxNTkxODIwMjYzLCJqdGkiOiIzMWFjMmI4Mjg2ZjJiN2E1ZGUzYTBhNWM5MTExZDgwN2U1NGNkYjRiIn0.EbwFGv97DVVQq13B7cvnAUcJHOb-FJxjIXxn1i538h1-p_ZHUe9KRZ_04kNAM8xxoxSaE7pPbmTdFbCKZRa4IJa-kJ0FRVPYAYA1uOGaCPADP7VRQ2kvE1fQvQeGJDZhDBEbXfF3DZlnL-nzN9QiBnJd-y7LFfUmxH2dhIJqu1cFhpODfC4o3yhCoBU_f0tDWG5Wr4TGmFbI8dxB7fnLOrJH9PWHIO9CGIIM5eLbhV4H_wCTlinFGTfzNFCx2yPV_cWCqwG3NGDfcY3tw2SttkCZj2C3aZAtAAZGGjWtlNQK1Iue0pQbRu9ohEB66BWDPFGIEgv5SlKqfX83U8mi1w\",\"session_state\":{\"extraQueryParams\":{\"authuser\":\"0\"}},\"first_issued_at\":1591816662309,\"expires_at\":1591820261309},\"responseType\":\"token id_token\"}}"));
        //        var cookies = driver.Manage().Cookies.AllCookies;
        //    }
        //    finally
        //    {
        //        //driver.Quit();
        //    }
        //    //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\SERA\PHOTO");
        //    ////string profilePath = "C:\\Users\\Serafima Foxy\\AppData\\Local\\Google\\Chrome\\User Data\\Default";
        //    //ChromeOptions options = new ChromeOptions();
        //    //options.AddArguments("user-data-dir=C:\\Users\\Serafima Foxy\\AppData\\Local\\Google\\Chrome\\User Data\\Default");
        //    ////options.AddArguments("user-data-dir=" + profilePath);
        //    //ChromeDriver driver = new ChromeDriver(options);
        //    //driver.Navigate().GoToUrl("http://crypto-battle.pp.ua/");
        //    ////driver = BaseDriver.GetDriverWithOption();
        //    ////driver.Navigate().GoToUrl("http://crypto-battle.pp.ua/");
        //    //////driver.Manage().Window.Maximize();
        //    ////driverOpt.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
        //    ////driverOpt.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        //    ////driverOpt.Url = "http://crypto-battle.pp.ua/";
        //}

        [Given(@"the game crypto-battle is opened in Google Chrome with player autorization")]
        public void GivenTheGameCrypto_BattleIsOpenedInGoogleChromeWithPlayerAutorization()
        {
            IWebElement logInEl;
            //IWebElement googleEl;
            logInPage = BaseDriver.GetLogInPageModel();
            //IWebDriver driver = new ChromeDriver();
            var url = "http://crypto-battle.pp.ua/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            logInEl = driver.FindElement(logInPage.loginButton);
            logInEl.Click();
            AutoItX.WinWaitActive("Авторизоваться");
            driver.SwitchTo().Alert().Accept();
            
            //AutoItX.Send("{TAB}");
            //AutoItX.Send("{Enter}");
            driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/button[2]")).Click();
            driver.SwitchTo().Alert().Accept();
            AutoItX.WinWaitActive("Windows Security");
            AutoItX.Send("annazabolotnia@gmail.com");
            AutoItX.Send("{Enter}");
            AutoItX.Send("spazierengehenshmel");
            AutoItX.Send("{Enter}");
            Thread.Sleep(1000);
        }

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
                case "12":
                    List<IWebElement> listOfScoreEl_12 = driver.FindElements(By.Name("12")).ToList();
                    string firstEl_12 = listOfScoreEl_12[0].ToString();
                    Assert.AreEqual(expRes, firstEl_12);
                    string secEl_12 = listOfScoreEl_12[1].ToString();
                    Assert.AreEqual(expRes, secEl_12);
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
