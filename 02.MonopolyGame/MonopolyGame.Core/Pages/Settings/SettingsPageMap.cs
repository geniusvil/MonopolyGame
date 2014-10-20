using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtOfTest.WebAii.Controls.HtmlControls;
using QA.UI.TestingFramework.Core;


namespace MonopolyGame.Core.Pages.Settings
{
    [TestClass]
    public class SettingsPageMap : BaseElementMap
    {
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

        public HtmlSpan Settings
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Settings");
            }
        }

        public HtmlInputText ValidationResult
        {
            get
            {
                return this.Find.ById<HtmlInputText>("ValidationResult");
            }
        }

        public string FindHowManyPlayersNameAppeared(string countPlayers)
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
