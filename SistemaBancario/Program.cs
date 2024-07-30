using SistemaBancario.Models;
using SistemaBancario.Services;

namespace SistemaBancario
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Criando contas
            ContaCorrente cc = new ContaCorrente("12345", 500, 100);
            ContaPoupanca cp = new ContaPoupanca("67890", 50, 1.5);

            // Criando clientes
            Cliente cliente1 = new Cliente("João Silva", "123.456.789-00", cc);
            Cliente cliente2 = new Cliente("Maria Oliveira", "987.654.321-00", cp);

            // Criando banco e adicionando contas
            Banco banco = new Banco();
            banco.AdicionarConta(cc);
            banco.AdicionarConta(cp);
            Console.WriteLine();

            // Operações nas contas
            Console.WriteLine("Operações na Conta Corrente:");
            cc.Depositar(1000);
            cc.Sacar(200);
            cc.ExibirInformacoes();
            Console.WriteLine();

            Console.WriteLine("Operações na Conta Poupança:");
            cp.Depositar(1500);
            cp.AplicarJuros();
            cp.ExibirInformacoes();
            Console.WriteLine();

            // Exibir informações dos clientes
            Console.WriteLine("Informações do Cliente 1:");
            cliente1.ExibirInformacoes();
            Console.WriteLine();

            Console.WriteLine("Informações do Cliente 2:");
            cliente2.ExibirInformacoes();
            Console.WriteLine();

            // Exibir todas as contas no banco
            Console.WriteLine("Informações de Todas as Contas no Banco:");
            banco.ExibirTodasAsContas();
        }
    }
}