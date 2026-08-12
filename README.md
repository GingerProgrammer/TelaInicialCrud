# 📋 TelaInicialCrud

Sistema web desenvolvido para o **gerenciamento de projetos**, permitindo realizar operações de cadastro, consulta, edição e exclusão de projetos.

## 🔗 Link do projeto

**GitHub:** https://github.com/GingerProgrammer/TelaInicialCrud.git

> Substitua o endereço acima pelo link do repositório no GitHub.

## 🚀 Funcionalidades

O sistema possui as seguintes funcionalidades:

* 👤 Cadastro de usuários
* 🔐 Login e autenticação
* 🚪 Logout
* 🔑 Recuperação de senha
* ➕ Cadastro de projetos
* 📋 Listagem de projetos
* 🔎 Visualização dos detalhes dos projetos
* ✏️ Edição de projetos
* 🗑️ Exclusão de projetos

## 📁 Dados dos projetos

Cada projeto possui as seguintes informações:

* 🆔 Identificação do projeto
* 📝 Nome do projeto
* 📄 Descrição
* 💰 Valor
* 📅 Data de início
* 📅 Data de fim
* 👥 Quantidade de pessoas

## 🛠️ Tecnologias utilizadas

* 💻 C#
* 🌐 ASP.NET Core MVC
* ⚙️ .NET 8
* 🗄️ SQL Server
* 🔗 Entity Framework Core
* 🔐 ASP.NET Core Identity
* 🎨 Razor
* 🖌️ HTML e CSS
* 🧩 Bootstrap

## 🏗️ Estrutura do projeto

O projeto utiliza a arquitetura **MVC (Model-View-Controller)**.

```text
TelaInicialCrud/
│
├── Areas/
│   └── Identity/
│       ├── Data/
│       └── Pages/
│
├── Controllers/
│   ├── HomeController.cs
│   └── ProjetosController.cs
│
├── Models/
│   └── ErrorViewModel.cs
│
├── Migrations/
│
├── Views/
│   ├── Home/
│   ├── Projetos/
│   └── Shared/
│
├── wwwroot/
│
├── appsettings.json
├── Program.cs
└── TelaInicialCrud.csproj
```

## 🗄️ Banco de dados

O sistema utiliza o **SQL Server** para armazenar os dados.

O acesso ao banco é realizado através do **Entity Framework Core**, utilizando o contexto `TelaInicialCrudContext`.

As migrations utilizadas para criação e atualização do banco de dados estão na pasta:

```text
Migrations/
```

## ⚙️ Como executar o projeto

### 1. 📥 Clonar o repositório

```bash
git clone URL_DO_REPOSITORIO
```

### 2. 📂 Abrir o projeto

Abra a solução `TelaInicialCrud.sln` no **Visual Studio**.

### 3. 🗄️ Configurar o banco de dados

Configure a conexão com o SQL Server no arquivo:

```text
appsettings.json
```

### 4. 🔄 Atualizar o banco

Execute:

```bash
dotnet ef database update
```

### 5. ▶️ Executar

Execute o projeto pelo Visual Studio ou através do comando:

```bash
dotnet run
```

## 📌 Objetivo

O projeto foi desenvolvido com o objetivo de aplicar conhecimentos de **desenvolvimento web**, **programação em C#**, **arquitetura MVC**, **banco de dados**, **Entity Framework Core** e **autenticação de usuários**.

---

### 👩‍💻 Desenvolvedor

**Mariana Fernandes Souza Santos**

---

### 👨‍🏫 Professor

**Wallace Oliveira dos Santos**
