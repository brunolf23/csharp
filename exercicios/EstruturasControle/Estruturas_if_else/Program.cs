Console.WriteLine("Instrução if-else\n");

Console.WriteLine("Qual a sua nota da AV?");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota >= 7.0)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();