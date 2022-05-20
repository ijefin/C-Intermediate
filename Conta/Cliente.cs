using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.DadosCliente;
namespace bytebank.Conta
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public string Conta { get; set; }

        public int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0) { }
                else
                {
                    _agencia = value;
                }
            }
        }
        public string NomeAgencia { get; set; }

        private double saldo;
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

        public static int TotalDeContas { get; set; }

        public ContaCorrente(Cliente titular, string conta, int agencia, string nomeAgencia, double saldo)
        {
            Titular = titular;
            Conta = conta;
            Agencia = agencia;
            NomeAgencia = nomeAgencia;
            Saldo = saldo;
            TotalDeContas += 1;
        }

        public void MostraDados()
        {
            Console.WriteLine($"Olá {Titular.Nome}!");
            Console.WriteLine("Abaixo serão mostrados os seus dados");
            Console.WriteLine($"CPF: {Titular.Cpf}");
            Console.WriteLine($"PROFISSÃO: {Titular.Profissao}");
            Console.WriteLine($"N° da Conta: {Conta}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Nome da Agência: {NomeAgencia}");
            Console.WriteLine($"Saldo disponível: {Saldo}R$");
        }
    }
}
