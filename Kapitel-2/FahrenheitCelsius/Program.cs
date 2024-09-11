//Program för att konvertera Fahrenheit till Celsius
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Program för att konvertera Fahrenheit till Celsius");

Console.ForegroundColor = ConsoleColor.Yellow;

//Läsa in temp i Fahrenheit
Console.Write("Ange temperaturen i Fahrenheit: ");
double tempF = double.Parse(Console.ReadLine());

//Konvertera och skriva ut
double tempC = (tempF - 32) / 1.8;
Console.WriteLine($"{tempF}° Fahrenheit är {tempC}° Celsius");

Console.ForegroundColor = ConsoleColor.White;

