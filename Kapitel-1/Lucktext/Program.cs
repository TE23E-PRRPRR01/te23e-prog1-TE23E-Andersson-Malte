using System.Threading.Tasks.Dataflow;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Ange förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn: ");
string efternamn = Console.ReadLine();
Console.Write("Ange maträtt: ");
string maträtt = Console.ReadLine();
Console.Write("Ange TV-program: ");
string TV = Console.ReadLine();


if (förnamn == "Alvin")
{
    Console.WriteLine("Tyvärr är inte Alvin " + efternamn + " välkommen här!");
Console.WriteLine("Vänligen ange ett annat förnamn: ");
string förnamn2 = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("En tisdag eftermiddag satt " + förnamn2 + " " + efternamn + " och käkade sin mycket älskade " + maträtt + " medans han kollade på " + TV + ".");
}
else
{
    Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("En tisdag eftermiddag satt " + förnamn + " " + efternamn + " och käkade sin mycket älskade " + maträtt + " medans han kollade på " + TV + ".");    
}

