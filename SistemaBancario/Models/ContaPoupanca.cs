using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class ContaPoupanca : ContaBancaria
    {
        public double TaxaJuros { get; set; }
        public ContaPoupanca(string numeroDaConta, double saldo, double taxaJuros) : base(numeroDaConta, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        // Método específico para aplicar juros
        public void AplicarJuros()
        {
            Saldo += Saldo * TaxaJuros / 100;
            Console.WriteLine($"Juros aplicados. Saldo atual: {Saldo}");
        }

        // Sobrescrevendo método ExibirInformações
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Taxa de Juros: {TaxaJuros}%");
        }
    }
}
