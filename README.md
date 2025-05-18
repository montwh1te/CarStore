# CarStore MVC (.NET 6)

Este projeto � uma aplica��o ASP.NET Core MVC para cadastro de **clientes**, **carros**, **vendedores** e **notas fiscais de venda**.

## Tecnologias Utilizadas

- .NET 6
- ASP.NET Core MVC
- Entity Framework Core (SQLite)
- SQLite Toolbox (SQLite / SQL Server Compact Toolbox) 
- Visual Studio 2022

## Sobre o Projeto

O sistema permite:

- Cadastrar, editar, excluir e listar clientes, carros, vendedores e notas fiscais.
- Relacionar notas fiscais a clientes, carros e vendedores.
- Persist�ncia de dados usando **SQLite**.

## Banco de Dados

Foi utilizado **SQLite** para facilitar o desenvolvimento local.

### Acesso ao banco:

- O banco � gerado no arquivo `carstore.db` na raiz do projeto.
- A extens�o **SQLite / SQL Server Compact Toolbox** foi usada no Visual Studio 2022 para:
  - Visualizar as tabelas
  - Inserir e consultar dados manualmente
  - Executar comandos SQL
	
## Depend�ncias

Ao clonar este projeto, certifique-se de restaurar os pacotes NuGet:

```bash
dotnet restore
```

## Como Executar

1. Clone o reposit�rio
2. Abra no Visual Studio 2022
3. Restaure os pacotes NuGet
4. Execute os comandos:
   ```bash
   Add-Migration Inicial
   Update-Database
   ```
5. Rode a aplica��o (CTRL + F5);
6. Para acessar o CRUD das Entidades, use os endpoints:
   - Carro: /Carros
   - Vendedor: /Vendedores
   - Cliente: /Clientes
   - Nota: /Notas