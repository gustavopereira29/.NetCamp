using Models;


















//Operador NOT !

/*bool choveu = true;
bool estaTarde = true;

if(!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}



//Operador AND &&

bool possuiPresencaMinima = true;
double media = 5;

if(possuiPresencaMinima && media >= 7){
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}





//Operador OR ( || )

bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada Liberada");
}
else
{
    Console.WriteLine("Entrada não liberada");
}









//Switch Case
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();


switch(letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
    break;

    default:
        Console.WriteLine("Não é vogal");
    break;    
}










//Operador Condicional

int quantidadeEmEstoque = 10;
int quantidadeCompra = 1;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

//IF-ELSE
if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda Inválida");
}
else if(possivelVenda)
{
    Console.WriteLine("Venda Aprovada");
}
else{
    Console.WriteLine("Desculpe, Não temos em estoque a quantidade suficiente");
}







//Casting

int a = Convert.ToInt32(null);
int ab = int.Parse("5");

//CAsting de String

//int inteiro = 5;
/*string a = inteiro.ToString();

//TryParse

string a = "15-";
int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);*/






/*Pessoa pessoa1 = new Pessoa();

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

pessoa3.Nome = "Samir";
pessoa3.Idade = 30;
pessoa3.Altura = 1.70;

DateTime dataAtual = DateTime.Now.AddMonths(4);
Console.WriteLine(dataAtual);
*/