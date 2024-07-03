Console.WriteLine("## Conversão de tipos implicidos ##\n");
/*
int varInt = 100;
double varDouble = varInt;

Console.WriteLine(varDouble);

int numeroInt = 1204562;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

Console.ReadLine();

*/

double varDouble = 12.456; // 8 bytes
int varInt = (int)varDouble; // 4 bytes

Console.WriteLine(varInt);