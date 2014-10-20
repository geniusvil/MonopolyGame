using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;

namespace MonopolyGame.Core.Pages.Settings
{
    [TestClass]
    public class SettingsPageValidator
    {
       private  TestContext testContext = null;

        public SettingsPageMap Map
        {
            get
            {
                return new SettingsPageMap();
            }
        }

        [DataSource("SettingsPlayerCount")]
        [DeploymentItem(@"C:\MyStaff\14.QA-part2\HOMEWORK\02.TestTechniques\MonopolyGame.Core\MonopolyGameTestTechnique.xlsx")]
        public void NumberPlayersName()
        {

            string countPlayers = testContext.DataRow["PlayerCount"].ToString();
            string actualCount = testContext.DataRow["Expected PlayerCount"].ToString();
            //it seems wrong !!!!!
            new SettingsPage().Navigate();
            this.Map.Settings.Click();

            this.Map.PlayerCount.Value = countPlayers;
            this.Map.FirstPlayer.Click();
            string expectedCount = this.Map.FindHowManyPlayersNameAppeared(countPlayers);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [DataSource("SettingsPlayerCount")]
        [DeploymentItem(@"C:\MyStaff\14.QA-part2\HOMEWORK\02.TestTechniques\MonopolyGame.Core\MonopolyGameTestTechnique.xlsx")]
        public void NumberPlayersName(TestContext testContext)
        {

            string countPlayers = testContext.DataRow["PlayerCount"].ToString();
            string actualCount = testContext.DataRow["Expected PlayerCount"].ToString();
           //it seems wrong !!!!!
            new SettingsPage().Navigate();
            this.Map.Settings.Click();

            this.Map.PlayerCount.Value = countPlayers;
            this.Map.FirstPlayer.Click();
            string expectedCount = this.Map.FindHowManyPlayersNameAppeared(countPlayers);
            Assert.AreEqual(expectedCount, actualCount);
        }

        //[DataSource("SettingsPlayerCount")]
        //[DeploymentItem("MonopolyGame.Core\\MonopolyGameTestTechnique.xlsx")]
        //public void CheckPlayerName()
        //{
        //    string inputName = testContext.DataRow["PlayerName1"].ToString();
        //    string result = testContext.DataRow["Expected Result"].ToString();

        //    this.Map.FirstPlayer.Text = inputName;
        //    this.Map.BankMoney.Click();
          
        //    Assert.IsTrue(this.Map.ValidationResult.Text.Contains(result));
        //}

        //[DataSource("SettingsMoneyPlayer")]
        //[DeploymentItem("MonopolyGame.Core\\MonopolyGameTestTechnique.xlsx")]
        //public void CheckMoneyPlayer()
        //{
        //    string inputMoney = testContext.DataRow["MoneyForPlayer"].ToString();
        //    string expectedMoney = testContext.DataRow["ExpectedMoneyPlayer"].ToString();

        //    this.Map.MoneyPerPlayer.Text = inputMoney;
        //    this.Map.BankMoney.Click();
        //    string actualMoney = this.Map.MoneyPerPlayer.Text;

        //    Assert.AreEqual(expectedMoney, actualMoney);
        //}

        //[DataSource("SettingsMoneyBank")]
        //[DeploymentItem("MonopolyGame.Core\\MonopolyGameTestTechnique.xlsx")]
        //public void CheckMoneyBank()
        //{
        //    string countPlayers = testContext.DataRow["PlayerCount"].ToString();
        //    string inputMoneyPlayer = testContext.DataRow["MoneyForPlayer"].ToString();
        //    string expectedMoneyBank = testContext.DataRow["ExpectedMoneyBank"].ToString();


        //    this.Map.PlayerCount.Text = countPlayers;
        //    this.Map.MoneyPerPlayer.Text = inputMoneyPlayer;

        //    string calMoneyBank = this.Map.BankMoney.Text;

        //    Assert.AreEqual(expectedMoneyBank, calMoneyBank);
        //}

    }
}
