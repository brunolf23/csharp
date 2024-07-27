Console.WriteLine("Estrutura switch-case 2");

//var mes = Console.ReadLine().ToLower();

//switch (mes)
//{
//    case "janeiro":
//    case "março":
//    case "maio":
//    case "julho":
//    case "agosto":
//    case "outubro":
//    case "dezembro":
//        Console.WriteLine("Este mês tem 31 dias");
//        break;
//    case "fevereiro":
//        Console.WriteLine("Este mês tem 28 ou 29 dias");
//        break;
//    default:
//        Console.WriteLine("Este mês tem 30 dias");
//        break;
//}

int cargo = 0;
int funcao = 0;

Console.WriteLine("Você é suporte(1) ou programador(2)?");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 1)
{
    Console.WriteLine("Você é Junior(1) ou Senior(2)?");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("Bem vindo Suporte");
        break;
    case 2:
        Console.WriteLine("Bem vindo Programador");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Você é Junior");
                break;
            case 2:
                Console.WriteLine("Você é Senior");
                break;
            default:
                Console.WriteLine("Função desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("Não consigo identificar");
        break;
}

Console.WriteLine("Fim do processamento...");

Console.ReadKey();