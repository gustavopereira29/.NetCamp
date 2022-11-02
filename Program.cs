using Models;

//Estruturas de repetição

//Do While

int soma = 0, numero2 = 0;

do{
    Console.WriteLine("Digite um número: (0 para parar)");
    numero2 = Convert.ToInt32(Console.ReadLine());

    soma += numero2;

}while(numero2 != 0);
    Console.WriteLine($"A soma dos números digitados é: {soma}");



//While

int numero1 = 29;
int contador1 = 1;

while (contador1 <= 10){
    Console.WriteLine($"{contador1 + 1}° Execução: {numero1} x {contador1} = {numero1 * contador1}");
    contador1++;

    if(contador1 == 7){
        break;
    }
}


//For

int numero = 21;

for (int contador = 0; contador <= 21; contador++){
    Console.WriteLine($"{numero} x {contador} = {numero * contador}"); 
}






//Operadores Aritmeticos
/*Calculadora calc = new Calculadora();
calc.Somar(20, 30);
calc.Subtrair(62, 30);
calc.Multiplicar(20, 21);
calc.Dividir(80, 20);
calc.Potencia(20, 5);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(144);

//Incremento e Decremento

int numeroIncremento = 21;
Console.WriteLine(numeroIncremento);
Console.WriteLine("Incrementando o 21");
//numeroIncremento = numeroIncremento + 1;
numeroIncremento++;

int numeroDecremento = 29;
Console.WriteLine("Decrementando o 29");
numeroDecremento = numeroDecremento - 1;

Console.WriteLine(numeroDecremento);






















//Operador NOT !

bool choveu = true;
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

/*int a = Convert.ToInt32(null);
int ab = int.Parse("5");

//CAsting de String

//int inteiro = 5;
string a = inteiro.ToString();

//TryParse

string a = "15";
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
Console.WriteLine(dataAtual);*/
