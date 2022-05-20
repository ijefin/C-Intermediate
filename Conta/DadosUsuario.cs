using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.DadosCliente
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public static int TotalDeClientes { get; set; }

        public void TrasDadosUsuario()
        {
            Console.WriteLine($"O nome do titular é: {Nome}");
            Console.WriteLine($"O CPF do usuário é: {Cpf}");
            Console.WriteLine($"{Nome}, sua profissão é {Profissao}");
        }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
            TotalDeClientes += 1;

        }
    }

}
