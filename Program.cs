using bytebank.Conta;
using bytebank.DadosCliente;

Console.WriteLine("Bem vindo ao Bytebank");

Cliente jeff = new("Jefferson Lucas Gomes", "179,437,907-07", "Software Developer");

ContaCorrente contaJeff = new(jeff, "10123-x", 10, "Dev Tech", 25000);

Cliente anna = new("Anna Luiza Carvalho", "055.892.176-01", "Biomédica");

ContaCorrente contaAnna = new(anna, "10871-5", 49, "BioTech", 50000);

Cliente pedro = new("Pedro Machado Gomes", "552-885-098-59", "Analista de Sistemas");

ContaCorrente contaPedro = new(pedro, "10589-x", 50, "Dev Tech", 8000);

Cliente joao = new("João Marcelo", "985.512.564.59", "Engenheiro de software");

ContaCorrente contaJoao = new(joao, "10594-x", 51, "DevTech", 5000);

Cliente marcelo = new("Marcelo", "559.502.950-40", "Engenheiro");

ContaCorrente contaMarcelo = new(marcelo, "10594-x", 52, "Marceneiro", 9000);

contaJeff.MostraDados();
Console.WriteLine("==============================");
contaAnna.MostraDados();
Console.WriteLine("==============================");
contaPedro.MostraDados();
Console.WriteLine("==============================");
contaJoao.MostraDados();
Console.WriteLine("==============================");
Console.WriteLine($"Total de CONTAS CORRENTES cadastradas no sistema: {ContaCorrente.TotalDeContas}");
Console.WriteLine("==============================");
Console.WriteLine($"Total de CLIENTES cadastrados no sistema: {Cliente.TotalDeClientes}");