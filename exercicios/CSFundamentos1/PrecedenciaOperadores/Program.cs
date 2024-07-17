Console.WriteLine("Precedência e associatividade de operadores");

int x = (5 - 10) * 3;
Console.WriteLine(x);


//Aritméticos: *, /, %, +, -
//Atribuição: =, *=, /=, %=, +=, -=
//Incremento/Decremento: ++, --(prefixo)++a, --a
//                       ++, -- (sufixo) a++, a--
//Relacionais: <, >, <=, >=, ==, !=
//Lógicos: !, &&, ||

bool b = (9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(b);

Console.ReadKey();