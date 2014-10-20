using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonopolyGame.Core.Pages.Settings;

namespace MonopolyGame.Tests
{
    [TestClass]
    public class SettingsTests
    {
        private TestContext testContextInstance = null;
        /// <summary>
        ///Gets or sets the VS test context which provides
        ///information about and functionality for the
        ///current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void VerifyPlayersNameCount()
        {
            SettingsPage.Instance.Validator.NumberPlayersName();
        }

        [TestMethod]
        public void VerifyPlayersNameCount_Var1()
        {
            SettingsPage.Instance.Validator.NumberPlayersName( this.TestContext);
        }

        //[TestMethod]
        //public void VerifyPlayersName()
        //{
        //    SettingsPage.Instance.Validator.CheckPlayerName();
        //}

        //[TestMethod]
        //public void VerifyPlayersMoney()
        //{
        //    SettingsPage.Instance.Validator.CheckMoneyPlayer();
        //}

        //[TestMethod]
        //public void VerifyBankMoney()
        //{
        //    SettingsPage.Instance.Validator.CheckMoneyBank();
        //}
    }
}
