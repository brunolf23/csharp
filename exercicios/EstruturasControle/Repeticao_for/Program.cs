Console.WriteLine("Instrução for\n");

double numero, resultado = 0;
double i;

Console.WriteLine("Informe o número inteiro maior que zero: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    for (i = 1; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.WriteLine("\nFim do processamento...");

Console.ReadKey();