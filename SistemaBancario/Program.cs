namespace SistemaBancario
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria cc = new ContaBancaria("12345", 500);
            cc.Depositar(1000);
        }
    }
}