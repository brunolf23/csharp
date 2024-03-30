Console.WriteLine("Definindo variáveis do tipo string e object e dynamic");
Console.WriteLine();

string nome = "Curso de C#";
String titulo = "Curso de C# Avançado"; // System.String / uma forma de usar do .net

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto é uma string";
valor = "Isto é uma string alterada";
valor = "Alterando pela terceira vez";

Console.WriteLine(valor);

// usamos o object como um coringa, quando não temos informações sobre os dados
object nota = 10;
object valor1 = 8.55m;
object nome1 = "Maria";
object ativa = true;
object letra = "A";

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();