# 🚀 User Management API

API desenvolvida em .NET com foco em estudo e aplicação de boas práticas de arquitetura e desenvolvimento, incluindo **MVC**, **DTOs**, **Clean Code** e **Arquitetura Hexagonal**.

## 📌 Objetivo

Este projeto tem como objetivo consolidar conhecimentos em construção de APIs robustas e escaláveis, aplicando padrões utilizados no mercado para separação de responsabilidades, organização de código e manutenibilidade.

## 🧠 Conceitos aplicados

- Arquitetura MVC
- Arquitetura Hexagonal (Ports and Adapters)
- Clean Code
- DTO (Data Transfer Object)
- Separação de camadas (Domain, Application, Infrastructure)
- Injeção de Dependência
- Validações de entrada
- Boas práticas de organização de código

## 🛠️ Tecnologias utilizadas

- .NET
- C#
- ASP.NET Core
- Entity Framework
- SQL Server


## 🔄 Fluxo da aplicação

1. Requisição chega no Controller (WebAPI)
2. Controller chama um caso de uso (Application)
3. Caso de uso aplica regras de negócio (Domain)
4. Infraestrutura é utilizada para persistência de dados
5. Resposta é retornada utilizando DTOs

## 📦 Funcionalidades

- ✅ Cadastro de usuários
- ✅ Listagem de usuários
- ✅ Atualização de dados
- ✅ Remoção de usuários
- ✅ Validação de dados
