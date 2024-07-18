Console.WriteLine("Operador Uniário e Ternário");

//Console.WriteLine("Informe a temperatura: \n");
//var temp = Convert.ToInt32(Console.ReadLine());

//var resultado = temp >= 27 ? "Quente" : "Frio";

//Console.WriteLine($"Está {resultado} atualmente.");

// informar o valor de x e y
Console.WriteLine("Informe o valor de X: ");
var valorX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Infome o valor de Y: ");
var valorY = Convert.ToInt32(Console.ReadLine());

var resultado = valorX > valorY ? "É maior que Y" :
                valorX < valorY ? "É menor que Y" :
                valorX == valorY ? "É igual a Y" : "Sem resultado";

Console.WriteLine($"{valorX} {resultado}");

Console.ReadKey();