using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooconsole
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public double Limite { get; set; }
        public string Nome { get; set; }

        public virtual double CalcularValorTarifaManutencao()
        {
            return Saldo * 0.1;
        }


        //Sacar
        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }
            else
            {
                this.Saldo = this.Saldo - valor;
                return true;
            }
        }

        //Depositar
        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo = this.Saldo + valor;
                return true;
            }
            else
            {
                Console.WriteLine("Valor deve ser maior que 0");
                return false;
            }
        }

        public void Transfere(Conta conta, double valor)
        {
            conta.Saldo = conta.Saldo + valor;
        }
    };
}
