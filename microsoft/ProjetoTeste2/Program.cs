/*
string[] fraudulentoID = new string[3];
fraudulentoID[0] = "A123";
fraudulentoID[1] = "B456";
fraudulentoID[2] = "C789";

string[] fraudulentoID = ["A123", "B456", "C789"];

Console.WriteLine($"Primeiro: {fraudulentoID[0]}");
Console.WriteLine($"Segundo: {fraudulentoID[1]}");
Console.WriteLine($"Terceiro: {fraudulentoID[2]}");

fraudulentoID[0] = "F1";
Console.WriteLine($"Resignando o primeiro: {fraudulentoID[0]}");
Console.WriteLine($"Existe {fraudulentoID.Length} pedidos fraudulento para processar.");

------------------------

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

*/

int[] inventario = [10, 150, 400, 350, 200];

int soma = 0;
int bin = 0;
foreach (int produtos in inventario)
{
    soma += produtos;
    bin += 1;
    Console.WriteLine($"Bin {bin} = {produtos} produtos (Somando o total: {soma})");
}
Console.WriteLine($"Existe {soma} produtos no inventário.");