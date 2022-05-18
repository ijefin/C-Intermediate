using bytebank.Conta;
using bytebank.Cliente;

Console.WriteLine("Bem vindo ao Bytebank");

DadosUsuario cliente1 = new();
cliente1.nome_titular = "Jefferson Lucas Gomes";
cliente1.cpf = "179.437.907-07";
cliente1.profissao = "Software Developer";

ContaCorrente conta1 = new();
conta1.titular = cliente1;
conta1.conta = "10123-x";
conta1.agencia = 10;
conta1.nome_agencia = "Dev Tech";
conta1.Saldo = 25000;

DadosUsuario cliente2 = new();
cliente2.nome_titular = "Anna Luiza Carvalho";
cliente2.cpf = "055.892.176-01";
cliente2.profissao = "Biomédica";

ContaCorrente conta2 = new();
conta2.titular = cliente2;
conta2.conta = "10125-x";
conta2.agencia = 10;
conta2.nome_agencia = "Dev Tech";
conta2.Saldo = 60000;

ContaCorrente conta3 = new();
conta3.Saldo = 30;

Console.WriteLine(conta3.Saldo);
conta1.MostraDados();
Console.WriteLine("==============================");
conta2.MostraDados();