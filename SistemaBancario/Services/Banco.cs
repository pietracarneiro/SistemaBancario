using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Services
{
    class Banco
    {
        private List<ContaBancaria> contas = new List<ContaBancaria>();

        public void AdicionarConta (ContaBancaria conta)
        {
            contas.Add(conta);
            Console.WriteLine("Conta adicionada com sucesso.");
        }

        public void ExibirTodasAsContas()
        {
            foreach (var conta in contas)
            {
                Console.WriteLine();
                conta.ExibirInformacoes();
            }
        }
    }
}
