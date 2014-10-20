using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.TestAttributes;
using ArtOfTest.WebAii.TestTemplates;
using ArtOfTest.WebAii.Win32.Dialogs;

using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.WebAii.Controls.Html;

namespace MonopolyGameSettings
{
    /// <summary>
    /// Summary description for TelerikVSUnitTest1
    /// </summary>
    [TestClass]
    public class SettingsTests : BaseTest
    {

        #region [Setup / TearDown]

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


        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
        }


        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            #region WebAii Initialization

            // Initializes WebAii manager to be used by the test case.
            // If a WebAii configuration section exists, settings will be
            // loaded from it. Otherwise, will create a default settings
            // object with system defaults.
            //
            // Note: We are passing in a delegate to the VisualStudio
            // testContext.WriteLine() method in addition to the Visual Studio
            // TestLogs directory as our log location. This way any logging
            // done from WebAii (i.e. Manager.Log.WriteLine()) is
            // automatically logged to the VisualStudio test log and
            // the WebAii log file is placed in the same location as VS logs.
            //
            // If you do not care about unifying the log, then you can simply
            // initialize the test by calling Initialize() with no parameters;
            // that will cause the log location to be picked up from the config
            // file if it exists or will use the default system settings (C:\WebAiiLog\)
            // You can also use Initialize(LogLocation) to set a specific log
            // location for this test.

            // Pass in 'true' to recycle the browser between test methods
            Initialize(false, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));

            // If you need to override any other settings coming from the
            // config section you can comment the 'Initialize' line above and instead
            // use the following:

            /*

            // This will get a new Settings object. If a configuration
            // section exists, then settings from that section will be
            // loaded

            Settings settings = GetSettings();

            // Override the settings you want. For example:
            settings.Web.DefaultBrowser = BrowserType.FireFox;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(this.TestContext.WriteLine));

            */

            // Set the current test method. This is needed for WebAii to discover
            // its custom TestAttributes set on methods and classes.
            // This method should always exist in [TestInitialize()] method.
            SetTestMethod(this, (string)TestContext.Properties["TestName"]);

            #endregion

            //
            // Place any additional initialization here
            //

        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {

            //
            // Place any additional cleanup here
            //

            #region WebAii CleanUp

            // Shuts down WebAii manager and closes all browsers currently running
            // after each test. This call is ignored if recycleBrowser is set
            this.CleanUp();

            #endregion
        }

        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            // This will shut down all browsers if
            // recycleBrowser is turned on. Else
            // will do nothing.
            ShutDown();
        }

        #endregion

        public HtmlInputText PlayerCount
        {
            get
            {
                return this.Find.ById<HtmlInputText>("PlayerCount");
            }
        }
        public HtmlInputText FirstPlayer
        {
            get
            {
                return this.Find.ById<HtmlInputText>("PlayerName1");
            }
        }

        public HtmlInputText MoneyPerPlayer
        {
            get
            {
                return this.Find.ById<HtmlInputText>("MoneyPerPlayer");
            }
        }

        public HtmlInputText BankMoney
        {
            get
            {
                return this.Find.ById<HtmlInputText>("BankMoney");
            }
        }

        public HtmlInputText ValidationResult
        {
            get
            {
                return this.Find.ById<HtmlInputText>("ValidationResult");
            }
        }

              //[TestMethod]
        //[DataSource("SettingsPlayerCount")]
        //[DeploymentItem("MonopolyGameSettings\\MonopolyGameTestTechnique.xlsx")]
        //public void NumberPlayersName()
        //{
        //    string countPlayers = TestContext.DataRow["PlayerCount"].ToString();
        //    string actualCount = TestContext.DataRow["Expected PlayerCount"].ToString();

        //    Manager.LaunchNewBrowser();
        //    ActiveBrowser.NavigateTo(@"http://localhost:49573/Default.aspx");

        //    this.PlayerCount.Value = countPlayers;
        //    this.FirstPlayer.Click();
        //    string expectedCount = this.FindHowManyPlayersNameAppeared(countPlayers);
        //    Assert.AreEqual(expectedCount, actualCount);
        //}

        //[TestMethod]
        //[DataSource("SettingsFirtsPlayerName")]
        //[DeploymentItem("MonopolyGameSettings\\MonopolyGameTestTechnique.xlsx")]
        //public void CheckPlayerName()
        //{
        //    string inputName = TestContext.DataRow["PlayerName1"].ToString();
        //    string result = TestContext.DataRow["Expected Result"].ToString();

        //    this.FirstPlayer.Value = inputName;
        //    this.BankMoney.Click();

        //    Assert.IsTrue(this.ValidationResult.Text.Contains(result));
        //}

        //[TestMethod]
        //[DataSource("SettingsMoneyPlayer")]
        //[DeploymentItem("MonopolyGameSettings\\MonopolyGameTestTechnique.xlsx")]
        //public void CheckMoneyPlayer()
        //{
        //    string inputMoney = TestContext.DataRow["MoneyForPlayer"].ToString();
        //    string expectedMoney = TestContext.DataRow["ExpectedMoneyPlayer"].ToString();

           
        //    Manager.LaunchNewBrowser();
        //    ActiveBrowser.NavigateTo(@"http://localhost:49573/Default.aspx");

        //    this.MoneyPerPlayer.Value = inputMoney;
        //    this.BankMoney.Click();
        //    string actualMoney = this.MoneyPerPlayer.Value;

        //    Assert.AreEqual(expectedMoney, actualMoney);
        //}

        [TestMethod]
        [DataSource("SettingsMoneyBank")]
        [DeploymentItem(@"C:\MyStaff\14.QA-part2\HOMEWORK\MonopolyGame\MonopolyGameSettings\MonopolyGameTestTechnique.xlsx")]
        public void CheckMoneyBank()
        {
            string countPlayers = TestContext.DataRow["PlayerCount"].ToString();
            string inputMoneyPlayer = TestContext.DataRow["MoneyForPlayer"].ToString();
            string expectedMoneyBank = TestContext.DataRow["ExpectedMoneyBank"].ToString();

            //that seems wrong !!!
            Manager.LaunchNewBrowser();
            ActiveBrowser.NavigateTo(@"http://localhost:49573/Default.aspx");
            Find.ByContent<HtmlSpan>("Settings").Click();

            this.PlayerCount.Value = countPlayers;
            this.MoneyPerPlayer.Value = inputMoneyPlayer;

            string calMoneyBank = this.BankMoney.Value;

            Assert.AreEqual(expectedMoneyBank, calMoneyBank);
        }

        private string FindHowManyPlayersNameAppeared(string countPlayers)
        {
            string idToFind = "PlayerName";
            if (int.Parse(countPlayers) < 2)
            {
                idToFind = "PlayerName2";
            }
            else if (int.Parse(countPlayers) > 6)
            {
                idToFind = "PlayerName6";
            }
            else
            {
                idToFind += countPlayers;
            }

            bool isVisible = this.Find.ById<HtmlInputText>(idToFind).IsVisible();

            string count = string.Empty;
            if (isVisible)
            {
                count = idToFind.Substring(idToFind.Length - 2, 1);
            }
            return count;
        }
    }
}
