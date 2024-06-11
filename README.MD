# Gerenciador de Biblioteca

## Descrição do Projeto
Este é um Sistema de Gerenciamento de Livro / Biblioteca. O objetivo é desenvolver um sistema onde seja possível cadastrar livros, usuários, empréstimos, além de outras funcionalidades.

## Funcionalidades
- Cadastrar um Livro
- Validar Dados
- Consultar Todos Livros
- Consultar Um Livro
- Remover um Livro
- Cadastrar Um Usuário
- Cadastrar um Empréstimo
- Cadastrar Data de Devolução
- Devolver um Livro
- Emitir Mensagem Com Dias de Atraso (Se Estiver) ou Se Estiver em Dia

## Entidades e Dados
- Livro: Id (int), Título (string), Autor (string), ISBN (string), Ano de Publicação (int)
- Usuário: Id (int), Nome (string), Email (string)
- Empréstimo: Id (int), IdUsuario, IdLivro, Data de Empréstimo (Hoje / Agora)

## Passo a Passo
1. Criar o Projeto de tipo ASP.NET Core API
2. Criar as Classes das Entidades
3. Criar o Controller BooksController (ou LivrosController)
4. Criar Actions para cada ação
5. Criar Classe LivrosDbContext, que será usada para acesso a Dados
6. Implementar Acesso a Dados em Memória, Primeiramente
7. Utilizar Nas Actions

## Observações
Nesta versão, o Entity Framework Core é usado para acesso a dados, até mesmo em Memória. Recomenda-se usar SQL Server. É sugerido aplicar o Padrão Repository e a Arquitetura Limpa.
