<h1 align="center">Eco Power ☀️ </h1>

<div align="center">


| Integrantes      |            Responsabilidades          | Turma      |   RM     |
| --------------   | ------------------------------------- | ---------- | -------- |
| Cauã Couto       | Desenvolvimento do projeto em Java    |  2TDSS     |  97755   |
| Eduardo Júnio    | Documentação do sistema               |  2TDSS     |  552374  |
| José dos Santos  | Documentação do sistema               |  2TDSS     |  552367  |
| Kaique Agostinho | Mapeamento das tabelas e relações     |  2TDSS     |  550815  |
| Thiago Gil       | Mapeamento das tabelas e relações     |  2TDSPV    |  551211  |
</div>

## 📝 Descrição do Projeto 

Esta é uma API desenvolvida em .NET que implementa funcionalidades de recomendação utilizando ML.NET e integra serviços externos para fornecer dados climáticos.

## 📋 Funcionalidades

- **Integração com serviços externos**: A API se conecta à API do OpenWeather para obter dados climáticos.
- **Recomendação de produtos**: Utiliza ML.NET para gerar recomendações com base nas avaliações de produtos.

## 🎯 Testes Implementados

Utilizamos o xUnit para implementar testes unitários que garantem a funcionalidade da API. Os principais testes incluem:

- Testes de registro de clientes.
- Testes de recomendações de produtos.

## 📝 Práticas de Clean Code

Aplicamos princípios de Clean Code e SOLID, incluindo:

- **Single Responsibility Principle**: Cada classe tem uma única responsabilidade.
- **Dependency Injection**: Utilizamos injeção de dependência para promover a testabilidade e reduzir o acoplamento.

## 📝 Explicação IA generativa
 API utiliza ML.NET para fornecer recomendações de produtos com base nas avaliações dos usuários. Treina o modelo com dados de avaliações e, em seguida, solicitar recomendações ao fornecer seu CPF e o produto desejado. A recomendação é classificada como "Altamente Recomendado", "Recomendado" ou "Não Recomendado" com base na pontuação gerada pelo modelo.
 
## 🌐 Endpoints da API

### 🌐 ClientsController
- **POST /api/clients/register**: Registra um novo cliente. É necessário fornecer o email, senha e nome do cliente no corpo da requisição.
- **PUT /api/clients/{id}**: Atualiza os dados de um cliente existente, onde `{id}` é o ID do cliente.
- **DELETE /api/clients/{id}**: Remove um cliente pelo ID especificado.

### 🌐 ClimaController
- **GET /clima/{cidade}**: Retorna os dados climáticos da cidade especificada. A cidade é passada como um parâmetro na URL.

### 🌐 RecomendacaoController
- **POST /recomendacao/treinar**: Treina o modelo de recomendação. Este endpoint deve ser chamado antes de utilizar as recomendações.
- **GET /recomendacao/recomendar/{cpf}/{produto}**: Retorna uma recomendação para um produto baseado no CPF do cliente e no produto solicitado.

## ❗❗ Como Executar ❗❗

1. Clone o repositório.
2. Restaure os pacotes com `dotnet restore`.
3. Execute a aplicação com `dotnet run`.

### 🧑🏻‍💻 Autor 
> Cauã Couto Basques - Turma 2TDSS
