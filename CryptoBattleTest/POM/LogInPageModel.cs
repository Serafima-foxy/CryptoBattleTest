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
     }
}
