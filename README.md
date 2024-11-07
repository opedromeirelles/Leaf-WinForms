# Leaf Desktop

**Leaf Desktop** é um módulo do sistema de gestão distribuído **Leaf**, projetado para gerenciar a produção e vendas de produtos em uma fazenda urbana. A aplicação é desenvolvida com foco em eficiência, produtividade e facilidade de uso, utilizando a tecnologia **Windows Forms (WinForms)** e uma arquitetura **MVC** em **C#**, com conexão ao **SQL Server** para gerenciamento e persistência de dados.

## Índice

- [Sobre o Projeto](#sobre-o-projeto)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Funcionalidades](#funcionalidades)
- [Arquitetura do Projeto](#arquitetura-do-projeto)
- [Considerações](#considerações)

## Sobre o Projeto

**Leaf Desktop** é um componente fundamental do sistema **Leaf**, responsável pela gestão completa da produção e vendas de produtos agrícolas. Foi projetado para facilitar as operações diárias, como o controle de lotes de produção e gerenciamento de estoques, além de processar e registrar vendas.

### Contexto
O projeto foi desenvolvido para fazendas urbanas que precisam de uma solução robusta e integrada para otimizar sua produção e processos de venda. A aplicação desktop funciona de forma integrada ao restante do sistema **Leaf** (web e mobile), proporcionando uma visão abrangente e controle eficiente das operações.

## Tecnologias Utilizadas

- **Windows Forms (WinForms)**: Para desenvolvimento da interface gráfica de usuário.
- **C#**: Linguagem principal de desenvolvimento.
- **SQL Server**: Banco de dados relacional para armazenamento de dados.
- **Arquitetura MVC**: Para separação clara entre interface, lógica de negócios e acesso a dados.
- **ADO.NET**: Para conexões e operações com o banco de dados.

## Funcionalidades

- **Gestão de Produção**: Controle detalhado de lotes de produção e monitoramento de etapas de produção.
- **Gerenciamento de Estoques**: Visualização e atualização de inventário em tempo real.
- **Registro de Vendas**: Processamento de vendas de produtos, com atualizações automáticas de estoque.
- **Relatórios de Produção e Vendas**: Geração de relatórios detalhados para monitoramento do desempenho da produção e análise de vendas.
- **Autenticação de Usuários**: Controle de acesso com permissões específicas.
- **Interface Intuitiva**: Focada em usabilidade e otimização do fluxo de trabalho.

## Arquitetura do Projeto

A aplicação **Leaf Desktop** segue uma arquitetura **MVC (Model-View-Controller)** para promover a separação de responsabilidades, facilitando a manutenção e expansão do projeto:

- **Model**: Representa as entidades de negócio e se conecta ao **SQL Server** para operações de CRUD (Create, Read, Update, Delete).
- **View**: Interface de usuário desenvolvida com **WinForms**, projetada para ser intuitiva e responsiva às necessidades do usuário.
- **Controller**: Camada de lógica de negócios que gerencia a interação entre a View e o Model, processando as solicitações e enviando as respostas adequadas.

### Conexão com Banco de Dados
A aplicação utiliza **ADO.NET** para estabelecer a conexão com o **SQL Server**, garantindo operações rápidas e confiáveis para o armazenamento e recuperação de dados.

## Considerações

**Leaf** é um sistema de gestão distribuído desenvolvido como um projeto acadêmico, com o objetivo de aplicar e consolidar conhecimentos em desenvolvimento web e de software. Este projeto busca simular um ambiente real de trabalho, permitindo a prática de conceitos avançados como arquitetura em camadas, injeção de dependências, controle de versionamento, e metodologias de desenvolvimento em **ASP.NET** com **C#**.

---

Veja outras partes que complementam este projeto:

- [Leaf Web - Gerenciamento de cadastros e lançamentos de compras](https://github.com/opedromeirelles/Leaf-Web)
- [Leaf Mobile - Gerenciamento de entregas dos produtos vendidos](https://github.com/opedromeirelles/Leaf-Mobile)
