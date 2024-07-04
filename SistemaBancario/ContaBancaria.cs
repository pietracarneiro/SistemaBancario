using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class ContaBancaria
    {
        // Propriedades da conta bancaria
        public string IdDaConta { get; set; }
        public double Saldo { get; protected set; }

        // Constructor da classe
        public ContaBancaria(string idDaConta, double saldo)
        {
            IdDaConta = idDaConta;
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

    }
}
