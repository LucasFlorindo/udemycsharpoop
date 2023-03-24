using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex02classmethodudemycsharp
{
    class Funcionario
    {
        public string Nome;
        public double Bruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Bruto - Imposto;
        }

        public void Aumento(double porcentagem)
        {
            Bruto = Bruto + (Bruto *porcentagem / 100);
        }
        
            public override string ToString()
        {
            return Nome
            +", "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    }

