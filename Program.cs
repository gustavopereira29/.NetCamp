using Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Gustavo";
pessoa1.Idade = 25;
pessoa1.Altura = 1.91;
pessoa1.Apresentar();

Pessoa pessoa2 = new Pessoa();

pessoa2.Nome = "Savic";
pessoa2.Idade = 27;
pessoa2.Altura = 1.90;
pessoa2.Apresentar();

Pessoa pessoa3 = new Pessoa();

pessoa3.Nome = "Amaral";
pessoa3.Idade = 30;
pessoa3.Altura = 1.70;

DateTime dataAtual = DateTime.Now.AddMonths(4);
Console.WriteLine(dataAtual);
