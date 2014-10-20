using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtOfTest.WebAii.Core;

namespace MonopolyGame.Core.Pages.Settings
{
    [TestClass]
    public class SettingsPage
    {
        private readonly string Url =  @"http://localhost:49573/Default.aspx";
        private static SettingsPage instance;

        public static SettingsPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingsPage();
                }

                return instance;
            }
        }
        public SettingsPageMap Map
        {
            get
            {
                return new SettingsPageMap();
            }
        }

        public SettingsPageValidator Validator
        {
            get
            {
                return new SettingsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }
    }
}
