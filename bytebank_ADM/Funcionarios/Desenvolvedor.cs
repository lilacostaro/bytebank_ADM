using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    internal class Desenvolvedor:Funcionario
    {
        public Desenvolvedor(string cpf):base(cpf, 4500)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.30;
        }
    }
}
