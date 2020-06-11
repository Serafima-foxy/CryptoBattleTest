using CryptoBattleTest.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBattleTest.Steps
{
    public static class BaseDriver
    {
        public static IWebDriver driver;
        public static IWebDriver driverOpt;
        public static GameMainPageModel gameMainModel;
        public static RequestPageModel requestModel;
        public static LogInPageModel logInModel;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver("C:\\SERA\\PHOTO");

            }
            return driver;
        }

        public static IWebDriver GetDriverWithOption()
        {
            if (driver == null)
            {
                System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\SERA\PHOTO");
                string profilePath = "C:\\Users\\Serafima Foxy\\AppData\\Local\\Google\\Chrome\\User Data\\Default";
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("user-data-dir=" + profilePath);
                ChromeDriver driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl("http://crypto-battle.pp.ua/");
            }
            return driver;
        }
        public static GameMainPageModel GetGameMainPageModel()
        {
            return new GameMainPageModel();
        }
        public static LogInPageModel GetLogInPageModel()
        {
            return new LogInPageModel();
        }
        public static RequestPageModel GetRequestPageModel()
        {
            return new RequestPageModel();
        }
        public static void RemoveDriver()
        {
            driver = null;
        }
    }
}
