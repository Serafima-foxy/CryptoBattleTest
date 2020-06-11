using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBattleTest.POM
{
    public class GameMainPageModel
    {
        //Top Warriors Elements
        public By topWarriorsLabel = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[1]/div[1]");
        public By firstPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[1]/div[2]/div");
        public By firstPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[1]/div[2]/p");
        public By secondPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[2]/div[2]/div");
        public By secondPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[2]/div[2]/p");
        public By thirdPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[3]/div[2]/div");
        public By thirdPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[3]/div[2]/p");
        public By fourthPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[4]/div[2]/div");
        public By fourthPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[4]/div[2]/p");
        public By fifthPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[5]/div[2]/div");
        public By fifthPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[5]/div[2]/p");
        public By sixthPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[6]/div[2]/div");
        public By sixthPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[6]/div[2]/p");
        public By seventhPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[7]/div[2]/div");
        public By seventhPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[7]/div[2]/p");
        public By eighthPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[8]/div[2]/div");
        public By eighthPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[8]/div[2]/p");
        public By ninthPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[9]/div[2]/div");
        public By ninthPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[9]/div[2]/p");
        public By tenthPlaceName = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[10]/div[2]/div");
        public By tenthPlaceScore = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/div[10]/div[2]/p");
        public By playerPlaceName = By.XPath("/html/body/div[1]/div/div/div[2]/div/div[2]/div[1]/div/div[5]/div/div[2]/div");
        public By playerPlaceScore = By.XPath("/html/body/div[1]/div/div/div[2]/div/div[2]/div[1]/div/div[5]/div/div[2]/p");

        public By gameLabel = By.XPath("/html/body/div[1]/div/header/header/div[1]/span");
    }
}
