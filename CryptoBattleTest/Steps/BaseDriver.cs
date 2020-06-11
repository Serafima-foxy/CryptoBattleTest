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
