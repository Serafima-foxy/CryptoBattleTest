using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBattleTest.POM
{
    public class LogInPageModel
    {
        public By loginButton = By.XPath("/html/body/div/div/header/header/div[3]/div[1]/div/button");
        public By logOutButton = By.XPath("/html/body/div[1]/div/header/header/div[3]/div[1]/div[2]/button");
        public By logInInCardButton = By.XPath("/html/body/div[1]/div/div/div[2]/div/div[2]/div[2]/div/div/div[1]/div[3]/div/button");
        public By authorizedWithGoogleButton = By.XPath("/html/body/div[3]/div/div[2]/button[2]");
        public By emailField = By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/div");
        public By nextButton = By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/div[2]");
        public By passwordField = By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input");
        //public By nextButton1 = By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/div[2]");

    }
}
