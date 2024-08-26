// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Hej, världen!");
Console.Write("Vad du heter?");
string namn = Console.ReadLine();
Console.WriteLine("Hej min käraste " + namn + "!");
Console.WriteLine("Vad du gillar att göra på fritiden " + namn + "?");
string fritiden = Console.ReadLine();
Console.WriteLine("Jag gillar också att " + fritiden + " på fritiden!");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.WriteLine("Du kollade på OS eller?");
Console.WriteLine("Vilken sport du tycker var bäst?");


