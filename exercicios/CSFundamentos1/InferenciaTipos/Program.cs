Console.WriteLine("Inferencia de Tipos");

int idade = 35;
string nome = "Bruno";
decimal salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} e recebe {salario}");

// var limitações
var salario = null;
var salario;
var salario, nome, idade;

// não posso mudar o tipo apos inicializar
var num = 10;
num = num + 20;
num = "teste";

Console.ReadKey();