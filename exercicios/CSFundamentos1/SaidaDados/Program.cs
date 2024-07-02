Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

int idade = 35;
string nome = "Bruno";

Console.WriteLine(idade);
Console.WriteLine(nome);

// Escrever na mesma linha 'Bruno tem 35 anos'

Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos.");

// Usar a concatenação usando o operador +

Console.WriteLine();
Console.WriteLine("======== Concatenação ========");
Console.WriteLine(nome + " tem " + idade + " anos.");
Console.Write(nome + " tem " + idade + " anos.");

// Usar a interpolação de strings : $ => a interpolação {}

Console.WriteLine();
Console.WriteLine("======== Interpolação ========");
Console.WriteLine($"{nome} tem {idade} anos.");

// Usar place holders : usa {} com numeração com inicio em zero

Console.WriteLine();
Console.WriteLine("======== Place holders ========");
Console.WriteLine("{0} tem {1} anos.", nome, idade);

Console.ReadLine();