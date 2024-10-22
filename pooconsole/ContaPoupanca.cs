using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooconsole
{
    public class ContaPoupanca : Conta
    {
        public override double CalcularValorTarifaManutencao()
        {
            return Saldo * 0.2;
        }
    }
}
