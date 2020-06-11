using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBattleTest.POM
{
    public class RequestPageModel
    {
        public By requestButton = By.XPath("/html/body/div[1]/div/header/header/div[3]/div[1]/div[1]/div/button");
        public By requestLabel = By.XPath("/html/body/div[3]/div/div[1]/div");
        public By chooseHpLabel = By.XPath("/html/body/div[3]/div/div[3]/div[1]");
        public By warriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[1]/div/div[2]/img");

        public By bchWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[1]/div/div[3]/img");
        public By bchWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[1]/div/div[2]/img");

        public By dashWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[2]/div/div[4]");
        public By dashWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[2]/div/div[2]/img");

        public By eosWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[3]/div/div[3]");
        public By eosWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[3]/div/div[2]/img");

        public By btcWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[4]/div/div[3]");
        public By btcWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[4]/div/div[2]/img");

        public By ethWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[5]/div/div[3]");
        public By ethWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[5]/div/div[2]/img");

        public By ltcWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[6]/div/div[3]");
        public By ltcWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[6]/div/div[2]/img");

        public By neoWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[7]/div/div[3]/img");
        public By neoWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[7]/div/div[2]/img");

        public By zecWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[8]/div/div[3]");
        public By zecWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[8]/div/div[2]/img");

        public By zrxWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[9]/div/div[3]");
        public By zrxWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[9]/div/div[2]/img");

        public By wavesWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[10]/div/div[3]");
        public By wavesWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[10]/div/div[2]");

        public By batWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[11]/div/div[3]/img");
        public By batWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[11]/div/div[2]/img");

        public By xmrWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[12]/div/div[3]/img");
        public By xmrWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[12]/div/div[2]/img");

        public By xrpWarriorButton = By.XPath("/html/body/div[3]/div/div[2]/div/div[13]/div/div[3]");
        public By xrpWarriorSelected = By.XPath("/html/body/div[3]/div/div[2]/div/div[13]/div/div[2]");

        public By hpPointButton = By.XPath("/html/body/div[3]/div/div[3]/div[2]/div[1]/div");
        public By hpPoint50 = By.XPath("/html/body/div[3]/div/div[3]/div[2]/div[1]/div/div[2]/div[1]");
        public By hpPoint100 = By.XPath("/html/body/div[3]/div/div[3]/div[2]/div[1]/div/div[2]/div[2]");
        public By hpPoint150 = By.XPath("/html/body/div[3]/div/div[3]/div[2]/div[1]/div/div[2]/div[3]");
        public By hpPoint200 = By.XPath("/html/body/div[3]/div/div[3]/div[2]/div[1]/div/div[2]/div[4]");
        public By hpPoint300 = By.XPath("/html/body/div[3]/div/div[3]/div[2]/div[1]/div/div[2]/div[5]");
        public By hpPoint500 = By.XPath("/html/body/div[3]/div/div[3]/div[2]/div[1]/div/div[2]/div[6]");
        public By creatButton = By.XPath("/html/body/div[3]/div/div[3]/div[2]/div[2]/button");

        public By newPlayrCard = By.XPath("/html/body/div[1]/div/div/div[2]/div/div[2]/div[2]/div/div/div[1]");
        public By spinnerIcon = By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[1]/div[3]/div/div/div");
    }
}
