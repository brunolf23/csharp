Console.WriteLine("Instrução While\n");

int numero;
var contador = 1;

Console.WriteLine("Digite um número maior que zero para sua tabuada.");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"\nTabuada do número {numero}.\n");
    while (contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("Número deve ser maior que zero!");
}
Console.WriteLine("\nFim do processamento...");

Console.ReadKey();