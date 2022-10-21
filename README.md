# Sistema Simples Fluxo Caixa
Sistema desenvolvido por Edson de Araujo
Cadastro Simples com ASP.NET CORE 3.0 C# para entrevistas

# Modo de Instalção e Utilização

Requisitos Basicos:<br>
Visual Studio 2019<br>
SQL Server Manager<br>
EntityFramework Core<br>
Biblioteca Rotativa PDF<br>
Servidor IIS<br>

1 - Fazer o clone do projeto<br>
2 - Aprir Usando Visual Studio 2019<br>
3 - Atualizar os pacotes Nugets<br>
4 - Configura o banco de dados no arquivo appsettings.json, conforme seu banco:<br>

"ConnectionStrings": {
"DefaultConnection": "Data Source = localhost; Initial Catalog = Fluxo_Caixa; Uid = sa; Password = 1234; MultipleActiveResultSets=true; Pooling=true; Min Pool Size=0; Max Pool Size=250; Connect Timeout=30;"
},
<br><br>
4 - Rodar a Aplicação em modo Cmd (webApp)<br>
5 - No Console do Gerenciador de Pacotes entre com PM> Add-Migration 00000000000000_CreateIdentitySchema.cs<br>
6 - Crie um novo usuário para que as tabelas possam ser geradas<br><br>

link do Sistema para Teste: https://www.utyum.com.br/Caixa

Usuario: admin@net.com
Senha: Bt123Senha#
