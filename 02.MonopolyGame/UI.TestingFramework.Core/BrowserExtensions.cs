﻿using ArtOfTest.WebAii.Core;
using System.Threading;

namespace QA.UI.TestingFramework.Core
{
    public static class BrowserExtensions
    {
        public static void WaitForExists(this Browser browser, params string[] customExpression)
        {
            EventWaiter.WaitForEvent(
            () =>
            {
                try
                {
                    browser.RefreshDomTree();
                    HtmlFindExpression hfe = new HtmlFindExpression(customExpression);
                    browser.WaitForElement(hfe, 500, false);
                }
                catch
                {
                    Thread.Sleep(100);
                    return false;
                }
                return true;
            },
            200000);
        }       
    }
}
