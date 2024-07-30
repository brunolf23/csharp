Console.WriteLine("Instrução While\n");

//var i = 1;

//do
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}
//while ( i <= 10 );

// exemplo 2

int x = 0;

do
{
    int y = 0;
    do
    {
        Console.Write($"{x},{y} ");
        y++;
    }
    while (y < 5);
    x++;
    Console.WriteLine();
}
while (x < 5);

Console.ReadKey();