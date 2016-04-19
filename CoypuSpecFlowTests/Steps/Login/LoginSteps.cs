using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CFlowTests.Common;
using CFlowTests.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace CFlowTests.Steps.Login
{

    [Binding]
    public sealed class LoginSteps
    {
        private readonly LoginPage login;

        public LoginSteps(LoginPage login)
        {
            this.login = login;
        }

        [Given(@"que estou na página ""(.*)""")]
        public void DadoQueEstouNaPagina(string p0)
        {
            Assert.Contains(login.GetTitle(), p0);
        }

        [Given(@"informo usuário ""(.*)"" e senha ""(.*)""")]
        public void DadoInformoUsuarioESenha(string p0, string p1)
        {
            login.TypeEmailAndPassword(p0,p1);
        }

        [When(@"eu clico no botão ""(.*)""")]
        public void QuandoEuClicoNoBotao(string p0)
        {
            login.ClickButton(p0);
        }

        [Then(@"sou redirecionado para o ""(.*)""")]
        public void EntaoSouRedirecionadoParaO(string p0)
        {
            Assert.Contains(login.GetTitle(), p0);
        }

    }
}
