# Teste-GTI-Solution
Teste Técnico

- Esse é o repositório do código fonte que tem como objetovo medir o nível técnico em desenvolvimento nas tecnologias presentes:
  * ASP.NET MVC
  * WEB API
  * WCF
  * WEB FORMS

- A solução contém quatro projetos (ProjetoAPI, ProjetoWCF, SiteMVC e SiteWebForms).

- Status dos projetos:
  * ProjetoAPI: Completo com os endpoints solicitados realizando a listagem de clientes, busca por id, criação, alteração e exclusão.
  * ProjetoWCF: Completo com os endpoints solicitados realizando a listagem de clientes, busca por id, criação, alteração e exclusão.
  * SiteMVC: Completo com referência ao ProjetoAPI acessando os endpoinst e apresentando de forma visual todos as ações solicitadas.
  * SiteWebFroms: Incompleto, apenas com referência ao ProjetoWCF e mada mais.

- O ProjetoAPI utiliza o migration com EF core, e para criação da base de dados basta rodar os comandos no Package Manager Console no ProjetoAPI:
  * Add-Migration CriandoBanco
  * Update-database

- O ProjetoWCF utiliza a criação do banco de dados por scripts SQL. O scriptDB.txt no ProjetoWCF contém todas os scripts SQL necessários para criação.

- O SiteMVC ficou completo, com todas as validações solicitadas no documento, e acessando ao ProjetoAPI sem nenhum problema.

- O SiteWebForms infelizmente ficou incompleto pela falta de conhecimentos técnicos para criação das páginas solicitadas, porém, a conexão com o ProjetoWCF para conexão com banco de dados foi feita com sucesso.


No mais é isso, espero que gostem do meu teste.

Att-

Carlos F. Santos.
