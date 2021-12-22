// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Clear();

// leap year // ano bissexto
Console.WriteLine("Quantidade de dias do mês de Fevereiro do ano 2019: " + DateTime.DaysInMonth(2019, 2));
Console.WriteLine("Quantidade de dias do mês de Fevereiro do ano 2020: " + DateTime.DaysInMonth(2020, 2)); // Note: 2020 is a leap year // Nota: 2020 é um ano bissexto
Console.WriteLine("Quantidade de dias do mês de Fevereiro do ano 2021: " + DateTime.DaysInMonth(2021, 2));
Console.WriteLine("Quantidade de dias do mês de Fevereiro do ano 2022: " + DateTime.DaysInMonth(2022, 2));
Console.WriteLine("Quantidade de dias do mês de Fevereiro do ano 2023: " + DateTime.DaysInMonth(2023, 2));
Console.WriteLine("Quantidade de dias do mês de Fevereiro do ano 2024: " + DateTime.DaysInMonth(2024, 2)); // Note: 2024 is a leap year // Nota: 2024 é um ano bissexto
Console.WriteLine("Quantidade de dias do mês de Fevereiro do ano 2028: " + DateTime.DaysInMonth(2028, 2)); // Note: 2028 is a leap year // Nota: 2028 é um ano bissexto
Console.WriteLine("\n");

// Quantide de Dias do Mes
Console.WriteLine(DateTime.DaysInMonth(2020, 2)); // 28 (February)
Console.WriteLine(DateTime.DaysInMonth(2020, 4)); // 30 (April)
Console.WriteLine(DateTime.DaysInMonth(2020, 6)); // 30 (June)
Console.WriteLine(DateTime.DaysInMonth(2020, 9)); // 30 (September)
Console.WriteLine(DateTime.DaysInMonth(2020, 11)); // 30 (November)
Console.WriteLine(DateTime.DaysInMonth(2020, 12)); // 31 (December)

Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

// Que dia é hoje?
Console.WriteLine("\n");
Console.WriteLine("Hoje é: " + DateTime.Now.ToString("dddd")); // dddd = Day of the week

// Que mês é hoje?
Console.WriteLine("\n");
Console.WriteLine("Hoje é: " + DateTime.Now.ToString("MMMM")); // MMMM = Month

// Que ano é hoje?
Console.WriteLine("\n");
Console.WriteLine("Hoje é: " + DateTime.Now.ToString("yyyy")); // yyyy = Year

// Estamos horario de verão?
Console.WriteLine("\n");
Console.WriteLine("Estamos no horário de verão? " + DateTime.Now.IsDaylightSavingTime()); // horário de verão ? true or false
Console.WriteLine("\n");


// Fim de Semana
static bool IsWeekend(DayOfWeek today)
{
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday; // Note: Saturday and Sunday are weekend days // Nota: Sábado e Domingo são dias de fim de semana
}