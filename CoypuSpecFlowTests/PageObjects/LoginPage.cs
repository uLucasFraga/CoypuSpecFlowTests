using System.Collections.Generic;
using System.Linq;
using System.Threading;
using CFlowTests.Common;

namespace CFlowTests.PageObjects
{
    public class LoginPage : BasePage
    {
        public void DoLogin(string email, string pass, bool remember = false)
        {
            TypeEmailAndPassword(email, pass);

            if (remember)
            {
                CheckRemember();
            }

            ClickButton("Login");
        }

        public void TypeEmailAndPassword(string user, string pass)
        {
            browser.FillIn("User").With(user);
            browser.FillIn("Password").With(pass);
        }

        public void CheckRemember()
        {
            browser.Check("RememberMe");
            Thread.Sleep(1000);
        }

        public bool AreLogged(string user)
        {
            var LogeedUser = browser.FindCss(".logged-user").Text;
            return LogeedUser.Contains(user);
        }
    }
}