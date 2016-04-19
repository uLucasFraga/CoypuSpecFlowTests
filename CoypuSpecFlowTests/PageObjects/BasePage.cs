using System.Configuration;
using System.Threading;
using CFlowTests.Common;

namespace CFlowTests.PageObjects
{
    public class BasePage : BaseTest

    {
        protected string baseURL => ConfigurationManager.AppSettings["DefaultUrl"];

        public void NavigateToMainPage()
        {
            browser.Visit(baseURL);
        }

        public bool OnPage(string title)
        {
            return browser.Title.Contains(title);
        }

        public void ClickButton(string name, int think = 3000)
        {
            browser.ClickButton(name);
            Thread.Sleep(think);
        }

        public string GetTitle()
        {
            return browser.Title;
        }
    }
}