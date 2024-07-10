Console.WriteLine("Operadores Incremento e Decremento");

int x = 0;

// pós-decremento -> primeiro resolve depois decrementa
int resultado1 = x++ + 10;

Console.WriteLine($"pós-incremento => {resultado1}");
Console.WriteLine($"valor de x => {x}\n");

// pré-decremento => primeiro incrementa depois resolve
int y = 0;

Console.WriteLine($"y = {y}");
int resultado2 = ++y + 10;

Console.WriteLine($"pré-incremento => {resultado2}");
Console.WriteLine($"valor de y => {y}\n");

Console.ReadKey();