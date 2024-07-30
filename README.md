# Sistema Bancário em C#

Este projeto é um exemplo de um sistema bancário simples implementado em C# para agregar nos meus estudos acerca dos princípios da Programação Orientada a Objetos (POO). O sistema inclui funcionalidades básicas de contas bancárias, operações de depósito e saque, aplicação de juros e gerenciamento de contas de clientes.

## Classes e suas funcionalidades
- Conta Bancária: Classe base com métodos para depositar, sacar e exibir informações da conta.
- Conta Corrente: Herda de Conta Bancária e adiciona a funcionalidade de limite de saque.
- Conta Poupança: Herda de Conta Bancária e adiciona a funcionalidade de aplicação de juros.
- Cliente: Representa um cliente bancário que possui uma conta bancária.
- Banco: Gerencia um conjunto de contas bancárias.
- Program: Classe principal que executa operações no sistema.

## Configuração e Execução
### Requisitos
- .NET SDK 6.0 ou superior
- Visual Studio ou Visual Studio Code
