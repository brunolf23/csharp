/*
string[] novosProdutos = ["Geleia", "Manteiga", "Queijo", "Presunto", "Mortadela"];

object contador = 0;
foreach (string s in novosProdutos)
{
    Console.WriteLine($"Desejo o que no pão? {s}");
}
*/


string[] dados = ["Bruno", "Lopes", "Bruno", "Lopes"];
int contador = 1;

foreach (string s in dados)
{
    Console.WriteLine($"O {s} foi contado {contador} vez");
    contador += 1;
}

int idade = 18;
if (idade >= 18)
{
    // Se a váriavel idade for maior ou igual à 18 esse trecho de código será executado
    Console.WriteLine("Você é maior de idade!");
}
else if (idade >= 16)
{
    // Se a váriavel idade não for maior ou igual à 18 mas for maior ou igual a 16 esse trecho de código será executado
    Console.WriteLine("Você não é maior de idade, mas já pode votar!");
}



else
{
    // Se a váriavel idade não for maior ou igual à 18 esse trecho de código será executado
    Console.WriteLine("Você é menor de idade!");
}