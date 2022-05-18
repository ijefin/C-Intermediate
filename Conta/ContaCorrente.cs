using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Cliente;
namespace bytebank.Conta
{
    public class ContaCorrente
    {
        public DadosUsuario titular;
        public string conta;
        public int agencia;
        public string nome_agencia;
        private double saldo;

        public void ValorInvalido()
        {
            Console.WriteLine("O valor inserido é invalido!");
        }

        public bool Saque(int valor)
        {
            if (valor > saldo || valor <= 0)
            {
                ValorInvalido();
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor || valor <= 0)
            {
                ValorInvalido();
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public void MostraDados()
        {
            Console.WriteLine($"Olá {titular.nome_titular}!");
            Console.WriteLine("Abaixo serão mostrados os seus dados");
            Console.WriteLine($"CPF: {titular.cpf}");
            Console.WriteLine($"PROFISSÃO: {titular.profissao}");
            Console.WriteLine($"N° da Conta: {conta}");
            Console.WriteLine($"Agência: {agencia}");
            Console.WriteLine($"Nome da Agência: {nome_agencia}");
            Console.WriteLine($"Saldo disponível: {Saldo}R$");
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }
    }
}
