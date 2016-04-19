#language: pt-BR

Funcionalidade: Login
       Eu como usuário do sistema
       Desejo acessar o módulo Administrativo
       Para poder administrar todos os módulos do meu sistema

Contexto:
       Usuário com acesso ao Administrativo
	   acessa a página de login

Cenário: Login
 
    Dado que estou na página "Principal"
	E informo usuário "fernandosqa@outlook.com" e senha "vaiplaneta"
	Quando eu clico no botão "Login"
    Então sou redirecionado para o "Dashboard"

