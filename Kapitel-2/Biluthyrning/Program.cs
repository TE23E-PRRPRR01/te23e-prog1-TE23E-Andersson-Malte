//Biluthyrning
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
System.Console.WriteLine("PROGRAM FÖR ATT BERÄKNA KOSTNADEN HOS EN BILUTHYRNINGSFIRMA");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ange antal mil: ");
double mil = double.Parse(Console.ReadLine());
Console.Write("Ange antal dagar: ");
double dagar = double.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Yellow;
double kostnad = 500 + 5 * mil + 100 * dagar;
Console.WriteLine($"Den totala kostnaden blir {kostnad}kr");
