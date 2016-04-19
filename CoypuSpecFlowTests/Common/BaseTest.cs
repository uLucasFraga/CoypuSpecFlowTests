using System;
using System.Configuration;
using Coypu;
using Coypu.Drivers;
using Coypu.Drivers.Selenium;

namespace CFlowTests.Common
{
    public abstract class BaseTest : IDisposable
    {
        public static BrowserSession browser { get; private set; }

        protected BaseTest()
        {
            var sessionConfiguration = new SessionConfiguration
            {
                AppHost = ConfigurationManager.AppSettings["DefaultUrl"],
                Driver = typeof (SeleniumWebDriver),
                Timeout = TimeSpan.FromSeconds(30),
                Browser = Browser.Firefox
            };

            browser = new BrowserSession(sessionConfiguration);
            browser.MaximiseWindow();
            browser.Visit("about:blank");
        }

        public void Dispose()
        {
            try
            {
                browser.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao finalizar browser. => {0} ", ex);
                throw;
            }
        }
    }
}