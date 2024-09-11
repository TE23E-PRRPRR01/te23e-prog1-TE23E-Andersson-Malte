//Program för att konvertera temperatur i Celcius till Fahrenheit
using Microsoft.VisualBasic;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("PROGRAM ATT KONVERTERA CELSIUS TILL FAHRENHEIT");

//Läsa in i Celsius
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Ange temperatur i Celsius: ");
int tempCelsius = int.Parse(Console.ReadLine());

//Kovertera till Fahrenheit
int tempFahrenheit = tempCelsius * 9 / 5 + 32;

//Skriv ut resultat
Console.WriteLine($"{tempCelsius}° Celsius är {tempFahrenheit}° Fahrenheit");
Console.ForegroundColor = ConsoleColor.White;
