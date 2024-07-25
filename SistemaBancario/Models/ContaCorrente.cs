using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class ContaCorrente : ContaBancaria
    {
        public double LimiteDeCredito { get; set; } // Limite de crédito - Cheque especial
        public ContaCorrente(string numeroDaConta, double saldo, double limiteDeCredito) : base(numeroDaConta, saldo)
        {
            LimiteDeCredito = limiteDeCredito;
        }

        // Sobrescrevendo o método Sacar
        public override void Sacar(double valor)
        {
            if(valor > 0 && valor <= Saldo + LimiteDeCredito)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado. Saldo atual: {Saldo}");
            } else {
                Console.WriteLine("Saldo insuficiente, mesmo com o limite");
            }
        }

        // Sobrescrevendo o método ExibirInformações
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Limite de Crédito: {LimiteDeCredito}");
        }
    }

}
