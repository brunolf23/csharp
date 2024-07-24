﻿Console.WriteLine("Estrutura switch-case");

Console.WriteLine("Valor total da compra R$: ");
var compra = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o número de parcelas: (1/3)");
var parcelas = Convert.ToInt32(Console.ReadLine());

switch (parcelas)
{
    case 1:
        {
            Console.WriteLine($"Prestação R$: 1x {compra / parcelas}");
            break;
        }
    case 2: {
            Console.WriteLine($"Prestação R$: 2x {compra / parcelas}");
            break;
        }
    case 3:
        {
            Console.WriteLine($"Prestação R$: 3x {compra / parcelas}");
            break;
        }
}

Console.ReadKey();