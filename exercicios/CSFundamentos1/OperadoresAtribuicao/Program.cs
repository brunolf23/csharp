using System.Drawing;

Console.WriteLine("Operadores de atribuição");

// usando operadores atribuição com tipos numéricos

float x = 10;
x = 20;
Console.WriteLine($"Valor inicial de x ={x}");
Console.WriteLine($"x += 5 = {x += 5}");
Console.WriteLine($"x -= 3 = {x -= 3}");
Console.WriteLine($"x *= 4 = {x *= 4}");
Console.WriteLine($"x /= 5 = {x /= 5}");
Console.WriteLine($"x %= 5 = {x %= 5}");

var y = "123";

Console.WriteLine($"O valor de y {y}");
Console.WriteLine($"y+= {y += "456"}");

Console.ReadKey();