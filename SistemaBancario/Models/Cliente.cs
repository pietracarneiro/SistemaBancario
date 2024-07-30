using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public ContaBancaria Conta {  get; set; }

        public Cliente(string nome, string cpf, ContaBancaria conta)
        {
            Nome = nome;
            CPF = cpf;
            Conta = conta;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Cliente: {Nome}, CPF: {CPF}");
            Conta.ExibirInformacoes();
        }
    }
}
