# 💻 TelaInicialCrud

Projeto desenvolvido em **ASP.NET Core MVC** com **.NET 8**, utilizando **Entity Framework Core**, **SQL Server** e **ASP.NET Core Identity**.

## 📌 Sobre o projeto

O sistema foi desenvolvido para realizar o gerenciamento de projetos através de um CRUD (**Create, Read, Update e Delete**).

A aplicação permite que usuários cadastrados façam login e tenham acesso às funcionalidades de gerenciamento de projetos.

## ⚙️ Funcionalidades

* 👤 Cadastro de usuários
* 🔐 Login e logout
* 🛡️ Controle de acesso com autenticação
* ➕ Cadastro de projetos
* 📋 Listagem de projetos
* 🔎 Visualização dos detalhes de um projeto
* ✏️ Edição de projetos
* 🗑️ Exclusão de projetos

## 📊 Informações do projeto

Cada projeto possui os seguintes dados:

* 📝 Nome do projeto
* 📄 Descrição
* 💰 Valor
* 📅 Data de início
* 📅 Data de fim
* 👥 Quantidade de pessoas

## 💻 Tecnologias utilizadas

* 🔹 C#
* 🔹 .NET 8
* 🔹 ASP.NET Core MVC
* 🔹 Entity Framework Core
* 🔹 SQL Server
* 🔹 ASP.NET Core Identity
* 🔹 Razor
* 🔹 Bootstrap
* 🔹 HTML
* 🔹 CSS
* 🔹 JavaScript

## 📁 Estrutura principal

```text
TelaInicialCrud/
├── Areas/
│   └── Identity/
│       ├── Data/
│       │   ├── Projeto.cs
│       │   ├── TelaInicialCrudContext.cs
│       │   └── Usuario.cs
│       └── Pages/
├── Controllers/
│   ├── HomeController.cs
│   └── ProjetosController.cs
├── Models/
├── Views/
│   ├── Home/
│   ├── Projetos/
│   └── Shared/
├── Program.cs
└── TelaInicialCrud.csproj
```

## 🗄️ Banco de dados

O projeto utiliza **SQL Server** através do **Entity Framework Core**.

O contexto `TelaInicialCrudContext` é responsável pela comunicação com o banco de dados e possui a entidade `Projeto`, além das tabelas utilizadas pelo ASP.NET Core Identity para autenticação dos usuários.

## 🚀 Como executar

1. 📂 Abra a solução `TelaInicialCrud.sln` no Visual Studio.
2. 🔗 Verifique a string de conexão do SQL Server no arquivo `appsettings.json`.
3. 📦 Restaure os pacotes NuGet.
4. 🗄️ Configure ou atualize o banco de dados utilizando as migrations do Entity Framework Core, caso necessário.
5. ▶️ Execute o projeto pelo Visual Studio ou pelo terminal:

```bash
dotnet restore
dotnet run
```

6. 🌐 Acesse a aplicação pelo endereço indicado no terminal.

## 🔄 CRUD de Projetos

O sistema possui as operações:

* 🟢 **Create:** cadastro de novos projetos.
* 🔵 **Read:** visualização e listagem dos projetos cadastrados.
* 🟡 **Update:** edição das informações de um projeto.
* 🔴 **Delete:** exclusão de projetos.

## 🔐 Autenticação

As páginas principais do sistema utilizam autenticação. O usuário deve realizar o cadastro e o login para acessar as funcionalidades protegidas.

---

## 👩‍💻 Créditos

### Desenvolvedor

**Mariana Fernandes Souza Santos**

---

### 👨‍🏫 Professor

**Wallace Oliveira dos Santos**
