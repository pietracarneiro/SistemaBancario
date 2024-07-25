using SistemaBancario.Models;

namespace SistemaBancario
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Criando contas corrente
            ContaCorrente cc = new ContaCorrente("12345-X", 50, 40);
            cc.Depositar(10);
            cc.Sacar(100);
            cc.ExibirInformacoes();

            ContaCorrente cc2 = new ContaCorrente("67890-0", 100, 40);
            cc2.Depositar(40);
            cc2.Sacar(100);
            cc2.ExibirInformacoes();

            ContaCorrente cc3 = new ContaCorrente("64654-1", 40, 10);
            cc3.Depositar(20);
            cc3.Sacar(1000);
            cc3.ExibirInformacoes();

            // Criando contas poupança
            ContaPoupanca cp = new ContaPoupanca("54789-3", 80, 1.5);
            cp.Depositar(30);
            cp.Sacar(20);
            cp.AplicarJuros();
            cp.ExibirInformacoes();

            ContaPoupanca cp2 = new ContaPoupanca("54789-3", 60, 0.5);
            cp2.Depositar(10);
            cp2.Sacar(50);
            cp2.AplicarJuros();
            cp2.ExibirInformacoes();
        }
    }
}