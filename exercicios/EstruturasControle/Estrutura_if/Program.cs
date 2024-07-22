Console.WriteLine("Instrução If");

//Console.Write("Cliente especial (S/N)\t");
//var resposta = Console.ReadLine().ToUpper();

//if (resposta == "S")
//{
//    Console.WriteLine("Desconto de 10%");
//}
//else
//{
//    Console.WriteLine("Sem desconto!");
//}

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    if (x < y)
    { 
    Console.WriteLine("x é menor que y");
    }

    else
    {
    Console.WriteLine("x é igual a y");
    }
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();