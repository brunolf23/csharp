Console.WriteLine("Struct DateTime");

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);

// criar uma data especifica usa formato: aaaa/mm/dd
DateTime dataHoje = new DateTime(2024, 03, 29);
Console.WriteLine(dataHoje);

// definir as horas
DateTime dataHoraHoje = new DateTime(2024, 03, 29, 22, 16, 23);
Console.WriteLine(dataHoraHoje);

// extraindo informações de data e horário
DateTime hoje = DateTime.Now;
Console.WriteLine($"Hoje: {hoje}\n");

Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

// adicionando valores
Console.WriteLine(hoje.AddDays(60));
Console.WriteLine(hoje.AddMonths(3));
Console.WriteLine(hoje.AddYears(2));
Console.WriteLine(hoje.AddHours(500));

// obter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

Console.ReadKey();