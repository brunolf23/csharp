/* Console.WriteLine("a" == "a ");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string meuValor = "a";
Console.WriteLine(meuValor == "a");

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string meuValor = "a";
Console.WriteLine(meuValor != "a");


Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string pan = "A grande raposa branca pula pra cima do cachorro preguiçoso.";
Console.WriteLine(pan.Contains("raposa"));
Console.WriteLine(!pan.Contains("cachorro"));

int a = 7;
int b = 6;
Console.WriteLine(a != b); // O operador de desigualdade != inclui um caractere !, mas não deve ser confundido com negação lógica.
                           // O operador de desigualdade retornará true se seus operandos não forem iguais e retornará false se os operandos forem iguais.

string s1 = "Olá";
string s2 = "Olá";
Console.WriteLine(s1 != s2);
*/

int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");