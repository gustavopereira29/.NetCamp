using Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Guga";
pessoa1.Idade = 25;
pessoa1.Altura = 1.91;
pessoa1.Apresentar();

Pessoa pessoa2 = new Pessoa();

pessoa2.Nome = "Savic";
pessoa2.Idade = 27;
pessoa2.Altura = 1.90;
pessoa2.Apresentar();

DateTime dataAtual = DateTime.Now.AddMonths(4);
Console.WriteLine(dataAtual);
