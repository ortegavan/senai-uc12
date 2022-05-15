<h2 align="center">
    SENAI - SP    
</h2>
<h3 align="center">
    Cadastro de PF & PJ
</h3>

<p align="center">
    <a href="https://github.com/ortegavan/senai-uc12/commits/">
        <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/ortegavan/senai-uc12?style=flat-square">
    </a>
    <a href="https://github.com/prettier">
        <img alt="code style: prettier" src="https://img.shields.io/badge/code_style-prettier-ff69b4.svg?style=flat-square">
    </a>
</p>

![](https://github.com/ortegavan/senai-uc12/blob/0199ee1e3b20100cc19e82afa3b0d346d04b63f5/sa2/Banner.png)

Este sistema tem por objetivo permitir o cadastro de pessoas físicas e jurídicas e seus respectivos endereços.

## Features

Até a data deste README as funcionalidades descritas a seguir foram implementadas.

**Pessoa física**: inserir e listar os dados de pessoa física e seu endereço; verificação de maioridade; cálculo de imposto.

**Pessoa jurídica**: inserir e listar os dados de pessoa jurídica e seu endereço; validação do CNPJ; cálculo de imposto.

## Tecnologias utilizadas

A solução foi implementada em uma aplicação do tipo console na linguagem C# em .NET 6.0.

## Organização do projeto

O projeto está organizado conforme descrição a seguir:

**Pasta Classes**: contém as classes abstratas e concretas da aplicação

**Pasta Enumeradores**: contém a especificação de Maioridade (Menor, Maior) e de Tipo de Endereço (Residencial, Comercial)

**Pasta Interfaces**: contém as interfaces implementadas pelas classes da aplicação

**Arquivo Program.cs**: ponto de entrada do programa

## Pré-requisitos para edição

-   .NET SDK 6.0
-   Visual Studio Code ou Visual Studio 2022
-   Git e acesso ao GitHub

## Pré-requisitos para execução

-   .NET Runtime 6.0

## Execução da aplicação

### No Visual Studio Code

Ao abrir a aplicação pela primeira vez, utilize o comando abaixo para restaurar as dependências e ferramentas do projeto:

`dotnet restore`

Para compilar a aplicação, utilize o comando abaixo:

`dotnet build`

Para rodar a aplicação, utilize o comando abaixo de dentro da pasta do projeto web:

`dotnet run`

### No Visual Studio 2022

Clique com o botão direito do mouse na solução e selecione a opção "Run solution"

## Colaboradores

Vanessa Ortega
