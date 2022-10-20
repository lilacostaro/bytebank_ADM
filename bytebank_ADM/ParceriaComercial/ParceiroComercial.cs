using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.ParceriaComercial
{
    public class ParceiroComercial
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }

        public bool Authenticar(string login, string senha)
        {
            return (this.Senha == senha && this.Login == login);
        }
    }
}
