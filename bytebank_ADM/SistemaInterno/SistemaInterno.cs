using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Authenticar(login, senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine($"Bem vindo ao Sistema do ByteBank {funcionario.Nome}");
                return true;
            }
            else
            {
                Console.WriteLine("Usuario ou Senha Incorreta!");
                return false;
            }
        }

        public bool Logar(ParceiroComercial funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Authenticar(login, senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine($"Bem vindo ao Sistema do ByteBank {funcionario.Nome}");
                return true;
            }
            else
            {
                Console.WriteLine("Usuario ou Senha Incorreta!");
                return false;
            }
        }
    }
}
