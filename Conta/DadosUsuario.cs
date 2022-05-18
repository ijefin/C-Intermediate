using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Cliente
{
    public class DadosUsuario
    {
        public string nome_titular;
        public string cpf;
        public string profissao;

        public void TrasDadosUsuario()
        {
            Console.WriteLine($"O nome do titular é: {nome_titular}");
            Console.WriteLine($"O CPF do usuário é: {cpf}");
            Console.WriteLine($"{nome_titular}, sua profissão é {profissao}");
        }
    }

}
