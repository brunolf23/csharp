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