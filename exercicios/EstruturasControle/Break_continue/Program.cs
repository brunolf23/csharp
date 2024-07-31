Console.WriteLine("Break e Continue\n");

//int x = 1;

//while (x <= 10)
//{
//    if (x == 5)
//    {
//        x++;
//        continue;
//    }
//    Console.WriteLine($"x = {x}");
//    x++;
//}

// segundo exemplo

for (int x = 1; x <= 10; x++)
{
    if (x == 5)
        continue;

    if (x == 8)
        break;

    Console.WriteLine($"{x}");
}

Console.WriteLine("\nFim do processamento...");

Console.ReadKey();