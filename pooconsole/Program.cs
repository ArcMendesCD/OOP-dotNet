namespace pooconsole
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Depositar(1000);

            ContaPoupanca contaPoupanca = new ContaPoupanca();
            contaPoupanca.Depositar(5000);

            ContaInvestimento contaInvestimento = new ContaInvestimento();
            contaInvestimento.Depositar(2000);

            double valorConta = conta.CalcularValorTarifaManutencao();
            Console.WriteLine(valorConta);

            double valorCP = contaPoupanca.CalcularValorTarifaManutencao();
            Console.WriteLine(valorCP);

            double valorCI = contaInvestimento.CalcularValorTarifaManutencao();
            Console.WriteLine(valorCI);
        }
    }


}
