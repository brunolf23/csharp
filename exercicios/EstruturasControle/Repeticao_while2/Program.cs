Console.WriteLine("Instrução While\n");

while (true)
{
    Console.WriteLine("Informe um número inteiro: (Para sair digite 999)");

    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 999)
    {
        break;
    }
    if (numero % 2 == 0)
    {
        Console.WriteLine($"O número {numero} é PAR.\n");
    }
    else
    {
        Console.WriteLine($"O número {numero} é IMPAR.\n");
    }
}

// exemplo 2

//int x = 1;

//while (x <= 5)
//{
//    int y = 1;
//    while (y <= 5)
//    {
//        Console.WriteLine($"({x},{y}) ");
//        y++;
//    }
//    x++;
//    Console.WriteLine();
//}

//Console.WriteLine("\nFim de processamento...");

//Console.ReadKey();