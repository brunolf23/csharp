Console.WriteLine("Instrução if-else-if");

Console.WriteLine("Informe a nota do aluno: ");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno REPROVADO");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("Aluno APROVADO");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em RECUPERAÇÃO");
}
else
{
    Console.WriteLine("Aluno aprovado com DISTINÇÃO");
}
Console.WriteLine("Fim do PROCESSAMENTO....");

Console.ReadKey();