using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class ContaBancaria
    {
        // Propriedades da conta bancaria
        public string NumeroDaConta { get; set; }
        public double Saldo { get; protected set; }

        // Constructor da classe
        public ContaBancaria(string numeroDaConta, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        // Método virtual para depositar dinheiro
        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor} realizado. Saldo atual: {Saldo}");
            }
        }

        // Método virtual para sacar dinheiro
        public virtual void Sacar(double valor)
        {
            // se o valor for maior que zero e for menor ou igual ao saldo
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado. Saldo atual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor de saque inválido");
            }
        }

        // Método virtual para exibir informações da conta
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Número da Conta: {NumeroDaConta}, Saldo: {Saldo}");
        }

    }
}
