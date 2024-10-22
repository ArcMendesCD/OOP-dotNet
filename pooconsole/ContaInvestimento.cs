using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooconsole
{
    public class ContaInvestimento : Conta
    {
        public override double CalcularValorTarifaManutencao()
        {
            return Saldo * 0.3;
        }
    }
}
