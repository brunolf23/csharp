Random dice = new Random();

int rolar1 = dice.Next(1, 7);
int rolar2 = dice.Next(1, 7);
int rolar3 = dice.Next(1, 7);

int total = rolar1 + rolar2 + rolar3;
Console.WriteLine($"Rolar dado: {rolar1} + {rolar2} + { rolar3} = {total}");

if ((rolar1 == rolar2 || rolar2 == rolar3 || rolar1 == rolar3))
{

    if ((rolar1 == rolar2) && (rolar2 == rolar3))
    {
        Console.WriteLine("Você rolou o triplo! +6 pontos ao total.");
        total += 6;
    }
    else
    {
        Console.WriteLine($"Você rolou o doblo! +2 pontos ao total: {total}");
        total += 2;
    }
}
if (total >= 16)
{
    Console.WriteLine("Você ganhou um carro.");
}
else if (total >= 10)
{
    Console.WriteLine("Você ganhou um notebook.");
}
else if (total == 7)
{
    Console.WriteLine("Você ganhou uma viagem para dois.");
}
else
{
    Console.WriteLine("Você um iPhone.");
}